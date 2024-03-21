using ECommerce.Core.Entities;
using ECommerce.DTO.ProductImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Mappers
{
    public static class ProductImageMapping
    {
        public static ProductImageDTO ToProductImageDto(this ProductImage productImage)
        {
            return new ProductImageDTO
            {
                ProductId = productImage.ProductId,
                Id = productImage.Id,
                ImageUrl = productImage.ImageUrl,
            };
        }
    }
}
