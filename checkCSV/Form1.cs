using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkCSV
{
    public partial class Form1 : Form
    {
        //defaults
        private string _defaultCSVdir;
        private string _defaultWorkshopdir;

        //active
        private string _csvFolderPath;
        private string _workshopFolderPath;
        private string _csvFilePath;

        List<string> _csvFiles = new List<string>();
        List<string> _pdfFiles = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        //LOADING
        private void Form1_Load(object sender, EventArgs e)
        {
            bool hasSettings = defaults.readDefaultDirectorys(out _csvFolderPath, out _workshopFolderPath);
            txt_csv_dir.Text = _csvFolderPath;
            txt_workshop_dir.Text = _workshopFolderPath;

            lbl_csv_dir.Text = "Directory: ";
            lbl_workshop_dir.Text = "Directory: ";

            lbl_csv_file.Text = "";

            if (hasSettings)
            {
                readCSVfolder();
                readPDFfolder();
            }
        }


        //TAB 1 - CSV
        private void txt_csv_dir_TextChanged(object sender, EventArgs e)
        {
            _csvFolderPath = txt_csv_dir.Text;
            txt_default_csv_dir.Text = _csvFolderPath;

            if (!_csvFolderPath.EndsWith(@"\"))
            {
                _csvFolderPath = _csvFolderPath + @"\";
            }
        }

        private void btn_read_csv_Click(object sender, EventArgs e)
        {
            readCSVfolder();
        }

        private void readCSVfolder()
        {
            try
            {
                lbl_csv_dir.Text = "Directory: " + _csvFolderPath;
                _csvFiles = csvDirectoryImport.importCSVdir(_csvFolderPath);
                update_csv_list();
            }
            catch
            {
                MessageBox.Show("Viga (1)");
            }
        }

        private void update_csv_list()
        {
            lib_csv_dir.DataSource = _csvFiles;
            lib_csv_dir.SelectedIndex = _csvFiles.Count - 1;
        }


        //TAB 2 - WORKSHOP
        private void txt_workshop_directory_TextChanged(object sender, EventArgs e)
        {
            _workshopFolderPath = txt_workshop_dir.Text;
            txt_default_workshop_dir.Text = _workshopFolderPath;

            if (!_workshopFolderPath.EndsWith(@"\"))
            {
                _workshopFolderPath = _workshopFolderPath + @"\";
            }
        }

        private void btn_checkPDF_Click(object sender, EventArgs e)
        {
            readPDFfolder();
        }

        private void readPDFfolder()
        {
            try
            {
                lbl_workshop_dir.Text = "Directory: " + _workshopFolderPath;
                _pdfFiles = workshopDirectoryImport.importPDF(_workshopFolderPath);
                update_pdf_list();
            }
            catch
            {
                MessageBox.Show("Viga (2)");
            }
        }

        private void update_pdf_list()
        {
            lib_workshop_dir.DataSource = _pdfFiles;
        }


        // TAB 4
        private void txt_default_csv_directory_TextChanged(object sender, EventArgs e)
        {
            _defaultCSVdir = txt_default_csv_dir.Text;
        }

        private void txt_default_workshop_directory_TextChanged(object sender, EventArgs e)
        {
            _defaultWorkshopdir = txt_default_workshop_dir.Text;
        }

        private void btn_save_defaults_Click(object sender, EventArgs e)
        {
            defaults.writeDefaultDirectorys(_defaultCSVdir, _defaultWorkshopdir);
        }

        private void lib_csv_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lib_csv_dir.SelectedItem != null)
            {
                _csvFilePath = _csvFolderPath + lib_csv_dir.SelectedItem + ".csv";
                lbl_csv_file.Text = _csvFilePath;
            }
        }
    }
}
