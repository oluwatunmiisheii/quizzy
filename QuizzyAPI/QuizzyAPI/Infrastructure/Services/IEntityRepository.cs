using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuizzyAPI.Infrastructure.Services
{
    public interface IEntityRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();

        TEntity GetOne(Func<TEntity, bool> where);
        IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, string includeProperties = "");

        TEntity Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        bool Exist(int id);

        int Count();

        void Update(TEntity entity);

        int Save();

    }
}