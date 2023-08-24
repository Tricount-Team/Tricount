using Tricount.Entities.Concrete;
using Tricount.MVC.Models.DTO_s.Expense;
using Tricount.MVC.Models.DTO_s.Group;
using Tricount.MVC.Models.DTO_s.Payment;

namespace Tricount.MVC.Models
{
    public class GroupDetailViewModel
    {
        public ExpenseCreateDTO? ExpenseDTO { get; set; }
        public ExpenseDetail? ExpenseDetail { get; set; }
        public GroupCreateDTO? GroupDTO { get; set; }
        public Group? Group { get; set; }
        public PaymentCreateDTO? PaymentDTO { get; set; }
        public Invite? Invite { get; set; }
        public ICollection<Invite>? Invites { get; set; }
    }
}
