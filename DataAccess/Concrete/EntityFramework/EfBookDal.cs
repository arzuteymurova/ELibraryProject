using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal:EfEntityRepositoryBase<Book,ELibraryContext>,IBookDal
    {
        public List<BookDetailsDto> GetBookDetails(Expression<Func<Book, bool>> filter = null)
        {
            using (var context=new ELibraryContext())
            {
                var result = from b in context.Books
                    join a in context.Authors on b.AuthorId equals a.AuthorId
                    join c in context.Categories on b.CategoryId equals c.CategoryId
                    select new BookDetailsDto()
                    {
                        Id = b.BookId,
                        BookTitle = b.BookTitle,
                        AuthorName = a.Name,
                        CategoryName = c.CategoryName,
                        Language = b.Language,
                        Count = b.Count,
                        Price = b.Price
                    };
                return result.ToList();
            }
        }
    }
}
