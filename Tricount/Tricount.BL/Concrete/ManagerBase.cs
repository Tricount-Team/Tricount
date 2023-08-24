using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
using Tricount.Entities.Abstract;

namespace Tricount.BL.Concrete
{
<<<<<<< HEAD
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity, new()
    {
        private readonly IBaseRepository<T> repository;
        
=======
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> repository;
>>>>>>> ercan

        public ManagerBase(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }

<<<<<<< HEAD
        public async virtual Task<int> Insert(T entity)
        {
            return await repository.Insert(entity);
        }

        public async virtual Task<int> Update(T entity)
        {
            return await repository.Update(entity);
        }
        public async virtual Task<int> Delete(T entity)
        {
            return await repository.Delete(entity);
        }
        public async virtual Task<T?> GetById(int id)
        {
            return await repository.GetById(id);
        }
        public async virtual Task<ICollection<T>>? GetAll(Expression<Func<T, bool>>? filter)
=======
        public virtual async Task<int> Delete(T entity)
        {
            return await repository.Delete(entity);
        }

        public virtual async Task<ICollection<T>> GetAll(Expression<Func<T, bool>>? filter)
>>>>>>> ercan
        {
            return await repository.GetAll(filter);
        }

<<<<<<< HEAD
        public async virtual Task<IQueryable<T>>? GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? include)
        {
            return await repository.GetAllInclude(filter, include);
        }
    }
}

=======
        public virtual async Task<IQueryable<T>>? GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? include)
        {
            return await repository.GetAllInclude(filter, include);
        }

        public virtual async Task<T> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public virtual async Task<int> Create(T entity)
        {
            return await repository.Create(entity);
        }

        public virtual async Task<int> Update(T entity)
        {
            return await repository.Update(entity);
        }
    }
}
>>>>>>> ercan
