using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace libraryvdatabase
{
    public partial class Accountgui : Form
    {
        public Accountgui()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, 88, 44, 55);
            panel4.BackColor = Color.FromArgb(100, 88, 44, 55);
            panelsearch.BackColor= Color.FromArgb(100, 88, 44, 55);
            radionameacc.Checked = true;
        }
        database dsdulieu = new database();
        private void butrefresh_Click(object sender, EventArgs e)
        {
            dsdulieu.setconnect();
            string command = "SELECT accountname FROM account";
            DataSet DS = new DataSet();
            SQLiteDataAdapter DB = new SQLiteDataAdapter(command, dsdulieu.sql_con);
            DS.Clear();
            DB.Fill(DS);
            //dsdulieu.filltertable(command, DS);
            listaccount.DataSource = DS.Tables[0];
            listaccount.DisplayMember = "accountname";
            dsdulieu.sql_con.Close();
           
        }
        private void listaccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listaccount.Text!=null)
            {
                dsdulieu.getaccountbynameacc(listaccount.Text);
                textaccname.Text = listaccount.Text;
                DataRow rows = dsdulieu.DT.Rows[0];
                textpass.Text = rows["password"].ToString();
                textusercode.Text = rows["codeuser"].ToString();
                textrole.Text = dsdulieu.getrolebycode(rows["role"].ToString());
                textstatus.Text = dsdulieu.getstatusbycode(rows["status"].ToString());
                textfine.Text = rows["fine"].ToString();
            }
        }
        private void Accountgui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void butadd_Click(object sender, EventArgs e)
        {
            Addandeditaccount addaccount = new Addandeditaccount();
            addaccount.ShowDialog();
        }

        private void butremove_Click(object sender, EventArgs e)
        {
            if (listaccount.Text != null)
            {
                if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    dsdulieu.getaccountbynameacc(listaccount.Text);
                    DataRow row = dsdulieu.DT.Rows[0];
                    if(int.Parse(row["numborrow"].ToString())==0)
                    {
                        string command = "DELETE FROM account WHERE accountname='" + listaccount.Text + "'";
                        dsdulieu.ExecuteQuery(command);
                        MessageBox.Show("Deleting an Account is successful !", "Notification !");

                    }
                    else { MessageBox.Show("This Account is borrowing books !", "Notification !"); }
                }
            }
            else { MessageBox.Show("Please chosing a Account to delete !", "Attention !"); }
        }

        private void butedit_Click(object sender, EventArgs e)
        {
            if (listaccount.Text != null)
            {
                Addandeditaccount editacc = new Addandeditaccount(listaccount.Text);
                editacc.ShowDialog();
            }
            else { MessageBox.Show("Please chosing a Account to edit !", "Attention !"); }
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            if (listaccount.Text != null)
            {
                if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    dsdulieu.getaccountbynameacc(listaccount.Text);
                    DataRow row = dsdulieu.DT.Rows[0];
                    string command= "UPDATE account SET accountname='" + textaccname.Text + "',password='" + "123456" + "',codeuser='" + textusercode.Text + "',role='" + row["role"] + "',status='" + row["status"] + "',numborrow='" + row["numborrow"] + "',numrequest='" + row["numrequest"] + "',fine='" + row["fine"] + "' WHERE accountname='" + listaccount.Text + "'";
                    dsdulieu.ExecuteQuery(command);
                    MessageBox.Show("Reseting this Account is successful !", "Notification !");
                }
            }
            else { MessageBox.Show("Please chosing a Account reset password !", "Attention !"); }
        }

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            if (textsearch.Text != null)
            {
                if (radionameacc.Checked)
                {
                    string command = "SELECT * FROM account WHERE accountname like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    listaccount.DataSource = dsdulieu.DT;
                    listaccount.DisplayMember = "accountname";
                }
                if (radiocodeuser.Checked)
                {
                    string command = "SELECT * FROM account WHERE codeuser like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    listaccount.DataSource = dsdulieu.DT;
                    listaccount.DisplayMember = "accountname";
                }
            }
            else { MessageBox.Show("Please type infomation to search Account !", "Attention !"); }
        }
    }
}
