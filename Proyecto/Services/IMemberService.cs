using Proyecto.Model;
using System.Collections.Generic;

namespace Proyecto.Services
{
    public interface IMemberService
    {
        List<Member> ShowAll();
        void Create(Member member);

        void Delete(Member member);

        void Update(Member member);
    }
}