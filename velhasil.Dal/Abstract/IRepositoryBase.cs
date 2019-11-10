using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace velhasil.Dal.Abstract
{
    public interface IRepositoryBase<T>where T:class
    {
        List<T> listAll(Expression<Func<T, bool>> filter = null);
        T listOne(Expression<Func<T, bool>> filter);
        bool add(T entity);
        bool update(T entity);
        bool delete(T entity);

    }
}