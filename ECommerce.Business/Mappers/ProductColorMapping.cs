using ECommerce.Core.Entities;
using ECommerce.DTO.ProductColor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Mappers
{
    public static class ProductColorMapping
    {
        public static ProductColorDTO ToProductColorDto(this ProductColor productColor)
        {
            return new ProductColorDTO
            {
                ProductId = productColor.ProductId,
                Color = productColor.Color,
                Id = productColor.Id,
                IsAvailable = productColor.IsAvailable,
            };
        }
    }
}
