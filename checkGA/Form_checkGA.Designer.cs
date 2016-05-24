﻿namespace checkGA
{
    partial class Form_checkGA
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
            this.btn_choose_csv = new System.Windows.Forms.Button();
            this.btn_choose_dir = new System.Windows.Forms.Button();
            this.txt_csv = new System.Windows.Forms.TextBox();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.txt_rowFileName = new System.Windows.Forms.TextBox();
            this.txt_rowRevision = new System.Windows.Forms.TextBox();
            this.txt_revisionFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_preview = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.cb_drawing_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_csv_results = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_choose_csv
            // 
            this.btn_choose_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choose_csv.Location = new System.Drawing.Point(439, 26);
            this.btn_choose_csv.Name = "btn_choose_csv";
            this.btn_choose_csv.Size = new System.Drawing.Size(110, 23);
            this.btn_choose_csv.TabIndex = 0;
            this.btn_choose_csv.Text = "Open CSV file...";
            this.btn_choose_csv.UseVisualStyleBackColor = true;
            this.btn_choose_csv.Click += new System.EventHandler(this.btn_choose_csv_Click);
            // 
            // btn_choose_dir
            // 
            this.btn_choose_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choose_dir.Location = new System.Drawing.Point(439, 73);
            this.btn_choose_dir.Name = "btn_choose_dir";
            this.btn_choose_dir.Size = new System.Drawing.Size(110, 23);
            this.btn_choose_dir.TabIndex = 1;
            this.btn_choose_dir.Text = "Open directory...";
            this.btn_choose_dir.UseVisualStyleBackColor = true;
            this.btn_choose_dir.Click += new System.EventHandler(this.btn_choose_dir_Click);
            // 
            // txt_csv
            // 
            this.txt_csv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_csv.Location = new System.Drawing.Point(12, 28);
            this.txt_csv.Name = "txt_csv";
            this.txt_csv.Size = new System.Drawing.Size(421, 20);
            this.txt_csv.TabIndex = 2;
            this.txt_csv.TextChanged += new System.EventHandler(this.txt_csv_TextChanged);
            // 
            // txt_folder
            // 
            this.txt_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_folder.Location = new System.Drawing.Point(12, 76);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(421, 20);
            this.txt_folder.TabIndex = 3;
            this.txt_folder.TextChanged += new System.EventHandler(this.txt_folder_TextChanged);
            // 
            // txt_rowFileName
            // 
            this.txt_rowFileName.Location = new System.Drawing.Point(12, 130);
            this.txt_rowFileName.Name = "txt_rowFileName";
            this.txt_rowFileName.Size = new System.Drawing.Size(100, 20);
            this.txt_rowFileName.TabIndex = 4;
            this.txt_rowFileName.Text = "<row1>";
            this.txt_rowFileName.TextChanged += new System.EventHandler(this.txt_rowFileName_TextChanged);
            // 
            // txt_rowRevision
            // 
            this.txt_rowRevision.Location = new System.Drawing.Point(125, 130);
            this.txt_rowRevision.Name = "txt_rowRevision";
            this.txt_rowRevision.Size = new System.Drawing.Size(100, 20);
            this.txt_rowRevision.TabIndex = 5;
            this.txt_rowRevision.Text = "<row2>";
            this.txt_rowRevision.TextChanged += new System.EventHandler(this.txt_rowRevision_TextChanged);
            // 
            // txt_revisionFormat
            // 
            this.txt_revisionFormat.Location = new System.Drawing.Point(343, 130);
            this.txt_revisionFormat.Name = "txt_revisionFormat";
            this.txt_revisionFormat.Size = new System.Drawing.Size(100, 20);
            this.txt_revisionFormat.TabIndex = 6;
            this.txt_revisionFormat.Text = "<revision_format>";
            this.txt_revisionFormat.TextChanged += new System.EventHandler(this.txt_revisionFormat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name row number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Revision format:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Revision row number:";
            // 
            // txt_line
            // 
            this.txt_line.Location = new System.Drawing.Point(237, 130);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(100, 20);
            this.txt_line.TabIndex = 11;
            this.txt_line.Text = "<line>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start at line:";
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.Location = new System.Drawing.Point(340, 153);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(78, 13);
            this.lbl_preview.TabIndex = 13;
            this.lbl_preview.Text = "<example text>";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 182);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "DO";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cb_drawing_type
            // 
            this.cb_drawing_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drawing_type.FormattingEnabled = true;
            this.cb_drawing_type.Location = new System.Drawing.Point(450, 129);
            this.cb_drawing_type.Name = "cb_drawing_type";
            this.cb_drawing_type.Size = new System.Drawing.Size(100, 21);
            this.cb_drawing_type.TabIndex = 15;
            this.cb_drawing_type.SelectedIndexChanged += new System.EventHandler(this.cb_drawing_type_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Drawing type:";
            // 
            // lv_csv_results
            // 
            this.lv_csv_results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_csv_results.FullRowSelect = true;
            this.lv_csv_results.Location = new System.Drawing.Point(12, 211);
            this.lv_csv_results.MultiSelect = false;
            this.lv_csv_results.Name = "lv_csv_results";
            this.lv_csv_results.Size = new System.Drawing.Size(538, 331);
            this.lv_csv_results.TabIndex = 17;
            this.lv_csv_results.UseCompatibleStateImageBehavior = false;
            this.lv_csv_results.View = System.Windows.Forms.View.Details;
            // 
            // Form_checkGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 554);
            this.Controls.Add(this.lv_csv_results);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_drawing_type);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_preview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_revisionFormat);
            this.Controls.Add(this.txt_rowRevision);
            this.Controls.Add(this.txt_rowFileName);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.txt_csv);
            this.Controls.Add(this.btn_choose_dir);
            this.Controls.Add(this.btn_choose_csv);
            this.Name = "Form_checkGA";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_choose_csv;
        private System.Windows.Forms.Button btn_choose_dir;
        private System.Windows.Forms.TextBox txt_csv;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.TextBox txt_rowFileName;
        private System.Windows.Forms.TextBox txt_rowRevision;
        private System.Windows.Forms.TextBox txt_revisionFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_preview;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox cb_drawing_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_csv_results;
    }
}
