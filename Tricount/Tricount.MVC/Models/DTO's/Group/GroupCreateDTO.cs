using System.ComponentModel.DataAnnotations;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Models.DTO_s.Group
{
    public class GroupCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Grup ismi boş geçilemez!")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Para birimi boş geçilemez!")]
        public CurrencyEnum DefaultCurrency { get; set; }
    }
}
