using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly TestECommerceContext _dbContext;
        public DbSet<T> DbSet { get; }
        public BaseRepository(TestECommerceContext dbContext) 
        { 
            _dbContext = dbContext;
            DbSet = _dbContext.Set<T>();
        }
        public IQueryable<T> FindAll(Expression<Func<T, bool>> where)
        {
            return DbSet.Where(where);
        }

        public Task<List<T>> FindAllAsync(Expression<Func<T, bool>> where)
        {
            return DbSet.Where(where).ToListAsync();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public Task<List<T>> GetAllAsync()
        {
            return DbSet.ToListAsync();
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }
    }
}
