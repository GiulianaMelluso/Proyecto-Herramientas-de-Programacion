using System.Collections.Generic;
using Proyecto.Model;
using System;
using System.Linq;

namespace Proyecto.Services
{
    public class MemberService:IMemberService
    {

        private List<Member> Members;

        public MemberService()
        {
            Members = new List<Member>(){

                new Member(){Name="Gerardo Gomez", RegistrationDate=new DateTime(2001,02,25), MemberId=1},
                new Member(){Name="Grisel Gallardo", RegistrationDate=new DateTime(1999,09,18), MemberId=2},
                new Member(){Name="Guillermina Gutierrez", RegistrationDate=new DateTime(2011,04,30), MemberId=3},
                new Member(){Name="Gabriel Garibaldi", RegistrationDate=new DateTime(1994,11,28), MemberId=4},
            };
        }

        public List<Member> ShowAll()
        {
           return Members;
        }

        public void Create(Member member)
        {
            Members.Add(member);
        }

        public void Delete(Member member)
        {
            var prevMem = Members.Where(x => x.MemberId == member.MemberId).FirstOrDefault();
            Members.Remove(prevMem);
        }

    
        public void Update(Member member)
        {
            var prevMem = Members.Where(x => x.MemberId == member.MemberId).FirstOrDefault();
            Members.Remove(prevMem);
            Members.Add(member);
        }
    }
}
