using ECommerce.Core.Entities;
using ECommerce.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Mappers
{
    public static class ProductMapping
    {
        public static GetVipProductDTO ToVipProductDto(this Product product)
        {
            return new GetVipProductDTO
            {
                CompanyId = product.CompanyId,
                CompanyName = product.Company?.Name,
                DeliveryIn = product.DeliveryIn,
                Description = product.Description,
                HasColor = product.ProductColors.Any(),
                HasSize = product.ProductSizes.Any(),
                Id = product.Id,
                ImagePath = product.ImagePath,
                Price = product.Price,
                ProductName = product.Name,
                ProvidedBy = product.Provider?.Name,
                ProviderId = product.ProviderId,
                VIPCategoryId = product.CategoryId,
                VIPStoreProductColorApiRes = product.ProductColors.Select(pc => pc.ToProductColorDto()).ToList(),
                VIPStoreProductImagesApiRes = product.ProductImages.Select(pi => pi.ToProductImageDto()).ToList(),
                VIPStoreProductSizeApiRes = product.ProductSizes.Select(ps => ps.ToProductSizeDto()).ToList(),


            };
        }
    }
}
