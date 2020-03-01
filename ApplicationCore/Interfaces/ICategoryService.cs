using NetSmartz.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetSmartz.Application.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryModel> Get();

        CategoryModel AddUpdate(CategoryModel categoryModel);
        int Delete(int id);

    }
}
