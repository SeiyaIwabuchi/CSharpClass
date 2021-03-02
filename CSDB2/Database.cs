using System;
using System.Data.OleDb;

namespace CSDB2
{
    class Database
    {
        string strAccessConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDB2.accdb";
        protected static OleDbConnection myAccessConn = null;
        public Database()
        {
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}