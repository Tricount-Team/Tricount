using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
	public class Group :BaseEntity
	{
        public string GroupName{ get; set; }
        public Currency DefaultCurrency { get; set; }
		ICollection<User> Users { get; set; }
		ICollection<Expense> Expenses { get; set; }

		public enum Currency
		{
			USD,
			EURO,
			TRY
		}
	}
}
