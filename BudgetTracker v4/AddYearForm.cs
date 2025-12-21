using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetTracker_v4
{
    public partial class AddYearForm : Form
    {
        public AddYearForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FinancialYear fy = new FinancialYear();
            fy.Year = int.Parse(txtBoxYear.Text);
            fy.MainIncomeBudget = new Budget(fy, null, [], double.Parse(txtBoxIncome.Text), 0, 0, []);
            fy.MainExpenseBudget = new Budget(fy, null, [], double.Parse(txtBoxExpense.Text), 0, 0, []);
            MainForm.FinancialYears.Add(fy);
            Close();
        }
    }
}
