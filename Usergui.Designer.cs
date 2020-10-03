namespace libraryvdatabase
{
    partial class Usergui
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
            this.panellistuser = new System.Windows.Forms.Panel();
            this.butedit = new System.Windows.Forms.Button();
            this.butremove = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.labellistuser = new System.Windows.Forms.Label();
            this.butrefresh = new System.Windows.Forms.Button();
            this.listuser = new System.Windows.Forms.ListBox();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.textnumacc = new System.Windows.Forms.TextBox();
            this.textdayofbirth = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textuserjob = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textusercode = new System.Windows.Forms.TextBox();
            this.labelnumacc = new System.Windows.Forms.Label();
            this.labeldayofbirth = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeljob = new System.Windows.Forms.Label();
            this.labelnameuser = new System.Windows.Forms.Label();
            this.labelcodeuser = new System.Windows.Forms.Label();
            this.labelinfo = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.butlogout = new System.Windows.Forms.Button();
            this.butaccount = new System.Windows.Forms.Button();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.butsearch = new System.Windows.Forms.Button();
            this.labelsearch = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.groupBoxsearch = new System.Windows.Forms.GroupBox();
            this.radioemail = new System.Windows.Forms.RadioButton();
            this.radiojob = new System.Windows.Forms.RadioButton();
            this.radionameuser = new System.Windows.Forms.RadioButton();
            this.radiocodeuser = new System.Windows.Forms.RadioButton();
            this.butchangepass = new System.Windows.Forms.Button();
            this.panellistuser.SuspendLayout();
            this.panelinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panelsearch.SuspendLayout();
            this.groupBoxsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellistuser
            // 
            this.panellistuser.Controls.Add(this.butedit);
            this.panellistuser.Controls.Add(this.butremove);
            this.panellistuser.Controls.Add(this.butadd);
            this.panellistuser.Controls.Add(this.labellistuser);
            this.panellistuser.Controls.Add(this.butrefresh);
            this.panellistuser.Controls.Add(this.listuser);
            this.panellistuser.Location = new System.Drawing.Point(33, 58);
            this.panellistuser.Name = "panellistuser";
            this.panellistuser.Size = new System.Drawing.Size(300, 287);
            this.panellistuser.TabIndex = 0;
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(12, 250);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(71, 29);
            this.butedit.TabIndex = 5;
            this.butedit.Text = "Edit";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.butedit_Click);
            // 
            // butremove
            // 
            this.butremove.Location = new System.Drawing.Point(116, 250);
            this.butremove.Name = "butremove";
            this.butremove.Size = new System.Drawing.Size(71, 29);
            this.butremove.TabIndex = 4;
            this.butremove.Text = "Remove";
            this.butremove.UseVisualStyleBackColor = true;
            this.butremove.Click += new System.EventHandler(this.butremove_Click);
            // 
            // butadd
            // 
            this.butadd.Location = new System.Drawing.Point(218, 250);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(71, 29);
            this.butadd.TabIndex = 3;
            this.butadd.Text = "Add";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // labellistuser
            // 
            this.labellistuser.AutoSize = true;
            this.labellistuser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellistuser.ForeColor = System.Drawing.SystemColors.Control;
            this.labellistuser.Location = new System.Drawing.Point(95, 10);
            this.labellistuser.Name = "labellistuser";
            this.labellistuser.Size = new System.Drawing.Size(92, 22);
            this.labellistuser.TabIndex = 2;
            this.labellistuser.Text = "List Users";
            // 
            // butrefresh
            // 
            this.butrefresh.Location = new System.Drawing.Point(218, 7);
            this.butrefresh.Name = "butrefresh";
            this.butrefresh.Size = new System.Drawing.Size(71, 29);
            this.butrefresh.TabIndex = 1;
            this.butrefresh.Text = "Refresh";
            this.butrefresh.UseVisualStyleBackColor = true;
            this.butrefresh.Click += new System.EventHandler(this.butrefresh_Click);
            // 
            // listuser
            // 
            this.listuser.FormattingEnabled = true;
            this.listuser.Location = new System.Drawing.Point(47, 44);
            this.listuser.Name = "listuser";
            this.listuser.Size = new System.Drawing.Size(200, 199);
            this.listuser.TabIndex = 0;
            this.listuser.SelectedIndexChanged += new System.EventHandler(this.listuser_SelectedIndexChanged);
            // 
            // panelinfo
            // 
            this.panelinfo.Controls.Add(this.textnumacc);
            this.panelinfo.Controls.Add(this.textdayofbirth);
            this.panelinfo.Controls.Add(this.textemail);
            this.panelinfo.Controls.Add(this.textuserjob);
            this.panelinfo.Controls.Add(this.textusername);
            this.panelinfo.Controls.Add(this.textusercode);
            this.panelinfo.Controls.Add(this.labelnumacc);
            this.panelinfo.Controls.Add(this.labeldayofbirth);
            this.panelinfo.Controls.Add(this.labelemail);
            this.panelinfo.Controls.Add(this.labeljob);
            this.panelinfo.Controls.Add(this.labelnameuser);
            this.panelinfo.Controls.Add(this.labelcodeuser);
            this.panelinfo.Controls.Add(this.labelinfo);
            this.panelinfo.Location = new System.Drawing.Point(371, 58);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(298, 287);
            this.panelinfo.TabIndex = 0;
            // 
            // textnumacc
            // 
            this.textnumacc.Location = new System.Drawing.Point(146, 196);
            this.textnumacc.Name = "textnumacc";
            this.textnumacc.ReadOnly = true;
            this.textnumacc.Size = new System.Drawing.Size(132, 20);
            this.textnumacc.TabIndex = 2;
            // 
            // textdayofbirth
            // 
            this.textdayofbirth.Location = new System.Drawing.Point(146, 168);
            this.textdayofbirth.Name = "textdayofbirth";
            this.textdayofbirth.ReadOnly = true;
            this.textdayofbirth.Size = new System.Drawing.Size(132, 20);
            this.textdayofbirth.TabIndex = 2;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(146, 135);
            this.textemail.Name = "textemail";
            this.textemail.ReadOnly = true;
            this.textemail.Size = new System.Drawing.Size(132, 20);
            this.textemail.TabIndex = 2;
            // 
            // textuserjob
            // 
            this.textuserjob.Location = new System.Drawing.Point(146, 103);
            this.textuserjob.Name = "textuserjob";
            this.textuserjob.ReadOnly = true;
            this.textuserjob.Size = new System.Drawing.Size(132, 20);
            this.textuserjob.TabIndex = 2;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(146, 71);
            this.textusername.Name = "textusername";
            this.textusername.ReadOnly = true;
            this.textusername.Size = new System.Drawing.Size(132, 20);
            this.textusername.TabIndex = 2;
            // 
            // textusercode
            // 
            this.textusercode.Location = new System.Drawing.Point(146, 40);
            this.textusercode.Name = "textusercode";
            this.textusercode.ReadOnly = true;
            this.textusercode.Size = new System.Drawing.Size(132, 20);
            this.textusercode.TabIndex = 2;
            // 
            // labelnumacc
            // 
            this.labelnumacc.AutoSize = true;
            this.labelnumacc.BackColor = System.Drawing.Color.Transparent;
            this.labelnumacc.ForeColor = System.Drawing.SystemColors.Control;
            this.labelnumacc.Location = new System.Drawing.Point(22, 201);
            this.labelnumacc.Name = "labelnumacc";
            this.labelnumacc.Size = new System.Drawing.Size(104, 13);
            this.labelnumacc.TabIndex = 1;
            this.labelnumacc.Text = "Number of Accounts";
            // 
            // labeldayofbirth
            // 
            this.labeldayofbirth.AutoSize = true;
            this.labeldayofbirth.BackColor = System.Drawing.Color.Transparent;
            this.labeldayofbirth.ForeColor = System.Drawing.SystemColors.Control;
            this.labeldayofbirth.Location = new System.Drawing.Point(22, 172);
            this.labeldayofbirth.Name = "labeldayofbirth";
            this.labeldayofbirth.Size = new System.Drawing.Size(62, 13);
            this.labeldayofbirth.TabIndex = 1;
            this.labeldayofbirth.Text = "Day of Birth";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.Color.Transparent;
            this.labelemail.ForeColor = System.Drawing.SystemColors.Control;
            this.labelemail.Location = new System.Drawing.Point(22, 140);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(32, 13);
            this.labelemail.TabIndex = 1;
            this.labelemail.Text = "Email";
            // 
            // labeljob
            // 
            this.labeljob.AutoSize = true;
            this.labeljob.BackColor = System.Drawing.Color.Transparent;
            this.labeljob.ForeColor = System.Drawing.SystemColors.Control;
            this.labeljob.Location = new System.Drawing.Point(22, 107);
            this.labeljob.Name = "labeljob";
            this.labeljob.Size = new System.Drawing.Size(24, 13);
            this.labeljob.TabIndex = 1;
            this.labeljob.Text = "Job";
            // 
            // labelnameuser
            // 
            this.labelnameuser.AutoSize = true;
            this.labelnameuser.BackColor = System.Drawing.Color.Transparent;
            this.labelnameuser.ForeColor = System.Drawing.SystemColors.Control;
            this.labelnameuser.Location = new System.Drawing.Point(22, 77);
            this.labelnameuser.Name = "labelnameuser";
            this.labelnameuser.Size = new System.Drawing.Size(60, 13);
            this.labelnameuser.TabIndex = 1;
            this.labelnameuser.Text = "User Name";
            // 
            // labelcodeuser
            // 
            this.labelcodeuser.AutoSize = true;
            this.labelcodeuser.BackColor = System.Drawing.Color.Transparent;
            this.labelcodeuser.ForeColor = System.Drawing.SystemColors.Control;
            this.labelcodeuser.Location = new System.Drawing.Point(22, 45);
            this.labelcodeuser.Name = "labelcodeuser";
            this.labelcodeuser.Size = new System.Drawing.Size(57, 13);
            this.labelcodeuser.TabIndex = 1;
            this.labelcodeuser.Text = "User Code";
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelinfo.Location = new System.Drawing.Point(103, 9);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(99, 22);
            this.labelinfo.TabIndex = 0;
            this.labelinfo.Text = "Infomation";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(81, 383);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(523, 87);
            this.dataGrid.TabIndex = 1;
            // 
            // butlogout
            // 
            this.butlogout.Location = new System.Drawing.Point(634, 383);
            this.butlogout.Name = "butlogout";
            this.butlogout.Size = new System.Drawing.Size(87, 41);
            this.butlogout.TabIndex = 2;
            this.butlogout.Text = "Logout";
            this.butlogout.UseVisualStyleBackColor = true;
            this.butlogout.Click += new System.EventHandler(this.butlogout_Click);
            // 
            // butaccount
            // 
            this.butaccount.Location = new System.Drawing.Point(635, 433);
            this.butaccount.Name = "butaccount";
            this.butaccount.Size = new System.Drawing.Size(85, 36);
            this.butaccount.TabIndex = 3;
            this.butaccount.Text = "Account";
            this.butaccount.UseVisualStyleBackColor = true;
            this.butaccount.Click += new System.EventHandler(this.butaccount_Click);
            // 
            // panelsearch
            // 
            this.panelsearch.Controls.Add(this.butsearch);
            this.panelsearch.Controls.Add(this.labelsearch);
            this.panelsearch.Controls.Add(this.textsearch);
            this.panelsearch.Controls.Add(this.groupBoxsearch);
            this.panelsearch.Location = new System.Drawing.Point(717, 58);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(248, 243);
            this.panelsearch.TabIndex = 4;
            // 
            // butsearch
            // 
            this.butsearch.Location = new System.Drawing.Point(157, 202);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(71, 29);
            this.butsearch.TabIndex = 3;
            this.butsearch.Text = "Search";
            this.butsearch.UseVisualStyleBackColor = true;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelsearch.Location = new System.Drawing.Point(5, 179);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(57, 13);
            this.labelsearch.TabIndex = 2;
            this.labelsearch.Text = "Type Here";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(73, 175);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(154, 20);
            this.textsearch.TabIndex = 1;
            // 
            // groupBoxsearch
            // 
            this.groupBoxsearch.Controls.Add(this.radioemail);
            this.groupBoxsearch.Controls.Add(this.radiojob);
            this.groupBoxsearch.Controls.Add(this.radionameuser);
            this.groupBoxsearch.Controls.Add(this.radiocodeuser);
            this.groupBoxsearch.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxsearch.Location = new System.Drawing.Point(25, 16);
            this.groupBoxsearch.Name = "groupBoxsearch";
            this.groupBoxsearch.Size = new System.Drawing.Size(203, 148);
            this.groupBoxsearch.TabIndex = 0;
            this.groupBoxsearch.TabStop = false;
            this.groupBoxsearch.Text = "Search User";
            // 
            // radioemail
            // 
            this.radioemail.AutoSize = true;
            this.radioemail.ForeColor = System.Drawing.SystemColors.Control;
            this.radioemail.Location = new System.Drawing.Point(21, 110);
            this.radioemail.Name = "radioemail";
            this.radioemail.Size = new System.Drawing.Size(65, 17);
            this.radioemail.TabIndex = 0;
            this.radioemail.TabStop = true;
            this.radioemail.Text = "By Email";
            this.radioemail.UseVisualStyleBackColor = true;
            // 
            // radiojob
            // 
            this.radiojob.AutoSize = true;
            this.radiojob.ForeColor = System.Drawing.SystemColors.Control;
            this.radiojob.Location = new System.Drawing.Point(21, 83);
            this.radiojob.Name = "radiojob";
            this.radiojob.Size = new System.Drawing.Size(57, 17);
            this.radiojob.TabIndex = 0;
            this.radiojob.TabStop = true;
            this.radiojob.Text = "By Job";
            this.radiojob.UseVisualStyleBackColor = true;
            // 
            // radionameuser
            // 
            this.radionameuser.AutoSize = true;
            this.radionameuser.ForeColor = System.Drawing.SystemColors.Control;
            this.radionameuser.Location = new System.Drawing.Point(21, 57);
            this.radionameuser.Name = "radionameuser";
            this.radionameuser.Size = new System.Drawing.Size(68, 17);
            this.radionameuser.TabIndex = 0;
            this.radionameuser.TabStop = true;
            this.radionameuser.Text = "By Name";
            this.radionameuser.UseVisualStyleBackColor = true;
            // 
            // radiocodeuser
            // 
            this.radiocodeuser.AutoSize = true;
            this.radiocodeuser.ForeColor = System.Drawing.SystemColors.Control;
            this.radiocodeuser.Location = new System.Drawing.Point(21, 30);
            this.radiocodeuser.Name = "radiocodeuser";
            this.radiocodeuser.Size = new System.Drawing.Size(65, 17);
            this.radiocodeuser.TabIndex = 0;
            this.radiocodeuser.TabStop = true;
            this.radiocodeuser.Text = "By Code";
            this.radiocodeuser.UseVisualStyleBackColor = true;
            // 
            // butchangepass
            // 
            this.butchangepass.Location = new System.Drawing.Point(766, 383);
            this.butchangepass.Name = "butchangepass";
            this.butchangepass.Size = new System.Drawing.Size(128, 41);
            this.butchangepass.TabIndex = 5;
            this.butchangepass.Text = "Change Password";
            this.butchangepass.UseVisualStyleBackColor = true;
            this.butchangepass.Click += new System.EventHandler(this.butchangepass_Click);
            // 
            // Usergui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryvdatabase.Properties.Resources.hinhnen8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 497);
            this.Controls.Add(this.butchangepass);
            this.Controls.Add(this.panelsearch);
            this.Controls.Add(this.butaccount);
            this.Controls.Add(this.butlogout);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panelinfo);
            this.Controls.Add(this.panellistuser);
            this.Name = "Usergui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Usergui_FormClosing);
           
            this.panellistuser.ResumeLayout(false);
            this.panellistuser.PerformLayout();
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            this.groupBoxsearch.ResumeLayout(false);
            this.groupBoxsearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellistuser;
        private System.Windows.Forms.Button butrefresh;
        private System.Windows.Forms.ListBox listuser;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Label labeldayofbirth;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeljob;
        private System.Windows.Forms.Label labelnameuser;
        private System.Windows.Forms.Label labelcodeuser;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label labelnumacc;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textusercode;
        private System.Windows.Forms.TextBox textnumacc;
        private System.Windows.Forms.TextBox textdayofbirth;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textuserjob;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label labellistuser;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butremove;
        private System.Windows.Forms.Button butedit;
        private System.Windows.Forms.Button butlogout;
        private System.Windows.Forms.Button butaccount;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.GroupBox groupBoxsearch;
        private System.Windows.Forms.RadioButton radioemail;
        private System.Windows.Forms.RadioButton radiojob;
        private System.Windows.Forms.RadioButton radionameuser;
        private System.Windows.Forms.RadioButton radiocodeuser;
        private System.Windows.Forms.Button butchangepass;
    }
}

