namespace libraryvdatabase
{
    partial class Readergui
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
            this.butchangepass = new System.Windows.Forms.Button();
            this.butlogout = new System.Windows.Forms.Button();
            this.transparent1 = new thuform.transparent();
            this.tabbook = new System.Windows.Forms.TabPage();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.butsearch = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.labelsearch = new System.Windows.Forms.Label();
            this.groupsearch = new System.Windows.Forms.GroupBox();
            this.radioauthor = new System.Windows.Forms.RadioButton();
            this.radiotype = new System.Windows.Forms.RadioButton();
            this.radiobookname = new System.Windows.Forms.RadioButton();
            this.radiocodebook = new System.Windows.Forms.RadioButton();
            this.butrequest = new System.Windows.Forms.Button();
            this.butrefresh = new System.Windows.Forms.Button();
            this.dataGridbook = new System.Windows.Forms.DataGridView();
            this.tabinfo = new System.Windows.Forms.TabPage();
            this.panelsearchbo = new System.Windows.Forms.Panel();
            this.butsearchbo = new System.Windows.Forms.Button();
            this.textsearchbo = new System.Windows.Forms.TextBox();
            this.labelsearchbo = new System.Windows.Forms.Label();
            this.groupsearchbo = new System.Windows.Forms.GroupBox();
            this.radiodayborrow = new System.Windows.Forms.RadioButton();
            this.radiobooknamebo = new System.Windows.Forms.RadioButton();
            this.radiocodebookbo = new System.Windows.Forms.RadioButton();
            this.panelsearchre = new System.Windows.Forms.Panel();
            this.butsearchre = new System.Windows.Forms.Button();
            this.textsearchre = new System.Windows.Forms.TextBox();
            this.labelsearchre = new System.Windows.Forms.Label();
            this.groupsearchre = new System.Windows.Forms.GroupBox();
            this.radiotypere = new System.Windows.Forms.RadioButton();
            this.radionamebookre = new System.Windows.Forms.RadioButton();
            this.radiocodebookre = new System.Windows.Forms.RadioButton();
            this.butremovere = new System.Windows.Forms.Button();
            this.butrefreshinfo = new System.Windows.Forms.Button();
            this.dataGridborrow = new System.Windows.Forms.DataGridView();
            this.labelborrow = new System.Windows.Forms.Label();
            this.labelrequest = new System.Windows.Forms.Label();
            this.dataGridrequest = new System.Windows.Forms.DataGridView();
            this.tabhistory = new System.Windows.Forms.TabPage();
            this.panelsearchhis = new System.Windows.Forms.Panel();
            this.butsearchhi = new System.Windows.Forms.Button();
            this.textsearchhi = new System.Windows.Forms.TextBox();
            this.labelsearchhis = new System.Windows.Forms.Label();
            this.groupsearchhis = new System.Windows.Forms.GroupBox();
            this.radiodayborrowhi = new System.Windows.Forms.RadioButton();
            this.radiobooknamehi = new System.Windows.Forms.RadioButton();
            this.radiobookcodehi = new System.Windows.Forms.RadioButton();
            this.butrefreshhi = new System.Windows.Forms.Button();
            this.dataGridhistory = new System.Windows.Forms.DataGridView();
            this.transparent1.SuspendLayout();
            this.tabbook.SuspendLayout();
            this.panelsearch.SuspendLayout();
            this.groupsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbook)).BeginInit();
            this.tabinfo.SuspendLayout();
            this.panelsearchbo.SuspendLayout();
            this.groupsearchbo.SuspendLayout();
            this.panelsearchre.SuspendLayout();
            this.groupsearchre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridborrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridrequest)).BeginInit();
            this.tabhistory.SuspendLayout();
            this.panelsearchhis.SuspendLayout();
            this.groupsearchhis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // butchangepass
            // 
            this.butchangepass.Location = new System.Drawing.Point(740, 447);
            this.butchangepass.Name = "butchangepass";
            this.butchangepass.Size = new System.Drawing.Size(115, 36);
            this.butchangepass.TabIndex = 1;
            this.butchangepass.Text = "Change Password";
            this.butchangepass.UseVisualStyleBackColor = true;
            // 
            // butlogout
            // 
            this.butlogout.Location = new System.Drawing.Point(887, 447);
            this.butlogout.Name = "butlogout";
            this.butlogout.Size = new System.Drawing.Size(83, 36);
            this.butlogout.TabIndex = 2;
            this.butlogout.Text = "Logout";
            this.butlogout.UseVisualStyleBackColor = true;
            this.butlogout.Click += new System.EventHandler(this.butlogout_Click);
            // 
            // transparent1
            // 
            this.transparent1.Controls.Add(this.tabbook);
            this.transparent1.Controls.Add(this.tabinfo);
            this.transparent1.Controls.Add(this.tabhistory);
            this.transparent1.Location = new System.Drawing.Point(39, 24);
            this.transparent1.Name = "transparent1";
            this.transparent1.SelectedIndex = 0;
            this.transparent1.Size = new System.Drawing.Size(1009, 417);
            this.transparent1.TabIndex = 0;
            // 
            // tabbook
            // 
            this.tabbook.Controls.Add(this.panelsearch);
            this.tabbook.Controls.Add(this.butrequest);
            this.tabbook.Controls.Add(this.butrefresh);
            this.tabbook.Controls.Add(this.dataGridbook);
            this.tabbook.Location = new System.Drawing.Point(4, 22);
            this.tabbook.Name = "tabbook";
            this.tabbook.Padding = new System.Windows.Forms.Padding(3);
            this.tabbook.Size = new System.Drawing.Size(1001, 391);
            this.tabbook.TabIndex = 0;
            this.tabbook.Text = "Book";
            this.tabbook.UseVisualStyleBackColor = true;
            // 
            // panelsearch
            // 
            this.panelsearch.Controls.Add(this.butsearch);
            this.panelsearch.Controls.Add(this.textsearch);
            this.panelsearch.Controls.Add(this.labelsearch);
            this.panelsearch.Controls.Add(this.groupsearch);
            this.panelsearch.Location = new System.Drawing.Point(130, 203);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(307, 182);
            this.panelsearch.TabIndex = 3;
            // 
            // butsearch
            // 
            this.butsearch.Location = new System.Drawing.Point(224, 137);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(65, 32);
            this.butsearch.TabIndex = 3;
            this.butsearch.Text = "Search";
            this.butsearch.UseVisualStyleBackColor = true;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(79, 144);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(134, 20);
            this.textsearch.TabIndex = 2;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.ForeColor = System.Drawing.SystemColors.Control;
            this.labelsearch.Location = new System.Drawing.Point(15, 146);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(60, 13);
            this.labelsearch.TabIndex = 1;
            this.labelsearch.Text = "Type Here:";
            // 
            // groupsearch
            // 
            this.groupsearch.Controls.Add(this.radioauthor);
            this.groupsearch.Controls.Add(this.radiotype);
            this.groupsearch.Controls.Add(this.radiobookname);
            this.groupsearch.Controls.Add(this.radiocodebook);
            this.groupsearch.ForeColor = System.Drawing.SystemColors.Control;
            this.groupsearch.Location = new System.Drawing.Point(17, 16);
            this.groupsearch.Name = "groupsearch";
            this.groupsearch.Size = new System.Drawing.Size(196, 117);
            this.groupsearch.TabIndex = 0;
            this.groupsearch.TabStop = false;
            this.groupsearch.Text = "Search Book";
            // 
            // radioauthor
            // 
            this.radioauthor.AutoSize = true;
            this.radioauthor.Location = new System.Drawing.Point(28, 93);
            this.radioauthor.Name = "radioauthor";
            this.radioauthor.Size = new System.Drawing.Size(56, 17);
            this.radioauthor.TabIndex = 0;
            this.radioauthor.TabStop = true;
            this.radioauthor.Text = "Author";
            this.radioauthor.UseVisualStyleBackColor = true;
            // 
            // radiotype
            // 
            this.radiotype.AutoSize = true;
            this.radiotype.Location = new System.Drawing.Point(28, 70);
            this.radiotype.Name = "radiotype";
            this.radiotype.Size = new System.Drawing.Size(49, 17);
            this.radiotype.TabIndex = 0;
            this.radiotype.TabStop = true;
            this.radiotype.Text = "Type";
            this.radiotype.UseVisualStyleBackColor = true;
            // 
            // radiobookname
            // 
            this.radiobookname.AutoSize = true;
            this.radiobookname.Location = new System.Drawing.Point(28, 48);
            this.radiobookname.Name = "radiobookname";
            this.radiobookname.Size = new System.Drawing.Size(81, 17);
            this.radiobookname.TabIndex = 0;
            this.radiobookname.TabStop = true;
            this.radiobookname.Text = "Book Name";
            this.radiobookname.UseVisualStyleBackColor = true;
            // 
            // radiocodebook
            // 
            this.radiocodebook.AutoSize = true;
            this.radiocodebook.Location = new System.Drawing.Point(28, 27);
            this.radiocodebook.Name = "radiocodebook";
            this.radiocodebook.Size = new System.Drawing.Size(93, 17);
            this.radiocodebook.TabIndex = 0;
            this.radiocodebook.TabStop = true;
            this.radiocodebook.Text = "By Book Code";
            this.radiocodebook.UseVisualStyleBackColor = true;
            // 
            // butrequest
            // 
            this.butrequest.Location = new System.Drawing.Point(856, 253);
            this.butrequest.Name = "butrequest";
            this.butrequest.Size = new System.Drawing.Size(65, 32);
            this.butrequest.TabIndex = 2;
            this.butrequest.Text = "Request";
            this.butrequest.UseVisualStyleBackColor = true;
            this.butrequest.Click += new System.EventHandler(this.butrequest_Click);
            // 
            // butrefresh
            // 
            this.butrefresh.Location = new System.Drawing.Point(856, 15);
            this.butrefresh.Name = "butrefresh";
            this.butrefresh.Size = new System.Drawing.Size(65, 32);
            this.butrefresh.TabIndex = 1;
            this.butrefresh.Text = "Refresh";
            this.butrefresh.UseVisualStyleBackColor = true;
            this.butrefresh.Click += new System.EventHandler(this.butrefresh_Click);
            // 
            // dataGridbook
            // 
            this.dataGridbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridbook.Location = new System.Drawing.Point(76, 59);
            this.dataGridbook.Name = "dataGridbook";
            this.dataGridbook.ReadOnly = true;
            this.dataGridbook.Size = new System.Drawing.Size(765, 140);
            this.dataGridbook.TabIndex = 0;
            // 
            // tabinfo
            // 
            this.tabinfo.Controls.Add(this.panelsearchbo);
            this.tabinfo.Controls.Add(this.panelsearchre);
            this.tabinfo.Controls.Add(this.butremovere);
            this.tabinfo.Controls.Add(this.butrefreshinfo);
            this.tabinfo.Controls.Add(this.dataGridborrow);
            this.tabinfo.Controls.Add(this.labelborrow);
            this.tabinfo.Controls.Add(this.labelrequest);
            this.tabinfo.Controls.Add(this.dataGridrequest);
            this.tabinfo.Location = new System.Drawing.Point(4, 22);
            this.tabinfo.Name = "tabinfo";
            this.tabinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabinfo.Size = new System.Drawing.Size(1001, 391);
            this.tabinfo.TabIndex = 1;
            this.tabinfo.Text = "Infomation";
            this.tabinfo.UseVisualStyleBackColor = true;
            // 
            // panelsearchbo
            // 
            this.panelsearchbo.Controls.Add(this.butsearchbo);
            this.panelsearchbo.Controls.Add(this.textsearchbo);
            this.panelsearchbo.Controls.Add(this.labelsearchbo);
            this.panelsearchbo.Controls.Add(this.groupsearchbo);
            this.panelsearchbo.Location = new System.Drawing.Point(4, 229);
            this.panelsearchbo.Name = "panelsearchbo";
            this.panelsearchbo.Size = new System.Drawing.Size(270, 141);
            this.panelsearchbo.TabIndex = 7;
            // 
            // butsearchbo
            // 
            this.butsearchbo.Location = new System.Drawing.Point(198, 106);
            this.butsearchbo.Name = "butsearchbo";
            this.butsearchbo.Size = new System.Drawing.Size(65, 32);
            this.butsearchbo.TabIndex = 3;
            this.butsearchbo.Text = "Search";
            this.butsearchbo.UseVisualStyleBackColor = true;
            this.butsearchbo.Click += new System.EventHandler(this.butsearchbo_Click);
            // 
            // textsearchbo
            // 
            this.textsearchbo.Location = new System.Drawing.Point(66, 113);
            this.textsearchbo.Name = "textsearchbo";
            this.textsearchbo.Size = new System.Drawing.Size(125, 20);
            this.textsearchbo.TabIndex = 2;
            // 
            // labelsearchbo
            // 
            this.labelsearchbo.AutoSize = true;
            this.labelsearchbo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelsearchbo.Location = new System.Drawing.Point(4, 117);
            this.labelsearchbo.Name = "labelsearchbo";
            this.labelsearchbo.Size = new System.Drawing.Size(60, 13);
            this.labelsearchbo.TabIndex = 1;
            this.labelsearchbo.Text = "Type Here:";
            // 
            // groupsearchbo
            // 
            this.groupsearchbo.Controls.Add(this.radiodayborrow);
            this.groupsearchbo.Controls.Add(this.radiobooknamebo);
            this.groupsearchbo.Controls.Add(this.radiocodebookbo);
            this.groupsearchbo.ForeColor = System.Drawing.SystemColors.Control;
            this.groupsearchbo.Location = new System.Drawing.Point(15, 15);
            this.groupsearchbo.Name = "groupsearchbo";
            this.groupsearchbo.Size = new System.Drawing.Size(175, 90);
            this.groupsearchbo.TabIndex = 0;
            this.groupsearchbo.TabStop = false;
            this.groupsearchbo.Text = "Search Borrowing";
            // 
            // radiodayborrow
            // 
            this.radiodayborrow.AutoSize = true;
            this.radiodayborrow.Location = new System.Drawing.Point(10, 66);
            this.radiodayborrow.Name = "radiodayborrow";
            this.radiodayborrow.Size = new System.Drawing.Size(109, 17);
            this.radiodayborrow.TabIndex = 0;
            this.radiodayborrow.TabStop = true;
            this.radiodayborrow.Text = "By Borrowing Day";
            this.radiodayborrow.UseVisualStyleBackColor = true;
            // 
            // radiobooknamebo
            // 
            this.radiobooknamebo.AutoSize = true;
            this.radiobooknamebo.Location = new System.Drawing.Point(10, 44);
            this.radiobooknamebo.Name = "radiobooknamebo";
            this.radiobooknamebo.Size = new System.Drawing.Size(96, 17);
            this.radiobooknamebo.TabIndex = 0;
            this.radiobooknamebo.TabStop = true;
            this.radiobooknamebo.Text = "By Book Name";
            this.radiobooknamebo.UseVisualStyleBackColor = true;
            // 
            // radiocodebookbo
            // 
            this.radiocodebookbo.AutoSize = true;
            this.radiocodebookbo.Location = new System.Drawing.Point(10, 22);
            this.radiocodebookbo.Name = "radiocodebookbo";
            this.radiocodebookbo.Size = new System.Drawing.Size(93, 17);
            this.radiocodebookbo.TabIndex = 0;
            this.radiocodebookbo.TabStop = true;
            this.radiocodebookbo.Text = "By Code Book";
            this.radiocodebookbo.UseVisualStyleBackColor = true;
            // 
            // panelsearchre
            // 
            this.panelsearchre.Controls.Add(this.butsearchre);
            this.panelsearchre.Controls.Add(this.textsearchre);
            this.panelsearchre.Controls.Add(this.labelsearchre);
            this.panelsearchre.Controls.Add(this.groupsearchre);
            this.panelsearchre.Location = new System.Drawing.Point(6, 43);
            this.panelsearchre.Name = "panelsearchre";
            this.panelsearchre.Size = new System.Drawing.Size(268, 143);
            this.panelsearchre.TabIndex = 6;
            // 
            // butsearchre
            // 
            this.butsearchre.Location = new System.Drawing.Point(197, 102);
            this.butsearchre.Name = "butsearchre";
            this.butsearchre.Size = new System.Drawing.Size(65, 32);
            this.butsearchre.TabIndex = 3;
            this.butsearchre.Text = "Search";
            this.butsearchre.UseVisualStyleBackColor = true;
            this.butsearchre.Click += new System.EventHandler(this.butsearchre_Click);
            // 
            // textsearchre
            // 
            this.textsearchre.Location = new System.Drawing.Point(66, 108);
            this.textsearchre.Name = "textsearchre";
            this.textsearchre.Size = new System.Drawing.Size(123, 20);
            this.textsearchre.TabIndex = 2;
            // 
            // labelsearchre
            // 
            this.labelsearchre.AutoSize = true;
            this.labelsearchre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelsearchre.Location = new System.Drawing.Point(2, 112);
            this.labelsearchre.Name = "labelsearchre";
            this.labelsearchre.Size = new System.Drawing.Size(60, 13);
            this.labelsearchre.TabIndex = 1;
            this.labelsearchre.Text = "Type Here:";
            // 
            // groupsearchre
            // 
            this.groupsearchre.Controls.Add(this.radiotypere);
            this.groupsearchre.Controls.Add(this.radionamebookre);
            this.groupsearchre.Controls.Add(this.radiocodebookre);
            this.groupsearchre.ForeColor = System.Drawing.SystemColors.Control;
            this.groupsearchre.Location = new System.Drawing.Point(15, 11);
            this.groupsearchre.Name = "groupsearchre";
            this.groupsearchre.Size = new System.Drawing.Size(177, 92);
            this.groupsearchre.TabIndex = 0;
            this.groupsearchre.TabStop = false;
            this.groupsearchre.Text = "Search Request";
            // 
            // radiotypere
            // 
            this.radiotypere.AutoSize = true;
            this.radiotypere.Location = new System.Drawing.Point(8, 65);
            this.radiotypere.Name = "radiotypere";
            this.radiotypere.Size = new System.Drawing.Size(64, 17);
            this.radiotypere.TabIndex = 0;
            this.radiotypere.TabStop = true;
            this.radiotypere.Text = "By Type";
            this.radiotypere.UseVisualStyleBackColor = true;
            // 
            // radionamebookre
            // 
            this.radionamebookre.AutoSize = true;
            this.radionamebookre.Location = new System.Drawing.Point(8, 43);
            this.radionamebookre.Name = "radionamebookre";
            this.radionamebookre.Size = new System.Drawing.Size(96, 17);
            this.radionamebookre.TabIndex = 0;
            this.radionamebookre.TabStop = true;
            this.radionamebookre.Text = "By Book Name";
            this.radionamebookre.UseVisualStyleBackColor = true;
            // 
            // radiocodebookre
            // 
            this.radiocodebookre.AutoSize = true;
            this.radiocodebookre.Location = new System.Drawing.Point(8, 20);
            this.radiocodebookre.Name = "radiocodebookre";
            this.radiocodebookre.Size = new System.Drawing.Size(93, 17);
            this.radiocodebookre.TabIndex = 0;
            this.radiocodebookre.TabStop = true;
            this.radiocodebookre.Text = "By Code Book";
            this.radiocodebookre.UseVisualStyleBackColor = true;
            // 
            // butremovere
            // 
            this.butremovere.Location = new System.Drawing.Point(922, 74);
            this.butremovere.Name = "butremovere";
            this.butremovere.Size = new System.Drawing.Size(65, 32);
            this.butremovere.TabIndex = 5;
            this.butremovere.Text = "Remove";
            this.butremovere.UseVisualStyleBackColor = true;
            this.butremovere.Click += new System.EventHandler(this.butremovere_Click);
            // 
            // butrefreshinfo
            // 
            this.butrefreshinfo.Location = new System.Drawing.Point(922, 16);
            this.butrefreshinfo.Name = "butrefreshinfo";
            this.butrefreshinfo.Size = new System.Drawing.Size(65, 32);
            this.butrefreshinfo.TabIndex = 4;
            this.butrefreshinfo.Text = "Refresh";
            this.butrefreshinfo.UseVisualStyleBackColor = true;
            this.butrefreshinfo.Click += new System.EventHandler(this.butrefreshinfo_Click);
            // 
            // dataGridborrow
            // 
            this.dataGridborrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridborrow.Location = new System.Drawing.Point(280, 229);
            this.dataGridborrow.Name = "dataGridborrow";
            this.dataGridborrow.ReadOnly = true;
            this.dataGridborrow.Size = new System.Drawing.Size(635, 142);
            this.dataGridborrow.TabIndex = 3;
            // 
            // labelborrow
            // 
            this.labelborrow.AutoSize = true;
            this.labelborrow.ForeColor = System.Drawing.SystemColors.Control;
            this.labelborrow.Location = new System.Drawing.Point(572, 204);
            this.labelborrow.Name = "labelborrow";
            this.labelborrow.Size = new System.Drawing.Size(84, 13);
            this.labelborrow.TabIndex = 2;
            this.labelborrow.Text = "Borrowing Table";
            // 
            // labelrequest
            // 
            this.labelrequest.AutoSize = true;
            this.labelrequest.ForeColor = System.Drawing.SystemColors.Control;
            this.labelrequest.Location = new System.Drawing.Point(572, 16);
            this.labelrequest.Name = "labelrequest";
            this.labelrequest.Size = new System.Drawing.Size(77, 13);
            this.labelrequest.TabIndex = 1;
            this.labelrequest.Text = "Request Table";
            // 
            // dataGridrequest
            // 
            this.dataGridrequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridrequest.Location = new System.Drawing.Point(280, 43);
            this.dataGridrequest.Name = "dataGridrequest";
            this.dataGridrequest.ReadOnly = true;
            this.dataGridrequest.Size = new System.Drawing.Size(635, 143);
            this.dataGridrequest.TabIndex = 0;
            // 
            // tabhistory
            // 
            this.tabhistory.Controls.Add(this.panelsearchhis);
            this.tabhistory.Controls.Add(this.butrefreshhi);
            this.tabhistory.Controls.Add(this.dataGridhistory);
            this.tabhistory.Location = new System.Drawing.Point(4, 22);
            this.tabhistory.Name = "tabhistory";
            this.tabhistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabhistory.Size = new System.Drawing.Size(1001, 391);
            this.tabhistory.TabIndex = 2;
            this.tabhistory.Text = "History";
            this.tabhistory.UseVisualStyleBackColor = true;
            // 
            // panelsearchhis
            // 
            this.panelsearchhis.Controls.Add(this.butsearchhi);
            this.panelsearchhis.Controls.Add(this.textsearchhi);
            this.panelsearchhis.Controls.Add(this.labelsearchhis);
            this.panelsearchhis.Controls.Add(this.groupsearchhis);
            this.panelsearchhis.Location = new System.Drawing.Point(81, 211);
            this.panelsearchhis.Name = "panelsearchhis";
            this.panelsearchhis.Size = new System.Drawing.Size(308, 160);
            this.panelsearchhis.TabIndex = 2;
            // 
            // butsearchhi
            // 
            this.butsearchhi.Location = new System.Drawing.Point(221, 123);
            this.butsearchhi.Name = "butsearchhi";
            this.butsearchhi.Size = new System.Drawing.Size(65, 32);
            this.butsearchhi.TabIndex = 3;
            this.butsearchhi.Text = "Search";
            this.butsearchhi.UseVisualStyleBackColor = true;
            this.butsearchhi.Click += new System.EventHandler(this.butsearchhi_Click);
            // 
            // textsearchhi
            // 
            this.textsearchhi.Location = new System.Drawing.Point(79, 128);
            this.textsearchhi.Name = "textsearchhi";
            this.textsearchhi.Size = new System.Drawing.Size(126, 20);
            this.textsearchhi.TabIndex = 2;
            // 
            // labelsearchhis
            // 
            this.labelsearchhis.AutoSize = true;
            this.labelsearchhis.ForeColor = System.Drawing.SystemColors.Control;
            this.labelsearchhis.Location = new System.Drawing.Point(15, 131);
            this.labelsearchhis.Name = "labelsearchhis";
            this.labelsearchhis.Size = new System.Drawing.Size(60, 13);
            this.labelsearchhis.TabIndex = 1;
            this.labelsearchhis.Text = "Type Here:";
            // 
            // groupsearchhis
            // 
            this.groupsearchhis.Controls.Add(this.radiodayborrowhi);
            this.groupsearchhis.Controls.Add(this.radiobooknamehi);
            this.groupsearchhis.Controls.Add(this.radiobookcodehi);
            this.groupsearchhis.ForeColor = System.Drawing.SystemColors.Control;
            this.groupsearchhis.Location = new System.Drawing.Point(18, 17);
            this.groupsearchhis.Name = "groupsearchhis";
            this.groupsearchhis.Size = new System.Drawing.Size(268, 101);
            this.groupsearchhis.TabIndex = 0;
            this.groupsearchhis.TabStop = false;
            this.groupsearchhis.Text = "Search History";
            // 
            // radiodayborrowhi
            // 
            this.radiodayborrowhi.AutoSize = true;
            this.radiodayborrowhi.Location = new System.Drawing.Point(14, 66);
            this.radiodayborrowhi.Name = "radiodayborrowhi";
            this.radiodayborrowhi.Size = new System.Drawing.Size(109, 17);
            this.radiodayborrowhi.TabIndex = 0;
            this.radiodayborrowhi.TabStop = true;
            this.radiodayborrowhi.Text = "By Borrowing Day";
            this.radiodayborrowhi.UseVisualStyleBackColor = true;
            // 
            // radiobooknamehi
            // 
            this.radiobooknamehi.AutoSize = true;
            this.radiobooknamehi.Location = new System.Drawing.Point(14, 43);
            this.radiobooknamehi.Name = "radiobooknamehi";
            this.radiobooknamehi.Size = new System.Drawing.Size(96, 17);
            this.radiobooknamehi.TabIndex = 0;
            this.radiobooknamehi.TabStop = true;
            this.radiobooknamehi.Text = "By Book Name";
            this.radiobooknamehi.UseVisualStyleBackColor = true;
            // 
            // radiobookcodehi
            // 
            this.radiobookcodehi.AutoSize = true;
            this.radiobookcodehi.Location = new System.Drawing.Point(14, 20);
            this.radiobookcodehi.Name = "radiobookcodehi";
            this.radiobookcodehi.Size = new System.Drawing.Size(93, 17);
            this.radiobookcodehi.TabIndex = 0;
            this.radiobookcodehi.TabStop = true;
            this.radiobookcodehi.Text = "By Code Book";
            this.radiobookcodehi.UseVisualStyleBackColor = true;
            // 
            // butrefreshhi
            // 
            this.butrefreshhi.Location = new System.Drawing.Point(856, 12);
            this.butrefreshhi.Name = "butrefreshhi";
            this.butrefreshhi.Size = new System.Drawing.Size(65, 32);
            this.butrefreshhi.TabIndex = 1;
            this.butrefreshhi.Text = "Refresh";
            this.butrefreshhi.UseVisualStyleBackColor = true;
            this.butrefreshhi.Click += new System.EventHandler(this.butrefreshhi_Click);
            // 
            // dataGridhistory
            // 
            this.dataGridhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridhistory.Location = new System.Drawing.Point(68, 62);
            this.dataGridhistory.Name = "dataGridhistory";
            this.dataGridhistory.ReadOnly = true;
            this.dataGridhistory.Size = new System.Drawing.Size(776, 131);
            this.dataGridhistory.TabIndex = 0;
            // 
            // Readergui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryvdatabase.Properties.Resources.hinhnen12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 495);
            this.Controls.Add(this.butlogout);
            this.Controls.Add(this.butchangepass);
            this.Controls.Add(this.transparent1);
            this.Name = "Readergui";
            this.Text = "Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Readergui_FormClosing);
            this.transparent1.ResumeLayout(false);
            this.tabbook.ResumeLayout(false);
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            this.groupsearch.ResumeLayout(false);
            this.groupsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbook)).EndInit();
            this.tabinfo.ResumeLayout(false);
            this.tabinfo.PerformLayout();
            this.panelsearchbo.ResumeLayout(false);
            this.panelsearchbo.PerformLayout();
            this.groupsearchbo.ResumeLayout(false);
            this.groupsearchbo.PerformLayout();
            this.panelsearchre.ResumeLayout(false);
            this.panelsearchre.PerformLayout();
            this.groupsearchre.ResumeLayout(false);
            this.groupsearchre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridborrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridrequest)).EndInit();
            this.tabhistory.ResumeLayout(false);
            this.panelsearchhis.ResumeLayout(false);
            this.panelsearchhis.PerformLayout();
            this.groupsearchhis.ResumeLayout(false);
            this.groupsearchhis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridhistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private thuform.transparent transparent1;
        private System.Windows.Forms.TabPage tabbook;
        private System.Windows.Forms.TabPage tabinfo;
        private System.Windows.Forms.TabPage tabhistory;
        private System.Windows.Forms.Button butchangepass;
        private System.Windows.Forms.Button butlogout;
        private System.Windows.Forms.Button butrefresh;
        private System.Windows.Forms.DataGridView dataGridbook;
        private System.Windows.Forms.Button butrequest;
        private System.Windows.Forms.Button butrefreshinfo;
        private System.Windows.Forms.DataGridView dataGridborrow;
        private System.Windows.Forms.Label labelborrow;
        private System.Windows.Forms.Label labelrequest;
        private System.Windows.Forms.DataGridView dataGridrequest;
        private System.Windows.Forms.Button butremovere;
        private System.Windows.Forms.Button butrefreshhi;
        private System.Windows.Forms.DataGridView dataGridhistory;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.GroupBox groupsearch;
        private System.Windows.Forms.RadioButton radiotype;
        private System.Windows.Forms.RadioButton radiobookname;
        private System.Windows.Forms.RadioButton radiocodebook;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.RadioButton radioauthor;
        private System.Windows.Forms.Panel panelsearchre;
        private System.Windows.Forms.GroupBox groupsearchre;
        private System.Windows.Forms.RadioButton radiocodebookre;
        private System.Windows.Forms.Button butsearchre;
        private System.Windows.Forms.TextBox textsearchre;
        private System.Windows.Forms.Label labelsearchre;
        private System.Windows.Forms.RadioButton radiotypere;
        private System.Windows.Forms.RadioButton radionamebookre;
        private System.Windows.Forms.Panel panelsearchbo;
        private System.Windows.Forms.GroupBox groupsearchbo;
        private System.Windows.Forms.RadioButton radiodayborrow;
        private System.Windows.Forms.RadioButton radiobooknamebo;
        private System.Windows.Forms.RadioButton radiocodebookbo;
        private System.Windows.Forms.Button butsearchbo;
        private System.Windows.Forms.TextBox textsearchbo;
        private System.Windows.Forms.Label labelsearchbo;
        private System.Windows.Forms.Panel panelsearchhis;
        private System.Windows.Forms.Button butsearchhi;
        private System.Windows.Forms.TextBox textsearchhi;
        private System.Windows.Forms.Label labelsearchhis;
        private System.Windows.Forms.GroupBox groupsearchhis;
        private System.Windows.Forms.RadioButton radiodayborrowhi;
        private System.Windows.Forms.RadioButton radiobooknamehi;
        private System.Windows.Forms.RadioButton radiobookcodehi;
    }
}