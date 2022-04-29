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
    public class CreateModel : PageModel
    {

        [BindProperty]
        public Book NewBook { get; set; }

        private IBookService _bookService;
        private IMemberService _memberService;

        public CreateModel(IBookService bookService, IMemberService memberService)
        {
            _bookService = bookService;
            _memberService = memberService;
        }

        public void OnGet()
        {
            var members=_memberService.ShowAll();
            ViewData["Members"] = new SelectList(members,"MemberId","Name");

        }   

        public IActionResult OnPost()
        {
            if(ModelState.IsValid){
                _bookService.Create(NewBook);
                return RedirectToPage("BookList");
            }
            return Page();
        }
    }
}
