    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class Invite : BaseEntity
    {
        public Group? Groups { get; set; }
        public string? GroupId { get; set; }
        public User? User { get; set; }
        public string? UserId { get; set; }
        public bool IsFinished { get; set; }
        public string SenderId { get; set; }    

        [NotMapped]
        public string? GroupSlug { get; set; }
        [NotMapped]
        public string? UserName { get; set; }   
    }
}
