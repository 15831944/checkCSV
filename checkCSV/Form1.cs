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
        private string _defaultPDFdir;

        //active
        private string _csvFolderPath;
        private string _pdfFolderPath;
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
            bool hasSettings = defaults.readDefaultDirectorys(out _csvFolderPath, out _pdfFolderPath);
            txt_csv_dir.Text = _csvFolderPath;
            txt_pdf_dir.Text = _pdfFolderPath;

            lbl_csv_dir.Text = "Directory: ";
            lbl_pdf_dir.Text = "Directory: ";

            lbl_csv_file.Text = "";

            if (hasSettings)
            {
                checkCSVdir();
                checkPDFdir();
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

        private void btn_check_csv_dir_Click(object sender, EventArgs e)
        {
            checkCSVdir();
        }

        private void checkCSVdir()
        {
            lbl_csv_dir.Text = "Directory: " + _csvFolderPath;
            _csvFiles = directoryImport.importCSVdir(_csvFolderPath);
            update_csv_list();
        }

        private void update_csv_list()
        {
            lib_csv_dir.DataSource = _csvFiles;
            lib_csv_dir.SelectedIndex = _csvFiles.Count - 1;
        }


        //TAB 2 - PDF
        private void txt_pdf_dir_TextChanged(object sender, EventArgs e)
        {
            _pdfFolderPath = txt_pdf_dir.Text;
            txt_default_pdf_dir.Text = _pdfFolderPath;

            if (!_pdfFolderPath.EndsWith(@"\"))
            {
                _pdfFolderPath = _pdfFolderPath + @"\";
            }
        }

        private void btn_check_pdf_dir_Click(object sender, EventArgs e)
        {
            checkPDFdir();
        }

        private void checkPDFdir()
        {
            lbl_pdf_dir.Text = "Directory: " + _pdfFolderPath;
            _pdfFiles = directoryImport.importPDFdir(_pdfFolderPath);
            update_pdf_list();
        }

        private void update_pdf_list()
        {
            lib_pdf_dir.DataSource = _pdfFiles;
        }


        // TAB 4
        private void txt_default_csv_directory_TextChanged(object sender, EventArgs e)
        {
            _defaultCSVdir = txt_default_csv_dir.Text;
        }

        private void txt_default_pdf_dir_TextChanged(object sender, EventArgs e)
        {
            _defaultPDFdir = txt_default_pdf_dir.Text;
        }

        private void btn_save_defaults_Click(object sender, EventArgs e)
        {
            defaults.writeDefaultDirectorys(_defaultCSVdir, _defaultPDFdir);
        }

        private void lib_csv_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lib_csv_dir.SelectedItem != null)
            {
                _csvFilePath = _csvFolderPath + lib_csv_dir.SelectedItem + ".csv";
                lbl_csv_file.Text = _csvFilePath;
            }
        }

        //global brushes with ordinary/selected colors
        private SolidBrush reportsForegroundBrushSelected = new SolidBrush(Color.White);
        private SolidBrush reportsForegroundBrush = new SolidBrush(Color.Black);
        private SolidBrush reportsBackgroundBrushSelected = new SolidBrush(Color.FromKnownColor(KnownColor.Highlight));
        private SolidBrush reportsBackgroundBrush1 = new SolidBrush(Color.White);
        private SolidBrush reportsBackgroundBrush2 = new SolidBrush(Color.Gray);

        //custom method to draw the items, don't forget to set DrawMode of the ListBox to OwnerDrawFixed
        private void lbReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;
            if (index >= 0 && index < lib_csv_dir.Items.Count)
            {
                string text = lib_csv_dir.Items[index].ToString();
                Graphics g = e.Graphics;

                //background:
                SolidBrush backgroundBrush;
                if (selected)
                    backgroundBrush = reportsBackgroundBrushSelected;
                else if ((index % 2) == 0)
                    backgroundBrush = reportsBackgroundBrush1;
                else
                    backgroundBrush = reportsBackgroundBrush2;
                g.FillRectangle(backgroundBrush, e.Bounds);

                //text:
                SolidBrush foregroundBrush = (selected) ? reportsForegroundBrushSelected : reportsForegroundBrush;
                g.DrawString(text, e.Font, foregroundBrush, lib_csv_dir.GetItemRectangle(index).Location);
            }

            e.DrawFocusRectangle();
        }
    }
}
