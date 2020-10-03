namespace libraryvdatabase
{
    partial class Addandeditaccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxrole = new System.Windows.Forms.GroupBox();
            this.checkre = new System.Windows.Forms.CheckBox();
            this.checkli = new System.Windows.Forms.CheckBox();
            this.checkma = new System.Windows.Forms.CheckBox();
            this.groupBoxstatus = new System.Windows.Forms.GroupBox();
            this.radioina = new System.Windows.Forms.RadioButton();
            this.radioact = new System.Windows.Forms.RadioButton();
            this.textaccname = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textusercode = new System.Windows.Forms.TextBox();
            this.butok = new System.Windows.Forms.Button();
            this.butcancel = new System.Windows.Forms.Button();
            this.groupBoxrole.SuspendLayout();
            this.groupBoxstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Code";
            // 
            // groupBoxrole
            // 
            this.groupBoxrole.Controls.Add(this.checkre);
            this.groupBoxrole.Controls.Add(this.checkli);
            this.groupBoxrole.Controls.Add(this.checkma);
            this.groupBoxrole.Location = new System.Drawing.Point(38, 164);
            this.groupBoxrole.Name = "groupBoxrole";
            this.groupBoxrole.Size = new System.Drawing.Size(138, 114);
            this.groupBoxrole.TabIndex = 4;
            this.groupBoxrole.TabStop = false;
            this.groupBoxrole.Text = "Role";
            // 
            // checkre
            // 
            this.checkre.AutoSize = true;
            this.checkre.Location = new System.Drawing.Point(21, 80);
            this.checkre.Name = "checkre";
            this.checkre.Size = new System.Drawing.Size(61, 17);
            this.checkre.TabIndex = 6;
            this.checkre.Text = "Reader";
            this.checkre.UseVisualStyleBackColor = true;
            // 
            // checkli
            // 
            this.checkli.AutoSize = true;
            this.checkli.Location = new System.Drawing.Point(21, 54);
            this.checkli.Name = "checkli";
            this.checkli.Size = new System.Drawing.Size(66, 17);
            this.checkli.TabIndex = 5;
            this.checkli.Text = "Librarian";
            this.checkli.UseVisualStyleBackColor = true;
            // 
            // checkma
            // 
            this.checkma.AutoSize = true;
            this.checkma.Location = new System.Drawing.Point(21, 28);
            this.checkma.Name = "checkma";
            this.checkma.Size = new System.Drawing.Size(68, 17);
            this.checkma.TabIndex = 4;
            this.checkma.Text = "Manager";
            this.checkma.UseVisualStyleBackColor = true;
            // 
            // groupBoxstatus
            // 
            this.groupBoxstatus.Controls.Add(this.radioina);
            this.groupBoxstatus.Controls.Add(this.radioact);
            this.groupBoxstatus.Location = new System.Drawing.Point(229, 164);
            this.groupBoxstatus.Name = "groupBoxstatus";
            this.groupBoxstatus.Size = new System.Drawing.Size(117, 97);
            this.groupBoxstatus.TabIndex = 7;
            this.groupBoxstatus.TabStop = false;
            this.groupBoxstatus.Text = "Status";
            // 
            // radioina
            // 
            this.radioina.AutoSize = true;
            this.radioina.Location = new System.Drawing.Point(13, 54);
            this.radioina.Name = "radioina";
            this.radioina.Size = new System.Drawing.Size(63, 17);
            this.radioina.TabIndex = 8;
            this.radioina.TabStop = true;
            this.radioina.Text = "Inactive";
            this.radioina.UseVisualStyleBackColor = true;
            // 
            // radioact
            // 
            this.radioact.AutoSize = true;
            this.radioact.Location = new System.Drawing.Point(13, 22);
            this.radioact.Name = "radioact";
            this.radioact.Size = new System.Drawing.Size(55, 17);
            this.radioact.TabIndex = 7;
            this.radioact.TabStop = true;
            this.radioact.Text = "Active";
            this.radioact.UseVisualStyleBackColor = true;
            // 
            // textaccname
            // 
            this.textaccname.Location = new System.Drawing.Point(201, 52);
            this.textaccname.Name = "textaccname";
            this.textaccname.Size = new System.Drawing.Size(145, 20);
            this.textaccname.TabIndex = 1;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(201, 83);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(145, 20);
            this.textpass.TabIndex = 2;
            this.textpass.UseSystemPasswordChar = true;
            // 
            // textusercode
            // 
            this.textusercode.Location = new System.Drawing.Point(201, 111);
            this.textusercode.Name = "textusercode";
            this.textusercode.Size = new System.Drawing.Size(145, 20);
            this.textusercode.TabIndex = 3;
            // 
            // butok
            // 
            this.butok.Location = new System.Drawing.Point(197, 292);
            this.butok.Name = "butok";
            this.butok.Size = new System.Drawing.Size(89, 32);
            this.butok.TabIndex = 9;
            this.butok.Text = "OK";
            this.butok.UseVisualStyleBackColor = true;
            this.butok.Click += new System.EventHandler(this.butok_Click);
            // 
            // butcancel
            // 
            this.butcancel.Location = new System.Drawing.Point(320, 293);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(89, 32);
            this.butcancel.TabIndex = 10;
            this.butcancel.Text = "Cancel";
            this.butcancel.UseVisualStyleBackColor = true;
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // Addandeditaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 343);
            this.Controls.Add(this.butcancel);
            this.Controls.Add(this.butok);
            this.Controls.Add(this.textusercode);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textaccname);
            this.Controls.Add(this.groupBoxstatus);
            this.Controls.Add(this.groupBoxrole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addandeditaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Account";
            this.groupBoxrole.ResumeLayout(false);
            this.groupBoxrole.PerformLayout();
            this.groupBoxstatus.ResumeLayout(false);
            this.groupBoxstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxrole;
        private System.Windows.Forms.CheckBox checkre;
        private System.Windows.Forms.CheckBox checkli;
        private System.Windows.Forms.CheckBox checkma;
        private System.Windows.Forms.GroupBox groupBoxstatus;
        private System.Windows.Forms.RadioButton radioina;
        private System.Windows.Forms.RadioButton radioact;
        private System.Windows.Forms.TextBox textaccname;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textusercode;
        private System.Windows.Forms.Button butok;
        private System.Windows.Forms.Button butcancel;
    }
}