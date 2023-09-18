﻿using System.ComponentModel.DataAnnotations;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Models.DTO_s.Group
{
	public class GroupCreateDTO
	{
		[Required(ErrorMessage= "Group name can't be empty!")]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "Currency can't be empty!")]
        public CurrencyEnum DefaultCurrency { get; set; }
        public string? Slug { get; set; }
        public ICollection<User>? Users { get; set; }
		public ICollection<Tricount.Entities.Concrete.Expense>? Expenses { get; set; }
		public ICollection<Tricount.Entities.Concrete.Payment>? Payments { get; set; }
	}
}
