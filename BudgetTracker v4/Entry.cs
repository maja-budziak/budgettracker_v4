using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker_v4
{
    public class Entry
    {
        public Entry(Budget b, double amount)
        {
            Budget = b;
            Amount = amount;
            EntryTime = DateTime.Now;
        }

        private Budget Budget {  get; set; }
        public double Amount { get; set; }
        public DateTime EntryTime { get; set; }

        public void PushEntry(Budget b)
        {
            b.SpentAmount += Amount;
            if (b.ParentBudget != null)
            {
                PushEntry(b.ParentBudget);
            }
        }
    }
}
