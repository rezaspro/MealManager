using SqlLite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite.Repositories
{
    public class MealDao : BaseDao
    {
        public MealDao()
        {

        }

        public bool Create(Meal entity)
        {
            string query = string.Format(@"INSERT INTO Member (Name, Contact) VALUES ('{0}','{1}')", entity.Name, entity.Contact);
            ExecuteQuery_Operation("");
            return true;
        }

        internal List<Meal> LoadMember()
        {
            string query = "SELECT * FROM Member";
            var reader = ExecuteQuery_ReadData(query);
            return DrawData(reader);
        }

        private List<Meal> DrawData(System.Data.SQLite.SQLiteDataReader reader)
        {
            List<Meal> memberList = new List<Meal>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int i = 0;
                    Meal row = new Meal();
                    row.ID = reader.GetInt32(i++);
                    //row.Name = reader.GetString(i++);
                    //row.Contact = reader.GetString(i++);
                    memberList.Add(row);
                }
            }

            return memberList;
        }
    }
}
