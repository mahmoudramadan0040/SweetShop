﻿namespace ProjectCourse1.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PieShopDbContext _pieShopDbContext;

        public CategoryRepository(PieShopDbContext pieShopDbContext)
        {
            _pieShopDbContext = pieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _pieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
