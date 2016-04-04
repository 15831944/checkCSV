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
        //defaults
        private string _defaultCSVdir;
        private string _defaultPDFdir;
        private string _defaultIncastClass;

        //active
        private string _csvFolderPath;
        private string _pdfFolderPath;
        private string _csvFilePath;
        private string _incastClass;

        private int _rb_filter;

        List<string> _csvFiles = new List<string>();
        List<string> _pdfFiles = new List<string>();

        ElementDataGroup _reportData = new ElementDataGroup();

        public Form1()
        {
            InitializeComponent();
        }


        //LOADING
        private void Form1_Load(object sender, EventArgs e)
        {
            bool hasSettings = defaultSettings.readDefaultDirectorys(out _csvFolderPath, out _pdfFolderPath, out _incastClass);

            txt_csv_dir.Text = _csvFolderPath;
            txt_pdf_dir.Text = _pdfFolderPath;
            txt_incastClass.Text = _incastClass;

            lbl_csv_dir.Text = "Directory: ";
            lbl_pdf_dir.Text = "Directory: ";
            lbl_csv_file.Text = "CSV: None";

            update_radio_box_text();

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


        //BUTTON
        private void btn_check_csv_Click(object sender, EventArgs e)
        {
            List<ArrayList> parsedData = csvFileReader.importCSV(_csvFilePath, _incastClass);
            _reportData.buildData(parsedData);
            _reportData.findDrawings(_pdfFiles);

            update_status_list();
            update_radio_box_text();

            if (_reportData.total > 0)
            {
                rb_status_0.Enabled = true;
                rb_status_1.Enabled = true;
                rb_status_2.Enabled = true;
                rb_status_3.Enabled = true;
            }
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
            defaultSettings.writeDefaultDirectorys(_defaultCSVdir, _defaultPDFdir, _defaultIncastClass);
        }

        private void update_radio_box_text()
        {
            rb_status_0.Text = "Total (" + _reportData.total.ToString() + ")";
            rb_status_1.Text = "OK (" + _reportData.status_ok + ")";
            rb_status_2.Text = "Missing (" + _reportData.status_missing + ")";
            rb_status_3.Text = "Not Set (" + _reportData.status_not_set + ")";
        }

        //FN


        //ListBox
        private void update_status_list()
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
                    lv_csv_results.Items.Add(main.ToString()).SubItems.Add(main.drawingPath);
                    colorOfField(main);

                    foreach (ElementData special in main.specialDetails)
                    {
                        lv_csv_results.Items.Add("    -    " + special.ToString()).SubItems.Add(special.drawingPath);
                        colorOfField(special);
                    }
                }
            }
            else
            {
                List<ElementData> filtered = new List<ElementData>();

                switch (_rb_filter)
                {
                    case 1:
                        {
                            filtered = _reportData.allParts.Where(x => x.status == 1).ToList();
                            break;
                        }
                    case 2:
                        {
                            filtered = _reportData.allParts.Where(x => x.status == 2).ToList();
                            break;
                        }
                    case 3:
                        {
                            filtered = _reportData.allParts.Where(x => x.status == 3).ToList();
                            break;
                        }
                }

                foreach (ElementData part in filtered)
                {
                    lv_csv_results.Items.Add(part.ToString()).SubItems.Add(part.drawingPath);
                    colorOfField(part);
                }
            }


        }

        private void colorOfField(ElementData part)
        {
            if (part.status == 1)
            {
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = Color.LimeGreen;
            }
            else if (part.status == 2)
            {
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = Color.Red;
            }
            else if (part.status == 3)
            {
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = Color.Yellow;
            }
            else
            {
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = Color.Cyan;
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
                csvFileNames.Add(Path.GetFileNameWithoutExtension(csv));
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
            lv_csv_results.Clear();

            rb_status_0.Enabled = false;
            rb_status_1.Enabled = false;
            rb_status_2.Enabled = false;
            rb_status_3.Enabled = false;

            if (lib_csv_dir.SelectedItem != null)
            {
                _csvFilePath = _csvFolderPath + lib_csv_dir.SelectedItem + ".csv";
                lbl_csv_file.Text = "CSV: " + lib_csv_dir.SelectedItem + ".csv";
            }
        }

        //SETTINGS
        private void txt_default_csv_directory_TextChanged(object sender, EventArgs e)
        {
            _defaultCSVdir = txt_default_csv_dir.Text;
        }

        private void txt_default_pdf_dir_TextChanged(object sender, EventArgs e)
        {
            _defaultPDFdir = txt_default_pdf_dir.Text;
        }

        private void txt_default_incast_class_TextChanged(object sender, EventArgs e)
        {
            _defaultIncastClass = txt_default_incast_class.Text;
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
        }

        private void rb_status_0_CheckedChanged(object sender, EventArgs e)
        {
            set_rb_value();
            update_status_list();
        }

        private void rb_status_1_CheckedChanged(object sender, EventArgs e)
        {
            set_rb_value();
            update_status_list();
        }

        private void rb_status_2_CheckedChanged(object sender, EventArgs e)
        {
            set_rb_value();
            update_status_list();
        }

        private void rb_status_3_CheckedChanged(object sender, EventArgs e)
        {
            set_rb_value();
            update_status_list();
        }

        private void set_rb_value()
        {
            if (rb_status_0.Checked)
            {
                _rb_filter = 0;
            }

            if (rb_status_1.Checked)
            {
                _rb_filter = 1;
            }

            if (rb_status_2.Checked)
            {
                _rb_filter = 2;
            }

            if (rb_status_3.Checked)
            {
                _rb_filter = 3;
            }
        }
    }
}
