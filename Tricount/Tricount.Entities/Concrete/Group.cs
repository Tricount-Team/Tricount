using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Slug { get; set; }
        public CurrencyEnum DefaultCurrency { get; set; }
        public string? ConstituentId { get; set; }
        public ICollection<User>? Users { get; set; } = new List<User>();
        public ICollection<Expense>? Expenses { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public ICollection<Invite>? Invites { get; set; }


    }
}
