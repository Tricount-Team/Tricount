using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.Repositories.Abstract
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        public Task<ICollection<Group>> GetGroupsWithUserSlug(string slug);

        public Group GetGroupWithSlug(string slug);
        public Group GetGroupWithSlugAndIncludeUsers(string slug);
    }
}
