namespace libraryvdatabase
{
    partial class Logingui
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
            this.panellogin = new System.Windows.Forms.Panel();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textaccname = new System.Windows.Forms.TextBox();
            this.labelpass = new System.Windows.Forms.Label();
            this.labelaccname = new System.Windows.Forms.Label();
            this.butlogin = new System.Windows.Forms.Button();
            this.butexit = new System.Windows.Forms.Button();
            this.butma = new System.Windows.Forms.Button();
            this.butli = new System.Windows.Forms.Button();
            this.butre = new System.Windows.Forms.Button();
            this.labelregister = new System.Windows.Forms.Label();
            this.butregister = new System.Windows.Forms.Button();
            this.panellogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.Controls.Add(this.textpassword);
            this.panellogin.Controls.Add(this.textaccname);
            this.panellogin.Controls.Add(this.labelpass);
            this.panellogin.Controls.Add(this.labelaccname);
            this.panellogin.Location = new System.Drawing.Point(40, 50);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(258, 113);
            this.panellogin.TabIndex = 0;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(103, 60);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(136, 20);
            this.textpassword.TabIndex = 3;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // textaccname
            // 
            this.textaccname.Location = new System.Drawing.Point(103, 24);
            this.textaccname.Name = "textaccname";
            this.textaccname.Size = new System.Drawing.Size(136, 20);
            this.textaccname.TabIndex = 1;
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.BackColor = System.Drawing.Color.Transparent;
            this.labelpass.ForeColor = System.Drawing.SystemColors.Control;
            this.labelpass.Location = new System.Drawing.Point(11, 63);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(59, 13);
            this.labelpass.TabIndex = 0;
            this.labelpass.Text = "Password: ";
            // 
            // labelaccname
            // 
            this.labelaccname.AutoSize = true;
            this.labelaccname.BackColor = System.Drawing.Color.Transparent;
            this.labelaccname.ForeColor = System.Drawing.SystemColors.Control;
            this.labelaccname.Location = new System.Drawing.Point(11, 27);
            this.labelaccname.Name = "labelaccname";
            this.labelaccname.Size = new System.Drawing.Size(84, 13);
            this.labelaccname.TabIndex = 0;
            this.labelaccname.Text = "Account Name: ";
            // 
            // butlogin
            // 
            this.butlogin.Location = new System.Drawing.Point(375, 50);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(68, 36);
            this.butlogin.TabIndex = 3;
            this.butlogin.Text = "Login";
            this.butlogin.UseVisualStyleBackColor = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butexit
            // 
            this.butexit.Location = new System.Drawing.Point(375, 127);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(68, 36);
            this.butexit.TabIndex = 4;
            this.butexit.Text = "Exit";
            this.butexit.UseVisualStyleBackColor = true;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // butma
            // 
            this.butma.Location = new System.Drawing.Point(37, 203);
            this.butma.Name = "butma";
            this.butma.Size = new System.Drawing.Size(72, 35);
            this.butma.TabIndex = 3;
            this.butma.Text = "Manager";
            this.butma.UseVisualStyleBackColor = true;
            this.butma.Click += new System.EventHandler(this.butma_Click);
            // 
            // butli
            // 
            this.butli.Location = new System.Drawing.Point(133, 203);
            this.butli.Name = "butli";
            this.butli.Size = new System.Drawing.Size(72, 35);
            this.butli.TabIndex = 4;
            this.butli.Text = "Librarian";
            this.butli.UseVisualStyleBackColor = true;
            this.butli.Click += new System.EventHandler(this.butli_Click);
            // 
            // butre
            // 
            this.butre.Location = new System.Drawing.Point(226, 203);
            this.butre.Name = "butre";
            this.butre.Size = new System.Drawing.Size(72, 35);
            this.butre.TabIndex = 5;
            this.butre.Text = "Reader";
            this.butre.UseVisualStyleBackColor = true;
            this.butre.Click += new System.EventHandler(this.butre_Click);
            // 
            // labelregister
            // 
            this.labelregister.AutoSize = true;
            this.labelregister.Location = new System.Drawing.Point(140, 267);
            this.labelregister.Name = "labelregister";
            this.labelregister.Size = new System.Drawing.Size(215, 13);
            this.labelregister.TabIndex = 6;
            this.labelregister.Text = "If you do not have account, please register !";
            // 
            // butregister
            // 
            this.butregister.Location = new System.Drawing.Point(375, 255);
            this.butregister.Name = "butregister";
            this.butregister.Size = new System.Drawing.Size(68, 36);
            this.butregister.TabIndex = 7;
            this.butregister.Text = "Register";
            this.butregister.UseVisualStyleBackColor = true;
            this.butregister.Click += new System.EventHandler(this.butregister_Click);
            // 
            // Logingui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryvdatabase.Properties.Resources.hinhnen10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 447);
            this.Controls.Add(this.butregister);
            this.Controls.Add(this.labelregister);
            this.Controls.Add(this.butre);
            this.Controls.Add(this.butli);
            this.Controls.Add(this.butma);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.panellogin);
            this.Name = "Logingui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textaccname;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labelaccname;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button butexit;
        private System.Windows.Forms.Button butma;
        private System.Windows.Forms.Button butli;
        private System.Windows.Forms.Button butre;
        private System.Windows.Forms.Label labelregister;
        private System.Windows.Forms.Button butregister;
    }
}