using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        protected readonly ConcurrentDictionary<Type, object> _repsDictionary;
        protected InternetShopDbContext _dbContext;
        public UnitOfWork(InternetShopDbContext dbContext)
        {
            _dbContext = dbContext;
            _repsDictionary = new ConcurrentDictionary<Type, object>();
        }

        public IGenericRepository<TEntity> GetGenericRepository<TEntity>()
            where TEntity : class, IBaseEntity
        {
            return _repsDictionary.GetOrAdd(typeof(TEntity),
                x => new GenericRepository<TEntity>(_dbContext))  as IGenericRepository<TEntity>;
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        private bool _disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _dbContext.Dispose();
            }
            _disposed = true;
        }

        ~UnitOfWork() => Dispose(false);
    }
}