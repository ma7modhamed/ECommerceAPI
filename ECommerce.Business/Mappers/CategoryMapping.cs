using ECommerce.Core.Entities;
using ECommerce.DTO.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Mappers
{
    public static class CategoryMapping
    {
        public static VIPCategoryDTO ToVIPCategoryDto(this Core.Entities.Category category)
        {
            return new VIPCategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                VIPStoreProductsAPiRes = category.Products.Select(p => p.ToVipProductDto()).ToList()
            };
        }

    }
}
