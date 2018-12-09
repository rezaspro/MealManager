using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite
{
    public static class DbHelper
    {
        public const string DatabaseName = "Database.db";
        public static bool CreateDb()
        {
            try
            {
                var source = Environment.CurrentDirectory + "\\" + DatabaseName;
                if (!File.Exists(source))
                {
                    SQLiteConnection.CreateFile(source);
                    using (var sqliteConnection = new SQLiteConnection("Data Source=" + source + ";Version=3;"))
                    {
                        //sqliteConnection.SetPassword(DbPassword);
                        sqliteConnection.Open();
                        var command = new SQLiteCommand();
                        command.Connection = sqliteConnection;

                        //create attendancelog table
                        string attendanceLogsql = @"CREATE TABLE [User] 
                                                    (
                                                         [Id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT
                                                        ,[Name]  VARCHAR(50) NOT NULL
                                                        ,[Contact]  VARCHAR(50) NOT NULL
                                                 
                                                    )";
                        command.CommandText = attendanceLogsql;
                        command.ExecuteNonQuery();

                        sqliteConnection.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                //Log.Error(ex);
                throw ex;
            }
        }
        public static SQLiteConnection OpenDbConnection()
        {
            //var dbConnection = "data source= " + System.Environment.CurrentDirectory + "\\" + DbHelper.DatabaseName + ";Version=3;Password=" + DbHelper.DbPassword + ";";
            var dbConnection = "data source= " + System.Environment.CurrentDirectory + "\\" + DbHelper.DatabaseName + ";Version=3;";
            try
            {
                var sql_con = new SQLiteConnection(dbConnection);
                sql_con.Open();
                return sql_con;
            }
            catch (Exception ex)
            {
               // Log.Error(ex);
                throw;
            }
        }

    }
}
