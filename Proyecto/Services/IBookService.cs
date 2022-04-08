using System.Collections.Generic;
using Proyecto.Model;

namespace Proyecto.Services
{
    public interface IBookService
    {
        List<Book> ShowAll();
        void Create(Book book);

        void Delete(Book book);

        void Update(Book book);
    }
}