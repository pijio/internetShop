using System;
using System.Collections.Concurrent;

namespace InternetShop.DAL
{
    public interface IUnitOfWork
    {
        public IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class, IBaseEntity;
    }
}