using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace InternetShop.DAL
{
    public interface IUnitOfWork
    {
        public IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class, IBaseEntity;
        public Task SaveChangesAsync();
    }
}