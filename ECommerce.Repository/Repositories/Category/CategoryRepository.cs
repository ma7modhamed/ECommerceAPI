using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Repositories.Category
{
    public class CategoryRepository : BaseRepository<Core.Entities.Category>
    {
        public CategoryRepository(TestECommerceContext dbContext) : base(dbContext)
        {
        }
    }
}
