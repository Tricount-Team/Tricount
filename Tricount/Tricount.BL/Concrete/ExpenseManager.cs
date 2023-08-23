﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;
using Tricount.Entities.Concrete;

namespace Tricount.BL.Concrete
{
    public class ExpenseManager : ManagerBase<Expense>, IExpenseManager
    {
        public ExpenseManager(ExpenseRepository repository) : base(repository)
        {

        }
    }
}
