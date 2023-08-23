using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricount.Entities.Concrete
{
    public class GroupUser
    {
        public string UserId { get; set; }
        public User? User { get; set; }

        public string GroupId { get; set; }
        public Group? Group{ get; set; }
    }
}
