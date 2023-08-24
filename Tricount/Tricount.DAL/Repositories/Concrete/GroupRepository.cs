<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
=======
﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
>>>>>>> ercan
using System.Text;
using System.Threading.Tasks;
using Tricount.DAL.Repositories.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.Repositories.Concrete
{
<<<<<<< HEAD
	public class GroupRepository : BaseRepository<Group>, IGroupRepository
	{
	}
=======
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public async Task<ICollection<Group>> GetGroupsWithUserSlug(string slug)
        {
            var groups = await dbContext.Groups.Include(g => g.GroupUsers.Where(u => u.User.Slug == slug)).ToListAsync();
            return (ICollection<Group>)groups;
        }

        
    }
>>>>>>> ercan
}
