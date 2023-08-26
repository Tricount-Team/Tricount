using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
using Tricount.DAL.Contexts;
using Tricount.DAL.Repositories.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.BL.Concrete
{
    public class GroupManager : ManagerBase<Group>, Abstract.IGroupManager
    {
        private readonly IGroupRepository repository;

        public GroupManager(IGroupRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public async override Task<int> Create(Group entity)
        {
            entity.Slug = "";
            return await base.Create(entity);
        }

        public override Task<IQueryable<Group>>? GetAllInclude(Expression<Func<Group, bool>>? filter = null, params Expression<Func<Group, object>>[]? include)
        {
            return base.GetAllInclude(filter, include);
        }

        public virtual async Task<ICollection<Group>> GetGroupWithUserSlug(string slug)
        {
            return await repository.GetGroupsWithUserSlug(slug);
        }
        public override Task<int> Update(Group entity)
        {
            entity.Slug = entity.Name.ToLower() + "-" + entity.Description.ToLower() + "-" + entity.Id.ToString().Split('-')[0].ToLower();
            return base.Update(entity);
        }
    }
}
