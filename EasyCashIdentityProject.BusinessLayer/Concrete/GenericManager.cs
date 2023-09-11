using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task TAdd(T entity)
        {
            try
            {
                await _genericDal.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            await _genericDal.AddAsync(entity);
        }

        public async Task TDeleteById(int id)
        {
            try
            {
                var entity = await _genericDal.GetByIdAsync(id);
                if (entity != null)
                {
                    await _genericDal.DeleteAsync(entity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> TGetAll()
        {
            try
            {
                return await _genericDal.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> TGetByExpression(Expression<Func<T, bool>> expression)
        {
            try
            {
                return await _genericDal.GetByExpressionAsync(expression);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> TGetById(int id)
        {
            try
            {
                return await _genericDal.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task TUpdate(T entity)
        {
            try
            {
                await _genericDal.UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
