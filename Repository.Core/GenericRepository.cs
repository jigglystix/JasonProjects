using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Core
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Variables
        private readonly DbContext _context;
        private DbSet<T> _dbSet;
        private bool _disposed = false;
        #endregion

        #region Properties
        public IQueryable<T> Table
        {
            get
            {
                return _dbSet;
            }
        }
        #endregion

        #region Constructors
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        #endregion

        #region Methods
        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Insert(T entity)
        {
            ///TODO: Create Insert that will account for the entire entity tree 
            _dbSet.Add(entity);
        }

        public void Delete(object id)
        {
            ///TODO: Create Delete that will account for the entire entity tree 
            T entity = _dbSet.Find(id);
            Delete(entity);
        }

        public void Delete(T entity)
        {
            ///TODO: Create Delete that will account for the entire entity tree 
            if (_context.Entry(entity).State == System.Data.Entity.EntityState.Detached)
                _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            ///TODO: Create Update that will account for the entire entity tree 
            _dbSet.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
