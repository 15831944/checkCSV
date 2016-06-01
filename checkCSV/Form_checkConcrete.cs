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
    public partial class Form_checkConcrete : Form
    {
        private string _csvFolderPath;
        private string _pdfFolderPath;
        private string _dwgFolderPath;

        private string _csvFilePath;
        private string _incastClass;
        private string _drawingType;
        private int _reportFilter;

        private string _exportFolderPath;
        private string _exportElementType; // concrete vs steel
        private int _exportType;

        ElementDataGroup _reportData = new ElementDataGroup();

        public enum ExportElementType
        {
            Concrete = 1, Incast_Details, Steel
        }

        public enum DrawingFinder
        {
            PDF_DWG, PDF, DWG
        }

        public enum StatusFilter
        {
            ALL, OK, Missing, Not_Set, Not_Set_Has_Drawings, Has_Copy, Not_In_List
        }

        public enum ExportType
        {
            Add_only, Add_if_newer, Replace_all
        }

        public Form_checkConcrete()
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
            bool hasSettings = DefaultSettings.readDefaultDirectorys(out _csvFolderPath, out _pdfFolderPath, out _dwgFolderPath, out _incastClass);

            txt_csv_dir.Text = _csvFolderPath;
            txt_pdf_dir.Text = _pdfFolderPath;
            txt_dwg_dir.Text = _dwgFolderPath;
            txt_incastClass.Text = _incastClass;
            txt_export_target.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            cb_drawing_type.DataSource = Enum.GetValues(typeof(DrawingFinder));
            cb_filter_results_type.DataSource = Enum.GetValues(typeof(StatusFilter));
            cb_exportElementType.DataSource = Enum.GetValues(typeof(ExportElementType));
            cb_exportType.DataSource = Enum.GetValues(typeof(ExportType));

            lbl_csv_file_main.Text = "CSV: None";
            lbl_save_defaults_status.Text = "[" + DateTime.Now.ToString("h:mm:ss") + "]";

            report_labels_update();
            if (hasSettings)
            {
                checkReportdir();
                checkDrawingDir();
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
            _exportFolderPath = ABI.hasDashAtEnd(_exportFolderPath);
        }

        private void txt_csv_dir_TextChanged(object sender, EventArgs e)
        {
            _csvFolderPath = txt_csv_dir.Text;
            _csvFolderPath = ABI.hasDashAtEnd(_csvFolderPath);

            txt_default_csv_dir.Text = _csvFolderPath;
        }

        private void txt_pdf_dir_TextChanged(object sender, EventArgs e)
        {
            _pdfFolderPath = txt_pdf_dir.Text;
            _pdfFolderPath = ABI.hasDashAtEnd(_pdfFolderPath);

            txt_default_pdf_dir.Text = _pdfFolderPath;
        }

        private void txt_dwg_dir_TextChanged(object sender, EventArgs e)
        {
            _dwgFolderPath = txt_dwg_dir.Text;
            _dwgFolderPath = ABI.hasDashAtEnd(_dwgFolderPath);

            txt_default_dwg_dir.Text = _dwgFolderPath;
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

        private void txt_default_dwg_dir_TextChanged(object sender, EventArgs e)
        {
            _dwgFolderPath = txt_default_dwg_dir.Text;
            txt_dwg_dir.Text = _dwgFolderPath;
        }

        private void txt_default_incast_class_TextChanged(object sender, EventArgs e)
        {
            _incastClass = txt_default_incast_class.Text;
            txt_incastClass.Text = _incastClass;
        }

        //BUTTON
        private void btn_check_csv_Click(object sender, EventArgs e)
        {
            csvFileReader reader = new csvFileReader(_csvFilePath, _incastClass);
            List<ArrayList> parsedData = reader.importCSV();
            List<string> _pdfFiles = DirectoryImport.importDirFiles(_pdfFolderPath, "*.pdf", true);
            List<string> _dwgFiles = DirectoryImport.importDirFiles(_dwgFolderPath, "*.dwg", true);

            _reportData = new ElementDataGroup(parsedData, _pdfFiles, _dwgFiles);
            _reportData.buildData();
            _reportData.findDrawingHandler(_drawingType);

            report_labels_update();
            report_list_update();
        }

        private void btn_check_csv_dir_Click(object sender, EventArgs e)
        {
            checkReportdir();
        }

        private void btn_check_pdf_dir_Click(object sender, EventArgs e)
        {
            checkDrawingDir();
        }

        private void btn_save_defaults_Click(object sender, EventArgs e)
        {
            string save_status = DefaultSettings.writeDefaultDirectorys(_csvFolderPath, _pdfFolderPath, _dwgFolderPath, _incastClass);
            lbl_save_defaults_status.Text = "[" + DateTime.Now.ToString("h:mm:ss") + "] " + save_status;
        }

        //ListBox
        private void report_list_update()
        {
            lv_csv_results.Clear();
            lv_csv_results.Columns.Add("Name");
            lv_csv_results.Columns.Add("Status");

            update_main_list_values();

            lv_csv_results.Columns[0].Width = -2;
            lv_csv_results.Columns[1].Width = -2;
        }

        private void update_main_list_values()
        {
            if (_reportFilter == 0)
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
                filtered = _reportData.allParts.Where(x => x.status == _reportFilter).ToList();

                foreach (ElementData part in filtered)
                {
                    addPartToList(part);
                }
            }
        }

        private void addPartToList(ElementData part)
        {
            if (part.status == 1)
            {
                string pathShort = part.pdfPath + " " + part.dwgPath;
                pathShort = pathShort.Replace(_pdfFolderPath, "");
                pathShort = pathShort.Replace(_dwgFolderPath, "");

                lv_csv_results.Items.Add(part.ToString()).SubItems.Add(pathShort);
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = ABI.colorOfField(part);
            }
            else
            {
                lv_csv_results.Items.Add(part.ToString()).SubItems.Add(part.statusMessage);
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = ABI.colorOfField(part);
            }

        }

        private void checkReportdir()
        {
            List<string> csvFiles = DirectoryImport.importDirFiles(_csvFolderPath, "*.csv", false);
            List<string> csvFileNames = new List<string>();

            foreach (string csv in csvFiles)
            {
                string name = Path.GetFileNameWithoutExtension(csv);
                csvFileNames.Add(name);
            }

            lib_csv_dir.DataSource = csvFileNames;
            lib_csv_dir.SelectedIndex = csvFileNames.Count - 1;
        }

        private void checkDrawingDir()
        {
            List<string> pdfFiles = DirectoryImport.importDirFiles(_pdfFolderPath, "*.pdf", true);
            List<string> dwgFiles = DirectoryImport.importDirFiles(_dwgFolderPath, "*.dwg", true);
            lbl_pdf_dir_main.Text = "PDF:     " + _pdfFolderPath;
            lbl_dwg_dir_main.Text = "DWG:   " + _pdfFolderPath;

            lv_pdf_dir.Clear();
            lv_pdf_dir.Columns.Add("Name");
            lv_pdf_dir.Columns.Add("Path");

            foreach (string path in pdfFiles)
            {
                string name = Path.GetFileNameWithoutExtension(path);
                string shortPath = path.Replace(_pdfFolderPath, "");
                lv_pdf_dir.Items.Add(name).SubItems.Add(shortPath);
            }

            lv_pdf_dir.Columns[0].Width = -2;
            lv_pdf_dir.Columns[1].Width = -2;

            lv_dwg_dir.Clear();
            lv_dwg_dir.Columns.Add("Name");
            lv_dwg_dir.Columns.Add("Path");

            foreach (string path in dwgFiles)
            {
                string name = Path.GetFileNameWithoutExtension(path);
                string shortPath = path.Replace(_pdfFolderPath, "");
                lv_dwg_dir.Items.Add(name).SubItems.Add(shortPath);
            }

            lv_dwg_dir.Columns[0].Width = -2;
            lv_dwg_dir.Columns[1].Width = -2;
        }

        private void lib_csv_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            _reportData = new ElementDataGroup();
            lv_csv_results.Clear();
            lv_exportedParts.Clear();

            if (lib_csv_dir.SelectedItem != null)
            {
                _csvFilePath = _csvFolderPath + @"\" + lib_csv_dir.SelectedItem + ".csv";
                lbl_csv_file_main.Text = "CSV:     " + lib_csv_dir.SelectedItem + ".csv";
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
                string pathShort = part.pdfPath + " " + part.dwgPath;
                pathShort = pathShort.Replace(_pdfFolderPath, "");
                pathShort = pathShort.Replace(_dwgFolderPath, "");

                lv_exportedParts.Items.Add(part.ToString()).SubItems.Add(pathShort);
                lv_exportedParts.Items[lv_exportedParts.Items.Count - 1].BackColor = ABI.colorOfField(part);
            }

            lv_exportedParts.Columns[0].Width = -2;
            lv_exportedParts.Columns[1].Width = -2;
        }

        private void btn_create_folders_Click(object sender, EventArgs e)
        {
            List<ElementData> exportParts = new List<ElementData>();
            ExportModule export = new ExportModule(_exportFolderPath, _drawingType, _exportType, _exportElementType);

            exportParts = _reportData.allMainParts.Where(x => x.status == 1).ToList();

            export.main(exportParts);
        }

        private void cb_exportElementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _exportElementType = cb_exportElementType.SelectedValue.ToString();
        }

        private void cb_exportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _exportType = (int)cb_exportType.SelectedValue;
        }

        private void cb_drawing_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            _drawingType = cb_drawing_type.SelectedValue.ToString();
        }

        private void cb_filter_results_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            _reportFilter = (int)cb_filter_results_type.SelectedValue;
            report_list_update();
        }

        private void report_labels_update()
        {
            lb_status_0.Text = @"Total: (" + _reportData.allParts.Count.ToString() + @")" ;
            lb_status_1.Text = @"OK: (" + _reportData.allParts.Where(x => x.status == 1).ToList().Count.ToString() + @")";
            lb_status_2.Text = @"Missing: (" + _reportData.allParts.Where(x => x.status == 2).ToList().Count.ToString() + @")";
            lb_status_3.Text = @"Not Set (" + _reportData.allParts.Where(x => x.status == 3).ToList().Count.ToString() + @")";
            lb_status_4.Text = @"Not Set - Has Drawing (" + _reportData.allParts.Where(x => x.status == 4).ToList().Count.ToString() + @")";
            lb_status_5.Text = @"Has Copy (" + _reportData.allParts.Where(x => x.status == 5).ToList().Count.ToString() + @")";
            lb_status_6.Text = @"Not in CSV (" + _reportData.allParts.Where(x => x.status == 6).ToList().Count.ToString() + @")";
        }
    }
}
