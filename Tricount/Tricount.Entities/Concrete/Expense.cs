using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class Expense : BaseEntity
    {
        public double Amount { get; set; }
        public string? Description { get; set; }
        public bool IsPaid { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<ExpenseDetail>? ExpenseDetails { get; set; }
    }
}
