using EasyCashIdentityProject.DataAccessLayer.Abstracts;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.EntityLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository()
        {
            _appDbContext = new AppDbContext() ?? throw new ArgumentNullException();
        }

        public DbSet<T> _context => _appDbContext.Set<T>();

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _context.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return true; // You can customize the delete behavior as needed
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return true; // You can customize the update behavior as needed
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.ToListAsync();
        }
        public async Task<List<T>> GetByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Where(expression).ToListAsync();
        }
    }
}
