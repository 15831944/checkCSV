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
            this.tab_results = new System.Windows.Forms.TabPage();
            this.rb_status_4 = new System.Windows.Forms.RadioButton();
            this.rb_status_3 = new System.Windows.Forms.RadioButton();
            this.rb_status_2 = new System.Windows.Forms.RadioButton();
            this.rb_status_1 = new System.Windows.Forms.RadioButton();
            this.rb_status_0 = new System.Windows.Forms.RadioButton();
            this.lv_csv_results = new System.Windows.Forms.ListView();
            this.lbl_pdf_dir_main = new System.Windows.Forms.Label();
            this.lbl_csv_file = new System.Windows.Forms.Label();
            this.btn_check_csv = new System.Windows.Forms.Button();
            this.txt_incastClass = new System.Windows.Forms.TextBox();
            this.tab_folder = new System.Windows.Forms.TabPage();
            this.panel_export = new System.Windows.Forms.Panel();
            this.lv_exportedParts = new System.Windows.Forms.ListView();
            this.rb_steel = new System.Windows.Forms.RadioButton();
            this.rb_concrete = new System.Windows.Forms.RadioButton();
            this.btn_create_folders = new System.Windows.Forms.Button();
            this.txt_export_target = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_csv = new System.Windows.Forms.TabPage();
            this.lbl_csv_dir = new System.Windows.Forms.Label();
            this.lib_csv_dir = new System.Windows.Forms.ListBox();
            this.btn_check_csv_dir = new System.Windows.Forms.Button();
            this.txt_csv_dir = new System.Windows.Forms.TextBox();
            this.tab_pdf = new System.Windows.Forms.TabPage();
            this.lv_pdf_dir = new System.Windows.Forms.ListView();
            this.lbl_pdf_dir = new System.Windows.Forms.Label();
            this.btn_checkPDF = new System.Windows.Forms.Button();
            this.txt_pdf_dir = new System.Windows.Forms.TextBox();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.txt_default_incast_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save_defaults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_default_csv_directory = new System.Windows.Forms.Label();
            this.txt_default_pdf_dir = new System.Windows.Forms.TextBox();
            this.txt_default_csv_dir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_number_of_export = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_results.SuspendLayout();
            this.tab_folder.SuspendLayout();
            this.panel_export.SuspendLayout();
            this.tab_csv.SuspendLayout();
            this.tab_pdf.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_results);
            this.tabControl1.Controls.Add(this.tab_folder);
            this.tabControl1.Controls.Add(this.tab_csv);
            this.tabControl1.Controls.Add(this.tab_pdf);
            this.tabControl1.Controls.Add(this.tab_settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 761);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tab_results
            // 
            this.tab_results.Controls.Add(this.rb_status_4);
            this.tab_results.Controls.Add(this.rb_status_3);
            this.tab_results.Controls.Add(this.rb_status_2);
            this.tab_results.Controls.Add(this.rb_status_1);
            this.tab_results.Controls.Add(this.rb_status_0);
            this.tab_results.Controls.Add(this.lv_csv_results);
            this.tab_results.Controls.Add(this.lbl_pdf_dir_main);
            this.tab_results.Controls.Add(this.lbl_csv_file);
            this.tab_results.Controls.Add(this.btn_check_csv);
            this.tab_results.Controls.Add(this.txt_incastClass);
            this.tab_results.Location = new System.Drawing.Point(4, 22);
            this.tab_results.Name = "tab_results";
            this.tab_results.Padding = new System.Windows.Forms.Padding(3);
            this.tab_results.Size = new System.Drawing.Size(656, 735);
            this.tab_results.TabIndex = 2;
            this.tab_results.Text = "Results";
            this.tab_results.UseVisualStyleBackColor = true;
            // 
            // rb_status_4
            // 
            this.rb_status_4.AutoSize = true;
            this.rb_status_4.Enabled = false;
            this.rb_status_4.Location = new System.Drawing.Point(389, 104);
            this.rb_status_4.Name = "rb_status_4";
            this.rb_status_4.Size = new System.Drawing.Size(86, 17);
            this.rb_status_4.TabIndex = 11;
            this.rb_status_4.TabStop = true;
            this.rb_status_4.Text = "<rb_status4>";
            this.rb_status_4.UseVisualStyleBackColor = false;
            this.rb_status_4.CheckedChanged += new System.EventHandler(this.rb_status_4_CheckedChanged);
            // 
            // rb_status_3
            // 
            this.rb_status_3.AutoSize = true;
            this.rb_status_3.Enabled = false;
            this.rb_status_3.Location = new System.Drawing.Point(297, 104);
            this.rb_status_3.Name = "rb_status_3";
            this.rb_status_3.Size = new System.Drawing.Size(86, 17);
            this.rb_status_3.TabIndex = 11;
            this.rb_status_3.TabStop = true;
            this.rb_status_3.Text = "<rb_status3>";
            this.rb_status_3.UseVisualStyleBackColor = false;
            this.rb_status_3.CheckedChanged += new System.EventHandler(this.rb_status_3_CheckedChanged);
            // 
            // rb_status_2
            // 
            this.rb_status_2.AutoSize = true;
            this.rb_status_2.Enabled = false;
            this.rb_status_2.Location = new System.Drawing.Point(199, 104);
            this.rb_status_2.Name = "rb_status_2";
            this.rb_status_2.Size = new System.Drawing.Size(92, 17);
            this.rb_status_2.TabIndex = 10;
            this.rb_status_2.TabStop = true;
            this.rb_status_2.Text = "<rb_status_2>";
            this.rb_status_2.UseVisualStyleBackColor = false;
            this.rb_status_2.CheckedChanged += new System.EventHandler(this.rb_status_2_CheckedChanged);
            // 
            // rb_status_1
            // 
            this.rb_status_1.AutoSize = true;
            this.rb_status_1.Enabled = false;
            this.rb_status_1.Location = new System.Drawing.Point(101, 104);
            this.rb_status_1.Name = "rb_status_1";
            this.rb_status_1.Size = new System.Drawing.Size(92, 17);
            this.rb_status_1.TabIndex = 9;
            this.rb_status_1.TabStop = true;
            this.rb_status_1.Text = "<rb_status_1>";
            this.rb_status_1.UseVisualStyleBackColor = false;
            this.rb_status_1.CheckedChanged += new System.EventHandler(this.rb_status_1_CheckedChanged);
            // 
            // rb_status_0
            // 
            this.rb_status_0.AutoSize = true;
            this.rb_status_0.Checked = true;
            this.rb_status_0.Enabled = false;
            this.rb_status_0.Location = new System.Drawing.Point(3, 104);
            this.rb_status_0.Name = "rb_status_0";
            this.rb_status_0.Size = new System.Drawing.Size(92, 17);
            this.rb_status_0.TabIndex = 8;
            this.rb_status_0.TabStop = true;
            this.rb_status_0.Text = "<rb_status_0>";
            this.rb_status_0.UseVisualStyleBackColor = true;
            this.rb_status_0.CheckedChanged += new System.EventHandler(this.rb_status_0_CheckedChanged);
            // 
            // lv_csv_results
            // 
            this.lv_csv_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_csv_results.FullRowSelect = true;
            this.lv_csv_results.Location = new System.Drawing.Point(3, 127);
            this.lv_csv_results.MultiSelect = false;
            this.lv_csv_results.Name = "lv_csv_results";
            this.lv_csv_results.Size = new System.Drawing.Size(650, 605);
            this.lv_csv_results.TabIndex = 1;
            this.lv_csv_results.UseCompatibleStateImageBehavior = false;
            this.lv_csv_results.View = System.Windows.Forms.View.Details;
            // 
            // lbl_pdf_dir_main
            // 
            this.lbl_pdf_dir_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pdf_dir_main.AutoSize = true;
            this.lbl_pdf_dir_main.Location = new System.Drawing.Point(0, 80);
            this.lbl_pdf_dir_main.Name = "lbl_pdf_dir_main";
            this.lbl_pdf_dir_main.Size = new System.Drawing.Size(67, 13);
            this.lbl_pdf_dir_main.TabIndex = 7;
            this.lbl_pdf_dir_main.Text = "<lbl_pdf_dir>";
            // 
            // lbl_csv_file
            // 
            this.lbl_csv_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_csv_file.AutoSize = true;
            this.lbl_csv_file.Location = new System.Drawing.Point(0, 60);
            this.lbl_csv_file.Name = "lbl_csv_file";
            this.lbl_csv_file.Size = new System.Drawing.Size(71, 13);
            this.lbl_csv_file.TabIndex = 5;
            this.lbl_csv_file.Text = "<lbl_csv_file>";
            // 
            // btn_check_csv
            // 
            this.btn_check_csv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_csv.Location = new System.Drawing.Point(3, 29);
            this.btn_check_csv.Name = "btn_check_csv";
            this.btn_check_csv.Size = new System.Drawing.Size(650, 23);
            this.btn_check_csv.TabIndex = 1;
            this.btn_check_csv.Text = "check CSV file";
            this.btn_check_csv.UseVisualStyleBackColor = true;
            this.btn_check_csv.Click += new System.EventHandler(this.btn_check_csv_Click);
            // 
            // txt_incastClass
            // 
            this.txt_incastClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_incastClass.Location = new System.Drawing.Point(3, 3);
            this.txt_incastClass.Name = "txt_incastClass";
            this.txt_incastClass.Size = new System.Drawing.Size(650, 20);
            this.txt_incastClass.TabIndex = 0;
            this.txt_incastClass.Text = "<incast detail class>";
            this.txt_incastClass.TextChanged += new System.EventHandler(this.txt_incastClass_TextChanged);
            // 
            // tab_folder
            // 
            this.tab_folder.Controls.Add(this.panel_export);
            this.tab_folder.Location = new System.Drawing.Point(4, 22);
            this.tab_folder.Name = "tab_folder";
            this.tab_folder.Padding = new System.Windows.Forms.Padding(3);
            this.tab_folder.Size = new System.Drawing.Size(656, 735);
            this.tab_folder.TabIndex = 4;
            this.tab_folder.Text = "Export";
            this.tab_folder.UseVisualStyleBackColor = true;
            // 
            // panel_export
            // 
            this.panel_export.Controls.Add(this.lb_number_of_export);
            this.panel_export.Controls.Add(this.label4);
            this.panel_export.Controls.Add(this.lv_exportedParts);
            this.panel_export.Controls.Add(this.rb_steel);
            this.panel_export.Controls.Add(this.rb_concrete);
            this.panel_export.Controls.Add(this.btn_create_folders);
            this.panel_export.Controls.Add(this.txt_export_target);
            this.panel_export.Controls.Add(this.label3);
            this.panel_export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_export.Enabled = false;
            this.panel_export.Location = new System.Drawing.Point(3, 3);
            this.panel_export.Name = "panel_export";
            this.panel_export.Size = new System.Drawing.Size(650, 729);
            this.panel_export.TabIndex = 0;
            // 
            // lv_exportedParts
            // 
            this.lv_exportedParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_exportedParts.Location = new System.Drawing.Point(0, 88);
            this.lv_exportedParts.Name = "lv_exportedParts";
            this.lv_exportedParts.Size = new System.Drawing.Size(650, 612);
            this.lv_exportedParts.TabIndex = 5;
            this.lv_exportedParts.UseCompatibleStateImageBehavior = false;
            this.lv_exportedParts.View = System.Windows.Forms.View.Details;
            // 
            // rb_steel
            // 
            this.rb_steel.AutoSize = true;
            this.rb_steel.Enabled = false;
            this.rb_steel.Location = new System.Drawing.Point(95, 40);
            this.rb_steel.Name = "rb_steel";
            this.rb_steel.Size = new System.Drawing.Size(49, 17);
            this.rb_steel.TabIndex = 4;
            this.rb_steel.Text = "Steel";
            this.rb_steel.UseVisualStyleBackColor = true;
            // 
            // rb_concrete
            // 
            this.rb_concrete.AutoSize = true;
            this.rb_concrete.Checked = true;
            this.rb_concrete.Location = new System.Drawing.Point(0, 40);
            this.rb_concrete.Name = "rb_concrete";
            this.rb_concrete.Size = new System.Drawing.Size(68, 17);
            this.rb_concrete.TabIndex = 3;
            this.rb_concrete.TabStop = true;
            this.rb_concrete.Text = "Concrete";
            this.rb_concrete.UseVisualStyleBackColor = true;
            this.rb_concrete.CheckedChanged += new System.EventHandler(this.rb_concrete_CheckedChanged);
            // 
            // btn_create_folders
            // 
            this.btn_create_folders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create_folders.Location = new System.Drawing.Point(0, 706);
            this.btn_create_folders.Name = "btn_create_folders";
            this.btn_create_folders.Size = new System.Drawing.Size(650, 23);
            this.btn_create_folders.TabIndex = 2;
            this.btn_create_folders.Text = "Copy drawings to location";
            this.btn_create_folders.UseVisualStyleBackColor = true;
            this.btn_create_folders.Click += new System.EventHandler(this.btn_create_folders_Click);
            // 
            // txt_export_target
            // 
            this.txt_export_target.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_export_target.Location = new System.Drawing.Point(0, 16);
            this.txt_export_target.Name = "txt_export_target";
            this.txt_export_target.Size = new System.Drawing.Size(650, 20);
            this.txt_export_target.TabIndex = 1;
            this.txt_export_target.TextChanged += new System.EventHandler(this.txt_export_target_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Target directory";
            // 
            // tab_csv
            // 
            this.tab_csv.Controls.Add(this.lbl_csv_dir);
            this.tab_csv.Controls.Add(this.lib_csv_dir);
            this.tab_csv.Controls.Add(this.btn_check_csv_dir);
            this.tab_csv.Controls.Add(this.txt_csv_dir);
            this.tab_csv.Location = new System.Drawing.Point(4, 22);
            this.tab_csv.Name = "tab_csv";
            this.tab_csv.Padding = new System.Windows.Forms.Padding(3);
            this.tab_csv.Size = new System.Drawing.Size(656, 735);
            this.tab_csv.TabIndex = 0;
            this.tab_csv.Text = "CSV";
            this.tab_csv.UseVisualStyleBackColor = true;
            // 
            // lbl_csv_dir
            // 
            this.lbl_csv_dir.AutoSize = true;
            this.lbl_csv_dir.Location = new System.Drawing.Point(0, 62);
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
            this.lib_csv_dir.Location = new System.Drawing.Point(3, 86);
            this.lib_csv_dir.Name = "lib_csv_dir";
            this.lib_csv_dir.Size = new System.Drawing.Size(650, 641);
            this.lib_csv_dir.TabIndex = 2;
            this.lib_csv_dir.SelectedIndexChanged += new System.EventHandler(this.lib_csv_files_SelectedIndexChanged);
            // 
            // btn_check_csv_dir
            // 
            this.btn_check_csv_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_csv_dir.Location = new System.Drawing.Point(3, 29);
            this.btn_check_csv_dir.Name = "btn_check_csv_dir";
            this.btn_check_csv_dir.Size = new System.Drawing.Size(650, 23);
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
            this.txt_csv_dir.Size = new System.Drawing.Size(650, 20);
            this.txt_csv_dir.TabIndex = 0;
            this.txt_csv_dir.Text = "<csv directory>";
            this.txt_csv_dir.TextChanged += new System.EventHandler(this.txt_csv_dir_TextChanged);
            // 
            // tab_pdf
            // 
            this.tab_pdf.Controls.Add(this.lv_pdf_dir);
            this.tab_pdf.Controls.Add(this.lbl_pdf_dir);
            this.tab_pdf.Controls.Add(this.btn_checkPDF);
            this.tab_pdf.Controls.Add(this.txt_pdf_dir);
            this.tab_pdf.Location = new System.Drawing.Point(4, 22);
            this.tab_pdf.Name = "tab_pdf";
            this.tab_pdf.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pdf.Size = new System.Drawing.Size(656, 735);
            this.tab_pdf.TabIndex = 1;
            this.tab_pdf.Text = "PDF";
            this.tab_pdf.UseVisualStyleBackColor = true;
            // 
            // lv_pdf_dir
            // 
            this.lv_pdf_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_pdf_dir.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_pdf_dir.Location = new System.Drawing.Point(3, 86);
            this.lv_pdf_dir.MultiSelect = false;
            this.lv_pdf_dir.Name = "lv_pdf_dir";
            this.lv_pdf_dir.Size = new System.Drawing.Size(650, 646);
            this.lv_pdf_dir.TabIndex = 6;
            this.lv_pdf_dir.UseCompatibleStateImageBehavior = false;
            this.lv_pdf_dir.View = System.Windows.Forms.View.Details;
            // 
            // lbl_pdf_dir
            // 
            this.lbl_pdf_dir.AutoSize = true;
            this.lbl_pdf_dir.Location = new System.Drawing.Point(0, 62);
            this.lbl_pdf_dir.Name = "lbl_pdf_dir";
            this.lbl_pdf_dir.Size = new System.Drawing.Size(72, 13);
            this.lbl_pdf_dir.TabIndex = 4;
            this.lbl_pdf_dir.Text = "<lbl directory>";
            // 
            // btn_checkPDF
            // 
            this.btn_checkPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_checkPDF.Location = new System.Drawing.Point(3, 29);
            this.btn_checkPDF.Name = "btn_checkPDF";
            this.btn_checkPDF.Size = new System.Drawing.Size(650, 23);
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
            this.txt_pdf_dir.Size = new System.Drawing.Size(650, 20);
            this.txt_pdf_dir.TabIndex = 0;
            this.txt_pdf_dir.Text = "<pdf directory>";
            this.txt_pdf_dir.TextChanged += new System.EventHandler(this.txt_pdf_dir_TextChanged);
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.txt_default_incast_class);
            this.tab_settings.Controls.Add(this.label2);
            this.tab_settings.Controls.Add(this.btn_save_defaults);
            this.tab_settings.Controls.Add(this.label1);
            this.tab_settings.Controls.Add(this.lbl_default_csv_directory);
            this.tab_settings.Controls.Add(this.txt_default_pdf_dir);
            this.tab_settings.Controls.Add(this.txt_default_csv_dir);
            this.tab_settings.Location = new System.Drawing.Point(4, 22);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(656, 735);
            this.tab_settings.TabIndex = 3;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // txt_default_incast_class
            // 
            this.txt_default_incast_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_default_incast_class.Location = new System.Drawing.Point(3, 97);
            this.txt_default_incast_class.Name = "txt_default_incast_class";
            this.txt_default_incast_class.Size = new System.Drawing.Size(650, 20);
            this.txt_default_incast_class.TabIndex = 4;
            this.txt_default_incast_class.TextChanged += new System.EventHandler(this.txt_default_incast_class_TextChanged);
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
            // btn_save_defaults
            // 
            this.btn_save_defaults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_defaults.Location = new System.Drawing.Point(3, 123);
            this.btn_save_defaults.Name = "btn_save_defaults";
            this.btn_save_defaults.Size = new System.Drawing.Size(650, 23);
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
            this.txt_default_pdf_dir.Size = new System.Drawing.Size(650, 20);
            this.txt_default_pdf_dir.TabIndex = 0;
            this.txt_default_pdf_dir.TextChanged += new System.EventHandler(this.txt_default_pdf_dir_TextChanged);
            // 
            // txt_default_csv_dir
            // 
            this.txt_default_csv_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_default_csv_dir.Location = new System.Drawing.Point(3, 19);
            this.txt_default_csv_dir.Name = "txt_default_csv_dir";
            this.txt_default_csv_dir.Size = new System.Drawing.Size(650, 20);
            this.txt_default_csv_dir.TabIndex = 0;
            this.txt_default_csv_dir.TextChanged += new System.EventHandler(this.txt_default_csv_directory_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of elements that can be copied:";
            // 
            // lb_number_of_export
            // 
            this.lb_number_of_export.AutoSize = true;
            this.lb_number_of_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lb_number_of_export.Location = new System.Drawing.Point(202, 67);
            this.lb_number_of_export.Name = "lb_number_of_export";
            this.lb_number_of_export.Size = new System.Drawing.Size(142, 13);
            this.lb_number_of_export.TabIndex = 7;
            this.lb_number_of_export.Text = "<lbl_number_of_export>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 761);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tab_results.ResumeLayout(false);
            this.tab_results.PerformLayout();
            this.tab_folder.ResumeLayout(false);
            this.panel_export.ResumeLayout(false);
            this.panel_export.PerformLayout();
            this.tab_csv.ResumeLayout(false);
            this.tab_csv.PerformLayout();
            this.tab_pdf.ResumeLayout(false);
            this.tab_pdf.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_csv;
        private System.Windows.Forms.TabPage tab_pdf;
        private System.Windows.Forms.TabPage tab_results;
        private System.Windows.Forms.TextBox txt_csv_dir;
        private System.Windows.Forms.Button btn_check_csv_dir;
        private System.Windows.Forms.ListBox lib_csv_dir;
        private System.Windows.Forms.Label lbl_csv_dir;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_default_csv_directory;
        private System.Windows.Forms.TextBox txt_default_csv_dir;
        private System.Windows.Forms.Button btn_save_defaults;
        private System.Windows.Forms.TextBox txt_default_pdf_dir;
        private System.Windows.Forms.TextBox txt_pdf_dir;
        private System.Windows.Forms.Button btn_checkPDF;
        private System.Windows.Forms.Label lbl_pdf_dir;
        private System.Windows.Forms.TextBox txt_default_incast_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_check_csv;
        private System.Windows.Forms.TextBox txt_incastClass;
        private System.Windows.Forms.Label lbl_csv_file;
        private System.Windows.Forms.Label lbl_pdf_dir_main;
        private System.Windows.Forms.ListView lv_csv_results;
        private System.Windows.Forms.ListView lv_pdf_dir;
        private System.Windows.Forms.RadioButton rb_status_3;
        private System.Windows.Forms.RadioButton rb_status_2;
        private System.Windows.Forms.RadioButton rb_status_1;
        private System.Windows.Forms.RadioButton rb_status_0;
        private System.Windows.Forms.RadioButton rb_status_4;
        private System.Windows.Forms.TabPage tab_folder;
        private System.Windows.Forms.Panel panel_export;
        private System.Windows.Forms.TextBox txt_export_target;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_create_folders;
        private System.Windows.Forms.RadioButton rb_steel;
        private System.Windows.Forms.RadioButton rb_concrete;
        private System.Windows.Forms.ListView lv_exportedParts;
        private System.Windows.Forms.Label lb_number_of_export;
        private System.Windows.Forms.Label label4;
    }
}

