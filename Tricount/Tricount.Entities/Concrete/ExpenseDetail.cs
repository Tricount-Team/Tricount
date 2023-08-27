using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class ExpenseDetail : BaseEntity
    {
        public double? Amount { get; set; }
        public bool? IsPaid { get; set; }
        public string? DebtorId { get; set; }
        public User? Debtor { get; set; }
        public ICollection<Expense>? Expenses { get; set; }
    }
}