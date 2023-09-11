using EasyCashIdentityProject.EntityLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        DbSet<T> _context { get; }
        Task AddAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetByExpressionAsync(Expression<Func<T, bool>> expression);
    }
}
