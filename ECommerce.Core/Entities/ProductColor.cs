using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class ProductColor 
    {
        public ProductColor() { }
        public int Id { get; set; }
        public string Color { get; set; }
        public bool IsAvailable { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
