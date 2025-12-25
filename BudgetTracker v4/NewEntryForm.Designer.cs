namespace BudgetTracker_v4
{
    partial class NewEntryForm
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
            labelSelectedBudgetText = new Label();
            labelSelectedBudget = new Label();
            table_SubBudgets = new DataGridView();
            btnBackToParent = new Button();
            labelEntryName = new Label();
            txtBoxAvailable = new TextBox();
            txtBoxName = new TextBox();
            labelCurrentText = new Label();
            txtBoxAmount = new TextBox();
            labelEntryAmount = new Label();
            textBox2 = new TextBox();
            labelRemaning = new Label();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)table_SubBudgets).BeginInit();
            SuspendLayout();
            // 
            // labelSelectedBudgetText
            // 
            labelSelectedBudgetText.AutoSize = true;
            labelSelectedBudgetText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectedBudgetText.Location = new Point(12, 19);
            labelSelectedBudgetText.Name = "labelSelectedBudgetText";
            labelSelectedBudgetText.Size = new Size(138, 21);
            labelSelectedBudgetText.TabIndex = 20;
            labelSelectedBudgetText.Text = "Selected budget:";
            // 
            // labelSelectedBudget
            // 
            labelSelectedBudget.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectedBudget.Location = new Point(196, 19);
            labelSelectedBudget.Name = "labelSelectedBudget";
            labelSelectedBudget.Size = new Size(286, 21);
            labelSelectedBudget.TabIndex = 21;
            labelSelectedBudget.Text = "[code] Budget name";
            // 
            // table_SubBudgets
            // 
            table_SubBudgets.AllowUserToAddRows = false;
            table_SubBudgets.AllowUserToDeleteRows = false;
            table_SubBudgets.AllowUserToResizeColumns = false;
            table_SubBudgets.AllowUserToResizeRows = false;
            table_SubBudgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_SubBudgets.Location = new Point(12, 85);
            table_SubBudgets.Name = "table_SubBudgets";
            table_SubBudgets.Size = new Size(470, 318);
            table_SubBudgets.TabIndex = 22;
            // 
            // btnBackToParent
            // 
            btnBackToParent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBackToParent.Font = new Font("Segoe UI", 9F);
            btnBackToParent.Location = new Point(383, 53);
            btnBackToParent.Name = "btnBackToParent";
            btnBackToParent.Size = new Size(99, 26);
            btnBackToParent.TabIndex = 23;
            btnBackToParent.Text = "Go back";
            btnBackToParent.UseVisualStyleBackColor = true;
            // 
            // labelEntryName
            // 
            labelEntryName.AutoSize = true;
            labelEntryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEntryName.Location = new Point(12, 412);
            labelEntryName.Name = "labelEntryName";
            labelEntryName.Size = new Size(92, 21);
            labelEntryName.TabIndex = 24;
            labelEntryName.Text = "Entry name:";
            // 
            // txtBoxAvailable
            // 
            txtBoxAvailable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxAvailable.Font = new Font("Segoe UI", 12F);
            txtBoxAvailable.Location = new Point(280, 439);
            txtBoxAvailable.Name = "txtBoxAvailable";
            txtBoxAvailable.ReadOnly = true;
            txtBoxAvailable.Size = new Size(202, 29);
            txtBoxAvailable.TabIndex = 25;
            txtBoxAvailable.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxName.Font = new Font("Segoe UI", 12F);
            txtBoxName.Location = new Point(280, 409);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(202, 29);
            txtBoxName.TabIndex = 26;
            txtBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentText
            // 
            labelCurrentText.AutoSize = true;
            labelCurrentText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentText.Location = new Point(12, 442);
            labelCurrentText.Name = "labelCurrentText";
            labelCurrentText.Size = new Size(123, 21);
            labelCurrentText.TabIndex = 27;
            labelCurrentText.Text = "Current balance:";
            // 
            // txtBoxAmount
            // 
            txtBoxAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxAmount.Font = new Font("Segoe UI", 12F);
            txtBoxAmount.Location = new Point(280, 466);
            txtBoxAmount.Name = "txtBoxAmount";
            txtBoxAmount.Size = new Size(202, 29);
            txtBoxAmount.TabIndex = 28;
            txtBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // labelEntryAmount
            // 
            labelEntryAmount.AutoSize = true;
            labelEntryAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEntryAmount.Location = new Point(12, 469);
            labelEntryAmount.Name = "labelEntryAmount";
            labelEntryAmount.Size = new Size(69, 21);
            labelEntryAmount.TabIndex = 29;
            labelEntryAmount.Text = "Amount:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(280, 493);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(202, 29);
            textBox2.TabIndex = 30;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // labelRemaning
            // 
            labelRemaning.AutoSize = true;
            labelRemaning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRemaning.Location = new Point(12, 496);
            labelRemaning.Name = "labelRemaning";
            labelRemaning.Size = new Size(88, 21);
            labelRemaning.TabIndex = 31;
            labelRemaning.Text = "Remaining:";
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirm.Font = new Font("Segoe UI", 9F);
            btnConfirm.Location = new Point(383, 524);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(99, 26);
            btnConfirm.TabIndex = 32;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // NewEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 554);
            Controls.Add(btnConfirm);
            Controls.Add(labelRemaning);
            Controls.Add(textBox2);
            Controls.Add(labelEntryAmount);
            Controls.Add(txtBoxAmount);
            Controls.Add(labelCurrentText);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxAvailable);
            Controls.Add(labelEntryName);
            Controls.Add(btnBackToParent);
            Controls.Add(table_SubBudgets);
            Controls.Add(labelSelectedBudget);
            Controls.Add(labelSelectedBudgetText);
            MaximumSize = new Size(510, 593);
            MinimumSize = new Size(510, 593);
            Name = "NewEntryForm";
            Text = "NewEntryForm";
            Load += NewEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)table_SubBudgets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelectedBudgetText;
        private Label labelSelectedBudget;
        private DataGridView table_SubBudgets;
        private Button btnBackToParent;
        private Label labelEntryName;
        private TextBox txtBoxAvailable;
        private TextBox txtBoxName;
        private Label labelCurrentText;
        private TextBox txtBoxAmount;
        private Label labelEntryAmount;
        private TextBox textBox2;
        private Label labelRemaning;
        private Button btnConfirm;
    }
}