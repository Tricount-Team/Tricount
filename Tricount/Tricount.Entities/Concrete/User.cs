using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Iban { get; set; }
        public string Slug { get; set; }
        public CurrencyEnum DefaultCurrency { get; set; }
        public ICollection<Group>? Groups { get; set; } = new List<Group>();
        public ICollection<Expense>? Expenses { get; set; } = new List<Expense>();
        public ICollection<Payment>? Payments { get; set; } = new List<Payment>();
        public ICollection<Invite>? Invites { get; set; } = new List<Invite>();
    }
}
