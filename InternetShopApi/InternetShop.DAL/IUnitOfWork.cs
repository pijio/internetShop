using System;
using System.Collections.Concurrent;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.DAL
{
    public interface IUnitOfWork<TContext> where TContext : DbContext
    {
        public IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class, IBaseEntity;
    }
}