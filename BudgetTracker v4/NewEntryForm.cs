using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetTracker_v4
{
    public partial class NewEntryForm : Form
    {
        public NewEntryForm()
        {
            InitializeComponent();
        }
        public Budget ThisBudget;
        private void FormatTables()
        {
            table_SubBudgets.Rows.Clear();
            table_SubBudgets.Columns.AddRange([
                new DataGridViewTextBoxColumn { HeaderText = "K1", Width = 50 },
                new DataGridViewTextBoxColumn { HeaderText = "Name", Width = 148 },
                new DataGridViewTextBoxColumn { HeaderText = "Total Balance", Width = 70, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewTextBoxColumn { HeaderText = "TBA", Width = 70, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewButtonColumn { HeaderText = "Details", Width = 65 }
            ]);
        }
        private void FillTables()
        {
            table_SubBudgets.Rows.Clear();
            foreach (Budget b in ThisBudget.SubBudgets)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange([
                    new DataGridViewTextBoxCell { Value = b.Id },
                    new DataGridViewTextBoxCell { Value = b.Name },
                    new DataGridViewTextBoxCell { Value = b.GetCurrentAmount().ToString("F2") },
                    new DataGridViewTextBoxCell { Value = b.CalculateTBA().ToString("F2") , Style = { BackColor = ((b.CalculateTBA() * b.IsIncome()) < 0 ? Color.LightPink : ((b.CalculateTBA() * b.IsIncome()) > 0 ? Color.LightGreen : Color.White)) }},
                    new DataGridViewButtonCell { Value = "Select" }
                ]);
                table_SubBudgets.Rows.Add(row);
            }
        }

        private void NewEntryForm_Load(object sender, EventArgs e)
        {
            FormatTables();
            FillTables();
            btnBackToParent.Enabled = false;
        }

        private void table_SubBudgets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)table_SubBudgets.Rows[e.RowIndex].Cells[0].Value;
            Budget b = ThisBudget.SubBudgets.FirstOrDefault(b => b.Id == id);
            ThisBudget = b;
            txtBoxAvailable.Text = ThisBudget.GetCurrentAmount().ToString("F2");
            FillTables();
            labelSelectedBudget.Text = "[" + ThisBudget.GetFullId() + "] " + ThisBudget.Name;
            btnBackToParent.Enabled = true;

        }

        private void btnBackToParent_Click(object sender, EventArgs e)
        {
            ThisBudget = ThisBudget.ParentBudget;
            txtBoxAvailable.Text = ThisBudget.GetCurrentAmount().ToString("F2");
            FillTables();
            labelSelectedBudget.Text = "[" + ThisBudget.GetFullId() + "] " + ThisBudget.Name;
            if (ThisBudget == MainForm.CurrentYear.MainIncomeBudget || ThisBudget == MainForm.CurrentYear.MainExpenseBudget)
            {
                btnBackToParent.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtBoxAmount.Text);
            string name = txtBoxName.Text;
            Entry en = new Entry(ThisBudget, amount, name);
            ThisBudget.Entries.Add(en);
            en.PushEntry(ThisBudget);
            Close();
        }

        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxAmount.Text, out double balance))
            {
                txtBoxRemaining.Text = (ThisBudget.GetCurrentAmount() - balance).ToString("F2");
                txtBoxAmount.BackColor = Color.White;
            }
            else
            {
                txtBoxAmount.BackColor = Color.Salmon;
            }

        }
    }
}
