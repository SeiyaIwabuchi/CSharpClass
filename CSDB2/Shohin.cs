using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CSDB2
{
    class Shohin : Model
    {
        //strAccessInsert = "INSERT INTO shohin(pro_code,pro_name,pro_price)"+ " VALUES('" + textBox1.Text + "','"+ textBox2.Text + "',"+ textBox3.Text +  ")";
        string pro_code;
        string pro_name;
        int pro_price;
        public static string excutedSql = "";

        public Shohin() { }
        public Shohin(string pro_code, string pro_name, int pro_price)
        {
            this.pro_code = pro_code;
            this.pro_name = pro_name;
            this.pro_price = pro_price;
        }

        public string Pro_code { get => pro_code; set => pro_code = value; }
        public string Pro_name { get => pro_name; set => pro_name = value; }
        public int Pro_price { get => pro_price; set => pro_price = value; }

        public static List<Shohin> getAll()
        {
            string strAccessSelect = "SELECT * FROM shohin";
            excutedSql = strAccessSelect;
            List<Shohin> results = new List<Shohin>();
            OleDbCommand comm = getQueryExecute(strAccessSelect);
            myAccessConn.Open();
            OleDbDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                reader.GetString(0);
                reader.GetString(1);
                reader.GetInt16(2);
                results.Add(
                    new Shohin(
                        reader.GetString(0), 
                        reader.GetString(1), 
                        reader.GetInt16(2)
                        )
                    );
            }
            if (myAccessConn.State != ConnectionState.Closed)
            {
                myAccessConn.Close();
            }
            return results;
        }
        public static void insert(string pro_code, string pro_name, int pro_price)
        {
            string strAccessInsert = string.Format(
                "insert into shohin values({0},{1},{2})",
                pro_code,pro_name,pro_price
                );
            excutedSql = strAccessInsert;
            myAccessConn.Open();
            OleDbCommand cmd = new OleDbCommand(strAccessInsert, myAccessConn);
            cmd.ExecuteNonQuery();
            if(myAccessConn.State != ConnectionState.Closed)
            {
                myAccessConn.Close();
            }
        }


        public void update(string pro_code, string pro_name, int pro_price)
        {
            string strAccessInsert = string.Format(
                "update shohin set pro_code={0} pro_name={1} pro_price={2} where pro_code={0}",
                pro_code, pro_name, pro_price, this.pro_code
                );
            excutedSql = strAccessInsert;
            myAccessConn.Open();
            OleDbCommand cmd = new OleDbCommand(strAccessInsert, myAccessConn);
            cmd.ExecuteNonQuery();
            if (myAccessConn.State != ConnectionState.Closed)
            {
                myAccessConn.Close();
            }
        }

        public void delete()
        {
            string strAccessInsert = string.Format(
                "delete from shohin where pro_code={0}",
                this.pro_code
                );
            excutedSql = strAccessInsert;
            myAccessConn.Open();
            OleDbCommand cmd = new OleDbCommand(strAccessInsert, myAccessConn);
            cmd.ExecuteNonQuery();
            if (myAccessConn.State != ConnectionState.Closed)
            {
                myAccessConn.Close();
            }
        }

        public static List<Shohin> extractByCondition(string pro_code, string pro_name = "", int pro_price = 0)
        {
            string strAccessSelect = string.Format(
                "SELECT * FROM shohin where pro_code='{0}' or pro_name='{1}' or pro_price={2}",
                pro_code, pro_name, pro_price
                );
            excutedSql = strAccessSelect;
            List<Shohin> results = new List<Shohin>();
            OleDbCommand comm = getQueryExecute(strAccessSelect);
            myAccessConn.Open();
            OleDbDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                reader.GetString(0);
                reader.GetString(1);
                reader.GetInt16(2);
                results.Add(
                    new Shohin(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetInt16(2)
                        )
                    );
            }
            if (myAccessConn.State != ConnectionState.Closed)
            {
                myAccessConn.Close();
            }
            return results;
        }
        public override string ToString()
        {
            return String.Format("[{0},\t{1},\t\\{2}\t]",this.pro_code,this.pro_name,this.pro_price);
        }
    }
}