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

        List<string> _csvFiles = new List<string>();
        List<string> _pdfFiles = new List<string>();

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

            lv_csv_results.Columns.Add("Name"); update_width();

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
            doMagicStuff();
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


        //FN
        private void doMagicStuff()
        {
            lv_csv_results.Clear();
            lv_csv_results.Columns.Add("Name");
            update_width();

            List<ArrayList> parsedData = csvFileReader.importCSV(_csvFilePath, _incastClass);
            ElementDataGroup reportData = ElementDataBuilder.dataBuilder(parsedData);

    
            
            foreach (ElementData main in reportData)
            {
                lv_csv_results.Items.Add(main.ToString());
                colorOfField(main);

                foreach (ElementData special in main.specialDetails)
                {
                    lv_csv_results.Items.Add("    -    " + special.ToString());
                    colorOfField(special);
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

        private void checkPDFdir()
        {
            lbl_pdf_dir.Text = "Directory: " + _pdfFolderPath;
            lbl_pdf_dir_main.Text = "PDF: " + _pdfFolderPath;
            _pdfFiles = directoryImport.importPDFdir(_pdfFolderPath);
            update_pdf_list();
        }


        //ListBox
        private void update_csv_list()
        {
            lib_csv_dir.DataSource = _csvFiles;
            lib_csv_dir.SelectedIndex = _csvFiles.Count - 1;
        }

        private void update_pdf_list()
        {
            lib_pdf_dir.DataSource = _pdfFiles;
        }

        private void lib_csv_files_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            update_width();
        }

        private void update_width()
        {
            lv_csv_results.Columns[0].Width = -2;
            lv_csv_results.Columns[0].Width = (Width - 55);
        }
    }
}
