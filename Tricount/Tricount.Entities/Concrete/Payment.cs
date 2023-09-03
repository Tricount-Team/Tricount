using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class Payment : BaseEntity
    {
        public double Amount { get; set; }
        public bool IsApproved{ get; set; }
        public bool IsFinished { get; set; }
        public string UserId { get; set; }
        public User? User { get; set; }
        public string ExpenseId { get; set; }
        public Expense? Expense { get; set; }
        public string GroupId { get; set; }
        public Group? Group { get; set; }
    }
}
