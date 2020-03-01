using AutoMapper;
using NetSmartz.Application.Interfaces;
using NetSmartz.Application.Models;
using NetSmartz.Core.Repositories;
using NetSmartz.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetSmartz.Application.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _iProductRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _iProductRepository = productRepository;
            _mapper = mapper;
        }
        public List<ProductModel> Get()
        {
            try
            {
                var result = _iProductRepository.Get();

                return _mapper.Map<List<ProductModel>>(result);
            }
            catch (Exception)
            {
                throw new ApplicationException($"something went wrong.");

            }
        }

        public ProductModel AddUpdate(ProductModel productModel)
        {
            
            try
            {
                dynamic result;
                var Category = _mapper.Map<Product>(productModel);
                if (Category == null)
                    throw new ApplicationException($"Entity could not be mapped.");
                Category.createdOn = DateTime.Now;
                Category.IsActive = true;
                Category.IsDeleted = false;
                if (productModel.ProductId > 0)
                {
                    var data = _iProductRepository.Update(Category);
                    result = _mapper.Map<ProductModel>(data);
                    result.Message = "Updated successfully";
                }
                else
                {
                    var data = _iProductRepository.Create(Category);
                    result = _mapper.Map<ProductModel>(data);
                    result.Message = "added successfully";
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"something went wrong.");
            }

        }

        public int Delete(int id)
        {
            try
            {
                var result = _iProductRepository.Get().Where(x => x.ProductId == id).FirstOrDefault();
                result.IsDeleted = true;
                return _iProductRepository.Delete(result);

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"something went wrong.");

            }
        }

    }
}
