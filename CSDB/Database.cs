using System;
using System.Data.OleDb;

namespace CSDB
{
    class Database
    {
        string strAccessConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDB.accdb";
        protected OleDbConnection myAccessConn = null;
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