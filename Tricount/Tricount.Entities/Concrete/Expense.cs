using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class Expense : BaseEntity
    {
        public double? TotalAmount { get; set; }
        public string? Description { get; set; }
        public bool? IsFinished { get; set; }
        public string? PayerId { get; set; }
        public User? Payer { get; set; }
        public string? GroupId { get; set; }
        public Group? Group { get; set; }
        public string? PaymentId { get; set; }
        public Payment? Payment { get; set; }
        public ICollection<ExpenseDetail>? ExpenseDetails { get; set; } = new List<ExpenseDetail>();

        [NotMapped]
        public string? GroupSlug { get; set; }
        [NotMapped]
        public string[]? IsCheckedShowAmountPartial { get; set; }
    }
}
