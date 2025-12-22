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
        /// <param name="spentAmount"></param>
        /// <param name="entries"></param>
        public Budget(FinancialYear year, Budget? parentBudget, List<Budget> subBudgets, double totalAmount, double availableAmount, string name, double timeWeightedAmount, double spentAmount, List<Entry> entries)
        {
            Year = year;
            ParentBudget = parentBudget;
            SubBudgets = subBudgets;
            TotalAmount = totalAmount;
            TimeWeightedAmount = timeWeightedAmount;
            AvailableAmount = availableAmount;
            Name = name;
            SpentAmount = spentAmount;
            Entries = entries;
        }

        /// <summary>
        /// Simplified constructor using only manually entered properties.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="parentBudget"></param>
        /// <param name="totalAmount"></param>
        public Budget(FinancialYear year, Budget? parentBudget, int id, string name, double totalAmount)
        {
            Id = id;
            Year = year;
            ParentBudget = parentBudget;
            SubBudgets = [];
            TotalAmount = totalAmount;
            AvailableAmount = totalAmount;
            Name = name;
            TimeWeightedAmount = 0;
            SpentAmount = 0;
            Entries = [];
        }

        private FinancialYear Year {  get; set; }
        private Budget? ParentBudget { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Budget> SubBudgets { get; set; }
        public double TotalAmount { get; set; }
        private double TimeWeightedAmount { get; set; }
        public double SpentAmount { get; set; }
        public double AvailableAmount { get; set; }
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
                return GetCurrentAmount();
            }
            else if (DateTime.Now < FYStart)
            {
                return GetCurrentAmount() - TotalAmount;
            }
            else
            {
                TimeSpan yearDuration = FYEnd - FYStart;
                TimeSpan yearElapsed = DateTime.Now - FYStart;
                return (yearElapsed.TotalSeconds /  yearDuration.TotalSeconds) * TotalAmount - SpentAmount;
            }
        }
        public double GetCurrentAmount()
        {
            return TotalAmount - SpentAmount;
        }

        /// <summary>
        /// Adds a cost or income to the budget and then propagates it up through the Budget hierarchy.
        /// </summary>
        /// <param name="e"></param>
        public void PushEntry(Entry e)
        {
            Entries.Add(e);
            SpentAmount += e.Amount;
            if (ParentBudget != null)
            {
                ParentBudget.PushEntry(e);
            }
        }
        public string GetFullId()
        {
            if (ParentBudget == MainForm.CurrentYear.MainIncomeBudget || ParentBudget == MainForm.CurrentYear.MainExpenseBudget)
            {
                return Id.ToString();
            }
            else
            {
                return ParentBudget.GetFullId() + "-" + Id.ToString();
            }
        }
    }
}
