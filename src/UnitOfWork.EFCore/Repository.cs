using Microsoft.EntityFrameworkCore;
using UnitOfWork.Core.Generic;

namespace UnitOfWork.EFCore
{
    /// <summary>
    /// Generic repository
    /// </summary>
    /// <typeparam name="TEntity">Type of the Entity</typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public Repository(DbContext context)
        {

        }
    }
}
