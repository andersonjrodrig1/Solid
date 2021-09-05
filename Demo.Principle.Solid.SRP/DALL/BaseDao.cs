using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Principle.Solid.SRP.DALL
{
    public abstract class BaseDao<TEntity> where TEntity : class
    {
        private IList<TEntity> entities = new List<TEntity>();

        public void Add(TEntity entity) => entities.Add(entity);
        public void Remove(TEntity entity) => entities.Remove(entity);
        public IList<TEntity> GetAll() => entities;
    }
}
