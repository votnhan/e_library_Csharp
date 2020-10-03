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
    public partial class Usergui : Form
    {
        database dsdulieu = new database();
        string nowacc;
        public Usergui()
        {
            InitializeComponent();
            dataGrid.Hide();
            panelinfo.BackColor = Color.FromArgb(100, 88, 44, 55);
            panellistuser.BackColor = Color.FromArgb(100, 88, 44, 55);
            panelsearch.BackColor= Color.FromArgb(100, 88, 44, 55);
            radiocodeuser.Checked = true;
        }
        public Usergui(string accname)
        {
            InitializeComponent();
            dataGrid.Hide();
            panelinfo.BackColor = Color.FromArgb(100, 88, 44, 55);
            panellistuser.BackColor = Color.FromArgb(100, 88, 44, 55);
            panelsearch.BackColor = Color.FromArgb(100, 88, 44, 55);
            radiocodeuser.Checked = true;
            nowacc = accname;
        }
       private void butrefresh_Click(object sender, EventArgs e)
        {
            dsdulieu.setconnect();
            DataSet DS = new DataSet();
            string commandtext = "SELECT codeuser FROM user";
            dsdulieu.DB = new SQLiteDataAdapter(commandtext, dsdulieu.sql_con);
            DS.Clear();
            dsdulieu.DB.Fill(DS);
            listuser.DataSource = DS.Tables[0];
            listuser.DisplayMember = "codeuser";
            dsdulieu.sql_con.Close();
        }
        private void listuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (listuser.SelectedItem != null)
            {
                dsdulieu.setconnect();
                string tam = listuser.Text;
                string commandtext = "SELECT * FROM user WHERE codeuser='" +tam +"'";
                dsdulieu.DB = new SQLiteDataAdapter(commandtext,dsdulieu.sql_con);
                ds.Clear();
                dsdulieu.DB.Fill(ds);
                dsdulieu.DT = ds.Tables[0];
                dataGrid.DataSource = dsdulieu.DT;
                DataGridViewRow row = dataGrid.Rows[0];
                textusercode.Text = tam;
                textusername.Text = row.Cells[1].Value.ToString();
                textuserjob.Text = row.Cells[2].Value.ToString();
                textemail.Text = row.Cells[3].Value.ToString();
                textnumacc.Text = row.Cells[4].Value.ToString();
                textdayofbirth.Text = row.Cells[5].Value.ToString();
                dsdulieu.sql_con.Close();
            }
        }
        private void butadd_Click(object sender, EventArgs e)
        {
            Addandedituser adduser = new Addandedituser();
            adduser.ShowDialog();
        }

        private void butremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (listuser.Text !="")
                {
                    dsdulieu.getuserbycodeuser(listuser.Text);
                    DataRow row = dsdulieu.DT.Rows[0];
                    if (int.Parse(row["numaccount"].ToString()) == 0)
                    {
                        dsdulieu.setconnect();
                        string command = "DELETE FROM user WHERE codeuser='" + listuser.Text + "'";
                        dsdulieu.ExecuteQuery(command);
                        MessageBox.Show("Deleting a User is successful", "Notification");
                    }
                    else { MessageBox.Show("This User is linking many account !", "Attention !"); }
                }
                else { MessageBox.Show("Please choose a User to remove !", "Attention !"); }
            }
        }

        private void butedit_Click(object sender, EventArgs e)
        {
            if (listuser.DataSource != null)
            {
                if (listuser.Text != null)
                {
                    Addandedituser edituser = new Addandedituser(listuser.Text);
                    edituser.ShowDialog();
                }
                else { MessageBox.Show("Please chosing a User to edit infomation !", "Attention !"); }
            }
            else { MessageBox.Show("Please refresh List User !", "Attention !"); }
        }

        private void Usergui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void butlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accountgui account = new Accountgui();
            account.ShowDialog();
            this.Show();
        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            if (textsearch.Text != null)
            {
                if (radiocodeuser.Checked)
                {
                    string command = "SELECT * FROM user WHERE codeuser like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    listuser.DataSource = dsdulieu.DT;
                    listuser.DisplayMember = "codeuser";
                }
                if (radionameuser.Checked)
                {
                    string command = "SELECT * FROM user WHERE nameuser like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    listuser.DataSource = dsdulieu.DT;
                    listuser.DisplayMember = "codeuser";
                }
                if (radiojob.Checked)
                {
                    string command = "SELECT * FROM user WHERE job like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    listuser.DataSource = dsdulieu.DT;
                    listuser.DisplayMember = "codeuser";
                }
                if (radioemail.Checked)
                {
                    string command = "SELECT * FROM user WHERE email like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    listuser.DataSource = dsdulieu.DT;
                    listuser.DisplayMember = "codeuser";
                }
            }
            else { MessageBox.Show("Please type infomation to search User !", "Attention !"); }
        }

        private void butchangepass_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(nowacc);
            change.ShowDialog();
        }
    }
}
