using ECommerce.Core.Entities;
using ECommerce.DTO.ProductSize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Mappers
{
    public static class ProductSizeMapping
    {
        public static ProductSizeDTO ToProductSizeDto(this ProductSize productSize)
        {
            return new ProductSizeDTO
            {
                ProductId = productSize.ProductId,
                Id = productSize.Id,
                Height = productSize.Height,
                Length = productSize.Length,
                Width = productSize.Width
            };
        }
    }
}
