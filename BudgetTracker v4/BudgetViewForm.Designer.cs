namespace BudgetTracker_v4
{
    partial class BudgetViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            table_SubBudgets = new DataGridView();
            labelCurrentText = new Label();
            btnRefreshBalance = new Button();
            btnAddIncomeBudget = new Button();
            labelTBAText = new Label();
            labelCurrentBalance = new Label();
            labelTBABalance = new Label();
            labelCurrentBudgetText = new Label();
            labelCurrentBudget = new Label();
            labelBudgetTypeText = new Label();
            labelBudgetType = new Label();
            ((System.ComponentModel.ISupportInitialize)table_SubBudgets).BeginInit();
            SuspendLayout();
            // 
            // table_SubBudgets
            // 
            table_SubBudgets.AllowUserToAddRows = false;
            table_SubBudgets.AllowUserToDeleteRows = false;
            table_SubBudgets.AllowUserToResizeColumns = false;
            table_SubBudgets.AllowUserToResizeRows = false;
            table_SubBudgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_SubBudgets.Location = new Point(12, 183);
            table_SubBudgets.Name = "table_SubBudgets";
            table_SubBudgets.Size = new Size(470, 359);
            table_SubBudgets.TabIndex = 10;
            table_SubBudgets.CellContentClick += table_SubBudgets_CellContentClick;
            // 
            // labelCurrentText
            // 
            labelCurrentText.AutoSize = true;
            labelCurrentText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentText.Location = new Point(12, 87);
            labelCurrentText.Name = "labelCurrentText";
            labelCurrentText.Size = new Size(123, 21);
            labelCurrentText.TabIndex = 11;
            labelCurrentText.Text = "Current balance:";
            // 
            // btnRefreshBalance
            // 
            btnRefreshBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshBalance.Location = new Point(334, 87);
            btnRefreshBalance.Name = "btnRefreshBalance";
            btnRefreshBalance.Size = new Size(148, 58);
            btnRefreshBalance.TabIndex = 12;
            btnRefreshBalance.Text = "Refresh";
            btnRefreshBalance.UseVisualStyleBackColor = true;
            btnRefreshBalance.Click += btnRefreshBalance_Click;
            // 
            // btnAddIncomeBudget
            // 
            btnAddIncomeBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddIncomeBudget.Font = new Font("Segoe UI", 9F);
            btnAddIncomeBudget.Location = new Point(383, 151);
            btnAddIncomeBudget.Name = "btnAddIncomeBudget";
            btnAddIncomeBudget.Size = new Size(99, 26);
            btnAddIncomeBudget.TabIndex = 13;
            btnAddIncomeBudget.Text = "Add K1";
            btnAddIncomeBudget.UseVisualStyleBackColor = true;
            btnAddIncomeBudget.Click += btnAddIncomeBudget_Click;
            // 
            // labelTBAText
            // 
            labelTBAText.AutoSize = true;
            labelTBAText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTBAText.Location = new Point(12, 124);
            labelTBAText.Name = "labelTBAText";
            labelTBAText.Size = new Size(151, 21);
            labelTBAText.TabIndex = 14;
            labelTBAText.Text = "Time-based balance:";
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCurrentBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentBalance.Location = new Point(178, 87);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(150, 21);
            labelCurrentBalance.TabIndex = 15;
            labelCurrentBalance.Text = "0,00";
            labelCurrentBalance.TextAlign = ContentAlignment.TopRight;
            // 
            // labelTBABalance
            // 
            labelTBABalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTBABalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTBABalance.Location = new Point(178, 124);
            labelTBABalance.Name = "labelTBABalance";
            labelTBABalance.Size = new Size(150, 21);
            labelTBABalance.TabIndex = 16;
            labelTBABalance.Text = "0,00";
            labelTBABalance.TextAlign = ContentAlignment.TopRight;
            labelTBABalance.Click += labelTBABalance_Click;
            // 
            // labelCurrentBudgetText
            // 
            labelCurrentBudgetText.AutoSize = true;
            labelCurrentBudgetText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentBudgetText.Location = new Point(12, 9);
            labelCurrentBudgetText.Name = "labelCurrentBudgetText";
            labelCurrentBudgetText.Size = new Size(69, 21);
            labelCurrentBudgetText.TabIndex = 17;
            labelCurrentBudgetText.Text = "Budget:";
            // 
            // labelCurrentBudget
            // 
            labelCurrentBudget.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentBudget.Location = new Point(196, 9);
            labelCurrentBudget.Name = "labelCurrentBudget";
            labelCurrentBudget.Size = new Size(286, 21);
            labelCurrentBudget.TabIndex = 18;
            labelCurrentBudget.Text = "[code] Budget name";
            // 
            // labelBudgetTypeText
            // 
            labelBudgetTypeText.AutoSize = true;
            labelBudgetTypeText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBudgetTypeText.Location = new Point(12, 42);
            labelBudgetTypeText.Name = "labelBudgetTypeText";
            labelBudgetTypeText.Size = new Size(96, 21);
            labelBudgetTypeText.TabIndex = 19;
            labelBudgetTypeText.Text = "Budget type:";
            // 
            // labelBudgetType
            // 
            labelBudgetType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBudgetType.Location = new Point(196, 42);
            labelBudgetType.Name = "labelBudgetType";
            labelBudgetType.Size = new Size(286, 21);
            labelBudgetType.TabIndex = 20;
            labelBudgetType.Text = "INCOME / EXPENSES";
            // 
            // BudgetViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 554);
            Controls.Add(labelBudgetType);
            Controls.Add(labelBudgetTypeText);
            Controls.Add(labelCurrentBudget);
            Controls.Add(labelCurrentBudgetText);
            Controls.Add(labelTBABalance);
            Controls.Add(labelCurrentBalance);
            Controls.Add(labelTBAText);
            Controls.Add(btnAddIncomeBudget);
            Controls.Add(btnRefreshBalance);
            Controls.Add(labelCurrentText);
            Controls.Add(table_SubBudgets);
            MaximumSize = new Size(510, 593);
            MinimumSize = new Size(510, 593);
            Name = "BudgetViewForm";
            Text = "BudgetViewForm";
            Load += BudgetViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)table_SubBudgets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView table_SubBudgets;
        private Label labelCurrentText;
        private Button btnRefreshBalance;
        private Button btnAddIncomeBudget;
        private Label labelTBAText;
        private Label labelCurrentBalance;
        private Label labelTBABalance;
        private Label labelCurrentBudgetText;
        private Label labelCurrentBudget;
        private Label labelBudgetTypeText;
        private Label labelBudgetType;
    }
}