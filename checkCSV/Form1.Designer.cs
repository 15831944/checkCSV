namespace checkCSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_csv_file = new System.Windows.Forms.Label();
            this.lbl_csv_dir = new System.Windows.Forms.Label();
            this.lib_csv_dir = new System.Windows.Forms.ListBox();
            this.btn_check_csv_dir = new System.Windows.Forms.Button();
            this.txt_csv_dir = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_pdf_dir = new System.Windows.Forms.Label();
            this.lib_pdf_dir = new System.Windows.Forms.ListBox();
            this.btn_checkPDF = new System.Windows.Forms.Button();
            this.txt_pdf_dir = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_save_defaults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_default_csv_directory = new System.Windows.Forms.Label();
            this.txt_default_pdf_dir = new System.Windows.Forms.TextBox();
            this.txt_default_csv_dir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_default_incast_class = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(476, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Results";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_csv_file);
            this.tabPage1.Controls.Add(this.lbl_csv_dir);
            this.tabPage1.Controls.Add(this.lib_csv_dir);
            this.tabPage1.Controls.Add(this.btn_check_csv_dir);
            this.tabPage1.Controls.Add(this.txt_csv_dir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CSV";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_csv_file
            // 
            this.lbl_csv_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_csv_file.AutoSize = true;
            this.lbl_csv_file.Location = new System.Drawing.Point(0, 517);
            this.lbl_csv_file.Name = "lbl_csv_file";
            this.lbl_csv_file.Size = new System.Drawing.Size(71, 13);
            this.lbl_csv_file.TabIndex = 4;
            this.lbl_csv_file.Text = "<lbl_csv_file>";
            // 
            // lbl_csv_dir
            // 
            this.lbl_csv_dir.AutoSize = true;
            this.lbl_csv_dir.Location = new System.Drawing.Point(0, 55);
            this.lbl_csv_dir.Name = "lbl_csv_dir";
            this.lbl_csv_dir.Size = new System.Drawing.Size(72, 13);
            this.lbl_csv_dir.TabIndex = 3;
            this.lbl_csv_dir.Text = "<lbl directory>";
            // 
            // lib_csv_dir
            // 
            this.lib_csv_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lib_csv_dir.FormattingEnabled = true;
            this.lib_csv_dir.Location = new System.Drawing.Point(3, 78);
            this.lib_csv_dir.Name = "lib_csv_dir";
            this.lib_csv_dir.Size = new System.Drawing.Size(467, 433);
            this.lib_csv_dir.TabIndex = 2;
            this.lib_csv_dir.SelectedIndexChanged += new System.EventHandler(this.lib_csv_files_SelectedIndexChanged);
            // 
            // btn_check_csv_dir
            // 
            this.btn_check_csv_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_csv_dir.Location = new System.Drawing.Point(3, 29);
            this.btn_check_csv_dir.Name = "btn_check_csv_dir";
            this.btn_check_csv_dir.Size = new System.Drawing.Size(470, 23);
            this.btn_check_csv_dir.TabIndex = 1;
            this.btn_check_csv_dir.Text = "check CSV directory";
            this.btn_check_csv_dir.UseVisualStyleBackColor = true;
            this.btn_check_csv_dir.Click += new System.EventHandler(this.btn_check_csv_dir_Click);
            // 
            // txt_csv_dir
            // 
            this.txt_csv_dir.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_csv_dir.Location = new System.Drawing.Point(3, 3);
            this.txt_csv_dir.Name = "txt_csv_dir";
            this.txt_csv_dir.Size = new System.Drawing.Size(470, 20);
            this.txt_csv_dir.TabIndex = 0;
            this.txt_csv_dir.Text = "<csv directory>";
            this.txt_csv_dir.TextChanged += new System.EventHandler(this.txt_csv_dir_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_pdf_dir);
            this.tabPage2.Controls.Add(this.lib_pdf_dir);
            this.tabPage2.Controls.Add(this.btn_checkPDF);
            this.tabPage2.Controls.Add(this.txt_pdf_dir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PDF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_pdf_dir
            // 
            this.lbl_pdf_dir.AutoSize = true;
            this.lbl_pdf_dir.Location = new System.Drawing.Point(0, 55);
            this.lbl_pdf_dir.Name = "lbl_pdf_dir";
            this.lbl_pdf_dir.Size = new System.Drawing.Size(72, 13);
            this.lbl_pdf_dir.TabIndex = 4;
            this.lbl_pdf_dir.Text = "<lbl directory>";
            // 
            // lib_pdf_dir
            // 
            this.lib_pdf_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lib_pdf_dir.FormattingEnabled = true;
            this.lib_pdf_dir.Location = new System.Drawing.Point(3, 78);
            this.lib_pdf_dir.Name = "lib_pdf_dir";
            this.lib_pdf_dir.Size = new System.Drawing.Size(467, 459);
            this.lib_pdf_dir.TabIndex = 2;
            // 
            // btn_checkPDF
            // 
            this.btn_checkPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_checkPDF.Location = new System.Drawing.Point(3, 29);
            this.btn_checkPDF.Name = "btn_checkPDF";
            this.btn_checkPDF.Size = new System.Drawing.Size(470, 23);
            this.btn_checkPDF.TabIndex = 1;
            this.btn_checkPDF.Text = "check PDF directory";
            this.btn_checkPDF.UseVisualStyleBackColor = true;
            this.btn_checkPDF.Click += new System.EventHandler(this.btn_check_pdf_dir_Click);
            // 
            // txt_pdf_dir
            // 
            this.txt_pdf_dir.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_pdf_dir.Location = new System.Drawing.Point(3, 3);
            this.txt_pdf_dir.Name = "txt_pdf_dir";
            this.txt_pdf_dir.Size = new System.Drawing.Size(470, 20);
            this.txt_pdf_dir.TabIndex = 0;
            this.txt_pdf_dir.Text = "<pdf directory>";
            this.txt_pdf_dir.TextChanged += new System.EventHandler(this.txt_pdf_dir_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_default_incast_class);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btn_save_defaults);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.lbl_default_csv_directory);
            this.tabPage4.Controls.Add(this.txt_default_pdf_dir);
            this.tabPage4.Controls.Add(this.txt_default_csv_dir);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(476, 535);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_save_defaults
            // 
            this.btn_save_defaults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_defaults.Location = new System.Drawing.Point(3, 132);
            this.btn_save_defaults.Name = "btn_save_defaults";
            this.btn_save_defaults.Size = new System.Drawing.Size(467, 23);
            this.btn_save_defaults.TabIndex = 2;
            this.btn_save_defaults.Text = "Save default values to .dat file";
            this.btn_save_defaults.UseVisualStyleBackColor = true;
            this.btn_save_defaults.Click += new System.EventHandler(this.btn_save_defaults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default PDF directory";
            // 
            // lbl_default_csv_directory
            // 
            this.lbl_default_csv_directory.AutoSize = true;
            this.lbl_default_csv_directory.Location = new System.Drawing.Point(0, 3);
            this.lbl_default_csv_directory.Name = "lbl_default_csv_directory";
            this.lbl_default_csv_directory.Size = new System.Drawing.Size(108, 13);
            this.lbl_default_csv_directory.TabIndex = 1;
            this.lbl_default_csv_directory.Text = "Default CSV directory";
            // 
            // txt_default_pdf_dir
            // 
            this.txt_default_pdf_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_default_pdf_dir.Location = new System.Drawing.Point(3, 58);
            this.txt_default_pdf_dir.Name = "txt_default_pdf_dir";
            this.txt_default_pdf_dir.Size = new System.Drawing.Size(467, 20);
            this.txt_default_pdf_dir.TabIndex = 0;
            this.txt_default_pdf_dir.TextChanged += new System.EventHandler(this.txt_default_pdf_dir_TextChanged);
            // 
            // txt_default_csv_dir
            // 
            this.txt_default_csv_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_default_csv_dir.Location = new System.Drawing.Point(3, 19);
            this.txt_default_csv_dir.Name = "txt_default_csv_dir";
            this.txt_default_csv_dir.Size = new System.Drawing.Size(467, 20);
            this.txt_default_csv_dir.TabIndex = 0;
            this.txt_default_csv_dir.TextChanged += new System.EventHandler(this.txt_default_csv_directory_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "In-cast detail class number";
            // 
            // txt_default_incast_class
            // 
            this.txt_default_incast_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_default_incast_class.Location = new System.Drawing.Point(3, 97);
            this.txt_default_incast_class.Name = "txt_default_incast_class";
            this.txt_default_incast_class.Size = new System.Drawing.Size(467, 20);
            this.txt_default_incast_class.TabIndex = 4;
            this.txt_default_incast_class.TextChanged += new System.EventHandler(this.txt_default_incast_class_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_csv_dir;
        private System.Windows.Forms.Button btn_check_csv_dir;
        private System.Windows.Forms.ListBox lib_csv_dir;
        private System.Windows.Forms.Label lbl_csv_dir;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_default_csv_directory;
        private System.Windows.Forms.TextBox txt_default_csv_dir;
        private System.Windows.Forms.Button btn_save_defaults;
        private System.Windows.Forms.TextBox txt_default_pdf_dir;
        private System.Windows.Forms.Label lbl_csv_file;
        private System.Windows.Forms.TextBox txt_pdf_dir;
        private System.Windows.Forms.Button btn_checkPDF;
        private System.Windows.Forms.ListBox lib_pdf_dir;
        private System.Windows.Forms.Label lbl_pdf_dir;
        private System.Windows.Forms.TextBox txt_default_incast_class;
        private System.Windows.Forms.Label label2;
    }
}

