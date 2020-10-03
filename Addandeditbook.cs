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
    public partial class Addandeditbook : Form
    {
        string codebook;
        int trangthai;
        database dsdulieu = new database();
        public Addandeditbook()
        {
            InitializeComponent();
            trangthai = 0;
        }
        public Addandeditbook(string code)
        {
            InitializeComponent();
            codebook = code;
            trangthai = 1;
            dsdulieu.getbookbycode(codebook);
            DataRow rows = dsdulieu.DT.Rows[0];
            textcodebook.Text =code;
            textcodebook.Enabled = false;
            textnamebook.Text= rows["bookname"].ToString();
            textauthor.Text = rows["author"].ToString();
            texttype.Text = rows["type"].ToString();
            textpublisher.Text = rows["publisher"].ToString();
            textpubyear.Text = rows["pubyear"].ToString();
            textnumbook.Text = rows["numbook"].ToString();
            textprice.Text = rows["price"].ToString();
        }
        private void butcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Attention !", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
       }
       private void butok_Click(object sender, EventArgs e)
        {
            if(trangthai==0)
            {
                int kq = 0;int chuyenso;
                dsdulieu.getbookbycode(textcodebook.Text);
                if(dsdulieu.DT.Rows.Count>0)
                {
                    kq = 1;
                    MessageBox.Show("Redumplication of Book Code", "Attention");
                }
                if(!int.TryParse(textnumbook.Text,out chuyenso))
                {
                    kq = 2;
                    MessageBox.Show("The number of Books must be a number", "Attention");
                }
                if(!int.TryParse(textpubyear.Text, out chuyenso))
                {
                    kq = 3;
                    MessageBox.Show("The Publishing year must be a number", "Attention");
                }
                if(!int.TryParse(textprice.Text, out chuyenso))
                {
                    kq = 3;
                    MessageBox.Show("The Price of Book must be a number", "Attention");
                }
                if(kq==0)
                {
                    dsdulieu.setconnect();
                    string command = "INSERT INTO book (codebook,bookname,author,type,publisher,pubyear,status,numbook,price) VALUES(@codebook,@bookname,@author,@type,@publisher,@pubyear,@status,@numbook,@price)";
                    dsdulieu.sql_cmd = new System.Data.SQLite.SQLiteCommand(command, dsdulieu.sql_con);
                    dsdulieu.sql_cmd.Parameters.Add("@codebook", System.Data.DbType.Int32).Value = textcodebook.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@bookname", System.Data.DbType.String).Value = textnamebook.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@author", System.Data.DbType.String).Value = textauthor.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@type", System.Data.DbType.String).Value = textauthor.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@publisher", System.Data.DbType.String).Value = textpublisher.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@pubyear", System.Data.DbType.Int32).Value = textpubyear.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@status", System.Data.DbType.Int32).Value ="0";
                    dsdulieu.sql_cmd.Parameters.Add("@numbook", System.Data.DbType.Int32).Value = textnumbook.Text;
                    dsdulieu.sql_cmd.Parameters.Add("@price", System.Data.DbType.Int32).Value = textprice.Text;
                    dsdulieu.sql_cmd.ExecuteNonQuery();
                    dsdulieu.sql_con.Close();
                    MessageBox.Show("Adding a new book is successful !", "Notification");
                    this.Close();
                }
            }
            if(trangthai==1)
            {
                int kq = 0; int chuyenso;
                dsdulieu.getbookbycode(textcodebook.Text);
                DataRow rows = dsdulieu.DT.Rows[0];
                if (!int.TryParse(textnumbook.Text, out chuyenso))
                {
                    kq = 2;
                    MessageBox.Show("The number of Books must be a number", "Attention");
                }
                if (!int.TryParse(textpubyear.Text, out chuyenso))
                {
                    kq = 3;
                    MessageBox.Show("The Publishing year must be a number", "Attention");
                }
                if (!int.TryParse(textprice.Text, out chuyenso))
                {
                    kq = 3;
                    MessageBox.Show("The Price of Book must be a number", "Attention");
                }
                if(kq==0)
                {
                    string command = "UPDATE book SET codebook='" + textcodebook.Text + "',bookname='" + textnamebook.Text + "',author='" + textauthor.Text + "',type='" + texttype.Text + "',publisher='" + textpublisher.Text + "',pubyear='" + textpubyear.Text + "',status='" + rows["status"] + "',numbook='" + textnumbook.Text + "',price='"+textprice.Text+"' WHERE codebook='" + codebook + "'";
                    dsdulieu.ExecuteQuery(command);
                    MessageBox.Show("Editing this book is successful !", "Notification !");
                    this.Close();
                }
            }
        }
    }
}
