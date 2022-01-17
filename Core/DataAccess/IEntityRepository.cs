using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic constraint - kısıt
    //class : referans tip olabilir.
    //IEntity : IEntity olabilir veya IEntity implement eden bir nesne olabilir .
    //new() dedik çünkü newlenebilir olsun istedik bu sayede IEntity yazılamaz 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
