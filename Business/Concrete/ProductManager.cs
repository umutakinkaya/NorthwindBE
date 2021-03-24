using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDao _productDao;
        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }
        public IResult Add(Product product)
        {
            _productDao.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDao.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDao.Get(filter: p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDao.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDao.GetList(filter: p => p.CategoryId == categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDao.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
