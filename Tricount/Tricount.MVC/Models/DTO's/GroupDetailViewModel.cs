using Tricount.Entities.Concrete;

namespace Tricount.MVC.Models.DTO_s
{
	public class GroupDetailViewModel
	{
		public ExpenseCreateDTO? ExpenseDTO { get; set; }
		public ExpenseDetail? ExpenseDetail { get; set; }
        public GroupCreateDTO? GroupDTO { get; set; }
        public Group? Group { get; set; }
        public PaymentCreateDTO? PaymentCreateDTO { get; set; }
		public Payment payment { get; set; }
        public Invite? Invite { get; set; }
        public ICollection<Payment> Payments { get; set; }
        


    }
}
