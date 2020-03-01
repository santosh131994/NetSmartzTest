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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _iCategoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _iCategoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public List<CategoryModel> Get()
        {
            try
            {
                var result = _iCategoryRepository.Get();

                return _mapper.Map<List<CategoryModel>>(result);
            }
            catch (Exception)
            {
                throw new ApplicationException($"something went wrong.");

            }
        }
     
        public CategoryModel AddUpdate(CategoryModel categoryModel)
        {
           
            try
            {
                dynamic result;
                var Category = _mapper.Map<Category>(categoryModel);
                if (Category == null)
                throw new ApplicationException($"Entity could not be mapped.");
                Category.createdOn = DateTime.Now;
                Category.IsActive = true;
                Category.IsDeleted = false;
                if (categoryModel.CategoryId > 0)
                {
                    var data = _iCategoryRepository.Update(Category);
                    result=  _mapper.Map<CategoryModel>(data);
                    result.Message = "Updated successfully";
                }
                else {
                    var data = _iCategoryRepository.Create(Category);
                    result = _mapper.Map<CategoryModel>(data);
                    result.Message = "added successfully";
                }

                return result;
            }
            catch(Exception ex)
            {
                throw new ApplicationException($"something went wrong.");
            }
         
        }

        public int Delete(int id)
        {
            try
            {
                var result = _iCategoryRepository.Get().Where(x => x.CategoryId == id).FirstOrDefault();
                result.IsDeleted = true;
               return  _iCategoryRepository.Delete(result);

            }
            catch (Exception ex )
            {
                throw new ApplicationException($"something went wrong.");

            }
        }

    }
}
