using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;
using Tricount.Entities.Concrete;

namespace Tricount.BL.Concrete
{
    public class InviteManager : ManagerBase<Invite>, IInviteManager
    {
        public InviteManager(IInviteRepository repository) : base(repository)
        {
        }
        public override Task<int> Create(Invite entity)
        {
            return base.Create(entity);
        }
    }
}
