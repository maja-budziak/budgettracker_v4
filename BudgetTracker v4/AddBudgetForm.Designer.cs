namespace BudgetTracker_v4
{
    partial class AddBudgetForm
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
            labelK1Text = new Label();
            txtBoxId = new TextBox();
            labelK1Type = new Label();
            labelNameText = new Label();
            txtBoxName = new TextBox();
            labelAvailableBudget = new Label();
            txtBoxAvailable = new TextBox();
            txtBoxAllocated = new TextBox();
            labelAllocatedBudget = new Label();
            labelRemainingBudget = new Label();
            txtBoxRemaining = new TextBox();
            btnConfirm = new Button();
            labelParentBudget = new Label();
            SuspendLayout();
            // 
            // labelK1Text
            // 
            labelK1Text.AutoSize = true;
            labelK1Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelK1Text.Location = new Point(12, 21);
            labelK1Text.Name = "labelK1Text";
            labelK1Text.Size = new Size(71, 21);
            labelK1Text.TabIndex = 3;
            labelK1Text.Text = "K1 Code:";
            // 
            // txtBoxId
            // 
            txtBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxId.Font = new Font("Segoe UI", 12F);
            txtBoxId.Location = new Point(221, 18);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(54, 29);
            txtBoxId.TabIndex = 4;
            txtBoxId.TextAlign = HorizontalAlignment.Right;
            txtBoxId.TextChanged += txtBoxId_TextChanged;
            // 
            // labelK1Type
            // 
            labelK1Type.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelK1Type.Font = new Font("Segoe UI", 8F);
            labelK1Type.Location = new Point(182, 50);
            labelK1Type.Name = "labelK1Type";
            labelK1Type.Size = new Size(93, 21);
            labelK1Type.TabIndex = 5;
            labelK1Type.Text = "(type)";
            labelK1Type.TextAlign = ContentAlignment.TopRight;
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNameText.Location = new Point(12, 73);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(55, 21);
            labelNameText.TabIndex = 6;
            labelNameText.Text = "Name:";
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxName.Font = new Font("Segoe UI", 12F);
            txtBoxName.Location = new Point(73, 70);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(202, 29);
            txtBoxName.TabIndex = 7;
            txtBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // labelAvailableBudget
            // 
            labelAvailableBudget.AutoSize = true;
            labelAvailableBudget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAvailableBudget.Location = new Point(12, 122);
            labelAvailableBudget.Name = "labelAvailableBudget";
            labelAvailableBudget.Size = new Size(76, 21);
            labelAvailableBudget.TabIndex = 8;
            labelAvailableBudget.Text = "Available:";
            // 
            // txtBoxAvailable
            // 
            txtBoxAvailable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxAvailable.Font = new Font("Segoe UI", 12F);
            txtBoxAvailable.Location = new Point(106, 119);
            txtBoxAvailable.Name = "txtBoxAvailable";
            txtBoxAvailable.ReadOnly = true;
            txtBoxAvailable.Size = new Size(169, 29);
            txtBoxAvailable.TabIndex = 9;
            txtBoxAvailable.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBoxAllocated
            // 
            txtBoxAllocated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxAllocated.Font = new Font("Segoe UI", 12F);
            txtBoxAllocated.Location = new Point(106, 154);
            txtBoxAllocated.Name = "txtBoxAllocated";
            txtBoxAllocated.Size = new Size(169, 29);
            txtBoxAllocated.TabIndex = 10;
            txtBoxAllocated.TextAlign = HorizontalAlignment.Right;
            txtBoxAllocated.TextChanged += txtBoxAllocated_TextChanged;
            // 
            // labelAllocatedBudget
            // 
            labelAllocatedBudget.AutoSize = true;
            labelAllocatedBudget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAllocatedBudget.Location = new Point(12, 157);
            labelAllocatedBudget.Name = "labelAllocatedBudget";
            labelAllocatedBudget.Size = new Size(77, 21);
            labelAllocatedBudget.TabIndex = 11;
            labelAllocatedBudget.Text = "Allocated:";
            // 
            // labelRemainingBudget
            // 
            labelRemainingBudget.AutoSize = true;
            labelRemainingBudget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRemainingBudget.Location = new Point(12, 192);
            labelRemainingBudget.Name = "labelRemainingBudget";
            labelRemainingBudget.Size = new Size(88, 21);
            labelRemainingBudget.TabIndex = 12;
            labelRemainingBudget.Text = "Remaining:";
            // 
            // txtBoxRemaining
            // 
            txtBoxRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxRemaining.Font = new Font("Segoe UI", 12F);
            txtBoxRemaining.Location = new Point(106, 189);
            txtBoxRemaining.Name = "txtBoxRemaining";
            txtBoxRemaining.ReadOnly = true;
            txtBoxRemaining.Size = new Size(169, 29);
            txtBoxRemaining.TabIndex = 13;
            txtBoxRemaining.TextAlign = HorizontalAlignment.Right;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F);
            btnConfirm.Location = new Point(182, 224);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(93, 30);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // labelParentBudget
            // 
            labelParentBudget.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelParentBudget.Location = new Point(89, 21);
            labelParentBudget.Name = "labelParentBudget";
            labelParentBudget.Size = new Size(126, 21);
            labelParentBudget.TabIndex = 16;
            labelParentBudget.Text = "-";
            labelParentBudget.TextAlign = ContentAlignment.TopRight;
            // 
            // AddBudgetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 266);
            Controls.Add(labelParentBudget);
            Controls.Add(btnConfirm);
            Controls.Add(txtBoxRemaining);
            Controls.Add(labelRemainingBudget);
            Controls.Add(labelAllocatedBudget);
            Controls.Add(txtBoxAllocated);
            Controls.Add(txtBoxAvailable);
            Controls.Add(labelAvailableBudget);
            Controls.Add(txtBoxName);
            Controls.Add(labelNameText);
            Controls.Add(labelK1Type);
            Controls.Add(txtBoxId);
            Controls.Add(labelK1Text);
            Name = "AddBudgetForm";
            Text = "AddBudgetForm";
            Load += AddBudgetForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelK1Text;
        private TextBox txtBoxId;
        private Label labelK1Type;
        private Label labelNameText;
        private TextBox txtBoxName;
        private Label labelAvailableBudget;
        private TextBox txtBoxAvailable;
        private TextBox txtBoxAllocated;
        private Label labelAllocatedBudget;
        private Label labelRemainingBudget;
        private TextBox txtBoxRemaining;
        private Button btnConfirm;
        private Label labelParentBudget;
    }
}