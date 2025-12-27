using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetTracker_v4
{
    public class Entry
    {
        public Entry(Budget b, double amount, string name)
        {
            Budget = b;
            Amount = amount;
            EntryTime = DateTime.Now;
            Name = name;
        }

        [JsonConstructor]
        public Entry(double amount, DateTime entryTime)
        {
            Amount = amount;
            EntryTime = entryTime;
        }

        private Budget Budget {  get; set; }
        public double Amount { get; set; }
        public DateTime EntryTime { get; set; }
        public string Name { get; set; }

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
