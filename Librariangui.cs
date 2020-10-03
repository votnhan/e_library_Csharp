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
    public partial class Librariangui : Form
    {
        string nowacc;
        public Librariangui()
        {
            InitializeComponent();
            radiocodebook.Checked = true;
            radioaccnamere.Checked = true;
            radioaccnamebo.Checked = true;
            panelsearch.BackColor = Color.FromArgb(100, 88, 44, 55);
            panelsearchre.BackColor = Color.FromArgb(100, 88, 44, 55);
            panelsearchbo.BackColor = Color.FromArgb(100, 88, 44, 55);
            transparent1.MakeTransparent();
        }
        public Librariangui(string now)
        {
            InitializeComponent();
            radiocodebook.Checked = true;
            nowacc = now;
            radioaccnamere.Checked = true;
            radioaccnamebo.Checked = true;
            panelsearch.BackColor = Color.FromArgb(100, 88, 44, 55);
            panelsearchre.BackColor = Color.FromArgb(100, 88, 44, 55);
            panelsearchbo.BackColor = Color.FromArgb(100, 88, 44, 55);
            transparent1.MakeTransparent();
        }
        database dsdulieu = new database();
        public void setnamecolumn()
        {
            dataGridbook.Columns[0].HeaderText = "Book Code";
            dataGridbook.Columns[1].HeaderText = "Book Name";
            dataGridbook.Columns[2].HeaderText = "Author";
            dataGridbook.Columns[3].HeaderText = "Type";
            dataGridbook.Columns[4].HeaderText = "Publisher";
            dataGridbook.Columns[5].HeaderText = "Publishing Year";
            dataGridbook.Columns[6].HeaderText = "Status";
            dataGridbook.Columns[7].HeaderText = "Number of Book";
            dataGridbook.Columns[8].HeaderText = "Price";
        }
        public void setnamecolumnre()
        {
            dataGridrequest.Columns[0].HeaderText = "Account Name";
            dataGridrequest.Columns[1].HeaderText = "Book Code";
            dataGridrequest.Columns[2].HeaderText = "Day Request";
            dataGridrequest.Columns[3].HeaderText = "Book Name";
            dataGridrequest.Columns[4].HeaderText = "Author";
            dataGridrequest.Columns[5].HeaderText = "Type";
        }
        public void setnamecolumnbo()
        {
            dataGridborrow.Columns[0].HeaderText = "Account Name";
            dataGridborrow.Columns[1].HeaderText = "Book Code";
            dataGridborrow.Columns[2].HeaderText = "Day Borrow";
            dataGridborrow.Columns[3].HeaderText = "Day Return";
            dataGridborrow.Columns[4].HeaderText = "Fine";
            dataGridborrow.Columns[5].HeaderText = "Book Name";
        }
        private void butrefresh_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            string command = "select * from book";
            dsdulieu.filltertable(command, DS);
            dataGridbook.DataSource = dsdulieu.DT;
            setnamecolumn();
        }
        private void Librariangui_FormClosing(object sender, FormClosingEventArgs e)
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

        private void butadd_Click(object sender, EventArgs e)
        {
            Addandeditbook newbook = new Addandeditbook();
            newbook.ShowDialog();
        }

        private void butremove_Click(object sender, EventArgs e)
        {
            int kq = 0;
            foreach (DataGridViewRow row in dataGridbook.Rows)
            {
                if (row.Selected)
                {
                    string code = row.Cells[0].Value.ToString();kq = 1;
                    if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        dsdulieu.getbookbycode(code);
                        DataRow rows = dsdulieu.DT.Rows[0];
                        if (int.Parse(rows["status"].ToString()) != 0)
                        {
                            MessageBox.Show("This Account is still borrowing book !", "Attention");
                        }
                        else
                        {
                            String command = "DELETE FROM book WHERE codebook='" + code + "'";
                            dsdulieu.ExecuteQuery(command);
                            MessageBox.Show("Deleting a book is successful !", "Notification");
                        }
                    }
                    break;
                }
            }
            if (kq == 0) { MessageBox.Show("Please chosing a row of book to delete !", "Attention"); }
        }

        private void butedit_Click(object sender, EventArgs e)
        {
            int kq = 0;
            foreach (DataGridViewRow row in dataGridbook.Rows)
            {
                if (row.Selected)
                {   
                    kq = 1;
                    string code = row.Cells[0].Value.ToString();
                    Addandeditbook editbook = new Addandeditbook(code);
                    editbook.ShowDialog();
                    break;
                }
            }
            if(kq==0) { MessageBox.Show("Please chosing a row of book to edit !", "Attention"); }
        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            if (textsearch.Text != null)
            {
                if(radiocodebook.Checked)
                {
                    string command = "SELECT * FROM book WHERE codebook like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setnamecolumn();
                }
                else if(radiobookname.Checked)
                {
                    string command = "SELECT * FROM book WHERE bookname like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setnamecolumn();
                }
                else if(radioauthor.Checked)
                {
                    string command = "SELECT * FROM book WHERE author like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setnamecolumn();
                }
                else
                {
                    string command = "SELECT * FROM book WHERE type like '%" + textsearch.Text + "%'";
                    DataSet DS = new DataSet();
                    dsdulieu.filltertable(command, DS);
                    dataGridbook.DataSource = dsdulieu.DT;
                    setnamecolumn();
                }
            }
            else { MessageBox.Show("Please type infomation of book to search !", "Attention"); }
        }

        private void butrefreshre_Click(object sender, EventArgs e)
        {
            dsdulieu.setconnect();
            string command = "SELECT bookrequest.accountname,bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type FROM bookrequest,book WHERE bookrequest.codebook=book.codebook";
            SQLiteDataAdapter db = new SQLiteDataAdapter(command, dsdulieu.sql_con);
            DataSet ds = new DataSet();
            ds.Clear();
            db.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridrequest.DataSource = dt;
            dsdulieu.sql_con.Close();
            setnamecolumnre();

        }

        private void butaccept_Click(object sender, EventArgs e)
        {
            int kq = 0;
            foreach (DataGridViewRow row in dataGridrequest.Rows)
            {
                if(row.Selected)
                {
                    kq = 1;
                    dsdulieu.setconnect();
                    string command1 = "INSERT INTO bookborrow(accountname,codebook,dayborrow,dayreturn,fine) VALUES (@accountname,@codebook,@dayborrow,@dayreturn,@fine)";
                    dsdulieu.sql_cmd = new SQLiteCommand(command1, dsdulieu.sql_con);
                    dsdulieu.sql_cmd.Parameters.Add("@accountname", System.Data.DbType.String).Value = row.Cells[0].Value.ToString();
                    dsdulieu.sql_cmd.Parameters.Add("@codebook", System.Data.DbType.Int32).Value = row.Cells[1].Value.ToString();
                    dsdulieu.sql_cmd.Parameters.Add("@dayborrow", System.Data.DbType.String).Value = row.Cells[2].Value.ToString();
                    dsdulieu.sql_cmd.Parameters.Add("@dayreturn", System.Data.DbType.String).Value = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
                    dsdulieu.sql_cmd.Parameters.Add("@fine", System.Data.DbType.Int32).Value ="0";
                    dsdulieu.sql_cmd.ExecuteNonQuery();
                    dsdulieu.sql_con.Close();
                    string command2 = "DELETE FROM bookrequest WHERE accountname='" + row.Cells[0].Value.ToString() + "' and codebook='" + row.Cells[1].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command2);
                    dsdulieu.getaccountbynameacc(row.Cells[0].Value.ToString());
                    DataRow rows = dsdulieu.DT.Rows[0];
                    string command3= "UPDATE account SET numrequest='"+(int.Parse(rows["numrequest"].ToString())-1).ToString()+"',numborrow='"+(int.Parse(rows["numborrow"].ToString())+1).ToString()+ "' WHERE accountname='" + row.Cells[0].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command3);
                    dsdulieu.getbookbycode(row.Cells[1].Value.ToString());
                    rows = dsdulieu.DT.Rows[0];
                    string command4 = "UPDATE book SET numbook='"+(int.Parse(rows["numbook"].ToString())-1).ToString()+"',status='2'"+"WHERE codebook='" + row.Cells[1].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command4);
                    MessageBox.Show("Accepting a request is successful !", "Notification");
                    break;
                }
            }
            if (kq == 0) { MessageBox.Show("Please choose a row request to accept !", "Notification"); }
        }

        private void butdeny_Click(object sender, EventArgs e)
        {
            int kq = 0;
            foreach (DataGridViewRow row in dataGridrequest.Rows)
            {
                if (row.Selected)
                {
                    kq = 1;
                    string command2 = "DELETE FROM bookrequest WHERE accountname='" + row.Cells[0].Value.ToString() + "' and codebook='" + row.Cells[1].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command2);
                    dsdulieu.getaccountbynameacc(row.Cells[0].Value.ToString());
                    DataRow rows = dsdulieu.DT.Rows[0];
                    string command3= "UPDATE account SET numrequest = '"+(int.Parse(rows["numrequest"].ToString())-1).ToString()+"' WHERE accountname = '" + row.Cells[0].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command3);
                    dsdulieu.getbookbycode(row.Cells[1].Value.ToString());
                    rows = dsdulieu.DT.Rows[0];
                    string command4 = "UPDATE book SET status='0'" + "WHERE codebook='" + row.Cells[1].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command4);
                    MessageBox.Show("Denying a request is successful !", "Notification");
                    break;
                }
            }
            if (kq == 0) { MessageBox.Show("Please choose a row request to deny !", "Notification"); }
        }

        private void butchangepass_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(nowacc);
            change.ShowDialog();
        }
        private void butrefreshbo_Click(object sender, EventArgs e)
        {
            string command = "select bookborrow.accountname, bookborrow.codebook, bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine,book.bookname from bookborrow,book where bookborrow.codebook=book.codebook";
            DataSet ds = new DataSet();
            dsdulieu.filltertable(command, ds);
            dataGridborrow.DataSource = dsdulieu.DT;
            setnamecolumnbo();
        }

        private void butreturn_Click(object sender, EventArgs e)
        {
            int kq = 0;
            foreach (DataGridViewRow row in dataGridborrow.Rows)
            {
                if(row.Selected)
                {
                    dsdulieu.setconnect();
                    kq = 1;int fine;
                    string command1 = "INSERT INTO history(accountname,codebook,dayborrow,dayreturn,fine) VALUES (@accountname,@codebook,@dayborrow,@dayreturn,@fine)";
                    dsdulieu.sql_cmd = new SQLiteCommand(command1, dsdulieu.sql_con);
                    dsdulieu.sql_cmd.Parameters.Add("@accountname", System.Data.DbType.String).Value = row.Cells[0].Value.ToString();
                    dsdulieu.sql_cmd.Parameters.Add("@codebook", System.Data.DbType.Int32).Value = row.Cells[1].Value.ToString();
                    dsdulieu.sql_cmd.Parameters.Add("@dayborrow", System.Data.DbType.String).Value = row.Cells[2].Value.ToString();
                    dsdulieu.sql_cmd.Parameters.Add("@dayreturn", System.Data.DbType.String).Value = DateTime.Now.ToString("dd/MM/yyyy");
                    TimeSpan ngaytre = DateTime.Now.Subtract(DateTime.ParseExact(row.Cells[3].Value.ToString(),"dd/MM/yyyy",null));
                    int dotre = Convert.ToInt32(ngaytre.TotalDays);
                    if (dotre > 0)
                    {
                        fine = dotre * 100;
                        dsdulieu.sql_cmd.Parameters.Add("@fine", System.Data.DbType.Int32).Value = fine.ToString();
                    }
                    else dsdulieu.sql_cmd.Parameters.Add("@fine", System.Data.DbType.Int32).Value ="0";
                    dsdulieu.sql_cmd.ExecuteNonQuery();
                    dsdulieu.sql_con.Close();
                    string command2 = "UPDATE account SET numborrow=numborrow-1 WHERE accountname='" + row.Cells[0].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command2);
                    string command3 = "UPDATE book SET numbook=numbook+1 WHERE codebook='" + row.Cells[1].Value.ToString()+"'";
                    dsdulieu.ExecuteQuery(command3);
                    string command4 = "DELETE FROM bookborrow WHERE accountname='" + row.Cells[0].Value.ToString() + "' and codebook='" + row.Cells[1].Value.ToString() + "' and dayborrow='" + row.Cells[2].Value.ToString() + "'";
                    dsdulieu.ExecuteQuery(command4);
                    MessageBox.Show("Returning book is successful !", "Notification");
                    break;
                }
            }
            if (kq == 0) { MessageBox.Show("Please choose a row borrow to return !", "Notification"); }
        }

        private void butsearchre_Click(object sender, EventArgs e)
        {
            if(textsearchre.Text!="")
            {
                if(radioaccnamere.Checked)
                {
                    string command= "SELECT bookrequest.accountname,bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type FROM bookrequest,book WHERE bookrequest.codebook=book.codebook and bookrequest.accountname like '%" + textsearchre.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridrequest.DataSource = dsdulieu.DT;
                    setnamecolumnre();
                }
                if(radiobooknamere.Checked)
                {
                    string command = "SELECT bookrequest.accountname,bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type FROM bookrequest,book WHERE bookrequest.codebook=book.codebook and book.bookname like '%" + textsearchre.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridrequest.DataSource = dsdulieu.DT;
                    setnamecolumnre();
                }
                if(radiocodebookre.Checked)
                {
                    string command = "SELECT bookrequest.accountname,bookrequest.codebook,bookrequest.dayrequest,book.bookname,book.author,book.type FROM bookrequest,book WHERE bookrequest.codebook=book.codebook and book.codebook like '%" + textsearchre.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridrequest.DataSource = dsdulieu.DT;
                    setnamecolumnre();
                }
            }
            else { MessageBox.Show("Please type infomation of request to search !", "Notification"); }
        }

        private void butsearchbo_Click(object sender, EventArgs e)
        {
            if(textsearchbo.Text!="")
            {
                if(radioaccnamebo.Checked)
                {
                    string command = "select bookborrow.accountname, bookborrow.codebook, bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine,book.bookname from bookborrow,book where bookborrow.codebook=book.codebook and bookborrow.accountname like '%" + textsearchbo.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridborrow.DataSource = dsdulieu.DT;
                    setnamecolumnbo();
                }
                if(radiobooknamebo.Checked)
                {
                    string command = "select bookborrow.accountname, bookborrow.codebook, bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine,book.bookname from bookborrow,book where bookborrow.codebook=book.codebook and book.bookname like '%" + textsearchbo.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridborrow.DataSource = dsdulieu.DT;
                    setnamecolumnbo();
                }
                if(radiobookcodebo.Checked)
                {
                    string command = "select bookborrow.accountname, bookborrow.codebook, bookborrow.dayborrow,bookborrow.dayreturn,bookborrow.fine,book.bookname from bookborrow,book where bookborrow.codebook=book.codebook and book.codebook like '%" + textsearchbo.Text + "%'";
                    DataSet ds = new DataSet();
                    dsdulieu.filltertable(command, ds);
                    dataGridborrow.DataSource = dsdulieu.DT;
                    setnamecolumnbo();
                }
            }
            else { MessageBox.Show("Please type infomation of borrowing to search !", "Notification"); }
        }
    }
}
