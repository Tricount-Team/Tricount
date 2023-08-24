using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
<<<<<<< HEAD
using Tricount.DAL.Repositories.Concrete;
=======
>>>>>>> ercan
using Tricount.Entities.Concrete;

namespace Tricount.BL.Concrete
{
    public class ExpenseManager : ManagerBase<Expense>, IExpenseManager
    {
<<<<<<< HEAD
        public ExpenseManager(ExpenseRepository repository) : base(repository)
        {

=======
        public ExpenseManager(IExpenseRepository repository) : base(repository)
        {
>>>>>>> ercan
        }
    }
}
