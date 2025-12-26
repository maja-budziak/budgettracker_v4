using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetTracker_v4
{
    public class FinancialYear
    {
        [JsonConstructor]
        public FinancialYear(int year, Budget mainIncomeBudget, Budget mainExpenseBudget) { 
            Year = year;
            MainIncomeBudget = mainIncomeBudget;
            MainExpenseBudget = mainExpenseBudget;
        }
        public FinancialYear()
        {

        }

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
