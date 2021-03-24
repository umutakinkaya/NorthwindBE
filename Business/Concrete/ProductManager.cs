using Business.Abstract;
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
        public void Add(Product product)
        {
            _productDao.Add(product);
        }

        public void Delete(Product product)
        {
            _productDao.Delete(product);
        }

        public Product GetById(int productId)
        {
            return _productDao.Get(filter: p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            return _productDao.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDao.GetList(filter: p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            _productDao.Update(product);
        }
    }
}
