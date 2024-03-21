using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<List<T>> GetAllAsync();
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        IQueryable<T> FindAll(Expression<Func<T, bool>> where);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> where);
    }
}
