using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace checkCSV
{
    public partial class Form1 : Form
    {
        private string _csvFolderPath;
        private string _pdfFolderPath;
        private string _csvFilePath;
        private string _incastClass;

        private string _exportFolderPath;
        private string _exportElementType; // concrete vs steel

        private int _rb_filter;

        List<string> _csvFiles = new List<string>();
        List<string> _pdfFiles = new List<string>();

        ElementDataGroup _reportData = new ElementDataGroup();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (lv_csv_results.Columns.Count > 0)
            {
                lv_csv_results.Columns[0].Width = -2;
                lv_csv_results.Columns[1].Width = -2;
            }

            if (lv_pdf_dir.Columns.Count > 0)
            {
                lv_pdf_dir.Columns[0].Width = -2;
                lv_pdf_dir.Columns[1].Width = -2;
            }

            if (lv_exportedParts.Columns.Count > 0)
            {
                lv_exportedParts.Columns[0].Width = -2;
                lv_exportedParts.Columns[1].Width = -2;
            }
        }

        //LOADING
        private void Form1_Load(object sender, EventArgs e)
        {
            bool hasSettings = defaultSettings.readDefaultDirectorys(out _csvFolderPath, out _pdfFolderPath, out _incastClass);

            txt_csv_dir.Text = _csvFolderPath;
            txt_pdf_dir.Text = _pdfFolderPath;
            txt_incastClass.Text = _incastClass;
            txt_export_target.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";

            lbl_csv_dir.Text = "Directory: ";
            lbl_pdf_dir.Text = "Directory: ";
            lbl_csv_file.Text = "CSV: None";

            _exportElementType = "Concrete";

            rb_update_text();

            if (hasSettings)
            {
                checkCSVdir();
                checkPDFdir();
            }
        }

        //TEXT
        private void txt_incastClass_TextChanged(object sender, EventArgs e)
        {
            _incastClass = txt_incastClass.Text;
            txt_default_incast_class.Text = _incastClass;
        }

        private void txt_export_target_TextChanged(object sender, EventArgs e)
        {
            _exportFolderPath = txt_export_target.Text;
            if (!_exportFolderPath.EndsWith(@"\"))
            {
                _exportFolderPath = _exportFolderPath + @"\";
            }
        }

        private void txt_csv_dir_TextChanged(object sender, EventArgs e)
        {
            _csvFolderPath = txt_csv_dir.Text;
            txt_default_csv_dir.Text = _csvFolderPath;

            if (!_csvFolderPath.EndsWith(@"\"))
            {
                _csvFolderPath = _csvFolderPath + @"\";
            }
        }

        private void txt_pdf_dir_TextChanged(object sender, EventArgs e)
        {
            _pdfFolderPath = txt_pdf_dir.Text;
            txt_default_pdf_dir.Text = _pdfFolderPath;

            if (!_pdfFolderPath.EndsWith(@"\"))
            {
                _pdfFolderPath = _pdfFolderPath + @"\";
            }
        }

        private void txt_default_csv_directory_TextChanged(object sender, EventArgs e)
        {
            _csvFolderPath = txt_default_csv_dir.Text;
            txt_csv_dir.Text = _csvFolderPath;
        }

        private void txt_default_pdf_dir_TextChanged(object sender, EventArgs e)
        {
            _pdfFolderPath = txt_default_pdf_dir.Text;
            txt_pdf_dir.Text = _pdfFolderPath;
        }

        private void txt_default_incast_class_TextChanged(object sender, EventArgs e)
        {
            _incastClass = txt_default_incast_class.Text;
            txt_incastClass.Text = _incastClass;
        }

        //BUTTON
        private void btn_check_csv_Click(object sender, EventArgs e)
        {
            List<ArrayList> parsedData = csvFileReader.importCSV(_csvFilePath, _incastClass);
            _reportData = new ElementDataGroup();
            _reportData.buildData(parsedData, _pdfFiles);
            _reportData.findDrawings();

            status_list_update();
            rb_enable_buttons();
        }

        private void btn_check_csv_dir_Click(object sender, EventArgs e)
        {
            checkCSVdir();
        }

        private void btn_check_pdf_dir_Click(object sender, EventArgs e)
        {
            checkPDFdir();
        }

        private void btn_save_defaults_Click(object sender, EventArgs e)
        {
            defaultSettings.writeDefaultDirectorys(_csvFolderPath, _pdfFolderPath, _incastClass);
        }

        //ListBox
        private void status_list_update()
        {
            lv_csv_results.Clear();
            lv_csv_results.Columns.Add("Name");
            lv_csv_results.Columns.Add("Path");

            update_list_values();

            lv_csv_results.Columns[0].Width = -2;
            lv_csv_results.Columns[1].Width = -2;
        }

        private void update_list_values()
        {
            if (_rb_filter == 0)
            {
                foreach (ElementData main in _reportData.allMainParts)
                {
                    addPartToList(main);

                    foreach (ElementData special in main.specialDetails)
                    {
                        addPartToList(special);
                    }
                }
            }
            else
            {
                List<ElementData> filtered = new List<ElementData>();
                filtered = _reportData.allParts.Where(x => x.status == _rb_filter).ToList();

                foreach (ElementData part in filtered)
                {
                    addPartToList(part);
                }
            }
        }

        private void addPartToList(ElementData part)
        {
            lv_csv_results.Items.Add(part.ToString()).SubItems.Add(part.drawingPath);
            lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = colorOfField(part);
        }

        private Color colorOfField(ElementData part)
        {
            if (part.status == 1)
            {
                 return Color.LimeGreen;
            }
            else if (part.status == 2)
            {
                return Color.Red;
            }
            else if (part.status == 3)
            {
                return Color.Yellow;
            }
            else
            {
                return Color.Cyan;
            }
        }

        private void checkCSVdir()
        {
            lbl_csv_dir.Text = "Directory: " + _csvFolderPath;
            _csvFiles = directoryImport.importCSVdir(_csvFolderPath);
            update_csv_list();
        }

        private void update_csv_list()
        {
            List<string> csvFileNames = new List<string>();

            foreach (string csv in _csvFiles)
            {
                string name = Path.GetFileNameWithoutExtension(csv);
                csvFileNames.Add(name);
            }

            lib_csv_dir.DataSource = csvFileNames;
            lib_csv_dir.SelectedIndex = csvFileNames.Count - 1;
        }

        private void checkPDFdir()
        {
            lbl_pdf_dir.Text = "Directory: " + _pdfFolderPath;
            lbl_pdf_dir_main.Text = "PDF: " + _pdfFolderPath;
            _pdfFiles = directoryImport.importPDFdir(_pdfFolderPath);
            update_pdf_list();
        }

        private void update_pdf_list()
        {
            lv_pdf_dir.Clear();
            lv_pdf_dir.Columns.Add("Name");
            lv_pdf_dir.Columns.Add("Path");

            foreach (string path in _pdfFiles)
            {
                string name = Path.GetFileNameWithoutExtension(path);
                lv_pdf_dir.Items.Add(name).SubItems.Add(path);
            }

            lv_pdf_dir.Columns[0].Width = -2;
            lv_pdf_dir.Columns[1].Width = -2;
        }

        private void lib_csv_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            _reportData = new ElementDataGroup();
            lv_csv_results.Clear();
            lv_exportedParts.Clear();
            rb_disable_buttons();

            if (lib_csv_dir.SelectedItem != null)
            {
                _csvFilePath = _csvFolderPath + lib_csv_dir.SelectedItem + ".csv";
                lbl_csv_file.Text = "CSV: " + lib_csv_dir.SelectedItem + ".csv";
            }
        }

        private void rb_status_0_CheckedChanged(object sender, EventArgs e)
        {
            rb_set_value();
            status_list_update();
        }

        private void rb_status_1_CheckedChanged(object sender, EventArgs e)
        {
            rb_set_value();
            status_list_update();
        }

        private void rb_status_2_CheckedChanged(object sender, EventArgs e)
        {
            rb_set_value();
            status_list_update();
        }

        private void rb_status_3_CheckedChanged(object sender, EventArgs e)
        {
            rb_set_value();
            status_list_update();
        }

        private void rb_status_4_CheckedChanged(object sender, EventArgs e)
        {
            rb_set_value();
            status_list_update();
        }

        private void rb_enable_buttons()
        {
            rb_update_text();

            if (_reportData.total > 0)
            {
                rb_status_0.Enabled = true;
                rb_status_1.Enabled = true;
                rb_status_1.BackColor = Color.Lime;
                rb_status_2.Enabled = true;
                rb_status_2.BackColor = Color.Red;
                rb_status_3.Enabled = true;
                rb_status_3.BackColor = Color.Yellow;
                rb_status_4.Enabled = true;
                rb_status_4.BackColor = Color.Cyan;
            }
        }

        private void rb_disable_buttons()
        {
            rb_update_text();

            rb_status_0.Enabled = false;
            rb_status_1.Enabled = false;
            rb_status_1.BackColor = Color.Transparent;
            rb_status_2.Enabled = false;
            rb_status_2.BackColor = Color.Transparent;
            rb_status_3.Enabled = false;
            rb_status_3.BackColor = Color.Transparent;
            rb_status_4.Enabled = false;
            rb_status_4.BackColor = Color.Transparent;
        }

        private void rb_update_text()
        {
            rb_status_0.Text = "Total (" + _reportData.total.ToString() + ")";
            rb_status_1.Text = "OK (" + _reportData.status_ok + ")";
            rb_status_2.Text = "Missing (" + _reportData.status_missing + ")";
            rb_status_3.Text = "Not Set (" + _reportData.status_not_set + ")";
            rb_status_4.Text = "Not Set - has drawing (" + _reportData.status_not_set_has_drawing + ")";
        }

        private void rb_set_value()
        {
            if (rb_status_0.Checked)
            {
                _rb_filter = 0;
            }
            else if (rb_status_1.Checked)
            {
                _rb_filter = 1;
            }

            else if (rb_status_2.Checked)
            {
                _rb_filter = 2;
            }

            else if (rb_status_3.Checked)
            {
                _rb_filter = 3;
            }

            else if (rb_status_4.Checked)
            {
                _rb_filter = 4;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            List<ElementData> toExportParts = _reportData.allMainParts.Where(x => x.status == 1).ToList();

            lb_number_of_export.Text = toExportParts.Count.ToString() + @"   (no *ID)";

            if (toExportParts.Count > 0)
            {
                panel_export.Enabled = true;
                update_export_list_values(toExportParts);
            }
            else
            {
                panel_export.Enabled = false;
            }
        }

        private void update_export_list_values(List<ElementData> toExportParts)
        {
            lv_exportedParts.Clear();
            lv_exportedParts.Columns.Add("Name");
            lv_exportedParts.Columns.Add("Path");

            foreach (ElementData part in toExportParts)
            {
                lv_exportedParts.Items.Add(part.ToString()).SubItems.Add(part.drawingPath);
                lv_exportedParts.Items[lv_exportedParts.Items.Count - 1].BackColor = colorOfField(part);
            }

            lv_exportedParts.Columns[0].Width = -2;
            lv_exportedParts.Columns[1].Width = -2;
        }

        private void btn_create_folders_Click(object sender, EventArgs e)
        {
            List<ElementData> exportParts = new List<ElementData>();
            exportParts = _reportData.allMainParts.Where(x => x.status == 1).ToList();
            exportModule export = new exportModule(_exportFolderPath, _exportElementType);

            export.main(exportParts);
        }

        private void rb_concrete_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_concrete.Checked == true)
            {
                _exportElementType = "Concrete";
            }
            else
            {
                _exportElementType = "Steel";
            }
        }
    }
}
