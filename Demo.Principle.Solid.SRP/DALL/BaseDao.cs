using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Principle.Solid.SRP.DALL
{
    public abstract class BaseDao<TEntity> where TEntity : class
    {
        public abstract void Add(TEntity entity);
        public abstract void Remove(TEntity entity);
    }
}
