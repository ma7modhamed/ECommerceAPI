using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestECommerceContext _dbContext;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <param name="dbFactory">    The database factory. </param>
        ///-------------------------------------------------------------------------------------------------

        public UnitOfWork(TestECommerceContext dbContext)
        {
            _dbContext = dbContext;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a context for the database. </summary>
        ///
        /// <value> The database context. </value>
        ///-------------------------------------------------------------------------------------------------

        public TestECommerceContext DbContext
        {
            get
            {
                return _dbContext;
            }
        }

        /// <summary>   Commits this object. </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
