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
        ModelString pro_code = new ModelString();
        ModelString pro_name = new ModelString();
        ModelInt pro_price = new ModelInt();
        public static string excutedSql = "";

        internal ModelString Pro_code { get => pro_code; set => pro_code = value; }
        internal ModelString Pro_name { get => pro_name; set => pro_name = value; }
        internal ModelInt Pro_price { get => pro_price; set => pro_price = value; }

        public Shohin()
        {
            this.tableName = GetType().Name;
            this.pro_code.ColName = nameof(this.pro_code);
            this.pro_name.ColName = nameof(this.pro_name);
            this.pro_price.ColName = nameof(this.pro_price);
        }

        public Shohin(string pro_code="", string pro_name="", int pro_price=0)
        {
            this.tableName = GetType().Name;
            this.pro_code.ColName = nameof(this.pro_code);
            this.pro_name.ColName = nameof(this.pro_name);
            this.pro_price.ColName = nameof(this.pro_price);
            this.pro_code += pro_code;
            this.pro_name += pro_name;
            this.pro_price += pro_price;
        }



        public static List<Shohin> getAll()
        {
            Shohin dummy = new Shohin();
            string strAccessSelect = 
                SqlBuilder.select(
                    new ModelColumn[]{
                        dummy.pro_code,
                        dummy.pro_name,
                        dummy.pro_price
                    },
                    typeof(Shohin));
            excutedSql += strAccessSelect + "\r\n";
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
        public void insert()
        {
            string strAccessInsert = SqlBuilder.insert(
                new [] { 
                    string.Format("'{0}'",pro_code.ToString()),
                    string.Format("'{0}'",pro_name.ToString()),
                    pro_price.ToString() 
                },
                typeof(Shohin)
                );
            excutedSql += strAccessInsert + "\r\n";
            myAccessConn.Open();
            OleDbCommand cmd = new OleDbCommand(strAccessInsert, myAccessConn);
            cmd.ExecuteNonQuery();
            if(myAccessConn.State != ConnectionState.Closed)
            {
                myAccessConn.Close();
            }
        }


        public void update(Shohin newItem)
        {
            string strAccessInsert = 
                SqlBuilder.update(
                    new[]
                    {
                        string.Format("{0}='{1}'",newItem.pro_code.ColName,newItem.pro_code.ToString()),
                        string.Format("{0}='{1}'",newItem.pro_name.ColName,newItem.pro_name.ToString()),
                        string.Format("{0}={1}",newItem.pro_price.ColName,newItem.pro_price.ToString()),
                    },
                    typeof(Shohin),
                    pro_code == pro_code.value
                    );
            excutedSql += strAccessInsert + "\r\n";
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
            string strAccessInsert = SqlBuilder.delete(typeof(Shohin), this.pro_code == this.pro_code.value);
            excutedSql += strAccessInsert + "\r\n";
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
            Shohin dummy = new Shohin();
            string strAccessSelect =
                SqlBuilder.select(
                    new ModelColumn[]{
                        dummy.pro_code,
                        dummy.pro_name,
                        dummy.pro_price
                    },
                    typeof(Shohin),
                    dummy.pro_code == pro_code | dummy.pro_name == pro_name | dummy.pro_price == pro_price
                    );
            excutedSql += strAccessSelect + "\r\n";
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