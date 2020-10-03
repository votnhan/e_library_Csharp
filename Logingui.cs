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
    public partial class Logingui : Form
    {
        string nowacc;
        public Logingui()
        {
            InitializeComponent();
            butli.Hide();
            butma.Hide();
            butre.Hide();
            panellogin.BackColor= Color.FromArgb(100, 88, 44, 55);
        }
        database dsdulieu = new database();
        private void butexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            if(textaccname.Text!="")
            {
                dsdulieu.getaccountbynameacc(textaccname.Text);
                if (dsdulieu.DT.Rows.Count == 0) { MessageBox.Show("This Account Name does not exist !", "Attention"); }
                else
                {
                    nowacc = textaccname.Text;
                    if (textpassword.Text !="")
                    {   DataRow row = dsdulieu.DT.Rows[0];
                        if (row["password"].ToString() != textpassword.Text) { MessageBox.Show("This Password is Wrong !", "Attention"); }
                        else
                        {
                            if (row["status"].ToString() == "0") { MessageBox.Show("This Account is inactive !", "Attention"); }
                            else
                            {
                                if(row["role"].ToString()=="6") { butma.Show();butli.Show();butre.Show(); }
                                else if(row["role"].ToString() == "5") { butli.Show(); butre.Show(); }
                                else if (row["role"].ToString() == "4") { butma.Show(); butre.Show(); }
                                else if (row["role"].ToString() == "3") { butma.Show(); butli.Show(); }
                                else if (row["role"].ToString() == "2") { butre.Show(); }
                                else if (row["role"].ToString() == "1") { butli.Show(); }
                                else { butma.Show(); }

                            }
                        }
                    }
                    else { MessageBox.Show("Please type Password of this Account", "Notification"); }
                }
            }
            else { MessageBox.Show("Please type Account Name", "Notification");}
        }

        private void butma_Click(object sender, EventArgs e)
        {
            Usergui user = new Usergui(nowacc);
            butli.Hide();
            butma.Hide();
            butre.Hide();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void butli_Click(object sender, EventArgs e)
        {
            Librariangui librarian = new Librariangui(nowacc);
            butli.Hide();
            butma.Hide();
            butre.Hide();
            this.Hide();
            librarian.ShowDialog();
            this.Show();
        }

        private void butre_Click(object sender, EventArgs e)
        {
            Readergui reader = new Readergui(nowacc);
            butli.Hide();
            butma.Hide();
            butre.Hide();
            this.Hide();
            reader.ShowDialog();
            this.Show();
        }
        private void butregister_Click(object sender, EventArgs e)
        {
            Addandedituser registuser = new Addandedituser();
            registuser.ShowDialog();
            Addandeditaccount registaccount = new Addandeditaccount(3);
            registaccount.ShowDialog();
        }
    }
}
