using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Concrete;

namespace Tricount.BL.Abstract
{
    public interface IGroupManager : IManagerBase<Group>
    {
        public Task<ICollection<Group>> GetGroupWithUserSlug(string slug);
        public Group GetGroupWithSlug(string slug);
        public Group GetGroupWithSlugAndIncludeUsers(string slug);
    }
}
