using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        void Add(Author author);
        void Update(Author author);
        void Delete(Author author);
    }
}