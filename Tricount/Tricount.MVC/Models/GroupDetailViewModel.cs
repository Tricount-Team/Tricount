using Tricount.Entities.Concrete;

namespace Tricount.MVC.Models
{
    public class GroupDetailViewModel
    {
        public Expense Expense { get; set; }
        public ExpenseDetail ExpenseDetail { get; set; }
        public Group Group { get; set; }
        public Payment Payment { get; set; }
    }
}
