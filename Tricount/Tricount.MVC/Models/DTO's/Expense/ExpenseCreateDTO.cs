using System.ComponentModel.DataAnnotations;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Models.DTO_s.Expense
{
    public class ExpenseCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ücret kısmı boş geçilemez!")]
        public double Amount { get; set; }
        public string? Description { get; set; }
    }
}
