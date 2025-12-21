namespace BudgetTracker_v4
{
    partial class AddYearForm
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
            label1 = new Label();
            txtBoxYear = new TextBox();
            txtBoxIncome = new TextBox();
            txtBoxExpense = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 0;
            label1.Text = "Year";
            // 
            // txtBoxYear
            // 
            txtBoxYear.Font = new Font("Segoe UI", 12F);
            txtBoxYear.Location = new Point(154, 18);
            txtBoxYear.Name = "txtBoxYear";
            txtBoxYear.Size = new Size(100, 29);
            txtBoxYear.TabIndex = 1;
            // 
            // txtBoxIncome
            // 
            txtBoxIncome.Font = new Font("Segoe UI", 12F);
            txtBoxIncome.Location = new Point(111, 53);
            txtBoxIncome.Name = "txtBoxIncome";
            txtBoxIncome.Size = new Size(143, 29);
            txtBoxIncome.TabIndex = 2;
            // 
            // txtBoxExpense
            // 
            txtBoxExpense.Font = new Font("Segoe UI", 12F);
            txtBoxExpense.Location = new Point(111, 88);
            txtBoxExpense.Name = "txtBoxExpense";
            txtBoxExpense.Size = new Size(143, 29);
            txtBoxExpense.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 4;
            label2.Text = "Income";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 5;
            label3.Text = "Expenses";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F);
            btnConfirm.Location = new Point(154, 137);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 34);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // AddYearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 183);
            Controls.Add(btnConfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxExpense);
            Controls.Add(txtBoxIncome);
            Controls.Add(txtBoxYear);
            Controls.Add(label1);
            MaximumSize = new Size(282, 222);
            MinimumSize = new Size(282, 222);
            Name = "AddYearForm";
            Text = "AddYearForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxYear;
        private TextBox txtBoxIncome;
        private TextBox txtBoxExpense;
        private Label label2;
        private Label label3;
        private Button btnConfirm;
    }
}