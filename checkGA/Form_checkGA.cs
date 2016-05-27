using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkGA
{
    public enum DrawingFinder
    {
        PDF_DWG, PDF, DWG
    }

    public enum StatusFilter
    {
        ALL, OK, Missing
    }

    public partial class Form_checkGA : Form
    {
        private string _xlsx = String.Empty;
        private string _folder = String.Empty;
        private int _rowFileName = 1;
        private int _rowRevision = 2;
        private int _lineStart = 1;
        private string _revisionFormat = "_Rev";

        private string _drawingType;
        private int _reportFilter = 0;

        GA_DataGroup _reportData = new GA_DataGroup();

        public Form_checkGA()
        {
            InitializeComponent();
            
            btn_start.Enabled = false;


            txt_xlsx.Text = _xlsx;

            txt_rowFileName.Text = _rowFileName.ToString();
            txt_rowRevision.Text = _rowRevision.ToString();
            txt_line.Text = _lineStart.ToString();
            txt_revisionFormat.Text = _revisionFormat;

            cb_drawing_type.DataSource = Enum.GetValues(typeof(DrawingFinder));
            cb_filter_results_type.DataSource = Enum.GetValues(typeof(StatusFilter));

            report_labels_update();
            exampleText();
        }

        private void txt_xlsx_TextChanged(object sender, EventArgs e)
        {
            _xlsx = txt_xlsx.Text;

            if (String.IsNullOrEmpty(_xlsx))
            {
                btn_start.Enabled = false;
            }
            else
            {
                btn_start.Enabled = true;
            }
        }

        private void txt_folder_TextChanged(object sender, EventArgs e)
        {
            _folder = txt_folder.Text;
        }

        private void btn_choose_csv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "EXCEL Files (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_xlsx.Text = openFileDialog1.FileName;
            }
        }

        private void btn_choose_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_folder.Text = fbd.SelectedPath;
            }
        }

        private void txt_rowFileName_TextChanged(object sender, EventArgs e)
        {
            int dummy;

            if (Int32.TryParse(txt_rowFileName.Text, out dummy))
            {
                _rowFileName = dummy;
            }
            else
            {
                txt_rowFileName.Text = _rowFileName.ToString();
            }
        }

        private void txt_rowRevision_TextChanged(object sender, EventArgs e)
        {
            int dummy;

            if (Int32.TryParse(txt_rowRevision.Text, out dummy))
            {
                _rowRevision = dummy;
            }
            else
            {
                txt_rowRevision.Text = _rowRevision.ToString();
            }
        }

        private void txt_revisionFormat_TextChanged(object sender, EventArgs e)
        {
            _revisionFormat = txt_revisionFormat.Text;
            exampleText();
        }

        private void txt_line_TextChanged(object sender, EventArgs e)
        {
            int dummy;

            if (Int32.TryParse(txt_line.Text, out dummy))
            {
                _lineStart = dummy;
            }
            else
            {
                txt_line.Text = _lineStart.ToString();
            }
        }

        private void exampleText()
        {
            string example = "K-0001" + _revisionFormat + "B";
            lbl_preview.Text = example;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            excelFileReader reader = new excelFileReader(_xlsx, _rowFileName, _rowRevision, _lineStart, cb_include_revision.Checked);
            List<ArrayList> parsedData = reader.importXSLS();

            List<string> _pdfFiles = DirectoryImport.importDirFiles(_folder, "*.pdf", true);
            List<string> _dwgFiles = DirectoryImport.importDirFiles(_folder, "*.dwg", true);

            _reportData = new GA_DataGroup(parsedData, _pdfFiles, _dwgFiles);
            _reportData.buildData(_revisionFormat);
            _reportData.findDrawings(_drawingType);

            report_labels_update();
            report_list_update();
        }

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
                foreach (GA_Data ga in _reportData._allDrawings)
                {
                    addPartToList(ga);
                }
            }
            else
            {
                List<GA_Data> filtered = new List<GA_Data>();
                filtered = _reportData._allDrawings.Where(x => x.status == _reportFilter).ToList();

                foreach (GA_Data ga in filtered)
                {
                    addPartToList(ga);
                }
            }
        }

        private void addPartToList(GA_Data ga)
        {
            if (ga.status == 1)
            {
                string pathShort = ga.pdfPath + " " + ga.dwgPath;
                pathShort = pathShort.Replace(_folder, "");

                lv_csv_results.Items.Add(ga.ToString()).SubItems.Add(pathShort);
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = ABI.colorOfField(ga);
            }
            else
            {
                lv_csv_results.Items.Add(ga.ToString()).SubItems.Add(ga.statusMessage);
                lv_csv_results.Items[lv_csv_results.Items.Count - 1].BackColor = ABI.colorOfField(ga);
            }

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
            lb_status_0.Text = @"Total: (" + _reportData._allDrawings.Count.ToString() + @")";
            lb_status_1.Text = @"OK: (" + _reportData._allDrawings.Where(x => x.status == 1).ToList().Count.ToString() + @")";
            lb_status_2.Text = @"Missing: (" + _reportData._allDrawings.Where(x => x.status == 2).ToList().Count.ToString() + @")";
        }
    }
}
