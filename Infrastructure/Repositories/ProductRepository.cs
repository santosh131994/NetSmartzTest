using NetSmartz.Core.Repositories;
using NetSmartz.Infrastructure.Data;
using NetSmartz.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetSmartz.Infrastructure.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private NetSmartzContext _dataContext;

        public ProductRepository(NetSmartzContext netSmartzContext)
        {
            _dataContext = netSmartzContext;
        }
        public List<Product> Get()
        {
            return _dataContext.Products.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();
        }
        public Product Create(Product product)
        {
            _dataContext.Products.Add(product);
            _dataContext.SaveChanges();
            return product;
        }

        public int Delete(Product product)
        {
            _dataContext.Products.Update(product);
            return _dataContext.SaveChanges();

        }

        public Product Update(Product product)
        {
            _dataContext.Products.Update(product);
            _dataContext.SaveChanges();
            return product;
        }

    }
}
