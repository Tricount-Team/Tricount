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
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity, new()
    {
        private readonly IBaseRepository<T> repository;
        private IPaymentRepository repository1;
        private IGroupRepository repository2;
        private IExpenseDetailRepository repository3;

        public ManagerBase(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }

        public ManagerBase(IPaymentRepository repository1)
        {
            this.repository1 = repository1;
        }

        public ManagerBase(IGroupRepository repository2)
        {
            this.repository2 = repository2;
        }

        public ManagerBase(IExpenseDetailRepository repository3)
        {
            this.repository3 = repository3;
        }

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
        {
            return await repository.GetAll(filter);
        }

        public async virtual Task<IQueryable<T>>? GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[]? include)
        {
            return await repository.GetAllInclude(filter, include);
        }
    }
}

