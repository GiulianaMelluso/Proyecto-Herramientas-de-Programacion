using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyecto.Model
{
    public class Member
    {
        public String Name {get;set;}
        public DateTime RegistrationDate {get;set;}
        public int MemberId {get;set;}
    }
}
