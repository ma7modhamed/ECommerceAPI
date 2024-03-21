using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class ProductSize 
    {
        public ProductSize() { }
        public int Id { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
