using SqlLite.Models.Entities;
using SqlLite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite.Services
{
    public class MemberService
    {
        MemberDao memberDao = new MemberDao();

        public void Create(Member member)
        {
            memberDao.Create(member);
        }

        internal List<Member> LoadMember()
        {
           return memberDao.LoadMember();
        }
    }
}
