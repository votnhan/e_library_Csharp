using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryvdatabase
{
    public partial class ChangePassword : Form
    {
        string nowacc;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(string nowacc)
        {
            InitializeComponent();
            this.nowacc = nowacc;
            textnameacc.Text = nowacc;
            textnameacc.Enabled = false;
            string command = "select * from user where codeuser=(select codeuser from account where accountname ='" + nowacc + "')";
            DataSet ds = new DataSet();
            dsdulieu.filltertable(command, ds);
            DataRow row = dsdulieu.DT.Rows[0];
            textusercode.Text = row["codeuser"].ToString();
            textusername.Text = row["nameuser"].ToString();
            textjob.Text = row["job"].ToString();
            textemail.Text = row["email"].ToString();
            textnumacc.Text = row["numaccount"].ToString();
            textdayofbirth.Text = row["dayofbirth"].ToString();
        }
        database dsdulieu = new database();
        private void butcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void butok_Click(object sender, EventArgs e)
        {
            dsdulieu.getaccountbynameacc(nowacc);
            DataRow row = dsdulieu.DT.Rows[0];
            if(textoldpass.Text!="")
            {
                if(row["password"].ToString()==textoldpass.Text)
                {
                    if(textnewpass.Text==textconfirm.Text)
                    {
                        string command = "UPDATE account SET password='" + textnewpass.Text + "' WHERE accountname='" + nowacc + "'";
                        dsdulieu.ExecuteQuery(command);
                        MessageBox.Show("Changing Password of this Account is successful", "Notification");
                        this.Close();
                    }
                    else { MessageBox.Show("Confirm Password is wrong !", "Attention"); }
                }
                else { MessageBox.Show("Password of this Account is wrong !", "Attention"); }
            }
            else { MessageBox.Show("Please type Password to change !", "Attention"); }
        }
    }
}
