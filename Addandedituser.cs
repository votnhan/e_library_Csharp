using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryvdatabase
{
    public partial class Addandedituser : Form
    {
        database dsdulieu = new database();
        int trangthai;
        string codeuser;
        public Addandedituser()
        {
            InitializeComponent();
            trangthai = 0;
        }
        public Addandedituser(string code)
        {
            InitializeComponent();
            trangthai = 1;
            codeuser = code;
            textusercode.Text = codeuser;
            textusercode.Enabled = false;
            dsdulieu.getuserbycodeuser(code);
            DataRow row = dsdulieu.DT.Rows[0];
            textusername.Text = row["nameuser"].ToString();
            textjob.Text= row["job"].ToString();
            textemail.Text = row["email"].ToString();
            textdayofbirth.Text = row["dayofbirth"].ToString();
            this.Text = "Edit User Infomation";
        }
        private void butok_Click(object sender, EventArgs e)
        {
            dsdulieu.setconnect();
            if (trangthai == 0)
            {
                int kq = 0;
                DateTime date;
                if (!DateTime.TryParseExact(textdayofbirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    kq = 1;
                    MessageBox.Show("Day of birth id not valid", "Attention");
                }
                if (!textemail.Text.Contains("@"))
                {
                    kq = 2;
                    MessageBox.Show("Email address id not valid", "Attention");
                }
                DataSet DS = new DataSet();
                string command = "SELECT codeuser FROM user WHERE codeuser='" + textusercode.Text + "'";
                dsdulieu.filltertable(command, DS);
                if (dsdulieu.DT.Rows.Count > 0)
                {
                    kq = 4;
                    MessageBox.Show("Redumplication of User Code", "Attention");
                }
                if (kq == 0)
                {
                    dsdulieu.setconnect();
                    command = "INSERT INTO user (codeuser,nameuser,job,email,numaccount,dayofbirth) VALUES(@codeuser,@nameuser,@job,@email,@numaccount,@dayofbirth)";
                    dsdulieu.sql_cmd = new System.Data.SQLite.SQLiteCommand(command, dsdulieu.sql_con);
                    dsdulieu.sql_cmd.Parameters.Add("@codeuser", System.Data.DbType.String).Value = textusercode.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@nameuser", System.Data.DbType.String).Value = textusername.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@job", System.Data.DbType.String).Value = textjob.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@email", System.Data.DbType.String).Value = textemail.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@numaccount", System.Data.DbType.Int32).Value ="0";
                    dsdulieu.sql_cmd.Parameters.Add("@dayofbirth", System.Data.DbType.String).Value = textdayofbirth.Text;
                    dsdulieu.sql_cmd.ExecuteNonQuery();
                    dsdulieu.sql_con.Close();
                    MessageBox.Show("Adding a new User is successful", "Notification");
                    this.Close();
                }
            }
            if(trangthai==1)
            {
                int kq = 0; 
                DateTime date;
                if (!DateTime.TryParseExact(textdayofbirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    kq = 1;
                    MessageBox.Show("Day of birth id not valid", "Attention");
                }
                if (!textemail.Text.Contains("@"))
                {
                    kq = 2;
                    MessageBox.Show("Email address id not valid", "Attention");
                }
                if (kq == 0)
                {
                    string command = "UPDATE user SET codeuser='" + textusercode.Text + "',nameuser='" + textusername.Text + "',job='" + textjob.Text + "',email='" + textemail.Text + "',dayofbirth='" + textdayofbirth.Text + "' WHERE codeuser='"+codeuser+"'";
                    dsdulieu.ExecuteQuery(command);
                    MessageBox.Show("Editting infomation of this User is successful", "Notification");
                    this.Close();
                }
            }
        }
        private void butcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Addandedituser_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
