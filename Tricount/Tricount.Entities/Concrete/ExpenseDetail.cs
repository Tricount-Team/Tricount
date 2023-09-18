using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class ExpenseDetail : BaseEntity
    {
        public double Amount { get; set; }
        public bool? IsPaid { get; set; }
        public bool IsApproved { get; set; }
        public string? DebtorId { get; set; }
        public User? Debtor { get; set; }
        public string? ExpenseId { get; set; }
        public Expense? Expense { get; set; }
        public ICollection<Payment>? Payments { get; set; } = new List<Payment>();
    }
}