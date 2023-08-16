using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
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

        public override Task<int> Create(Group entity)
        {
            var group = repository.GetAll(p => p.Name == entity.Name).Result.FirstOrDefault();
            if (group == null)
            {
                throw new Exception($"{group.Name} adı zaten mevcut!");
            }

            return base.Create(entity);
        }
    }
}
