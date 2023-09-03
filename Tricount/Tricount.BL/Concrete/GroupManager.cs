using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.BL.Concrete
{
    public class GroupManager : ManagerBase<Group>, IGroupManager
    {
        private readonly IGroupRepository repository;
        public GroupManager(IGroupRepository repository) : base(repository)
        {
           this.repository= repository;
        }

        public async override Task<int> Insert(Group entity)
        {
            entity.Slug = "";
            return await base.Insert(entity);
        }
        public override Task<IQueryable<Group>> GetAllInclude(Expression<Func<Group, bool >>? filter = null, params  Expression<Func<Group , object>>[]? include)
        {
            return base.GetAllInclude(filter, include);

        }
        public virtual async Task<ICollection<Group>> GetGroupWithUserSlug(string slug)
        {
            return await repository.GetGroupWithUserSlug(slug);
        }
        
    }
}
