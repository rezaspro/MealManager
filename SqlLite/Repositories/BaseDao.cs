using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite.Repositories
{
    public class BaseDao
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        //private SQLiteDataAdapter dataAdapter;
        private SQLiteDataReader reader;

        //public Sql MyProperty { get; set; }

        //private DataSet DS = new DataSet();
        //private DataTable DT = new DataTable();

        public void ExecuteQuery_Operation(string query)
        {
            connection = DbHelper.OpenDbConnection();
            command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public SQLiteDataReader ExecuteQuery_ReadData(string query)
        {
            connection = DbHelper.OpenDbConnection();
            command = connection.CreateCommand();
            if (query == "") return null;
            if (reader != null && !reader.IsClosed) reader.Close();
            command.CommandText = query;
            try
            {
                reader = command.ExecuteReader();
                return reader;

            }
            catch (Exception)
            {
                if (reader != null && !reader.IsClosed) reader.Close();
                connection.Close();
                return null;
            }
        }
    }
}
