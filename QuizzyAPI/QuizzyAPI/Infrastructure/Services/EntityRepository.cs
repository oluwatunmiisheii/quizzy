using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuizzyAPI.Infrastructure.Services
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class
    {
        private readonly DataContext context;
        private DbSet<TEntity> _dbSet;

        public EntityRepository(DataContext context)
        {
            this.context = context;
        }

        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_dbSet == null)
                {
                    _dbSet = context.Set<TEntity>();
                }

                return _dbSet;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Entities.ToListAsync();
        }

        //public TEntity GetOne(Func<TEntity, bool> where)
        //{
        //    return Entities.FirstOrDefault(where);
        //}
        public TEntity Add(TEntity entity)
        {
            var entitysaved = Entities.Add(entity).Entity;
            Save();
            return entitysaved;

        }

        public IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, string includeProperties = "")
        {
            IQueryable<TEntity> query = Entities;
            if (!includeProperties.Equals(string.Empty))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.Where(predicate).AsEnumerable();
        }

        public TEntity Get(int id)
        {
            return Entities.Find(id);
        }
        public TEntity Get(Guid? id)
        {
            return Entities.Find(id);
        }


        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
            Save();
        }

        public void Update(TEntity entity)
        {
            context.Entry<TEntity>(entity).State = EntityState.Modified;
            Save();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public bool Exist(int id)
        {
            //remove the argument id above later
            return Entities.Any();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Entities.AddRange(entities);
            Save();
        }

        
        public int Count()
        {
            throw new NotImplementedException();
        }

        
    }
}