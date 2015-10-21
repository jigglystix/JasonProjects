using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Core
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Insert(T entity);
        void Delete(object id);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> Table { get; }
        void Attach(T entity);
    }
}
