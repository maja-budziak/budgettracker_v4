using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetTracker_v4
{
    public partial class BudgetViewForm : Form
    {
        public BudgetViewForm()
        {
            InitializeComponent();
        }
        public Budget ThisBudget;
        private void FormatTables()
        {
            table_SubBudgets.Rows.Clear();
            table_SubBudgets.Columns.AddRange([
                new DataGridViewTextBoxColumn { HeaderText = "K1", Width = 50 },
                new DataGridViewTextBoxColumn { HeaderText = "Name", Width = 153 },
                new DataGridViewTextBoxColumn { HeaderText = "Total Balance", Width = 75, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewTextBoxColumn { HeaderText = "TBA", Width = 75, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewButtonColumn { HeaderText = "Details", Width = 50 }
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
                    new DataGridViewTextBoxCell { Value = b.CalculateTBA().ToString("F2") },
                    new DataGridViewButtonCell { Value = "View" }
                ]);
                table_SubBudgets.Rows.Add(row);
            }
        }

        private void BudgetViewForm_Load(object sender, EventArgs e)
        {
            FormatTables();
            labelCurrentBudget.Text = "[" + ThisBudget.GetFullId() + "] " + ThisBudget.Name;
            btnAddIncomeBudget.Text = "Add K" + (ThisBudget.CheckBudgetLevel() + 1);
        }

        private void labelTBABalance_Click(object sender, EventArgs e)
        {

        }

        private void btnAddIncomeBudget_Click(object sender, EventArgs e)
        {
            AddBudgetForm abf = new AddBudgetForm();
            abf.ParentBudget = ThisBudget;
            abf.ShowDialog();
            FillTables();
        }

        private void table_SubBudgets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_SubBudgets.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int id = (int)table_SubBudgets.Rows[e.RowIndex].Cells[0].Value;
                Budget b = ThisBudget.SubBudgets.FirstOrDefault(b => b.Id == id);
                BudgetViewForm bvf = new BudgetViewForm();
                bvf.ThisBudget = b;
                bvf.ShowDialog();
            }
        }
    }
}
