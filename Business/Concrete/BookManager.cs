using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class BookManager:IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        [ValidationAspect(typeof(BookValidator))]
        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        [ValidationAspect(typeof(BookValidator))]
        public void Update(Book book)
        {
            _bookDal.Update(book);
        }

        [ValidationAspect(typeof(BookValidator))]
        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<BookDetailsDto> GetBookDetails()
        {
           return _bookDal.GetBookDetails();
        }

        public List<Book> GetByBookTitle(string title)
        {
            return _bookDal.GetAll(b => b.BookTitle.ToLower().Contains(title.ToLower()));
        }

        public List<Book> GetByCategory(int categoryId)
        {
            return _bookDal.GetAll(b => b.CategoryId == categoryId);
        }

        public List<Book> GetByAuthor(int authorId)
        {
            return _bookDal.GetAll(b => b.AuthorId == authorId);
        }

        public List<Book> GetByLanguage(string language)
        {
            return _bookDal.GetAll(b => b.Language.ToLower().Contains(language.ToLower()));
        }

        public List<Book> GetByPrice(decimal min, decimal max)
        {
            return _bookDal.GetAll(b => b.Price >= min & b.Price <= max);
        }

       
    }
}
