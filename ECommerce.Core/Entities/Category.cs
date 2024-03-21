using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Category 
    {
        public Category() 
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVIP { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
