using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class Payment : BaseEntity
    {
        public double Amount { get; set; }
        public bool IsFinished { get; set; }
        public string? DebtorId { get; set; }
        public User? Debtor { get; set; }
        public string ExpenseDetailId { get; set; }
        public ExpenseDetail? ExpenseDetail { get; set; }

        [NotMapped]
        public string? GroupSlug { get; set; }
        [NotMapped]
        public string? UserName { get; set; }
    }
}
