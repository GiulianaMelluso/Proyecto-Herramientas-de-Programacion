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
    public class BookListModel : PageModel
    {
        [BindProperty]
        public List<Book> Books{get;set;}

        [BindProperty]
        public Book NewBook {get;set;}
        private IBookService _bookService;

        public BookListModel(IBookService bookService){
            _bookService = bookService;
        }
        public void OnGet(string order)
        {
            Books=_bookService.ShowAll().ToList();

            if(order=="ByTitle"){
                Books=Books.OrderBy(x=>x.Title).ToList();
            }
            else if(order=="ByAuthor")
            {
                Books=Books.OrderBy(x=>x.Author).ToList();
            }
            else if(order=="ByGenre")
            {
                Books=Books.OrderBy(x=>x.Genre).ToList();
            }
            else if(order=="ByState")
            {
                Books=Books.OrderBy(x=>x.Borrowed).ToList();
            }
            else
            {
                Books=Books.OrderBy(x=>x.ISBN).ToList();
            }

        }

    }
}
