using System.ComponentModel.DataAnnotations;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Models.DTO_s.Expense
{
    public class ExpenseCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ücret kısmı boş geçilemez!")]
        public double TotalAmount { get; set; }
        public string? Description { get; set; }
        public bool? IsFinished { get; set; }
        public string? PayerId { get; set; }
        public User? Payer { get; set; }
        public string? GroupId { get; set; }
        public Tricount.Entities.Concrete.Group? Group { get; set; }
        public ICollection<ExpenseDetail>? ExpenseDetails { get; set; }

        public string? GroupSlug { get; set; }
    }
}
