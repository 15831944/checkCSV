using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkGA
{
    public partial class Form1 : Form
    {
        private string csv = "";
        private string folder = "";
        private int rowFileName = 0;
        private int rowRevision = 1;
        private string textRevision = "Rev";

        public Form1()
        {
            InitializeComponent();
            txt_rowFileName.Text = (rowFileName + 1).ToString();
            txt_rowRevision.Text = (rowRevision + 1).ToString();
            txt_textRevision.Text = textRevision;
        }

        private void txt_csv_TextChanged(object sender, EventArgs e)
        {
            csv = txt_csv.Text;
        }

        private void txt_folder_TextChanged(object sender, EventArgs e)
        {
            folder = txt_folder.Text;
        }

        private void btn_choose_csv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_csv.Text = openFileDialog1.FileName;
            }
        }

        private void btn_choose_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_folder.Text = fbd.SelectedPath;
            }
        }
}
