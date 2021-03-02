using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace CSDB
{
    class Gakusei : Model
    {
        string strAccessSelect = "SELECT * FROM gakusei";
        string gakusekino;
        string gakkacode;
        long gakunen;
        string gclass;
        string gname;
        double gshusseki;

        public Gakusei(){}

        public Gakusei(string gakusekino, string gakkacode, long gakunen, string gclass, string gname, double gshusseki)
        {
            this.Gakusekino = gakusekino;
            this.Gakkacode = gakkacode;
            this.Gakunen = gakunen;
            this.Gclass = gclass;
            this.Gname = gname;
            this.Gshusseki = gshusseki;
        }

        public string Gakusekino { get => gakusekino; set => gakusekino = value; }
        public string Gakkacode { get => gakkacode; set => gakkacode = value; }
        public long Gakunen { get => gakunen; set => gakunen = value; }
        public string Gclass { get => gclass; set => gclass = value; }
        public string Gname { get => gname; set => gname = value; }
        public double Gshusseki { get => gshusseki; set => gshusseki = value; }

        public List<Gakusei> getAll()
        {
            List<Gakusei> results = new List<Gakusei>();
            OleDbCommand comm = getQueryExecute(strAccessSelect);
            myAccessConn.Open();
            OleDbDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                reader.GetString(0);
                reader.GetString(1);
                reader.GetInt32(2);
                reader.GetString(3);
                reader.GetString(4);
                reader.GetDouble(5);
                results.Add(
                    new Gakusei(
                        reader.GetString(0), 
                        reader.GetString(1), 
                        reader.GetInt32(2), 
                        reader.GetString(3), 
                        reader.GetString(4), 
                        reader.GetDouble(5)
                        )
                    );
            }
            return results;
        }
        public override string ToString()
        {
            return String.Format("[{0}, {1}, {2}, {3}, {4}, {5}]",this.Gakusekino,this.Gakkacode,this.Gakunen,this.Gclass,this.Gname,this.Gshusseki);
        }
    }
}