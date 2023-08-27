using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class ExpenseDetail : BaseEntity
    {
        public string? UserId { get; set; }

        public User? User { get; set; }

        public string? GroupId { get; set; }

        public Group? Group { get; set; }

        public string? ExpenseId { get; set; }

        public Expense? Expense { get; set; }
    }
}