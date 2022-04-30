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

        public UpdateModel(IBookService bookService){
            _bookService=bookService;
        }
        public void OnGet(int isbn)
        {
            SBook = _bookService.ShowAll().Where(x=> x.ISBN==isbn).First();

        }

        public IActionResult OnPost(){
            _bookService.Update(SBook);
            return RedirectToPage("BookList");
        }
    }
}
