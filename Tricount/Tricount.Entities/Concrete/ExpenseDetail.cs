using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class ExpenseDetail : BaseEntity
    {
        public bool IsPaid { get; set; }

        public Guid? UserId { get; set; }

        public User? User { get; set; }

        public Guid? GroupId { get; set; }

        public Group? Group { get; set; }

        public Guid? ExpenseId { get; set; }

        public Expense? Expense{ get; set; }
    }
}