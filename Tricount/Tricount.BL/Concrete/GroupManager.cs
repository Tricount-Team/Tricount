using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.BL.Concrete
{
    public class GroupManager : ManagerBase<Group>, IGroupManager
    {
        public GroupManager(IGroupRepository repository) : base(repository)
        {
        }

        public Task<ICollection<Group>> GetGroupsWithUserSlug(string slug)
        {
            throw new NotImplementedException();
        }
    }
}