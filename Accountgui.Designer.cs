namespace libraryvdatabase
{
    partial class Accountgui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountgui));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butreset = new System.Windows.Forms.Button();
            this.butedit = new System.Windows.Forms.Button();
            this.butremove = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butrefresh = new System.Windows.Forms.Button();
            this.listaccount = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelaccname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textfine = new System.Windows.Forms.TextBox();
            this.textstatus = new System.Windows.Forms.TextBox();
            this.textrole = new System.Windows.Forms.TextBox();
            this.textusercode = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textaccname = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelfine = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.labelrole = new System.Windows.Forms.Label();
            this.labelusercode = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.butexit = new System.Windows.Forms.Button();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.groupBoxsearch = new System.Windows.Forms.GroupBox();
            this.radionameacc = new System.Windows.Forms.RadioButton();
            this.radiocodeuser = new System.Windows.Forms.RadioButton();
            this.labelsearch = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.butsearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelsearch.SuspendLayout();
            this.groupBoxsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butreset);
            this.panel1.Controls.Add(this.butedit);
            this.panel1.Controls.Add(this.butremove);
            this.panel1.Controls.Add(this.butadd);
            this.panel1.Controls.Add(this.butrefresh);
            this.panel1.Controls.Add(this.listaccount);
            this.panel1.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // butreset
            // 
            resources.ApplyResources(this.butreset, "butreset");
            this.butreset.Name = "butreset";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // butedit
            // 
            resources.ApplyResources(this.butedit, "butedit");
            this.butedit.Name = "butedit";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.butedit_Click);
            // 
            // butremove
            // 
            resources.ApplyResources(this.butremove, "butremove");
            this.butremove.Name = "butremove";
            this.butremove.UseVisualStyleBackColor = true;
            this.butremove.Click += new System.EventHandler(this.butremove_Click);
            // 
            // butadd
            // 
            resources.ApplyResources(this.butadd, "butadd");
            this.butadd.Name = "butadd";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butrefresh
            // 
            resources.ApplyResources(this.butrefresh, "butrefresh");
            this.butrefresh.Name = "butrefresh";
            this.butrefresh.UseVisualStyleBackColor = true;
            this.butrefresh.Click += new System.EventHandler(this.butrefresh_Click);
            // 
            // listaccount
            // 
            this.listaccount.FormattingEnabled = true;
            resources.ApplyResources(this.listaccount, "listaccount");
            this.listaccount.Name = "listaccount";
            this.listaccount.SelectedIndexChanged += new System.EventHandler(this.listaccount_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // labelaccname
            // 
            resources.ApplyResources(this.labelaccname, "labelaccname");
            this.labelaccname.ForeColor = System.Drawing.SystemColors.Control;
            this.labelaccname.Name = "labelaccname";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textfine);
            this.panel4.Controls.Add(this.textstatus);
            this.panel4.Controls.Add(this.textrole);
            this.panel4.Controls.Add(this.textusercode);
            this.panel4.Controls.Add(this.textpass);
            this.panel4.Controls.Add(this.textaccname);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.labelfine);
            this.panel4.Controls.Add(this.labelstatus);
            this.panel4.Controls.Add(this.labelrole);
            this.panel4.Controls.Add(this.labelusercode);
            this.panel4.Controls.Add(this.labelpassword);
            this.panel4.Controls.Add(this.labelaccname);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // textfine
            // 
            resources.ApplyResources(this.textfine, "textfine");
            this.textfine.Name = "textfine";
            this.textfine.ReadOnly = true;
            // 
            // textstatus
            // 
            resources.ApplyResources(this.textstatus, "textstatus");
            this.textstatus.Name = "textstatus";
            this.textstatus.ReadOnly = true;
            // 
            // textrole
            // 
            resources.ApplyResources(this.textrole, "textrole");
            this.textrole.Name = "textrole";
            this.textrole.ReadOnly = true;
            // 
            // textusercode
            // 
            resources.ApplyResources(this.textusercode, "textusercode");
            this.textusercode.Name = "textusercode";
            this.textusercode.ReadOnly = true;
            // 
            // textpass
            // 
            resources.ApplyResources(this.textpass, "textpass");
            this.textpass.Name = "textpass";
            this.textpass.ReadOnly = true;
            this.textpass.UseSystemPasswordChar = true;
            // 
            // textaccname
            // 
            resources.ApplyResources(this.textaccname, "textaccname");
            this.textaccname.Name = "textaccname";
            this.textaccname.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Name = "label4";
            // 
            // labelfine
            // 
            resources.ApplyResources(this.labelfine, "labelfine");
            this.labelfine.ForeColor = System.Drawing.SystemColors.Control;
            this.labelfine.Name = "labelfine";
            // 
            // labelstatus
            // 
            resources.ApplyResources(this.labelstatus, "labelstatus");
            this.labelstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelstatus.Name = "labelstatus";
            // 
            // labelrole
            // 
            resources.ApplyResources(this.labelrole, "labelrole");
            this.labelrole.ForeColor = System.Drawing.SystemColors.Control;
            this.labelrole.Name = "labelrole";
            // 
            // labelusercode
            // 
            resources.ApplyResources(this.labelusercode, "labelusercode");
            this.labelusercode.ForeColor = System.Drawing.SystemColors.Control;
            this.labelusercode.Name = "labelusercode";
            // 
            // labelpassword
            // 
            resources.ApplyResources(this.labelpassword, "labelpassword");
            this.labelpassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelpassword.Name = "labelpassword";
            // 
            // butexit
            // 
            resources.ApplyResources(this.butexit, "butexit");
            this.butexit.Name = "butexit";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // panelsearch
            // 
            this.panelsearch.Controls.Add(this.butsearch);
            this.panelsearch.Controls.Add(this.textsearch);
            this.panelsearch.Controls.Add(this.labelsearch);
            this.panelsearch.Controls.Add(this.groupBoxsearch);
            resources.ApplyResources(this.panelsearch, "panelsearch");
            this.panelsearch.Name = "panelsearch";
            // 
            // groupBoxsearch
            // 
            this.groupBoxsearch.Controls.Add(this.radiocodeuser);
            this.groupBoxsearch.Controls.Add(this.radionameacc);
            this.groupBoxsearch.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.groupBoxsearch, "groupBoxsearch");
            this.groupBoxsearch.Name = "groupBoxsearch";
            this.groupBoxsearch.TabStop = false;
            // 
            // radionameacc
            // 
            resources.ApplyResources(this.radionameacc, "radionameacc");
            this.radionameacc.Name = "radionameacc";
            this.radionameacc.TabStop = true;
            this.radionameacc.UseVisualStyleBackColor = true;
            // 
            // radiocodeuser
            // 
            resources.ApplyResources(this.radiocodeuser, "radiocodeuser");
            this.radiocodeuser.Name = "radiocodeuser";
            this.radiocodeuser.TabStop = true;
            this.radiocodeuser.UseVisualStyleBackColor = true;
            // 
            // labelsearch
            // 
            resources.ApplyResources(this.labelsearch, "labelsearch");
            this.labelsearch.ForeColor = System.Drawing.SystemColors.Control;
            this.labelsearch.Name = "labelsearch";
            // 
            // textsearch
            // 
            resources.ApplyResources(this.textsearch, "textsearch");
            this.textsearch.Name = "textsearch";
            // 
            // butsearch
            // 
            resources.ApplyResources(this.butsearch, "butsearch");
            this.butsearch.Name = "butsearch";
            this.butsearch.UseVisualStyleBackColor = true;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // Accountgui
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryvdatabase.Properties.Resources.hinhnen7;
            this.Controls.Add(this.panelsearch);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Accountgui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accountgui_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            this.groupBoxsearch.ResumeLayout(false);
            this.groupBoxsearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listaccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelaccname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.Label labelusercode;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelfine;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Button butrefresh;
        private System.Windows.Forms.TextBox textfine;
        private System.Windows.Forms.TextBox textstatus;
        private System.Windows.Forms.TextBox textrole;
        private System.Windows.Forms.TextBox textusercode;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textaccname;
        private System.Windows.Forms.Button butedit;
        private System.Windows.Forms.Button butremove;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.GroupBox groupBoxsearch;
        private System.Windows.Forms.RadioButton radiocodeuser;
        private System.Windows.Forms.RadioButton radionameacc;
    }
}