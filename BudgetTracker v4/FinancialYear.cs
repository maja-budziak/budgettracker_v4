using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker_v4
{
    public class FinancialYear
    {
        public int Year { get; set; }
        public Budget MainIncomeBudget { get; set; }
        public Budget MainExpenseBudget { get; set; }


        public double GetTotalBudgetIncome()
        {
            // TODO
            return 0;
        }
        public double GetTotalBudgetExpense()
        {
            // TODO
            return 0;
        }
        public double GetTotalIncome()
        {
            // TODO
            return 0;
        }
        public double GetTotalExpense()
        {
            // TODO
            return 0;
        }
    }
}
