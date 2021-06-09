using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        List<BookDetailsDto> GetBookDetails();
        List<Book> GetByBookTitle(string title);
        List<Book> GetByCategory(int categoryId);
        List<Book> GetByAuthor(int authorId);
        List<Book> GetByLanguage(string language);
        List<Book> GetByPrice(decimal min, decimal max);
        
    }
}
