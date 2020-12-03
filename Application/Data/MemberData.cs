using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data
{
    public class MemberData
    {
        public List<Member> Members
        {
            get
            {
                return new List<Member>
                {
                    new Member{ Member_Number = 1, Id = "ID #1", Name = "이름 #1", Password = "비밀번호 #1"},
                    new Member{ Member_Number = 2, Id = "ID #2", Name = "이름 #2", Password = "비밀번호 #2"},
                    new Member{ Member_Number = 3, Id = "ID #3", Name = "이름 #3", Password = "비밀번호 #3"},
                    new Member{ Member_Number = 4, Id = "ID #4", Name = "이름 #4", Password = "비밀번호 #4"},
                    new Member{ Member_Number = 5, Id = "ID #5", Name = "이름 #5", Password = "비밀번호 #5"},
                    new Member{ Member_Number = 6, Id = "ID #6", Name = "이름 #6", Password = "비밀번호 #6"}
                };
            }
        }
    }
}