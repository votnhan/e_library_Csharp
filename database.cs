using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace libraryvdatabase
{
    class database
    {
        public SQLiteConnection sql_con;
        public SQLiteCommand sql_cmd;
        public SQLiteDataAdapter DB;
        public DataTable DT = new DataTable();
        public void setconnect()
        {
            sql_con = new SQLiteConnection("Data Source=librarydatabase.db;Version=3;New=False;Compress=True");
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
        }
        public void ExecuteQuery(string txtQuery)
        {
            setconnect();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        public void filltertable(string cmd,DataSet DS)
        {
            setconnect();
            DB = new SQLiteDataAdapter(cmd, sql_con);
            DS.Clear();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
        }
        public void getuserbycodeuser(string code)
        {
            setconnect();
            DataSet DS = new DataSet();
            string command = "SELECT * FROM user WHERE codeuser='" + code + "'";
            filltertable(command, DS);
            sql_con.Close();
        }
        public void getaccountbynameacc(string nameacc)
        {
            DataSet DS = new DataSet();
            string command = "SELECT * FROM account WHERE accountname='" + nameacc + "'";
            filltertable(command, DS);
         }
        public void getbookbycode(string code)
        {
            DataSet DS = new DataSet();
            string command = "SELECT * FROM book WHERE codebook='" + code + "'";
            filltertable(command, DS);
        }
        public string getrolebycode(string code)
        {
            string kq;
            if (code == "0") kq = "Manager";
            else if (code == "1") kq = "Librarian";
            else if (code == "2") kq = "Reader";
            else if (code == "3") kq = "Manager,Librarian";
            else if (code == "4") kq = "Manager,Reader";
            else if (code == "5") kq = "Librarian,Reader";
            else kq = "Manager,Librarian,Reader";
            return kq;
        }
        public string getstatusbycode(string status)
        {
            string kq;
            if (status == "0") kq = "Inactive";
            else kq = "Active";
            return kq;
        }
        public database()
        {
            
        }

    }
}
