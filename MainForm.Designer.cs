
namespace PDFMergeDeleteSplit
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selFiles = new MetroFramework.Controls.MetroTextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.endpages = new MetroFramework.Controls.MetroTextBox();
            this.dirpath = new MetroFramework.Controls.MetroTextBox();
            this.startpages = new MetroFramework.Controls.MetroTextBox();
            this.dellPdf = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.merge = new MetroFramework.Controls.MetroButton();
            this.deletepdffile = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pdfsplit = new MetroFramework.Controls.MetroTextBox();
            this.pdfname = new MetroFramework.Controls.MetroTextBox();
            this.number = new MetroFramework.Controls.MetroTextBox();
            this.down = new System.Windows.Forms.DomainUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.up = new System.Windows.Forms.DomainUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Controls.Add(this.selFiles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroButton4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.endpages, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dirpath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startpages, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dellPdf, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroButton2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.merge, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.deletepdffile, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.pdfsplit, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pdfname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.number, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selFiles
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.selFiles, 4);
            // 
            // 
            // 
            this.selFiles.CustomButton.Image = null;
            this.selFiles.CustomButton.Location = new System.Drawing.Point(540, 2);
            this.selFiles.CustomButton.Name = "";
            this.selFiles.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.selFiles.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.selFiles.CustomButton.TabIndex = 1;
            this.selFiles.CustomButton.Text = "...";
            this.selFiles.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selFiles.CustomButton.UseSelectable = true;
            this.selFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selFiles.Lines = new string[0];
            this.selFiles.Location = new System.Drawing.Point(3, 91);
            this.selFiles.MaxLength = 32767;
            this.selFiles.Multiline = true;
            this.selFiles.Name = "selFiles";
            this.selFiles.PasswordChar = '\0';
            this.selFiles.PromptText = "Selected pdf file";
            this.selFiles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selFiles.SelectedText = "";
            this.selFiles.SelectionLength = 0;
            this.selFiles.SelectionStart = 0;
            this.selFiles.ShortcutsEnabled = true;
            this.selFiles.ShowButton = true;
            this.selFiles.Size = new System.Drawing.Size(576, 38);
            this.selFiles.Style = MetroFramework.MetroColorStyle.Brown;
            this.selFiles.TabIndex = 0;
            this.selFiles.UseSelectable = true;
            this.selFiles.WaterMark = "Selected pdf file";
            this.selFiles.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selFiles.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.selFiles.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.btn_SelFiles);
            // 
            // metroButton4
            // 
            this.metroButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton4.Location = new System.Drawing.Point(585, 179);
            this.metroButton4.Name = "metroButton4";
            this.tableLayoutPanel1.SetRowSpan(this.metroButton4, 2);
            this.metroButton4.Size = new System.Drawing.Size(87, 87);
            this.metroButton4.TabIndex = 1;
            this.metroButton4.Text = "Split";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.pdf_split);
            // 
            // endpages
            // 
            // 
            // 
            // 
            this.endpages.CustomButton.Image = null;
            this.endpages.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.endpages.CustomButton.Name = "";
            this.endpages.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.endpages.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.endpages.CustomButton.TabIndex = 1;
            this.endpages.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.endpages.CustomButton.UseSelectable = true;
            this.endpages.CustomButton.Visible = false;
            this.endpages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endpages.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.endpages.Lines = new string[] {
        "2"};
            this.endpages.Location = new System.Drawing.Point(273, 179);
            this.endpages.MaxLength = 32767;
            this.endpages.Multiline = true;
            this.endpages.Name = "endpages";
            this.endpages.PasswordChar = '\0';
            this.endpages.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.endpages.SelectedText = "";
            this.endpages.SelectionLength = 0;
            this.endpages.SelectionStart = 0;
            this.endpages.ShortcutsEnabled = true;
            this.endpages.Size = new System.Drawing.Size(178, 38);
            this.endpages.Style = MetroFramework.MetroColorStyle.Brown;
            this.endpages.TabIndex = 0;
            this.endpages.Text = "2";
            this.endpages.UseSelectable = true;
            this.endpages.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.endpages.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dirpath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dirpath, 4);
            // 
            // 
            // 
            this.dirpath.CustomButton.Image = null;
            this.dirpath.CustomButton.Location = new System.Drawing.Point(540, 2);
            this.dirpath.CustomButton.Name = "";
            this.dirpath.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.dirpath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dirpath.CustomButton.TabIndex = 1;
            this.dirpath.CustomButton.Text = "...";
            this.dirpath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dirpath.CustomButton.UseSelectable = true;
            this.dirpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirpath.Lines = new string[0];
            this.dirpath.Location = new System.Drawing.Point(3, 47);
            this.dirpath.MaxLength = 32767;
            this.dirpath.Multiline = true;
            this.dirpath.Name = "dirpath";
            this.dirpath.PasswordChar = '\0';
            this.dirpath.PromptText = "Search pdf Directory";
            this.dirpath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dirpath.SelectedText = "";
            this.dirpath.SelectionLength = 0;
            this.dirpath.SelectionStart = 0;
            this.dirpath.ShortcutsEnabled = true;
            this.dirpath.ShowButton = true;
            this.dirpath.Size = new System.Drawing.Size(576, 38);
            this.dirpath.Style = MetroFramework.MetroColorStyle.Brown;
            this.dirpath.TabIndex = 0;
            this.dirpath.UseSelectable = true;
            this.dirpath.WaterMark = "Search pdf Directory";
            this.dirpath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dirpath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.dirpath.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.pdfdirectory_click);
            // 
            // startpages
            // 
            // 
            // 
            // 
            this.startpages.CustomButton.Image = null;
            this.startpages.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.startpages.CustomButton.Name = "";
            this.startpages.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.startpages.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.startpages.CustomButton.TabIndex = 1;
            this.startpages.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startpages.CustomButton.UseSelectable = true;
            this.startpages.CustomButton.Visible = false;
            this.startpages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startpages.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.startpages.Lines = new string[] {
        "1"};
            this.startpages.Location = new System.Drawing.Point(137, 179);
            this.startpages.MaxLength = 32767;
            this.startpages.Multiline = true;
            this.startpages.Name = "startpages";
            this.startpages.PasswordChar = '\0';
            this.startpages.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.startpages.SelectedText = "";
            this.startpages.SelectionLength = 0;
            this.startpages.SelectionStart = 0;
            this.startpages.ShortcutsEnabled = true;
            this.startpages.Size = new System.Drawing.Size(130, 38);
            this.startpages.Style = MetroFramework.MetroColorStyle.Brown;
            this.startpages.TabIndex = 0;
            this.startpages.Text = "1";
            this.startpages.UseSelectable = true;
            this.startpages.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.startpages.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dellPdf
            // 
            this.dellPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dellPdf.Location = new System.Drawing.Point(585, 135);
            this.dellPdf.Name = "dellPdf";
            this.dellPdf.Size = new System.Drawing.Size(87, 38);
            this.dellPdf.TabIndex = 1;
            this.dellPdf.Text = "Delete page";
            this.dellPdf.UseSelectable = true;
            this.dellPdf.Click += new System.EventHandler(this.Del_button);
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton2.Location = new System.Drawing.Point(585, 91);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(87, 38);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Merge";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.SelFiles_click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.Location = new System.Drawing.Point(3, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 44);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Start page";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // merge
            // 
            this.merge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.merge.Location = new System.Drawing.Point(585, 47);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(87, 38);
            this.merge.TabIndex = 1;
            this.merge.Text = "Merge";
            this.merge.UseSelectable = true;
            this.merge.Click += new System.EventHandler(this.merge_click);
            // 
            // deletepdffile
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.deletepdffile, 3);
            // 
            // 
            // 
            this.deletepdffile.CustomButton.Image = null;
            this.deletepdffile.CustomButton.Location = new System.Drawing.Point(412, 2);
            this.deletepdffile.CustomButton.Name = "";
            this.deletepdffile.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.deletepdffile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.deletepdffile.CustomButton.TabIndex = 1;
            this.deletepdffile.CustomButton.Text = "...";
            this.deletepdffile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.deletepdffile.CustomButton.UseSelectable = true;
            this.deletepdffile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletepdffile.Lines = new string[0];
            this.deletepdffile.Location = new System.Drawing.Point(3, 135);
            this.deletepdffile.MaxLength = 32767;
            this.deletepdffile.Multiline = true;
            this.deletepdffile.Name = "deletepdffile";
            this.deletepdffile.PasswordChar = '\0';
            this.deletepdffile.PromptText = "Select pdf File";
            this.deletepdffile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.deletepdffile.SelectedText = "";
            this.deletepdffile.SelectionLength = 0;
            this.deletepdffile.SelectionStart = 0;
            this.deletepdffile.ShortcutsEnabled = true;
            this.deletepdffile.ShowButton = true;
            this.deletepdffile.Size = new System.Drawing.Size(448, 38);
            this.deletepdffile.Style = MetroFramework.MetroColorStyle.Brown;
            this.deletepdffile.TabIndex = 0;
            this.deletepdffile.UseSelectable = true;
            this.deletepdffile.WaterMark = "Select pdf File";
            this.deletepdffile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.deletepdffile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.deletepdffile.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.delpage);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.Location = new System.Drawing.Point(457, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 44);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "End Page";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdfsplit
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pdfsplit, 4);
            // 
            // 
            // 
            this.pdfsplit.CustomButton.Image = null;
            this.pdfsplit.CustomButton.Location = new System.Drawing.Point(534, 1);
            this.pdfsplit.CustomButton.Name = "";
            this.pdfsplit.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.pdfsplit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pdfsplit.CustomButton.TabIndex = 1;
            this.pdfsplit.CustomButton.Text = "...";
            this.pdfsplit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pdfsplit.CustomButton.UseSelectable = true;
            this.pdfsplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfsplit.Lines = new string[0];
            this.pdfsplit.Location = new System.Drawing.Point(3, 223);
            this.pdfsplit.MaxLength = 32767;
            this.pdfsplit.Multiline = true;
            this.pdfsplit.Name = "pdfsplit";
            this.pdfsplit.PasswordChar = '\0';
            this.pdfsplit.PromptText = "select pdf File";
            this.pdfsplit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pdfsplit.SelectedText = "";
            this.pdfsplit.SelectionLength = 0;
            this.pdfsplit.SelectionStart = 0;
            this.pdfsplit.ShortcutsEnabled = true;
            this.pdfsplit.ShowButton = true;
            this.pdfsplit.Size = new System.Drawing.Size(576, 43);
            this.pdfsplit.Style = MetroFramework.MetroColorStyle.Brown;
            this.pdfsplit.TabIndex = 0;
            this.pdfsplit.UseSelectable = true;
            this.pdfsplit.WaterMark = "select pdf File";
            this.pdfsplit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pdfsplit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pdfsplit.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.pdf_Split);
            // 
            // pdfname
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pdfname, 5);
            // 
            // 
            // 
            this.pdfname.CustomButton.Image = null;
            this.pdfname.CustomButton.Location = new System.Drawing.Point(633, 2);
            this.pdfname.CustomButton.Name = "";
            this.pdfname.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pdfname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pdfname.CustomButton.TabIndex = 1;
            this.pdfname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pdfname.CustomButton.UseSelectable = true;
            this.pdfname.CustomButton.Visible = false;
            this.pdfname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pdfname.Lines = new string[] {
        "Pdf Name"};
            this.pdfname.Location = new System.Drawing.Point(3, 3);
            this.pdfname.MaxLength = 32767;
            this.pdfname.Multiline = true;
            this.pdfname.Name = "pdfname";
            this.pdfname.PasswordChar = '\0';
            this.pdfname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pdfname.SelectedText = "";
            this.pdfname.SelectionLength = 0;
            this.pdfname.SelectionStart = 0;
            this.pdfname.ShortcutsEnabled = true;
            this.pdfname.Size = new System.Drawing.Size(669, 38);
            this.pdfname.Style = MetroFramework.MetroColorStyle.Brown;
            this.pdfname.TabIndex = 0;
            this.pdfname.Text = "Pdf Name";
            this.pdfname.UseSelectable = true;
            this.pdfname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pdfname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // number
            // 
            // 
            // 
            // 
            this.number.CustomButton.Image = null;
            this.number.CustomButton.Location = new System.Drawing.Point(86, 2);
            this.number.CustomButton.Name = "";
            this.number.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.number.CustomButton.TabIndex = 1;
            this.number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.number.CustomButton.UseSelectable = true;
            this.number.CustomButton.Visible = false;
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.number.Lines = new string[] {
        "1,2,3"};
            this.number.Location = new System.Drawing.Point(457, 135);
            this.number.MaxLength = 32767;
            this.number.Name = "number";
            this.number.PasswordChar = '\0';
            this.number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.number.SelectedText = "";
            this.number.SelectionLength = 0;
            this.number.SelectionStart = 0;
            this.number.ShortcutsEnabled = true;
            this.number.Size = new System.Drawing.Size(122, 38);
            this.number.TabIndex = 4;
            this.number.Text = "1,2,3";
            this.number.UseSelectable = true;
            this.number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(538, 32);
            this.down.Name = "down";
            this.down.ReadOnly = true;
            this.down.Size = new System.Drawing.Size(62, 22);
            this.down.TabIndex = 2;
            this.down.Text = "0";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(196, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "PDF Merger and Delete Pages";
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(631, 32);
            this.up.Name = "up";
            this.up.ReadOnly = true;
            this.up.Size = new System.Drawing.Size(61, 22);
            this.up.TabIndex = 2;
            this.up.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox dirpath;
        private MetroFramework.Controls.MetroTextBox pdfsplit;
        private MetroFramework.Controls.MetroTextBox selFiles;
        private MetroFramework.Controls.MetroTextBox startpages;
        private MetroFramework.Controls.MetroTextBox endpages;
        private MetroFramework.Controls.MetroTextBox deletepdffile;
        private MetroFramework.Controls.MetroButton dellPdf;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton merge;
        private System.Windows.Forms.DomainUpDown down;
        private MetroFramework.Controls.MetroTextBox pdfname;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox number;
        private System.Windows.Forms.DomainUpDown up;
    }
}

