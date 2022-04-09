using System.Collections.Generic;
using System.Linq;
using Proyecto.Model;

namespace Proyecto.Services
{
    public class BookService : IBookService
    {

        private List<Book> Books;
        public BookService()
        {
            Books = new List<Book>(){
                new Book(){Title="Orgullo y Prejuicio", Author = "Jane Austen", Genre = "Romance", ISBN = 978 , Borrowed = false},
                new Book(){Title="Los Miserables", Author = "Víctor Hugo", Genre = "Novela", ISBN = 478 , Borrowed = true},
                new Book(){Title="La Divina Comedia", Author = "Dante Alighieri", Genre = "Epopeya", ISBN = 595 , Borrowed = false},
                new Book(){Title="Cien años de Soledad", Author = "Gabriel García Márquez", Genre = "Realismo mágico", ISBN = 856 , Borrowed = true},
                new Book(){Title="El Principito", Author = "Antoine de Saint-Exupéry", Genre = "Novela infantil", ISBN = 246 , Borrowed = false},
                new Book(){Title="Un mundo feliz", Author = "Aldous Huxley", Genre = "Ficción distópica", ISBN = 113 , Borrowed = true}
            };
        }

        List<Book> IBookService.ShowAll()
        {
            return Books;
        }
        public void Create(Book book)
        {
            Books.Add(book);
        }

        public void Delete(Book book)
        {
            var prevBook = Books.Where(x => x.ISBN == book.ISBN).FirstOrDefault();
            Books.Remove(prevBook);
        }

        public void Update(Book book)
        {
            var prevBook = Books.Where(x=> x.ISBN==book.ISBN).FirstOrDefault();
            Books.Remove(prevBook);
            Books.Add(book);
        }
    }
}