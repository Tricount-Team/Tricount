using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tricount.DAL.Repositories.Concrete;
using Tricount.Entities.Concrete;
using Group = Tricount.Entities.Concrete.Group;

namespace Tricount.DAL.Repositories.Abstract
{
	public interface IGroupRepository: IBaseRepository<Group>
	{
		public Task<ICollection<Group>> GetGroupWithUserSlug(string slug);	
	}
}
