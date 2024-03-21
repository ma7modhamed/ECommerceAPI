using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Repository
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
