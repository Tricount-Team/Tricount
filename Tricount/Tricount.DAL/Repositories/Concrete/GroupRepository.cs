using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tricount.DAL.Contexts;
using Tricount.DAL.Repositories.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.Repositories.Concrete
{
	public class GroupRepository : BaseRepository<Group>, IGroupRepository
	{
		public async Task<ICollection<Group>>	GetGroupWithUserSlug(string slug)
		{
			var groups = await Context.Groups.Include(g => g.Users.Where(u => u.Slug == slug)).ToListAsync();
			return groups;

		}
	}
}
