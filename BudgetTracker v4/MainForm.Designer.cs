namespace BudgetTracker_v4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFY = new Label();
            btnChangeYear = new Button();
            labelCurrentText = new Label();
            labelTBAText = new Label();
            btnRefreshBalance = new Button();
            labelCurrentBalance = new Label();
            labelTBABalance = new Label();
            labelIncomeText = new Label();
            labelExpensesText = new Label();
            table_Income = new DataGridView();
            table_Costs = new DataGridView();
            btnAddIncomeBudget = new Button();
            btnAddExpenseBudget = new Button();
            ((System.ComponentModel.ISupportInitialize)table_Income).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_Costs).BeginInit();
            SuspendLayout();
            // 
            // labelFY
            // 
            labelFY.AutoSize = true;
            labelFY.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFY.Location = new Point(12, 21);
            labelFY.Name = "labelFY";
            labelFY.Size = new Size(234, 21);
            labelFY.TabIndex = 0;
            labelFY.Text = "Financial Year:  (not selected)";
            // 
            // btnChangeYear
            // 
            btnChangeYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangeYear.Location = new Point(334, 14);
            btnChangeYear.Name = "btnChangeYear";
            btnChangeYear.Size = new Size(148, 35);
            btnChangeYear.TabIndex = 1;
            btnChangeYear.Text = "Change Year";
            btnChangeYear.UseVisualStyleBackColor = true;
            btnChangeYear.Click += btnChangeYear_Click;
            // 
            // labelCurrentText
            // 
            labelCurrentText.AutoSize = true;
            labelCurrentText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentText.Location = new Point(12, 58);
            labelCurrentText.Name = "labelCurrentText";
            labelCurrentText.Size = new Size(123, 21);
            labelCurrentText.TabIndex = 2;
            labelCurrentText.Text = "Current balance:";
            // 
            // labelTBAText
            // 
            labelTBAText.AutoSize = true;
            labelTBAText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTBAText.Location = new Point(12, 95);
            labelTBAText.Name = "labelTBAText";
            labelTBAText.Size = new Size(151, 21);
            labelTBAText.TabIndex = 3;
            labelTBAText.Text = "Time-based balance:";
            // 
            // btnRefreshBalance
            // 
            btnRefreshBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshBalance.Location = new Point(334, 58);
            btnRefreshBalance.Name = "btnRefreshBalance";
            btnRefreshBalance.Size = new Size(148, 58);
            btnRefreshBalance.TabIndex = 4;
            btnRefreshBalance.Text = "Refresh";
            btnRefreshBalance.UseVisualStyleBackColor = true;
            btnRefreshBalance.Click += btnRefreshBalance_Click;
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCurrentBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentBalance.Location = new Point(178, 58);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(150, 21);
            labelCurrentBalance.TabIndex = 5;
            labelCurrentBalance.Text = "0,00";
            labelCurrentBalance.TextAlign = ContentAlignment.TopRight;
            // 
            // labelTBABalance
            // 
            labelTBABalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTBABalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTBABalance.Location = new Point(178, 95);
            labelTBABalance.Name = "labelTBABalance";
            labelTBABalance.Size = new Size(150, 21);
            labelTBABalance.TabIndex = 6;
            labelTBABalance.Text = "0,00";
            labelTBABalance.TextAlign = ContentAlignment.TopRight;
            // 
            // labelIncomeText
            // 
            labelIncomeText.AutoSize = true;
            labelIncomeText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIncomeText.Location = new Point(12, 133);
            labelIncomeText.Name = "labelIncomeText";
            labelIncomeText.Size = new Size(64, 21);
            labelIncomeText.TabIndex = 7;
            labelIncomeText.Text = "Income:";
            // 
            // labelExpensesText
            // 
            labelExpensesText.AutoSize = true;
            labelExpensesText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelExpensesText.Location = new Point(12, 353);
            labelExpensesText.Name = "labelExpensesText";
            labelExpensesText.Size = new Size(51, 21);
            labelExpensesText.TabIndex = 8;
            labelExpensesText.Text = "Costs:";
            // 
            // table_Income
            // 
            table_Income.AllowUserToAddRows = false;
            table_Income.AllowUserToDeleteRows = false;
            table_Income.AllowUserToResizeColumns = false;
            table_Income.AllowUserToResizeRows = false;
            table_Income.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_Income.Location = new Point(12, 157);
            table_Income.Name = "table_Income";
            table_Income.Size = new Size(470, 163);
            table_Income.TabIndex = 9;
            table_Income.CellContentClick += table_Income_CellContentClick;
            // 
            // table_Costs
            // 
            table_Costs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_Costs.Location = new Point(12, 377);
            table_Costs.Name = "table_Costs";
            table_Costs.Size = new Size(470, 165);
            table_Costs.TabIndex = 10;
            // 
            // btnAddIncomeBudget
            // 
            btnAddIncomeBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddIncomeBudget.Font = new Font("Segoe UI", 9F);
            btnAddIncomeBudget.Location = new Point(383, 128);
            btnAddIncomeBudget.Name = "btnAddIncomeBudget";
            btnAddIncomeBudget.Size = new Size(99, 26);
            btnAddIncomeBudget.TabIndex = 11;
            btnAddIncomeBudget.Text = "Add K1";
            btnAddIncomeBudget.UseVisualStyleBackColor = true;
            btnAddIncomeBudget.Click += btnAddIncomeBudget_Click;
            // 
            // btnAddExpenseBudget
            // 
            btnAddExpenseBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddExpenseBudget.Font = new Font("Segoe UI", 9F);
            btnAddExpenseBudget.Location = new Point(383, 348);
            btnAddExpenseBudget.Name = "btnAddExpenseBudget";
            btnAddExpenseBudget.Size = new Size(99, 26);
            btnAddExpenseBudget.TabIndex = 12;
            btnAddExpenseBudget.Text = "Add K1";
            btnAddExpenseBudget.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 554);
            Controls.Add(btnAddExpenseBudget);
            Controls.Add(btnAddIncomeBudget);
            Controls.Add(table_Costs);
            Controls.Add(table_Income);
            Controls.Add(labelExpensesText);
            Controls.Add(labelIncomeText);
            Controls.Add(labelTBABalance);
            Controls.Add(labelCurrentBalance);
            Controls.Add(btnRefreshBalance);
            Controls.Add(labelTBAText);
            Controls.Add(labelCurrentText);
            Controls.Add(btnChangeYear);
            Controls.Add(labelFY);
            MaximumSize = new Size(510, 593);
            MinimumSize = new Size(510, 593);
            Name = "MainForm";
            Text = "BudgetTracker v4";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)table_Income).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_Costs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFY;
        private Button btnChangeYear;
        private Label labelCurrentText;
        private Label labelTBAText;
        private Button btnRefreshBalance;
        private Label labelCurrentBalance;
        private Label labelTBABalance;
        private Label labelIncomeText;
        private Label labelExpensesText;
        private DataGridView table_Income;
        private DataGridView table_Costs;
        private Button btnAddIncomeBudget;
        private Button btnAddExpenseBudget;
    }
}
