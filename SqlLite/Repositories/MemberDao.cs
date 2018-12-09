using SqlLite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite.Repositories
{
    public class MemberDao : BaseDao
    {
        public MemberDao()
        {

        }

        public bool Create(Member entity)
        {
            string query = string.Format(@"INSERT INTO Member (Name, Contact) VALUES ('{0}','{1}')", entity.Name, entity.Contact);
            ExecuteQuery_Operation(query);
            return true;
        }

        internal List<Member> LoadMember()
        {
            string query = "SELECT * FROM Member";
            var reader = ExecuteQuery_ReadData(query);
            return DrawData(reader);
        }

        private List<Member> DrawData(System.Data.SQLite.SQLiteDataReader reader)
        {
            List<Member> memberList = new List<Member>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int i = 0;
                    Member row = new Member();
                    row.ID = reader.GetInt32(i++);
                    row.Name = reader.GetString(i++);
                    row.Contact = reader.GetString(i++);
                    memberList.Add(row);
                }
            }

            return memberList;
        }
    }
}
