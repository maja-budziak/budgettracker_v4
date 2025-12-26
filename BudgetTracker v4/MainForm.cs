namespace BudgetTracker_v4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<FinancialYear>? FinancialYears { get; set; } = [];
        public static List<Budget>? Budgets { get; set; } = [];
        public static List<Entry>? Entries { get; set; } = [];
        public static FinancialYear? CurrentYear { get; set; }


        private void MainForm_Load(object sender, EventArgs e)
        {
            FormatTables();
            btnAddIncomeBudget.Enabled = false;
            btnAddExpenseBudget.Enabled = false;
            // TODO pulling data from json
        }
        private void btnChangeYear_Click(object sender, EventArgs e)
        {
            ChangeYearForm cyf = new ChangeYearForm();
            cyf.ShowDialog();
            if (CurrentYear != null)
            {
                labelCurrentBalance.Text = CurrentYear.MainIncomeBudget.TotalAmount.ToString("F2");
                labelTBABalance.Text = CurrentYear.MainIncomeBudget.CalculateTBA().ToString("F2");
                labelFY.Text = "Financial Year:   " + CurrentYear.Year.ToString();
                btnAddIncomeBudget.Enabled = true;
                btnAddExpenseBudget.Enabled = true;
            }
        }

        private void btnRefreshBalance_Click(object sender, EventArgs e)
        {
            FillTables();
            labelCurrentBalance.Text = CurrentYear.MainIncomeBudget.GetCurrentAmount().ToString("F2");
            labelTBABalance.Text = CurrentYear.MainIncomeBudget.CalculateTBA().ToString("F2");
        }

        private void table_Income_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_Income.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int id = (int)table_Income.Rows[e.RowIndex].Cells[0].Value;
                Budget b = Budgets.FirstOrDefault(b => b.Id == id);
                BudgetViewForm bvf = new BudgetViewForm();
                bvf.ThisBudget = b;
                bvf.ShowDialog();
            }
        }
        private void FormatTables()
        {
            table_Income.Rows.Clear();
            table_Income.Columns.AddRange([
                new DataGridViewTextBoxColumn { HeaderText = "K1", Width = 50 },
                new DataGridViewTextBoxColumn { HeaderText = "Name", Width = 153 },
                new DataGridViewTextBoxColumn { HeaderText = "Total Balance", Width = 75, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewTextBoxColumn { HeaderText = "TBA", Width = 75, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewButtonColumn { HeaderText = "Details", Width = 50 }
            ]);
            table_Costs.Rows.Clear();
            table_Costs.Columns.AddRange([
                new DataGridViewTextBoxColumn { HeaderText = "K1", Width = 50 },
                new DataGridViewTextBoxColumn { HeaderText = "Name", Width = 153 },
                new DataGridViewTextBoxColumn { HeaderText = "Total Balance", Width = 75, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewTextBoxColumn { HeaderText = "TBA", Width = 75, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } },
                new DataGridViewButtonColumn { HeaderText = "Details", Width = 50 }
            ]);
        }

        private void FillTables()
        {
            table_Income.Rows.Clear();
            foreach (Budget b in CurrentYear.MainIncomeBudget.SubBudgets)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange([
                    new DataGridViewTextBoxCell { Value = b.Id },
                    new DataGridViewTextBoxCell { Value = b.Name },
                    new DataGridViewTextBoxCell { Value = b.GetCurrentAmount().ToString("F2") },
                    new DataGridViewTextBoxCell { Value = b.CalculateTBA().ToString("F2") },
                    new DataGridViewButtonCell { Value = "View" }
                ]);
                table_Income.Rows.Add(row);
            }
        }

        private void btnAddIncomeBudget_Click(object sender, EventArgs e)
        {
            AddBudgetForm abf = new AddBudgetForm();
            abf.ParentBudget = CurrentYear.MainIncomeBudget;
            abf.ShowDialog();
            FillTables();
        }

        private void btnAddEntryIncome_Click(object sender, EventArgs e)
        {
            NewEntryForm nef = new NewEntryForm();
            nef.ThisBudget = CurrentYear.MainIncomeBudget;
            nef.ShowDialog();
        }

        private void labelCurrentBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
