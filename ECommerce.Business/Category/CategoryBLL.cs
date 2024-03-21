using ECommerce.Business.Mappers;
using ECommerce.DTO.Category;
using ECommerce.Repository.Repositories.Category;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Category
{
    public class CategoryBLL : BaseBLL, ICategoryBLL
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryBLL(CategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }
        public Task<List<VIPCategoryDTO>> GetVIPCategories()
        {
            return _categoryRepository.FindAll(c => c.IsVIP)
                .Select(category => category.ToVIPCategoryDto())
                .ToListAsync();
        }
    }
}
