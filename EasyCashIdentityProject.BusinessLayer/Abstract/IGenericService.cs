using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<T> TGetById(int id);
        Task<List<T>> TGetAll();
        Task TUpdate(T entity);
        Task TAdd(T entity);
        Task TDeleteById(int id);
        Task<List<T>> TGetByExpression(Expression<Func<T,bool>> expression);
    }
}
