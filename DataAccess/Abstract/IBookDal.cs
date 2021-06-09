using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IBookDal:IEntityRepository<Book>
    {
        List<BookDetailsDto> GetBookDetails(Expression<Func<Book, bool>> filter = null);
    }
}
