using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        private ICategoryDao _categoryDao;

        public CategoryManager(ICategoryDao categoryDao)
        {
            _categoryDao = categoryDao;
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDao.GetList().ToList());
        }
    }
}
