namespace checkGA
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
            this.btn_choose_csv = new System.Windows.Forms.Button();
            this.btn_choose_dir = new System.Windows.Forms.Button();
            this.txt_csv = new System.Windows.Forms.TextBox();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.txt_rowFileName = new System.Windows.Forms.TextBox();
            this.txt_rowRevision = new System.Windows.Forms.TextBox();
            this.txt_textRevision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_choose_csv
            // 
            this.btn_choose_csv.Location = new System.Drawing.Point(410, 26);
            this.btn_choose_csv.Name = "btn_choose_csv";
            this.btn_choose_csv.Size = new System.Drawing.Size(110, 23);
            this.btn_choose_csv.TabIndex = 0;
            this.btn_choose_csv.Text = "Open CSV file...";
            this.btn_choose_csv.UseVisualStyleBackColor = true;
            this.btn_choose_csv.Click += new System.EventHandler(this.btn_choose_csv_Click);
            // 
            // btn_choose_dir
            // 
            this.btn_choose_dir.Location = new System.Drawing.Point(410, 74);
            this.btn_choose_dir.Name = "btn_choose_dir";
            this.btn_choose_dir.Size = new System.Drawing.Size(110, 23);
            this.btn_choose_dir.TabIndex = 1;
            this.btn_choose_dir.Text = "Open directory...";
            this.btn_choose_dir.UseVisualStyleBackColor = true;
            this.btn_choose_dir.Click += new System.EventHandler(this.btn_choose_dir_Click);
            // 
            // txt_csv
            // 
            this.txt_csv.Location = new System.Drawing.Point(12, 28);
            this.txt_csv.Name = "txt_csv";
            this.txt_csv.Size = new System.Drawing.Size(392, 20);
            this.txt_csv.TabIndex = 2;
            this.txt_csv.TextChanged += new System.EventHandler(this.txt_csv_TextChanged);
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(12, 76);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(392, 20);
            this.txt_folder.TabIndex = 3;
            this.txt_folder.TextChanged += new System.EventHandler(this.txt_folder_TextChanged);
            // 
            // txt_rowFileName
            // 
            this.txt_rowFileName.Location = new System.Drawing.Point(12, 130);
            this.txt_rowFileName.Name = "txt_rowFileName";
            this.txt_rowFileName.Size = new System.Drawing.Size(100, 20);
            this.txt_rowFileName.TabIndex = 4;
            // 
            // txt_rowRevision
            // 
            this.txt_rowRevision.Location = new System.Drawing.Point(138, 129);
            this.txt_rowRevision.Name = "txt_rowRevision";
            this.txt_rowRevision.Size = new System.Drawing.Size(100, 20);
            this.txt_rowRevision.TabIndex = 5;
            // 
            // txt_textRevision
            // 
            this.txt_textRevision.Location = new System.Drawing.Point(272, 129);
            this.txt_textRevision.Name = "txt_textRevision";
            this.txt_textRevision.Size = new System.Drawing.Size(100, 20);
            this.txt_textRevision.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_textRevision);
            this.Controls.Add(this.txt_rowRevision);
            this.Controls.Add(this.txt_rowFileName);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.txt_csv);
            this.Controls.Add(this.btn_choose_dir);
            this.Controls.Add(this.btn_choose_csv);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox txt_textRevision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

