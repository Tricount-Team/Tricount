using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Currency DefaultCurrency { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Payment> Payments { get; set; }

        public enum Currency
        {
            USD,
            EURO,
            TRY
        }
    }
}
