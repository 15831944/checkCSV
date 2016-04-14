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
            this.lb_status_4 = new System.Windows.Forms.Label();
            this.lb_status_3 = new System.Windows.Forms.Label();
            this.lb_status_2 = new System.Windows.Forms.Label();
            this.lb_status_1 = new System.Windows.Forms.Label();
            this.lb_status_0 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_filter_results_type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_drawing_type = new System.Windows.Forms.ComboBox();
            this.lbl_dwg_dir_main = new System.Windows.Forms.Label();
            this.lv_csv_results = new System.Windows.Forms.ListView();
            this.lbl_pdf_dir_main = new System.Windows.Forms.Label();
            this.lbl_csv_file_main = new System.Windows.Forms.Label();
            this.btn_check_csv = new System.Windows.Forms.Button();
            this.txt_incastClass = new System.Windows.Forms.TextBox();
            this.tab_folder = new System.Windows.Forms.TabPage();
            this.panel_export = new System.Windows.Forms.Panel();
            this.cb_exportType = new System.Windows.Forms.ComboBox();
            this.cb_exportElementType = new System.Windows.Forms.ComboBox();
            this.lb_number_of_export = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_exportedParts = new System.Windows.Forms.ListView();
            this.btn_create_folders = new System.Windows.Forms.Button();
            this.txt_export_target = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_csv = new System.Windows.Forms.TabPage();
            this.lib_csv_dir = new System.Windows.Forms.ListBox();
            this.btn_check_csv_dir = new System.Windows.Forms.Button();
            this.txt_csv_dir = new System.Windows.Forms.TextBox();
            this.tab_pdf = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dwg_dir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lv_dwg_dir = new System.Windows.Forms.ListView();
            this.lv_pdf_dir = new System.Windows.Forms.ListView();
            this.btn_checkPDF = new System.Windows.Forms.Button();
            this.txt_pdf_dir = new System.Windows.Forms.TextBox();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.lbl_save_defaults_status = new System.Windows.Forms.Label();
            this.txt_default_dwg_dir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_default_incast_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save_defaults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_default_csv_directory = new System.Windows.Forms.Label();
            this.txt_default_pdf_dir = new System.Windows.Forms.TextBox();
            this.txt_default_csv_dir = new System.Windows.Forms.TextBox();
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
            this.tab_results.Controls.Add(this.lb_status_4);
            this.tab_results.Controls.Add(this.lb_status_3);
            this.tab_results.Controls.Add(this.lb_status_2);
            this.tab_results.Controls.Add(this.lb_status_1);
            this.tab_results.Controls.Add(this.lb_status_0);
            this.tab_results.Controls.Add(this.label12);
            this.tab_results.Controls.Add(this.cb_filter_results_type);
            this.tab_results.Controls.Add(this.label10);
            this.tab_results.Controls.Add(this.cb_drawing_type);
            this.tab_results.Controls.Add(this.lbl_dwg_dir_main);
            this.tab_results.Controls.Add(this.lv_csv_results);
            this.tab_results.Controls.Add(this.lbl_pdf_dir_main);
            this.tab_results.Controls.Add(this.lbl_csv_file_main);
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
            // lb_status_4
            // 
            this.lb_status_4.AutoSize = true;
            this.lb_status_4.BackColor = System.Drawing.Color.Cyan;
            this.lb_status_4.Location = new System.Drawing.Point(476, 116);
            this.lb_status_4.Name = "lb_status_4";
            this.lb_status_4.Size = new System.Drawing.Size(143, 13);
            this.lb_status_4.TabIndex = 22;
            this.lb_status_4.Text = "Not set - Has Drawing: (xxxx)";
            // 
            // lb_status_3
            // 
            this.lb_status_3.AutoSize = true;
            this.lb_status_3.BackColor = System.Drawing.Color.Yellow;
            this.lb_status_3.Location = new System.Drawing.Point(397, 116);
            this.lb_status_3.Name = "lb_status_3";
            this.lb_status_3.Size = new System.Drawing.Size(73, 13);
            this.lb_status_3.TabIndex = 21;
            this.lb_status_3.Text = "Not set: (xxxx)";
            // 
            // lb_status_2
            // 
            this.lb_status_2.AutoSize = true;
            this.lb_status_2.BackColor = System.Drawing.Color.Red;
            this.lb_status_2.Location = new System.Drawing.Point(317, 116);
            this.lb_status_2.Name = "lb_status_2";
            this.lb_status_2.Size = new System.Drawing.Size(74, 13);
            this.lb_status_2.TabIndex = 20;
            this.lb_status_2.Text = "Missing: (xxxx)";
            // 
            // lb_status_1
            // 
            this.lb_status_1.AutoSize = true;
            this.lb_status_1.BackColor = System.Drawing.Color.Lime;
            this.lb_status_1.Location = new System.Drawing.Point(257, 116);
            this.lb_status_1.Name = "lb_status_1";
            this.lb_status_1.Size = new System.Drawing.Size(54, 13);
            this.lb_status_1.TabIndex = 19;
            this.lb_status_1.Text = "OK: (xxxx)";
            // 
            // lb_status_0
            // 
            this.lb_status_0.AutoSize = true;
            this.lb_status_0.BackColor = System.Drawing.Color.White;
            this.lb_status_0.Location = new System.Drawing.Point(188, 116);
            this.lb_status_0.Name = "lb_status_0";
            this.lb_status_0.Size = new System.Drawing.Size(63, 13);
            this.lb_status_0.TabIndex = 18;
            this.lb_status_0.Text = "Total: (xxxx)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "In-cast class:";
            // 
            // cb_filter_results_type
            // 
            this.cb_filter_results_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter_results_type.FormattingEnabled = true;
            this.cb_filter_results_type.Location = new System.Drawing.Point(3, 113);
            this.cb_filter_results_type.Name = "cb_filter_results_type";
            this.cb_filter_results_type.Size = new System.Drawing.Size(179, 21);
            this.cb_filter_results_type.TabIndex = 15;
            this.cb_filter_results_type.SelectedIndexChanged += new System.EventHandler(this.cb_filter_results_type_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Check drawings:";
            // 
            // cb_drawing_type
            // 
            this.cb_drawing_type.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_drawing_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drawing_type.FormattingEnabled = true;
            this.cb_drawing_type.Location = new System.Drawing.Point(443, 8);
            this.cb_drawing_type.Name = "cb_drawing_type";
            this.cb_drawing_type.Size = new System.Drawing.Size(210, 21);
            this.cb_drawing_type.TabIndex = 13;
            this.cb_drawing_type.SelectedIndexChanged += new System.EventHandler(this.cb_drawing_type_SelectedIndexChanged);
            // 
            // lbl_dwg_dir_main
            // 
            this.lbl_dwg_dir_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dwg_dir_main.AutoSize = true;
            this.lbl_dwg_dir_main.Location = new System.Drawing.Point(3, 95);
            this.lbl_dwg_dir_main.Name = "lbl_dwg_dir_main";
            this.lbl_dwg_dir_main.Size = new System.Drawing.Size(100, 13);
            this.lbl_dwg_dir_main.TabIndex = 12;
            this.lbl_dwg_dir_main.Text = "<lbl_dwg_dir_main>";
            // 
            // lv_csv_results
            // 
            this.lv_csv_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_csv_results.FullRowSelect = true;
            this.lv_csv_results.Location = new System.Drawing.Point(3, 140);
            this.lv_csv_results.MultiSelect = false;
            this.lv_csv_results.Name = "lv_csv_results";
            this.lv_csv_results.Size = new System.Drawing.Size(650, 592);
            this.lv_csv_results.TabIndex = 1;
            this.lv_csv_results.UseCompatibleStateImageBehavior = false;
            this.lv_csv_results.View = System.Windows.Forms.View.Details;
            // 
            // lbl_pdf_dir_main
            // 
            this.lbl_pdf_dir_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pdf_dir_main.AutoSize = true;
            this.lbl_pdf_dir_main.Location = new System.Drawing.Point(3, 78);
            this.lbl_pdf_dir_main.Name = "lbl_pdf_dir_main";
            this.lbl_pdf_dir_main.Size = new System.Drawing.Size(95, 13);
            this.lbl_pdf_dir_main.TabIndex = 7;
            this.lbl_pdf_dir_main.Text = "<lbl_pdf_dir_main>";
            // 
            // lbl_csv_file_main
            // 
            this.lbl_csv_file_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_csv_file_main.AutoSize = true;
            this.lbl_csv_file_main.Location = new System.Drawing.Point(3, 61);
            this.lbl_csv_file_main.Name = "lbl_csv_file_main";
            this.lbl_csv_file_main.Size = new System.Drawing.Size(99, 13);
            this.lbl_csv_file_main.TabIndex = 5;
            this.lbl_csv_file_main.Text = "<lbl_csv_file_main>";
            // 
            // btn_check_csv
            // 
            this.btn_check_csv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_csv.Location = new System.Drawing.Point(3, 35);
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
            this.txt_incastClass.Location = new System.Drawing.Point(92, 9);
            this.txt_incastClass.Name = "txt_incastClass";
            this.txt_incastClass.Size = new System.Drawing.Size(210, 20);
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
            this.panel_export.Controls.Add(this.cb_exportType);
            this.panel_export.Controls.Add(this.cb_exportElementType);
            this.panel_export.Controls.Add(this.lb_number_of_export);
            this.panel_export.Controls.Add(this.label4);
            this.panel_export.Controls.Add(this.lv_exportedParts);
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
            // cb_exportType
            // 
            this.cb_exportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_exportType.BackColor = System.Drawing.SystemColors.Window;
            this.cb_exportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_exportType.FormattingEnabled = true;
            this.cb_exportType.Location = new System.Drawing.Point(0, 69);
            this.cb_exportType.Name = "cb_exportType";
            this.cb_exportType.Size = new System.Drawing.Size(650, 21);
            this.cb_exportType.TabIndex = 9;
            this.cb_exportType.SelectedIndexChanged += new System.EventHandler(this.cb_exportType_SelectedIndexChanged);
            // 
            // cb_exportElementType
            // 
            this.cb_exportElementType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_exportElementType.BackColor = System.Drawing.SystemColors.Window;
            this.cb_exportElementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_exportElementType.FormattingEnabled = true;
            this.cb_exportElementType.Location = new System.Drawing.Point(0, 42);
            this.cb_exportElementType.Name = "cb_exportElementType";
            this.cb_exportElementType.Size = new System.Drawing.Size(650, 21);
            this.cb_exportElementType.TabIndex = 8;
            this.cb_exportElementType.SelectedIndexChanged += new System.EventHandler(this.cb_exportElementType_SelectedIndexChanged);
            // 
            // lb_number_of_export
            // 
            this.lb_number_of_export.AutoSize = true;
            this.lb_number_of_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lb_number_of_export.Location = new System.Drawing.Point(199, 104);
            this.lb_number_of_export.Name = "lb_number_of_export";
            this.lb_number_of_export.Size = new System.Drawing.Size(142, 13);
            this.lb_number_of_export.TabIndex = 7;
            this.lb_number_of_export.Text = "<lbl_number_of_export>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of elements that can be copied:";
            // 
            // lv_exportedParts
            // 
            this.lv_exportedParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_exportedParts.Location = new System.Drawing.Point(0, 120);
            this.lv_exportedParts.Name = "lv_exportedParts";
            this.lv_exportedParts.Size = new System.Drawing.Size(650, 578);
            this.lv_exportedParts.TabIndex = 5;
            this.lv_exportedParts.UseCompatibleStateImageBehavior = false;
            this.lv_exportedParts.View = System.Windows.Forms.View.Details;
            // 
            // btn_create_folders
            // 
            this.btn_create_folders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create_folders.Location = new System.Drawing.Point(0, 704);
            this.btn_create_folders.Name = "btn_create_folders";
            this.btn_create_folders.Size = new System.Drawing.Size(650, 20);
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
            // lib_csv_dir
            // 
            this.lib_csv_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lib_csv_dir.FormattingEnabled = true;
            this.lib_csv_dir.Location = new System.Drawing.Point(3, 65);
            this.lib_csv_dir.Name = "lib_csv_dir";
            this.lib_csv_dir.Size = new System.Drawing.Size(650, 667);
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
            this.tab_pdf.Controls.Add(this.label9);
            this.tab_pdf.Controls.Add(this.label8);
            this.tab_pdf.Controls.Add(this.txt_dwg_dir);
            this.tab_pdf.Controls.Add(this.label6);
            this.tab_pdf.Controls.Add(this.label5);
            this.tab_pdf.Controls.Add(this.lv_dwg_dir);
            this.tab_pdf.Controls.Add(this.lv_pdf_dir);
            this.tab_pdf.Controls.Add(this.btn_checkPDF);
            this.tab_pdf.Controls.Add(this.txt_pdf_dir);
            this.tab_pdf.Location = new System.Drawing.Point(4, 22);
            this.tab_pdf.Name = "tab_pdf";
            this.tab_pdf.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pdf.Size = new System.Drawing.Size(656, 735);
            this.tab_pdf.TabIndex = 1;
            this.tab_pdf.Text = "PDF / DWG";
            this.tab_pdf.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "DWG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "PDF:";
            // 
            // txt_dwg_dir
            // 
            this.txt_dwg_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dwg_dir.Location = new System.Drawing.Point(3, 58);
            this.txt_dwg_dir.Name = "txt_dwg_dir";
            this.txt_dwg_dir.Size = new System.Drawing.Size(650, 20);
            this.txt_dwg_dir.TabIndex = 9;
            this.txt_dwg_dir.Text = "<dwg directory>";
            this.txt_dwg_dir.TextChanged += new System.EventHandler(this.txt_dwg_dir_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "DWG directory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PDF directory:";
            // 
            // lv_dwg_dir
            // 
            this.lv_dwg_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_dwg_dir.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dwg_dir.Location = new System.Drawing.Point(350, 132);
            this.lv_dwg_dir.MultiSelect = false;
            this.lv_dwg_dir.Name = "lv_dwg_dir";
            this.lv_dwg_dir.Size = new System.Drawing.Size(300, 600);
            this.lv_dwg_dir.TabIndex = 6;
            this.lv_dwg_dir.UseCompatibleStateImageBehavior = false;
            this.lv_dwg_dir.View = System.Windows.Forms.View.Details;
            // 
            // lv_pdf_dir
            // 
            this.lv_pdf_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_pdf_dir.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_pdf_dir.Location = new System.Drawing.Point(8, 132);
            this.lv_pdf_dir.MultiSelect = false;
            this.lv_pdf_dir.Name = "lv_pdf_dir";
            this.lv_pdf_dir.Size = new System.Drawing.Size(300, 600);
            this.lv_pdf_dir.TabIndex = 6;
            this.lv_pdf_dir.UseCompatibleStateImageBehavior = false;
            this.lv_pdf_dir.View = System.Windows.Forms.View.Details;
            // 
            // btn_checkPDF
            // 
            this.btn_checkPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_checkPDF.Location = new System.Drawing.Point(3, 84);
            this.btn_checkPDF.Name = "btn_checkPDF";
            this.btn_checkPDF.Size = new System.Drawing.Size(650, 23);
            this.btn_checkPDF.TabIndex = 1;
            this.btn_checkPDF.Text = "check PDF / DWG directory";
            this.btn_checkPDF.UseVisualStyleBackColor = true;
            this.btn_checkPDF.Click += new System.EventHandler(this.btn_check_pdf_dir_Click);
            // 
            // txt_pdf_dir
            // 
            this.txt_pdf_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pdf_dir.Location = new System.Drawing.Point(3, 19);
            this.txt_pdf_dir.Name = "txt_pdf_dir";
            this.txt_pdf_dir.Size = new System.Drawing.Size(650, 20);
            this.txt_pdf_dir.TabIndex = 0;
            this.txt_pdf_dir.Text = "<pdf directory>";
            this.txt_pdf_dir.TextChanged += new System.EventHandler(this.txt_pdf_dir_TextChanged);
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.lbl_save_defaults_status);
            this.tab_settings.Controls.Add(this.txt_default_dwg_dir);
            this.tab_settings.Controls.Add(this.label7);
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
            // lbl_save_defaults_status
            // 
            this.lbl_save_defaults_status.AutoSize = true;
            this.lbl_save_defaults_status.Location = new System.Drawing.Point(3, 188);
            this.lbl_save_defaults_status.Name = "lbl_save_defaults_status";
            this.lbl_save_defaults_status.Size = new System.Drawing.Size(122, 13);
            this.lbl_save_defaults_status.TabIndex = 7;
            this.lbl_save_defaults_status.Text = " <save_defaults_status>";
            // 
            // txt_default_dwg_dir
            // 
            this.txt_default_dwg_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_default_dwg_dir.Location = new System.Drawing.Point(3, 97);
            this.txt_default_dwg_dir.Name = "txt_default_dwg_dir";
            this.txt_default_dwg_dir.Size = new System.Drawing.Size(650, 20);
            this.txt_default_dwg_dir.TabIndex = 6;
            this.txt_default_dwg_dir.TextChanged += new System.EventHandler(this.txt_default_dwg_dir_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Default DWG directory";
            // 
            // txt_default_incast_class
            // 
            this.txt_default_incast_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_default_incast_class.Location = new System.Drawing.Point(3, 136);
            this.txt_default_incast_class.Name = "txt_default_incast_class";
            this.txt_default_incast_class.Size = new System.Drawing.Size(650, 20);
            this.txt_default_incast_class.TabIndex = 4;
            this.txt_default_incast_class.TextChanged += new System.EventHandler(this.txt_default_incast_class_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "In-cast detail class number";
            // 
            // btn_save_defaults
            // 
            this.btn_save_defaults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_defaults.Location = new System.Drawing.Point(3, 162);
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
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_default_csv_directory;
        private System.Windows.Forms.TextBox txt_default_csv_dir;
        private System.Windows.Forms.Button btn_save_defaults;
        private System.Windows.Forms.TextBox txt_default_pdf_dir;
        private System.Windows.Forms.TextBox txt_pdf_dir;
        private System.Windows.Forms.Button btn_checkPDF;
        private System.Windows.Forms.TextBox txt_default_incast_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_check_csv;
        private System.Windows.Forms.TextBox txt_incastClass;
        private System.Windows.Forms.Label lbl_csv_file_main;
        private System.Windows.Forms.Label lbl_pdf_dir_main;
        private System.Windows.Forms.ListView lv_csv_results;
        private System.Windows.Forms.ListView lv_pdf_dir;
        private System.Windows.Forms.TabPage tab_folder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_default_dwg_dir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dwg_dir;
        private System.Windows.Forms.Label lbl_save_defaults_status;
        private System.Windows.Forms.Label lbl_dwg_dir_main;
        private System.Windows.Forms.ListView lv_dwg_dir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_export;
        private System.Windows.Forms.ComboBox cb_exportElementType;
        private System.Windows.Forms.Label lb_number_of_export;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_create_folders;
        private System.Windows.Forms.TextBox txt_export_target;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_exportedParts;
        private System.Windows.Forms.ComboBox cb_drawing_type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_filter_results_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_status_3;
        private System.Windows.Forms.Label lb_status_2;
        private System.Windows.Forms.Label lb_status_1;
        private System.Windows.Forms.Label lb_status_0;
        private System.Windows.Forms.Label lb_status_4;
        private System.Windows.Forms.ComboBox cb_exportType;
    }
}

