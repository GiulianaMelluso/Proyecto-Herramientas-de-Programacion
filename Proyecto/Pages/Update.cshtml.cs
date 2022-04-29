using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.Model;
using Proyecto.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Proyecto.Pages
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public Book SBook {get;set;}
        private IBookService _bookService;
        private IMemberService _memberService;

        public UpdateModel(IBookService bookService,IMemberService memberService){
            _bookService=bookService;
            _memberService=memberService;
        }
        public void OnGet(int isbn)
        {
            SBook = _bookService.ShowAll().Where(x=> x.ISBN==isbn).First();

            var members=_memberService.ShowAll();
            ViewData["Members"] = new SelectList(members,"MemberId","Name");
        
        }

        public IActionResult OnPost(){
            _bookService.Update(SBook);
            return RedirectToPage("BookList");
        }
    }
}
