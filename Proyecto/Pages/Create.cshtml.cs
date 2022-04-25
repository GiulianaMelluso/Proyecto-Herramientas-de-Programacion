using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.Model;
using Proyecto.Services;

namespace Proyecto.Pages
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public Book NewBook { get; set; }

        private IBookService _bookService;

        public CreateModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void OnGet()
        {

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
