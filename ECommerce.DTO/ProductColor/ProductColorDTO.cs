using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTO.ProductColor
{
    public class ProductColorDTO
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public bool IsAvailable { get; set; }
        public int ProductId { get; set; }
    }
}
