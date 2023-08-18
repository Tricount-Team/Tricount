using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
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
        SqlDbContext dbContext = new();

        public GroupManager(IGroupRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public async override Task<int> Create(Group entity)
        {
            var group = repository.GetAll(p => p.Name == entity.Name).Result.FirstOrDefault();
            if (group == null)
            {
                throw new Exception($"{group.Name} adı zaten mevcut!");
            }
            return await base.Create(entity);
        }
    }
}
