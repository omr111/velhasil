using System.Data.Entity;
using System.Linq;
using velhasil.Dal.Abstract;
using velhasil.Entities.Models;

namespace velhasil.Dal.Concrete
{
    public class RepositoryBase<T>:IRepositoryBase<T>where T:class
    {
        velhasilContext ctx=new velhasilContext();

        public System.Collections.Generic.List<T> listAll(System.Linq.Expressions.Expression<System.Func<T, bool>> filter = null)
        {
            if (filter!=null)
            {
                return ctx.Set<T>().Where(filter).ToList();
            }

            return ctx.Set<T>().ToList();
        }

        public T listOne(System.Linq.Expressions.Expression<System.Func<T, bool>> filter)
        {
            return ctx.Set<T>().FirstOrDefault(filter);
        }

        public bool add(T entity)
        {
            ctx.Entry(entity).State = EntityState.Added;
            int result = ctx.SaveChanges();
            if (result>0)
            {
                return true;
            }

            return false;
        }

        public bool update(T entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
            int result = ctx.SaveChanges();
            if (result > 0)
            {
                return true;
            }

            return false;
        }

        public bool delete(T entity)
        {
            ctx.Entry(entity).State = EntityState.Deleted;
            int result = ctx.SaveChanges();
            if (result > 0)
            {
                return true;
            }

            return false;
        }
    }
}