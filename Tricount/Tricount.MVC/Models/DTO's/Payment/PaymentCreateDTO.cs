using System.ComponentModel.DataAnnotations;

namespace Tricount.MVC.Models.DTO_s.Payment
{
    public class PaymentCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ücret kısmı boş geçilemez!")]
        public double Amount { get; set; }
    }
}
