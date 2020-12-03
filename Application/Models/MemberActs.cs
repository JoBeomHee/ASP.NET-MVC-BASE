using Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class MemberActs
    {
        public Member GetMembers(int number)
        {
            MemberData members = new MemberData();

            var member = members.Members.Where(x => x.Member_Number == number)
                .SingleOrDefault();

            return member;
        }
    }
}