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
            // TODO pulling data from json
        }
        private void btnChangeYear_Click(object sender, EventArgs e)
        {
            ChangeYearForm cyf = new ChangeYearForm();
            cyf.ShowDialog();
            if (CurrentYear != null)
            {
                labelCurrentBalance.Text = CurrentYear.MainIncomeBudget.TotalAmount.ToString("F2");
            }
        }

        private void btnRefreshBalance_Click(object sender, EventArgs e)
        {
            // TODO global calculate TBA
        }
    }
}
