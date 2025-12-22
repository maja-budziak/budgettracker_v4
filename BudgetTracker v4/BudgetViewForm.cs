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

        private void BudgetViewForm_Load(object sender, EventArgs e)
        {
            FormatTables();
            labelCurrentBudget.Text = "[" + ThisBudget.GetFullId() + "] " + ThisBudget.Name;
        }
    }
}
