using ECommerce.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTO.Category
{
    public class VIPCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GetVipProductDTO> VIPStoreProductsAPiRes { get; set; }
    }
}
