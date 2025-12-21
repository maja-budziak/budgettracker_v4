using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker_v4
{
    public class Budget
    {
        /// <summary>
        /// Full constructor for pulling all data into a new Budget object.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="parentBudget"></param>
        /// <param name="subBudgets"></param>
        /// <param name="totalAmount"></param>
        /// <param name="timeWeightedAmount"></param>
        /// <param name="currentAmount"></param>
        /// <param name="entries"></param>
        public Budget(FinancialYear year, Budget? parentBudget, List<Budget> subBudgets, double totalAmount, double timeWeightedAmount, double currentAmount, List<Entry> entries)
        {
            Year = year;
            ParentBudget = parentBudget;
            SubBudgets = subBudgets;
            TotalAmount = totalAmount;
            TimeWeightedAmount = timeWeightedAmount;
            CurrentAmount = currentAmount;
            Entries = entries;
        }

        private FinancialYear Year {  get; set; }
        private Budget? ParentBudget { get; set; }
        private List<Budget> SubBudgets { get; set; }
        public double TotalAmount { get; set; }
        private double TimeWeightedAmount { get; set; }
        public double CurrentAmount { get; set; }
        public List<Entry> Entries { get; set; }
        
        /// <summary>
        /// Calculates the time-based amount - based on the amount of the year that has passed.
        /// </summary>
        /// <returns></returns>
        public double CalculateTBA()
        {
            DateTime FYStart = new DateTime(Year.Year, 1, 1, 0, 0, 0);
            DateTime FYEnd = FYStart.AddYears(1);
            if (DateTime.Now > FYEnd)
            {
                return CurrentAmount;
            }
            else if (DateTime.Now < FYStart)
            {
                return CurrentAmount - TotalAmount;
            }
            else
            {
                TimeSpan yearDuration = FYEnd - FYStart;
                TimeSpan yearElapsed = DateTime.Now - FYStart;
                return CurrentAmount - (yearElapsed.TotalSeconds /  yearDuration.TotalSeconds) * TotalAmount;
            }
        }

    }
}
