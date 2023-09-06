using Tricount.Entities.Concrete;
using Tricount.MVC.Models.DTO_s.Expense;
using Tricount.MVC.Models.DTO_s.Group;

namespace Tricount.MVC.Models.DTO_s
{
	public class GroupDetailViewModel
	{
		public ExpenseCreateDTO? ExpenseDTO { get; set; }
		public ExpenseDetail? ExpenseDetail { get; set; }
        public GroupCreateDTO? GroupDTO { get; set; }
        public Payment payment { get; set; }
        public Invite? Invite { get; set; }
        public Tricount.Entities.Concrete.Group Group { get; set; }
        public ICollection<Tricount.Entities.Concrete.Expense> Expenses { get; set; } = new List<Tricount.Entities.Concrete.Expense>();

        


    }
}
