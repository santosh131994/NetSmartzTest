using NetSmartz.Core.Repositories;
using NetSmartz.Infrastructure.Data;
using NetSmartz.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetSmartz.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private NetSmartzContext _dataContext;

        public CategoryRepository(NetSmartzContext netSmartzContext)
        {
            _dataContext = netSmartzContext;
        }
        public List<Category> Get()
        {
           return _dataContext.Categories.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();
        }
        public Category Create(Category category)
        {
            _dataContext.Categories.Add(category);
            _dataContext.SaveChanges();
            return category;
        }

        public int Delete(Category category)
        {
             _dataContext.Categories.Update(category);
            return _dataContext.SaveChanges();

        }

        public Category Update(Category category)
        {
            _dataContext.Categories.Update(category);
            _dataContext.SaveChanges();
            return category;
        }
    }
}
