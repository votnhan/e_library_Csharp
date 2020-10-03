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
    public partial class Readergui : Form
    {
        string nowreader;
        database dsdulieu = new database();
        public Readergui()
        {
            InitializeComponent();
        }
        public Readergui(string nowacc)
        {
            InitializeComponent();
            transparent1.MakeTransparent();
            nowreader = nowacc;
            radiocodebook.Checked = true;
            radiocodebookre.Checked = true;
            radiocodebookbo.Checked = true;
            radiobookcodehi.Checked = true;
            panelsearch.BackColor = Color.FromArgb(100, 100, 44, 55);
            panelsearchhis.BackColor = Color.FromArgb(100, 100, 44, 55);
            panelsearchre.BackColor = Color.FromArgb(100, 100, 44, 55);
            panelsearchbo.BackColor = Color.FromArgb(100, 100, 44, 55);
        }
        public void setcolumnname()
        {
            dataGridbook.Columns[0].HeaderText = "Book Code";
            dataGridbook.Columns[1].HeaderText = "Book Name";
            dataGridbook.Columns[2].HeaderText = "Author";
            dataGridbook.Columns[3].HeaderText = "Type";
            dataGridbook.Columns[4].HeaderText = "Publisher";
            dataGridbook.Columns[5].HeaderText = "Publishing Year";
            dataGridbook.Columns[6].HeaderText = "Price";
        }
        public void setcolumnnamere()
        {
            dataGridrequest.Columns[0].HeaderText = "Book Code";
            dataGridrequest.Columns[1].HeaderText = "Requesting Day";
            dataGridrequest.Columns[2].HeaderText = "Book Name";
            dataGridrequest.Columns[3].HeaderText = "Author";
            dataGridrequest.Columns[4].HeaderText = "Type";
        }
        public void setcolumnnamebo()
        {
            dataGridborrow.Columns[0].HeaderText = "Book Code";
            dataGridborrow.Columns[1].HeaderText = "Book Name";
            dataGridborrow.Columns[2].HeaderText = "Borrowing Day";
            dataGridborrow.Columns[3].HeaderText = "Returning Day";
            dataGridborrow.Columns[4].HeaderText = "Fine";
        }
        public void setcolumnnamehis()
        {
            dataGridhistory.Columns[0].HeaderText = "Book Code";
            dataGridhistory.Columns[1].HeaderText = "Book Name";
            dataGridhistory.Columns[2].HeaderText = "Type";
            dataGridhistory.Columns[3].HeaderText = "Borrowing Day";
            dataGridhistory.Columns[4].HeaderText = "Returning Day";
            dataGridhistory.Columns[5].HeaderText = "Fine";
        }
        private void butlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Readergui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void butrefresh_Click(object sender, EventArgs e)
        {
            string command = "select codebook,bookname,author,type,publisher,pubyear,price from book";
            DataSet ds = new DataSet();
            dsdulieu.filltertable(command, ds);
            dataGridbook.DataSource = dsdulieu.DT;
            setcolumnname();
        }

        private void butrequest_Click(object sender, EventArgs e)
        {
            int kq = 0;
            dsdulieu.getaccountbynameacc(nowreader);
            DataRow rows = dsdulieu.DT.Rows[0];
            if (int.Parse(rows["numrequest"].ToString()) >= 3)
            { MessageBox.Show("You exceeded number of request (3) !", "Notification"); }
            else
            {
                foreach (DataGridViewRow row in dataGridbook.Rows)
                {
                    if (row.Selected)
                    {
                        kq = 1; dsdulieu.setconnect();
                        string command1 = "INSERT INTO bookrequest(accountname,codebook,dayrequest) VALUES (@accountname,@codebook,@dayrequest)";
                        dsdulieu.sql_cmd = new System.Data.SQLite.SQLiteCommand(command1, dsdulieu.sql_con);
                        dsdulieu.sql_cmd.Parameters.Add("@accountname", System.Data.DbType.String).Value = nowreader;
                        dsdulieu.sql_cmd.Parameters.Add("@codebook", System.Data.DbType.Int32).Value = row.Cells[0].Value.ToString();
                        dsdulieu.sql_cmd.Parameters.Add("@dayrequest", System.Data.DbType.String).Value = DateTime.Now.ToString("dd/MM/yyyy");
                        dsdulieu.sql_cmd.ExecuteNonQuery();
                        dsdulieu.sql_con.Close();
                        string command2 = "UPDATE account SET numrequest=numrequest+1 WHERE accountname='" + nowreader + "'";
                        dsdulieu.ExecuteQuery(command2);
                        string command3 = "UPDATE book SET status='1' WHERE codebook = '" + row.Cells[0].Value.ToString() + "'";
                        dsdulieu.ExecuteQuery(command3);
                        MessageBox.Show("Sending request is successful !", "Notification");
                    }
                }
                if (kq == 0) { MessageBox.Show("Please choose a row of book to request !", "Notification"); }
            }
        }

        private void butrefreshinfo_Click(object sender, EventArgs e)
        {
            string command = "Select bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type from bookrequest,book where bookrequest.codebook=book.codebook and bookrequest.accountname='" + nowreader + "'";
            DataSet ds = new DataSet();
            dsdulieu.filltertable(command, ds);
            dataGridrequest.DataSource = dsdulieu.DT;
            setcolumnnamere();
            command = "Select bookborrow.codebook,book.bookname,bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine from bookborrow,book where bookborrow.codebook=book.codebook and bookborrow.accountname='" + nowreader + "'";
            dsdulieu.setconnect();
            SQLiteDataAdapter db = new SQLiteDataAdapter(command, dsdulieu.sql_con);
            DataSet borrow = new DataSet();
            borrow.Clear();
            db.Fill(borrow);
            dataGridborrow.DataSource = borrow.Tables[0];
            dsdulieu.sql_con.Close();
            setcolumnnamebo();
        }

        private void butremovere_Click(object sender, EventArgs e)
        {
            int kq = 0;
            foreach (DataGridViewRow row in dataGridrequest.Rows)
            {
                if(row.Selected)
                {
                    if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        kq = 1;
                        string command = "UPDATE account SET numrequest=numrequest-1 where accountname='" + nowreader + "'";
                        dsdulieu.ExecuteQuery(command);
                        command = "DELETE FROM bookrequest where accountname='" + nowreader + "' and codebook='" + row.Cells[0].Value.ToString() + "'";
                        dsdulieu.ExecuteQuery(command);
                        MessageBox.Show("Removing this request is successful !", "Notification");
                        break;
                    }
                    else break;
                }
            }
            if(kq==0) { MessageBox.Show("Please choose a row of book to remove request !", "Notification"); }
        }

        private void butrefreshhi_Click(object sender, EventArgs e)
        {
            string command = "Select history.codebook,book.bookname,book.type,history.dayborrow,history.dayreturn,history.fine from history,book where history.codebook=book.codebook and history.accountname='" + nowreader + "'";
            DataSet ds = new DataSet();
            dsdulieu.filltertable(command, ds);
            dataGridhistory.DataSource = dsdulieu.DT;
            setcolumnnamehis();
        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            if(textsearch.Text!="")
            {
                if(radiocodebook.Checked)
                {
                    string command = "select codebook,bookname,author,type,publisher,pubyear,price from book where codebook like '%" + textsearch.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setcolumnname();
                }
                else if(radiobookname.Checked)
                {
                    string command = "select codebook,bookname,author,type,publisher,pubyear,price from book where bookname like '%" + textsearch.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setcolumnname();
                }
               else  if(radiotype.Checked)
                {
                    string command = "select codebook,bookname,author,type,publisher,pubyear,price from book where type like '%" + textsearch.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setcolumnname();
                }
                else
                {
                    string command = "select codebook,bookname,author,type,publisher,pubyear,price from book where author like '%" + textsearch.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setcolumnname();
                }
            }
            else { MessageBox.Show("Please type infomation of book to search !", "Notification"); }
        }

        private void butsearchre_Click(object sender, EventArgs e)
        {
            if(textsearchre.Text!="")
            {
                if(radiocodebookre.Checked)
                {
                    string command = "Select bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type from bookrequest,book where bookrequest.codebook=book.codebook and bookrequest.accountname='" + nowreader + "'" + "and bookrequest.codebook like '%" + textsearchre.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridrequest.DataSource = dsdulieu.DT;
                    setcolumnnamere();
                }
                else if(radionamebookre.Checked)
                {
                    string command = "Select bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type from bookrequest,book where bookrequest.codebook=book.codebook and bookrequest.accountname='" + nowreader + "'" + "and book.bookname like '%" + textsearchre.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridrequest.DataSource = dsdulieu.DT;
                    setcolumnnamere();
                }
                else 
                {
                    string command = "Select bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type from bookrequest,book where bookrequest.codebook=book.codebook and bookrequest.accountname='" + nowreader + "'" + "and book.type like '%" + textsearchre.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridrequest.DataSource = dsdulieu.DT;
                    setcolumnnamere();
                }
            }
            else { MessageBox.Show("Please type infomation of request to search !", "Notification"); }
        }

        private void butsearchbo_Click(object sender, EventArgs e)
        {
            if (textsearchbo.Text != "")
            {
                if (radiocodebookbo.Checked)
                {
                    string command = "Select bookborrow.codebook,book.bookname,bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine from bookborrow,book where bookborrow.codebook=book.codebook and bookborrow.accountname='" + nowreader + "'" + "and bookborrow.codebook like '%" + textsearchbo.Text + "%'";
                    dsdulieu.setconnect();
                    SQLiteDataAdapter db = new SQLiteDataAdapter(command, dsdulieu.sql_con);
                    DataSet borrow = new DataSet();
                    borrow.Clear();
                    db.Fill(borrow);
                    dataGridborrow.DataSource = borrow.Tables[0];
                    dsdulieu.sql_con.Close();
                    setcolumnnamebo();
                }
                else if(radiobooknamebo.Checked)
                {
                    string command = "Select bookborrow.codebook,book.bookname,bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine from bookborrow,book where bookborrow.codebook=book.codebook and bookborrow.accountname='" + nowreader + "'" + "and book.bookname like '%" + textsearchbo.Text + "%'";
                    dsdulieu.setconnect();
                    SQLiteDataAdapter db = new SQLiteDataAdapter(command, dsdulieu.sql_con);
                    DataSet borrow = new DataSet();
                    borrow.Clear();
                    db.Fill(borrow);
                    dataGridborrow.DataSource = borrow.Tables[0];
                    dsdulieu.sql_con.Close();
                    setcolumnnamebo();
                }
                else if(radiodayborrow.Checked)
                {
                    string command = "Select bookborrow.codebook,book.bookname,bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine from bookborrow,book where bookborrow.codebook=book.codebook and bookborrow.accountname='" + nowreader + "'" + "and bookborrow.dayborrow like '%" + textsearchbo.Text + "%'";
                    dsdulieu.setconnect();
                    SQLiteDataAdapter db = new SQLiteDataAdapter(command, dsdulieu.sql_con);
                    DataSet borrow = new DataSet();
                    borrow.Clear();
                    db.Fill(borrow);
                    dataGridborrow.DataSource = borrow.Tables[0];
                    dsdulieu.sql_con.Close();
                    setcolumnnamebo();
                }
            }
            else { MessageBox.Show("Please type infomation of borrowing book to search !", "Notification"); }
        }

        private void butsearchhi_Click(object sender, EventArgs e)
        {
            if(textsearchhi.Text!="")
            {
                if(radiobookcodehi.Checked)
                {
                    string command = "Select history.codebook,book.bookname,book.type,history.dayborrow,history.dayreturn,history.fine from history,book where history.codebook=book.codebook and history.accountname='" + nowreader + "'" + "and history.codebook like '%" + textsearchhi.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridhistory.DataSource = dsdulieu.DT;
                    setcolumnnamehis();
                }
                else if(radiobooknamehi.Checked)
                {
                    string command = "Select history.codebook,book.bookname,book.type,history.dayborrow,history.dayreturn,history.fine from history,book where history.codebook=book.codebook and history.accountname='" + nowreader + "'" + "and book.bookname like '%" + textsearchhi.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridhistory.DataSource = dsdulieu.DT;
                    setcolumnnamehis();
                }
                else
                {
                    string command = "Select history.codebook,book.bookname,book.type,history.dayborrow,history.dayreturn,history.fine from history,book where history.codebook=book.codebook and history.accountname='" + nowreader + "'" + "and history.dayborrow like '%" + textsearchhi.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridhistory.DataSource = dsdulieu.DT;
                    setcolumnnamehis();
                }
            }
            else { MessageBox.Show("Please type infomation of historic book to search !", "Notification"); }
        }
    }
}
