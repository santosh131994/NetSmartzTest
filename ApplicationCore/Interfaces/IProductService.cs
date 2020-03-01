using NetSmartz.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetSmartz.Application.Interfaces
{
    public interface IProductService
    {
        List<ProductModel> Get();
        ProductModel AddUpdate(ProductModel productModel);
        int Delete(int id);


    }
}
