using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BudgetTracker_v4
{
    internal class FinancialSerializer
    {
        public static string Serialize(List<FinancialYear> financialYears)
        {
            return JsonSerializer.Serialize(financialYears);
        }
        public static List<FinancialYear> DeserializeFromFile(string path)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<FinancialYear> lst = JsonSerializer.Deserialize<List<FinancialYear>>(json);
                RebuildReferences(lst);
                return lst;
            }
            else
            {
                return new List<FinancialYear>();
            }
        }
        public static void RebuildReferences(List<FinancialYear> lst)
        {
            foreach (FinancialYear fy in lst)
            {
                int year = fy.Year;
                fy.MainIncomeBudget.Year = fy;
                fy.MainExpenseBudget.Year = fy;
                RebuildReferencesBudgets(fy.MainIncomeBudget);
                RebuildReferencesBudgets(fy.MainExpenseBudget);
            }
        }
        public static void RebuildReferencesBudgets(Budget b)
        {
            foreach(Budget sb in b.SubBudgets)
            {
                sb.ParentBudget = b;
                sb.Year = b.Year;
                RebuildReferencesBudgets(sb);
            }
        }
    }
}
