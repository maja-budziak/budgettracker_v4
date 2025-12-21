using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetTracker_v4
{
    public partial class AddBudgetForm : Form
    {
        public AddBudgetForm()
        {
            InitializeComponent();
        }

        private void AddBudgetForm_Load(object sender, EventArgs e)
        {
            txtBoxAvailable.Text = ParentBudget.SpentAmount.ToString();
        }

        public Budget ParentBudget;

        private void txtBoxAllocated_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxAllocated.Text, out double balance))
            {
                txtBoxRemaining.Text = (ParentBudget.GetCurrentAmount() - balance).ToString();
                txtBoxAllocated.BackColor = Color.White;
            }
            else
            {
                txtBoxAllocated.BackColor = Color.Salmon;
            }
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxId.Text, out int id))
            {
                if (id > 400 && id < 700)
                {
                    labelK1Type.Text = "Type: Expense";
                    labelK1Type.ForeColor = Color.DarkRed;
                }
                else if (id > 700 && id < 1000)
                {
                    labelK1Type.Text = "Type: Income";
                    labelK1Type.ForeColor = Color.Green;
                }
                else
                {
                    labelK1Type.Text = "INVALID CODE";
                    labelK1Type.ForeColor = Color.Red;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtBoxId.Text, out int id))
                {
                    if(double.TryParse(txtBoxAllocated.Text, out double amount))
                    {
                        Budget b = new Budget(MainForm.CurrentYear, ParentBudget, id, amount);
                        MainForm.Budgets.Add(b);
                        ParentBudget.SubBudgets.Add(b);
                        
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid allocated amount. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid code. Please try again.");
                }
            }
            catch (Exception) {

            }
        }
    }
}
