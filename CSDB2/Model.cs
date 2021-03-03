using System;
using System.Data.OleDb;

namespace CSDB2
{
    class Model : Database
    {
        public string tableName;
        public static OleDbCommand getQueryExecute(string strAccessSelect)
        {
            try
            {
                return new OleDbCommand(strAccessSelect, myAccessConn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myAccessConn.Close();
            }
        }
    }
}