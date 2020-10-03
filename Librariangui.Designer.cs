namespace libraryvdatabase
{
    partial class Librariangui
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
            this.butlogout = new System.Windows.Forms.Button();
            this.butchangepass = new System.Windows.Forms.Button();
            this.transparent1 = new thuform.transparent();
            this.tabbook = new System.Windows.Forms.TabPage();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.butsearch = new System.Windows.Forms.Button();
            this.labelsearch = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.groupsearch = new System.Windows.Forms.GroupBox();
            this.radiotype = new System.Windows.Forms.RadioButton();
            this.radioauthor = new System.Windows.Forms.RadioButton();
            this.radiobookname = new System.Windows.Forms.RadioButton();
            this.radiocodebook = new System.Windows.Forms.RadioButton();
            this.butedit = new System.Windows.Forms.Button();
            this.butremove = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butrefresh = new System.Windows.Forms.Button();
            this.dataGridbook = new System.Windows.Forms.DataGridView();
            this.tabrequest = new System.Windows.Forms.TabPage();
            this.panelsearchre = new System.Windows.Forms.Panel();
            this.groupsearchre = new System.Windows.Forms.GroupBox();
            this.butsearchre = new System.Windows.Forms.Button();
            this.textsearchre = new System.Windows.Forms.TextBox();
            this.labelsearchre = new System.Windows.Forms.Label();
            this.radiobooknamere = new System.Windows.Forms.RadioButton();
            this.radiocodebookre = new System.Windows.Forms.RadioButton();
            this.radioaccnamere = new System.Windows.Forms.RadioButton();
            this.butdeny = new System.Windows.Forms.Button();
            this.butaccept = new System.Windows.Forms.Button();
            this.butrefreshre = new System.Windows.Forms.Button();
            this.dataGridrequest = new System.Windows.Forms.DataGridView();
            this.tabborrow = new System.Windows.Forms.TabPage();
            this.panelsearchbo = new System.Windows.Forms.Panel();
            this.groupsearchbo = new System.Windows.Forms.GroupBox();
            this.butsearchbo = new System.Windows.Forms.Button();
            this.textsearchbo = new System.Windows.Forms.TextBox();
            this.labelsearchbo = new System.Windows.Forms.Label();
            this.radiobooknamebo = new System.Windows.Forms.RadioButton();
            this.radiobookcodebo = new System.Windows.Forms.RadioButton();
            this.radioaccnamebo = new System.Windows.Forms.RadioButton();
            this.butreturn = new System.Windows.Forms.Button();
            this.butrefreshbo = new System.Windows.Forms.Button();
            this.dataGridborrow = new System.Windows.Forms.DataGridView();
            this.transparent1.SuspendLayout();
            this.tabbook.SuspendLayout();
            this.panelsearch.SuspendLayout();
            this.groupsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbook)).BeginInit();
            this.tabrequest.SuspendLayout();
            this.panelsearchre.SuspendLayout();
            this.groupsearchre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridrequest)).BeginInit();
            this.tabborrow.SuspendLayout();
            this.panelsearchbo.SuspendLayout();
            this.groupsearchbo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridborrow)).BeginInit();
            this.SuspendLayout();
            // 
            // butlogout
            // 
            this.butlogout.Location = new System.Drawing.Point(950, 447);
            this.butlogout.Name = "butlogout";
            this.butlogout.Size = new System.Drawing.Size(83, 36);
            this.butlogout.TabIndex = 1;
            this.butlogout.Text = "Logout";
            this.butlogout.UseVisualStyleBackColor = true;
            this.butlogout.Click += new System.EventHandler(this.butlogout_Click);
            // 
            // butchangepass
            // 
            this.butchangepass.Location = new System.Drawing.Point(804, 447);
            this.butchangepass.Name = "butchangepass";
            this.butchangepass.Size = new System.Drawing.Size(115, 36);
            this.butchangepass.TabIndex = 2;
            this.butchangepass.Text = "Change Password";
            this.butchangepass.UseVisualStyleBackColor = true;
            this.butchangepass.Click += new System.EventHandler(this.butchangepass_Click);
            // 
            // transparent1
            // 
            this.transparent1.Controls.Add(this.tabbook);
            this.transparent1.Controls.Add(this.tabrequest);
            this.transparent1.Controls.Add(this.tabborrow);
            this.transparent1.Location = new System.Drawing.Point(32, 31);
            this.transparent1.Name = "transparent1";
            this.transparent1.SelectedIndex = 0;
            this.transparent1.Size = new System.Drawing.Size(1005, 410);
            this.transparent1.TabIndex = 0;
            // 
            // tabbook
            // 
            this.tabbook.Controls.Add(this.panelsearch);
            this.tabbook.Controls.Add(this.butedit);
            this.tabbook.Controls.Add(this.butremove);
            this.tabbook.Controls.Add(this.butadd);
            this.tabbook.Controls.Add(this.butrefresh);
            this.tabbook.Controls.Add(this.dataGridbook);
            this.tabbook.Location = new System.Drawing.Point(4, 22);
            this.tabbook.Name = "tabbook";
            this.tabbook.Padding = new System.Windows.Forms.Padding(3);
            this.tabbook.Size = new System.Drawing.Size(997, 384);
            this.tabbook.TabIndex = 0;
            this.tabbook.Text = "Book";
            this.tabbook.UseVisualStyleBackColor = true;
            // 
            // panelsearch
            // 
            this.panelsearch.Controls.Add(this.butsearch);
            this.panelsearch.Controls.Add(this.labelsearch);
            this.panelsearch.Controls.Add(this.textsearch);
            this.panelsearch.Controls.Add(this.groupsearch);
            this.panelsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelsearch.Location = new System.Drawing.Point(76, 227);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(406, 139);
            this.panelsearch.TabIndex = 2;
            // 
            // butsearch
            // 
            this.butsearch.Location = new System.Drawing.Point(325, 47);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(65, 32);
            this.butsearch.TabIndex = 3;
            this.butsearch.Text = "Search";
            this.butsearch.UseVisualStyleBackColor = true;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.ForeColor = System.Drawing.SystemColors.Control;
            this.labelsearch.Location = new System.Drawing.Point(177, 23);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(57, 13);
            this.labelsearch.TabIndex = 2;
            this.labelsearch.Text = "Type Here";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(240, 19);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(150, 20);
            this.textsearch.TabIndex = 1;
            // 
            // groupsearch
            // 
            this.groupsearch.Controls.Add(this.radiotype);
            this.groupsearch.Controls.Add(this.radioauthor);
            this.groupsearch.Controls.Add(this.radiobookname);
            this.groupsearch.Controls.Add(this.radiocodebook);
            this.groupsearch.ForeColor = System.Drawing.SystemColors.Control;
            this.groupsearch.Location = new System.Drawing.Point(20, 19);
            this.groupsearch.Name = "groupsearch";
            this.groupsearch.Size = new System.Drawing.Size(134, 108);
            this.groupsearch.TabIndex = 0;
            this.groupsearch.TabStop = false;
            this.groupsearch.Text = "Search Book";
            // 
            // radiotype
            // 
            this.radiotype.AutoSize = true;
            this.radiotype.Location = new System.Drawing.Point(17, 85);
            this.radiotype.Name = "radiotype";
            this.radiotype.Size = new System.Drawing.Size(64, 17);
            this.radiotype.TabIndex = 0;
            this.radiotype.TabStop = true;
            this.radiotype.Text = "By Type";
            this.radiotype.UseVisualStyleBackColor = true;
            // 
            // radioauthor
            // 
            this.radioauthor.AutoSize = true;
            this.radioauthor.Location = new System.Drawing.Point(17, 64);
            this.radioauthor.Name = "radioauthor";
            this.radioauthor.Size = new System.Drawing.Size(71, 17);
            this.radioauthor.TabIndex = 0;
            this.radioauthor.TabStop = true;
            this.radioauthor.Text = "By Author";
            this.radioauthor.UseVisualStyleBackColor = true;
            // 
            // radiobookname
            // 
            this.radiobookname.AutoSize = true;
            this.radiobookname.Location = new System.Drawing.Point(17, 43);
            this.radiobookname.Name = "radiobookname";
            this.radiobookname.Size = new System.Drawing.Size(68, 17);
            this.radiobookname.TabIndex = 0;
            this.radiobookname.TabStop = true;
            this.radiobookname.Text = "By Name";
            this.radiobookname.UseVisualStyleBackColor = true;
            // 
            // radiocodebook
            // 
            this.radiocodebook.AutoSize = true;
            this.radiocodebook.Location = new System.Drawing.Point(17, 22);
            this.radiocodebook.Name = "radiocodebook";
            this.radiocodebook.Size = new System.Drawing.Size(65, 17);
            this.radiocodebook.TabIndex = 0;
            this.radiocodebook.TabStop = true;
            this.radiocodebook.Text = "By Code";
            this.radiocodebook.UseVisualStyleBackColor = true;
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(719, 222);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(65, 32);
            this.butedit.TabIndex = 4;
            this.butedit.Text = "Edit";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.butedit_Click);
            // 
            // butremove
            // 
            this.butremove.Location = new System.Drawing.Point(818, 222);
            this.butremove.Name = "butremove";
            this.butremove.Size = new System.Drawing.Size(65, 32);
            this.butremove.TabIndex = 3;
            this.butremove.Text = "Remove";
            this.butremove.UseVisualStyleBackColor = true;
            this.butremove.Click += new System.EventHandler(this.butremove_Click);
            // 
            // butadd
            // 
            this.butadd.Location = new System.Drawing.Point(914, 222);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(65, 32);
            this.butadd.TabIndex = 2;
            this.butadd.Text = "Add";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butrefresh
            // 
            this.butrefresh.Location = new System.Drawing.Point(912, 17);
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
            this.dataGridbook.Location = new System.Drawing.Point(23, 63);
            this.dataGridbook.Name = "dataGridbook";
            this.dataGridbook.ReadOnly = true;
            this.dataGridbook.Size = new System.Drawing.Size(954, 150);
            this.dataGridbook.TabIndex = 0;
            // 
            // tabrequest
            // 
            this.tabrequest.Controls.Add(this.panelsearchre);
            this.tabrequest.Controls.Add(this.butdeny);
            this.tabrequest.Controls.Add(this.butaccept);
            this.tabrequest.Controls.Add(this.butrefreshre);
            this.tabrequest.Controls.Add(this.dataGridrequest);
            this.tabrequest.Location = new System.Drawing.Point(4, 22);
            this.tabrequest.Name = "tabrequest";
            this.tabrequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabrequest.Size = new System.Drawing.Size(997, 384);
            this.tabrequest.TabIndex = 1;
            this.tabrequest.Text = "Request";
            this.tabrequest.UseVisualStyleBackColor = true;
            // 
            // panelsearchre
            // 
            this.panelsearchre.Controls.Add(this.groupsearchre);
            this.panelsearchre.Location = new System.Drawing.Point(120, 223);
            this.panelsearchre.Name = "panelsearchre";
            this.panelsearchre.Size = new System.Drawing.Size(394, 155);
            this.panelsearchre.TabIndex = 4;
            // 
            // groupsearchre
            // 
            this.groupsearchre.Controls.Add(this.butsearchre);
            this.groupsearchre.Controls.Add(this.textsearchre);
            this.groupsearchre.Controls.Add(this.labelsearchre);
            this.groupsearchre.Controls.Add(this.radiobooknamere);
            this.groupsearchre.Controls.Add(this.radiocodebookre);
            this.groupsearchre.Controls.Add(this.radioaccnamere);
            this.groupsearchre.ForeColor = System.Drawing.SystemColors.Control;
            this.groupsearchre.Location = new System.Drawing.Point(19, 16);
            this.groupsearchre.Name = "groupsearchre";
            this.groupsearchre.Size = new System.Drawing.Size(360, 123);
            this.groupsearchre.TabIndex = 0;
            this.groupsearchre.TabStop = false;
            this.groupsearchre.Text = "Search Request";
            // 
            // butsearchre
            // 
            this.butsearchre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsearchre.Location = new System.Drawing.Point(261, 81);
            this.butsearchre.Name = "butsearchre";
            this.butsearchre.Size = new System.Drawing.Size(65, 32);
            this.butsearchre.TabIndex = 3;
            this.butsearchre.Text = "Search";
            this.butsearchre.UseVisualStyleBackColor = true;
            this.butsearchre.Click += new System.EventHandler(this.butsearchre_Click);
            // 
            // textsearchre
            // 
            this.textsearchre.Location = new System.Drawing.Point(87, 88);
            this.textsearchre.Name = "textsearchre";
            this.textsearchre.Size = new System.Drawing.Size(142, 20);
            this.textsearchre.TabIndex = 2;
            // 
            // labelsearchre
            // 
            this.labelsearchre.AutoSize = true;
            this.labelsearchre.Location = new System.Drawing.Point(21, 93);
            this.labelsearchre.Name = "labelsearchre";
            this.labelsearchre.Size = new System.Drawing.Size(60, 13);
            this.labelsearchre.TabIndex = 1;
            this.labelsearchre.Text = "Type Here:";
            // 
            // radiobooknamere
            // 
            this.radiobooknamere.AutoSize = true;
            this.radiobooknamere.Location = new System.Drawing.Point(41, 65);
            this.radiobooknamere.Name = "radiobooknamere";
            this.radiobooknamere.Size = new System.Drawing.Size(96, 17);
            this.radiobooknamere.TabIndex = 0;
            this.radiobooknamere.TabStop = true;
            this.radiobooknamere.Text = "By Book Name";
            this.radiobooknamere.UseVisualStyleBackColor = true;
            // 
            // radiocodebookre
            // 
            this.radiocodebookre.AutoSize = true;
            this.radiocodebookre.Location = new System.Drawing.Point(41, 42);
            this.radiocodebookre.Name = "radiocodebookre";
            this.radiocodebookre.Size = new System.Drawing.Size(93, 17);
            this.radiocodebookre.TabIndex = 0;
            this.radiocodebookre.TabStop = true;
            this.radiocodebookre.Text = "By Book Code";
            this.radiocodebookre.UseVisualStyleBackColor = true;
            // 
            // radioaccnamere
            // 
            this.radioaccnamere.AutoSize = true;
            this.radioaccnamere.Location = new System.Drawing.Point(41, 19);
            this.radioaccnamere.Name = "radioaccnamere";
            this.radioaccnamere.Size = new System.Drawing.Size(111, 17);
            this.radioaccnamere.TabIndex = 0;
            this.radioaccnamere.TabStop = true;
            this.radioaccnamere.Text = "By Account Name";
            this.radioaccnamere.UseVisualStyleBackColor = true;
            // 
            // butdeny
            // 
            this.butdeny.Location = new System.Drawing.Point(914, 202);
            this.butdeny.Name = "butdeny";
            this.butdeny.Size = new System.Drawing.Size(65, 32);
            this.butdeny.TabIndex = 3;
            this.butdeny.Text = "Deny";
            this.butdeny.UseVisualStyleBackColor = true;
            this.butdeny.Click += new System.EventHandler(this.butdeny_Click);
            // 
            // butaccept
            // 
            this.butaccept.Location = new System.Drawing.Point(914, 110);
            this.butaccept.Name = "butaccept";
            this.butaccept.Size = new System.Drawing.Size(65, 32);
            this.butaccept.TabIndex = 2;
            this.butaccept.Text = "Accept";
            this.butaccept.UseVisualStyleBackColor = true;
            this.butaccept.Click += new System.EventHandler(this.butaccept_Click);
            // 
            // butrefreshre
            // 
            this.butrefreshre.Location = new System.Drawing.Point(914, 19);
            this.butrefreshre.Name = "butrefreshre";
            this.butrefreshre.Size = new System.Drawing.Size(65, 32);
            this.butrefreshre.TabIndex = 1;
            this.butrefreshre.Text = "Refresh";
            this.butrefreshre.UseVisualStyleBackColor = true;
            this.butrefreshre.Click += new System.EventHandler(this.butrefreshre_Click);
            // 
            // dataGridrequest
            // 
            this.dataGridrequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridrequest.Location = new System.Drawing.Point(63, 52);
            this.dataGridrequest.Name = "dataGridrequest";
            this.dataGridrequest.ReadOnly = true;
            this.dataGridrequest.Size = new System.Drawing.Size(805, 165);
            this.dataGridrequest.TabIndex = 0;
            // 
            // tabborrow
            // 
            this.tabborrow.Controls.Add(this.panelsearchbo);
            this.tabborrow.Controls.Add(this.butreturn);
            this.tabborrow.Controls.Add(this.butrefreshbo);
            this.tabborrow.Controls.Add(this.dataGridborrow);
            this.tabborrow.Location = new System.Drawing.Point(4, 22);
            this.tabborrow.Name = "tabborrow";
            this.tabborrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabborrow.Size = new System.Drawing.Size(997, 384);
            this.tabborrow.TabIndex = 2;
            this.tabborrow.Text = "Borrow";
            this.tabborrow.UseVisualStyleBackColor = true;
            // 
            // panelsearchbo
            // 
            this.panelsearchbo.Controls.Add(this.groupsearchbo);
            this.panelsearchbo.Location = new System.Drawing.Point(141, 229);
            this.panelsearchbo.Name = "panelsearchbo";
            this.panelsearchbo.Size = new System.Drawing.Size(354, 149);
            this.panelsearchbo.TabIndex = 3;
            // 
            // groupsearchbo
            // 
            this.groupsearchbo.Controls.Add(this.butsearchbo);
            this.groupsearchbo.Controls.Add(this.textsearchbo);
            this.groupsearchbo.Controls.Add(this.labelsearchbo);
            this.groupsearchbo.Controls.Add(this.radiobooknamebo);
            this.groupsearchbo.Controls.Add(this.radiobookcodebo);
            this.groupsearchbo.Controls.Add(this.radioaccnamebo);
            this.groupsearchbo.ForeColor = System.Drawing.SystemColors.Control;
            this.groupsearchbo.Location = new System.Drawing.Point(21, 14);
            this.groupsearchbo.Name = "groupsearchbo";
            this.groupsearchbo.Size = new System.Drawing.Size(308, 119);
            this.groupsearchbo.TabIndex = 0;
            this.groupsearchbo.TabStop = false;
            this.groupsearchbo.Text = "Search Borrow";
            // 
            // butsearchbo
            // 
            this.butsearchbo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsearchbo.Location = new System.Drawing.Point(235, 81);
            this.butsearchbo.Name = "butsearchbo";
            this.butsearchbo.Size = new System.Drawing.Size(65, 32);
            this.butsearchbo.TabIndex = 3;
            this.butsearchbo.Text = "Search";
            this.butsearchbo.UseVisualStyleBackColor = true;
            this.butsearchbo.Click += new System.EventHandler(this.butsearchbo_Click);
            // 
            // textsearchbo
            // 
            this.textsearchbo.Location = new System.Drawing.Point(84, 88);
            this.textsearchbo.Name = "textsearchbo";
            this.textsearchbo.Size = new System.Drawing.Size(143, 20);
            this.textsearchbo.TabIndex = 2;
            // 
            // labelsearchbo
            // 
            this.labelsearchbo.AutoSize = true;
            this.labelsearchbo.Location = new System.Drawing.Point(10, 92);
            this.labelsearchbo.Name = "labelsearchbo";
            this.labelsearchbo.Size = new System.Drawing.Size(60, 13);
            this.labelsearchbo.TabIndex = 1;
            this.labelsearchbo.Text = "Type Here:";
            // 
            // radiobooknamebo
            // 
            this.radiobooknamebo.AutoSize = true;
            this.radiobooknamebo.Location = new System.Drawing.Point(22, 65);
            this.radiobooknamebo.Name = "radiobooknamebo";
            this.radiobooknamebo.Size = new System.Drawing.Size(96, 17);
            this.radiobooknamebo.TabIndex = 0;
            this.radiobooknamebo.TabStop = true;
            this.radiobooknamebo.Text = "By Book Name";
            this.radiobooknamebo.UseVisualStyleBackColor = true;
            // 
            // radiobookcodebo
            // 
            this.radiobookcodebo.AutoSize = true;
            this.radiobookcodebo.Location = new System.Drawing.Point(22, 42);
            this.radiobookcodebo.Name = "radiobookcodebo";
            this.radiobookcodebo.Size = new System.Drawing.Size(93, 17);
            this.radiobookcodebo.TabIndex = 0;
            this.radiobookcodebo.TabStop = true;
            this.radiobookcodebo.Text = "By Book Code";
            this.radiobookcodebo.UseVisualStyleBackColor = true;
            // 
            // radioaccnamebo
            // 
            this.radioaccnamebo.AutoSize = true;
            this.radioaccnamebo.Location = new System.Drawing.Point(22, 19);
            this.radioaccnamebo.Name = "radioaccnamebo";
            this.radioaccnamebo.Size = new System.Drawing.Size(111, 17);
            this.radioaccnamebo.TabIndex = 0;
            this.radioaccnamebo.TabStop = true;
            this.radioaccnamebo.Text = "By Account Name";
            this.radioaccnamebo.UseVisualStyleBackColor = true;
            // 
            // butreturn
            // 
            this.butreturn.Location = new System.Drawing.Point(914, 229);
            this.butreturn.Name = "butreturn";
            this.butreturn.Size = new System.Drawing.Size(65, 32);
            this.butreturn.TabIndex = 2;
            this.butreturn.Text = "Return";
            this.butreturn.UseVisualStyleBackColor = true;
            this.butreturn.Click += new System.EventHandler(this.butreturn_Click);
            // 
            // butrefreshbo
            // 
            this.butrefreshbo.Location = new System.Drawing.Point(908, 17);
            this.butrefreshbo.Name = "butrefreshbo";
            this.butrefreshbo.Size = new System.Drawing.Size(65, 32);
            this.butrefreshbo.TabIndex = 1;
            this.butrefreshbo.Text = "Refresh";
            this.butrefreshbo.UseVisualStyleBackColor = true;
            this.butrefreshbo.Click += new System.EventHandler(this.butrefreshbo_Click);
            // 
            // dataGridborrow
            // 
            this.dataGridborrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridborrow.Location = new System.Drawing.Point(110, 63);
            this.dataGridborrow.Name = "dataGridborrow";
            this.dataGridborrow.ReadOnly = true;
            this.dataGridborrow.Size = new System.Drawing.Size(773, 157);
            this.dataGridborrow.TabIndex = 0;
            // 
            // Librariangui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryvdatabase.Properties.Resources.hinhnen9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 504);
            this.Controls.Add(this.butchangepass);
            this.Controls.Add(this.butlogout);
            this.Controls.Add(this.transparent1);
            this.Name = "Librariangui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Librariangui_FormClosing);
            this.transparent1.ResumeLayout(false);
            this.tabbook.ResumeLayout(false);
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            this.groupsearch.ResumeLayout(false);
            this.groupsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbook)).EndInit();
            this.tabrequest.ResumeLayout(false);
            this.panelsearchre.ResumeLayout(false);
            this.groupsearchre.ResumeLayout(false);
            this.groupsearchre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridrequest)).EndInit();
            this.tabborrow.ResumeLayout(false);
            this.panelsearchbo.ResumeLayout(false);
            this.groupsearchbo.ResumeLayout(false);
            this.groupsearchbo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridborrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private thuform.transparent transparent1;
        private System.Windows.Forms.TabPage tabbook;
        private System.Windows.Forms.TabPage tabrequest;
        private System.Windows.Forms.Button butrefresh;
        private System.Windows.Forms.DataGridView dataGridbook;
        private System.Windows.Forms.Button butlogout;
        private System.Windows.Forms.Button butedit;
        private System.Windows.Forms.Button butremove;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.GroupBox groupsearch;
        private System.Windows.Forms.RadioButton radiotype;
        private System.Windows.Forms.RadioButton radioauthor;
        private System.Windows.Forms.RadioButton radiobookname;
        private System.Windows.Forms.RadioButton radiocodebook;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button butdeny;
        private System.Windows.Forms.Button butaccept;
        private System.Windows.Forms.Button butrefreshre;
        private System.Windows.Forms.DataGridView dataGridrequest;
        private System.Windows.Forms.Button butchangepass;
        private System.Windows.Forms.TabPage tabborrow;
        private System.Windows.Forms.Button butreturn;
        private System.Windows.Forms.Button butrefreshbo;
        private System.Windows.Forms.DataGridView dataGridborrow;
        private System.Windows.Forms.Panel panelsearchre;
        private System.Windows.Forms.GroupBox groupsearchre;
        private System.Windows.Forms.Button butsearchre;
        private System.Windows.Forms.TextBox textsearchre;
        private System.Windows.Forms.Label labelsearchre;
        private System.Windows.Forms.RadioButton radiobooknamere;
        private System.Windows.Forms.RadioButton radiocodebookre;
        private System.Windows.Forms.RadioButton radioaccnamere;
        private System.Windows.Forms.Panel panelsearchbo;
        private System.Windows.Forms.GroupBox groupsearchbo;
        private System.Windows.Forms.Button butsearchbo;
        private System.Windows.Forms.TextBox textsearchbo;
        private System.Windows.Forms.Label labelsearchbo;
        private System.Windows.Forms.RadioButton radiobooknamebo;
        private System.Windows.Forms.RadioButton radiobookcodebo;
        private System.Windows.Forms.RadioButton radioaccnamebo;
    }
}