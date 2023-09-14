using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.DAL.Repositories.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.Repositories.Concrete
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        //expenseManager.GetAllInclude(e => e.Id == expenseId, e => e.ExpenseDetails).Result.FirstOrDefault();
        public Expense expenseWithIdAndIncludeE_Details(string expenseId)
        {
            var expenseWithIdAndIncludeE_Details = dbContext.Expenses.Where(e => e.Id == expenseId).Include(e => e.ExpenseDetails).FirstOrDefault();
            return expenseWithIdAndIncludeE_Details;
        }
    }
}
