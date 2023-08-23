﻿using System.ComponentModel.DataAnnotations;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Models.DTO_s
{
	public class GroupCreateDTO
	{
		[Required(AllowEmptyStrings= false, ErrorMessage="Grup ismi bos gecilemez!")]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Para birimi bos gecilemez!")]
        public CurrencyEnum DefaultCurrency { get; set; }
    }
}
