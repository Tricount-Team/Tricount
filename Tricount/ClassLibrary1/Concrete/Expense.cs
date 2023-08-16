using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TriCount.Entites.Abstract;

namespace TriCount.Entites.Concrete
{
    public class Expense : BaseEntity
    {
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }
    }
}
