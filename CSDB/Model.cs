using System;
using System.Data.OleDb;

namespace CSDB
{
    class Model : Database
    {
        public OleDbCommand getQueryExecute(string strAccessSelect)
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