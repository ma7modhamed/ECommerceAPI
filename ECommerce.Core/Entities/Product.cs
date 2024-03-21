using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Product
    {
        public Product() 
        {
            ProductColors = new List<ProductColor>();
            ProductImages = new List<ProductImage>();
            ProductSizes = new List<ProductSize>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DeliveryIn { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int CompanyId { get; set; }
        public int ProviderId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual Company Provider { get; set; }
        public virtual IEnumerable<ProductImage> ProductImages { get; set; }
        public virtual IEnumerable<ProductSize> ProductSizes { get; set; }
        public virtual IEnumerable<ProductColor> ProductColors { get; set; }


    }
}
