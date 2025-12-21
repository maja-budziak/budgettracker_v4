using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetTracker_v4
{
    public partial class ChangeYearForm : Form
    {
        public ChangeYearForm()
        {
            InitializeComponent();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            MainForm.CurrentYear = MainForm.FinancialYears.FirstOrDefault(f => f.Year == int.Parse(comBoxYears.Text));
            Close();
        }

        private void ChangeYearForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnAddNewYear_Click(object sender, EventArgs e)
        {
            AddYearForm form = new AddYearForm();
            form.ShowDialog();
            RefreshList();
        }
        private void RefreshList()
        {
            List<string> choices = new List<string>();
            foreach (FinancialYear fy in MainForm.FinancialYears)
            {
                choices.Add(fy.Year.ToString());
            }
            comBoxYears.Items.AddRange(choices.ToArray());
        }
    }
}
