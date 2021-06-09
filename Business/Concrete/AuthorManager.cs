using System.Collections.Generic;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AuthorManager:IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public void Update(Author author)
        {
            _authorDal.Update(author);
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }
    }
}