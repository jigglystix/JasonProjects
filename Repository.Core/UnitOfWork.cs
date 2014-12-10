using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Core
{
    public class UnitOfWork
    {
        private readonly string _connectionString;
        private bool _disposed = false;
        private DbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="connectionString">The database connection string.</param>
        /// <param name="httpContext">The HTTP context.</param>
        public UnitOfWork(DbContext context)
        {
            //_connectionString = connectionString;
            _context = context;
        }

        protected DbContext Context
        {
            get
            {
                return _context;// ?? (_context = new DatabaseContext(_connectionString));
            }
        }

        /// <summary>
        /// Saves all database changes that have been made through all services.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing && _context != null)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
