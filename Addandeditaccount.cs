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
    public partial class Addandeditaccount : Form
    {
        int trangthai;
        string accname;
        public Addandeditaccount()
        {
            InitializeComponent();
            trangthai = 0;
        }
        public Addandeditaccount(string nameacc)
        {
            InitializeComponent();
            trangthai = 1;
            accname = nameacc;
            textaccname.Text = accname;
            textaccname.Enabled = false;
            dsdulieu.getaccountbynameacc(nameacc);
            DataRow row = dsdulieu.DT.Rows[0];
            textpass.Text = row["password"].ToString();
            textpass.Enabled = false;
            textusercode.Text = row["codeuser"].ToString();
            if (row["role"].ToString() == "6") { checkma.Checked = true; checkli.Checked = true; checkre.Checked = true; }
            else if (row["role"].ToString() == "5") { checkli.Checked = true; checkre.Checked = true; }
            else if (row["role"].ToString() == "4") { checkma.Checked = true; checkre.Checked = true; }
            else if (row["role"].ToString() == "3") { checkma.Checked = true; checkli.Checked = true; }
            else if (row["role"].ToString() == "2") { checkre.Checked = true; }
            else if (row["role"].ToString() == "1") { checkli.Checked = true; }
            else { checkma.Checked = true; }
            if (row["status"].ToString()=="1") radioact.Checked = true;
            else radioina.Checked = true;
        }
        public Addandeditaccount(int regist)
        {
            InitializeComponent();
            trangthai = 2;
            groupBoxstatus.Hide();
        }
        database dsdulieu = new database();
        private void butok_Click(object sender, EventArgs e)
        {
            if (trangthai == 0)
            {
                int kq = 0;
                dsdulieu.getaccountbynameacc(textaccname.Text);
                if (dsdulieu.DT.Rows.Count > 0)
                {
                    kq = 1;
                    MessageBox.Show("Redumplication of Account Name !", "Attention !");
                }
                dsdulieu.getuserbycodeuser(textusercode.Text);
                if (dsdulieu.DT.Rows.Count == 0)
                {
                    kq = 2;
                    MessageBox.Show("This User does not exist !", "Attention !");
                }
                if (kq == 0)
                {
                    dsdulieu.setconnect();
                    string role, status;
                    if (checkma.Checked && checkli.Checked && checkre.Checked) role = "6";
                    else if (checkli.Checked && checkre.Checked) role = "5";
                    else if (checkma.Checked && checkre.Checked) role = "4";
                    else if (checkma.Checked && checkli.Checked) role = "3";
                    else if (checkre.Checked) role = "2";
                    else if (checkli.Checked) role = "1";
                    else role = "0";
                    if (radioact.Checked) status = "1";
                    else status = "0";
                    string command = "INSERT INTO account (accountname,password,codeuser,role,status,numborrow,numrequest,fine) VALUES (@accountname,@password,@codeuser,@role,@status,@numborrow,@numrequest,@fine)";
                    dsdulieu.sql_cmd = new System.Data.SQLite.SQLiteCommand(command, dsdulieu.sql_con);
                    dsdulieu.sql_cmd.Parameters.Add("@accountname", System.Data.DbType.String).Value = textaccname.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@password", System.Data.DbType.String).Value = textpass.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@codeuser", System.Data.DbType.String).Value = textusercode.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@role", System.Data.DbType.String).Value = role;
                    dsdulieu.sql_cmd.Parameters.Add("@status", System.Data.DbType.String).Value = status;
                    dsdulieu.sql_cmd.Parameters.Add("@numborrow", System.Data.DbType.Int32).Value = "0";
                    dsdulieu.sql_cmd.Parameters.Add("@numrequest", System.Data.DbType.Int32).Value = "0";
                    dsdulieu.sql_cmd.Parameters.Add("@fine", System.Data.DbType.Int32).Value = "0";
                    dsdulieu.sql_cmd.ExecuteNonQuery();
                    dsdulieu.sql_con.Close();
                    command = "UPDATE user SET numaccount=numaccount+1 where codeuser='" + textusercode.Text + "'";
                    dsdulieu.ExecuteQuery(command);
                    MessageBox.Show("Adding new Account is successful !", "Notification !");
                    this.Close();
                   
                }
            }
            if(trangthai==1)
            {
                int kq = 0;
                dsdulieu.getuserbycodeuser(textusercode.Text);
                if (dsdulieu.DT.Rows.Count == 0)
                {
                    kq = 2;
                    MessageBox.Show("This User does not exist !", "Attention !");
                }
                if (kq == 0)
                {
                    dsdulieu.getaccountbynameacc(accname);
                    DataRow row = dsdulieu.DT.Rows[0];
                    string role, status;
                    if (checkma.Checked && checkli.Checked && checkre.Checked) role = "6";
                    else if (checkli.Checked && checkre.Checked) role = "5";
                    else if (checkma.Checked && checkre.Checked) role = "4";
                    else if (checkma.Checked && checkli.Checked) role = "3";
                    else if (checkre.Checked) role = "2";
                    else if (checkli.Checked) role = "1";
                    else role = "0";
                    if (radioact.Checked) status = "1";
                    else status = "0";
                    string command= "UPDATE account SET accountname='" + textaccname.Text + "',password='" + textpass.Text + "',codeuser='" + textusercode.Text + "',role='" + role + "',status='" + status+ "',numborrow='" +row["numborrow"] +"',numrequest='"+row["numrequest"]+"',fine='"+row["fine"]+"' WHERE accountname='" + accname + "'";
                    dsdulieu.ExecuteQuery(command);
                    MessageBox.Show("Editing this Account is successful !", "Notification !");
                    this.Close();
                }
            }
            if(trangthai==2)
            {
                int kq = 0;
                dsdulieu.getaccountbynameacc(textaccname.Text);
                if (dsdulieu.DT.Rows.Count > 0)
                {
                    kq = 1;
                    MessageBox.Show("Redumplication of Account Name !", "Attention !");
                }
                dsdulieu.getuserbycodeuser(textusercode.Text);
                if (dsdulieu.DT.Rows.Count == 0)
                {
                    kq = 2;
                    MessageBox.Show("This User does not exist !", "Attention !");
                }
                if (kq == 0)
                {
                    dsdulieu.setconnect();
                    string role, status;
                    if (checkma.Checked && checkli.Checked && checkre.Checked) role = "6";
                    else if (checkli.Checked && checkre.Checked) role = "5";
                    else if (checkma.Checked && checkre.Checked) role = "4";
                    else if (checkma.Checked && checkli.Checked) role = "3";
                    else if (checkre.Checked) role = "2";
                    else if (checkli.Checked) role = "1";
                    else role = "0";
                    string command = "INSERT INTO account (accountname,password,codeuser,role,status,numborrow,numrequest,fine) VALUES (@accountname,@password,@codeuser,@role,@status,@numborrow,@numrequest,@fine)";
                    dsdulieu.sql_cmd = new System.Data.SQLite.SQLiteCommand(command, dsdulieu.sql_con);
                    dsdulieu.sql_cmd.Parameters.Add("@accountname", System.Data.DbType.String).Value = textaccname.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@password", System.Data.DbType.String).Value = textpass.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@codeuser", System.Data.DbType.String).Value = textusercode.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@role", System.Data.DbType.String).Value = role;
                    dsdulieu.sql_cmd.Parameters.Add("@status", System.Data.DbType.String).Value = "0";
                    dsdulieu.sql_cmd.Parameters.Add("@numborrow", System.Data.DbType.Int32).Value = "0";
                    dsdulieu.sql_cmd.Parameters.Add("@numrequest", System.Data.DbType.Int32).Value = "0";
                    dsdulieu.sql_cmd.Parameters.Add("@fine", System.Data.DbType.Int32).Value = "0";
                    dsdulieu.sql_cmd.ExecuteNonQuery();
                    dsdulieu.sql_con.Close();
                    command = "UPDATE user SET numaccount=numaccount+1 where codeuser='" + textusercode.Text + "'";
                    dsdulieu.ExecuteQuery(command);
                    MessageBox.Show("Adding new Account is successful !", "Notification !");
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
    }
}
