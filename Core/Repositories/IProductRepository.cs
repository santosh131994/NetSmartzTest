using NetSmartz.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetSmartz.Core.Repositories
{
    public interface IProductRepository
    {
        List<Product> Get();
        Product Create(Product product);
        Product Update(Product product);
        int Delete(Product product);
    }
}
