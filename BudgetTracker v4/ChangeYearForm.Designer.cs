namespace BudgetTracker_v4
{
    partial class ChangeYearForm
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
            comBoxYears = new ComboBox();
            btnLoad = new Button();
            btnEdit = new Button();
            btnAddNewYear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Select year:";
            // 
            // comBoxYears
            // 
            comBoxYears.Font = new Font("Segoe UI", 12F);
            comBoxYears.FormattingEnabled = true;
            comBoxYears.Location = new Point(106, 6);
            comBoxYears.Name = "comBoxYears";
            comBoxYears.Size = new Size(121, 29);
            comBoxYears.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(341, 6);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 31);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(260, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 31);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNewYear
            // 
            btnAddNewYear.BackColor = Color.FromArgb(192, 255, 255);
            btnAddNewYear.Font = new Font("Segoe UI", 12F);
            btnAddNewYear.Location = new Point(422, 6);
            btnAddNewYear.Name = "btnAddNewYear";
            btnAddNewYear.Size = new Size(75, 31);
            btnAddNewYear.TabIndex = 4;
            btnAddNewYear.Text = "Add new";
            btnAddNewYear.UseVisualStyleBackColor = false;
            btnAddNewYear.Click += btnAddNewYear_Click;
            // 
            // ChangeYearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 43);
            Controls.Add(btnAddNewYear);
            Controls.Add(btnEdit);
            Controls.Add(btnLoad);
            Controls.Add(comBoxYears);
            Controls.Add(label1);
            Name = "ChangeYearForm";
            Text = "ChangeYearForm";
            Load += ChangeYearForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comBoxYears;
        private Button btnLoad;
        private Button btnEdit;
        private Button btnAddNewYear;
    }
}