using ECommerce.DTO.ProductColor;
using ECommerce.DTO.ProductImage;
using ECommerce.DTO.ProductSize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTO.Product
{
    public class GetVipProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string DeliveryIn { get; set; }
        public string ImagePath { get; set; }
        public int VIPCategoryId { get; set; }
        public decimal Price { get; set; }
        public int CompanyId { get; set; }
        public int ProviderId { get; set; }
        public string CompanyName { get; set; }
        public string ProvidedBy { get; set; }
        public bool HasColor { get; set; }
        public bool HasSize { get; set; }
        public List<ProductImageDTO> VIPStoreProductImagesApiRes { get; set; }
        public List<ProductSizeDTO> VIPStoreProductSizeApiRes { get;set; }
        public List<ProductColorDTO> VIPStoreProductColorApiRes { get; set; }
    }
}
