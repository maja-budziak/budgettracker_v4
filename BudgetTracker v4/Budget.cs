using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetTracker_v4
{
    public class Budget
    {
        [JsonConstructor]
        public Budget(double totalAmount, double availableAmount, double spentAmount, string name, List<Budget> subBudgets, List<Entry> entries)
        {
            TotalAmount = totalAmount;
            AvailableAmount = availableAmount;
            SpentAmount = spentAmount;
            Entries = entries;
            SubBudgets = subBudgets;
            Name = name;
        }
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

        [JsonIgnore]
        public FinancialYear Year {  get; set; }
        [JsonIgnore]
        public Budget? ParentBudget { get; set; }
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
            if (ParentBudget    == MainForm.CurrentYear.MainIncomeBudget    || 
                ParentBudget    == MainForm.CurrentYear.MainExpenseBudget   ||
                this            == MainForm.CurrentYear.MainIncomeBudget    ||
                this            == MainForm.CurrentYear.MainExpenseBudget)
            {
                return Id.ToString();
            }
            else
            {
                return ParentBudget.GetFullId() + "-" + Id.ToString();
            }
        }

        /// <summary>
        /// Checks the level of a given budget in relation to the main budget, where the level 1 is a sub-budget of the main budget, level 2 is a sub-budget of a level 1 sub-budget, etc.
        /// </summary>
        /// <returns></returns>
        public int CheckBudgetLevel()
        {
            if(this == MainForm.CurrentYear.MainIncomeBudget || this == MainForm.CurrentYear.MainExpenseBudget)
            {
                return 0;
            }
            else if (ParentBudget == MainForm.CurrentYear.MainIncomeBudget || ParentBudget == MainForm.CurrentYear.MainExpenseBudget)
            {
                return 1;
            }
            else
            {
                return 1 + ParentBudget.CheckBudgetLevel();
            }
        }
        /// <summary>
        /// Inverts the displayed balance of income-side budgets.
        /// </summary>
        /// <returns>-1 if it's an income budget, 1 if it's an expense budget.</returns>
        public int IsIncome()
        {
            if(this == MainForm.CurrentYear.MainIncomeBudget)
            {
                return -1;
            }
            else if(this == MainForm.CurrentYear.MainExpenseBudget)
            {
                return 1;
            }
            else
            {
                return ParentBudget.IsIncome();
            }
        }
    }
}
