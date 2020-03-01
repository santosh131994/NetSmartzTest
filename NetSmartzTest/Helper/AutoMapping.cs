using AutoMapper;
using NetSmartz.Application.Models;
using NetSmartz.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetSmartz.Web.Helper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<CategoryModel, Category>();
            CreateMap<Category, CategoryModel>();

            CreateMap<ProductModel, Product>();
            CreateMap<Product, ProductModel>();

        }
    }
}
