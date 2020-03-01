using NetSmartz.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetSmartz.Core.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> Get();
        Category Create(Category category);
        Category Update(Category category);
        int Delete(Category category);

    }
}
