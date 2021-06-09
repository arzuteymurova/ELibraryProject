using System.Collections.Generic;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
          return  _categoryDal.GetAll();
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public void Add(Category category)
        {
          _categoryDal.Add(category);
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public void Update(Category category)
        {
           _categoryDal.Update(category);
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}