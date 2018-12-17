namespace BatchRenamer
{
    partial class BatchRenamerForm
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
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.NameRuleTextBox = new System.Windows.Forms.TextBox();
            this.NameRuleLabel = new System.Windows.Forms.Label();
            this.ApplyRuleButton = new System.Windows.Forms.Button();
            this.VariableGrid = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BeginIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VariableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(24, 123);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "选择文件";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // NameRuleTextBox
            // 
            this.NameRuleTextBox.Location = new System.Drawing.Point(82, 42);
            this.NameRuleTextBox.Name = "NameRuleTextBox";
            this.NameRuleTextBox.Size = new System.Drawing.Size(521, 20);
            this.NameRuleTextBox.TabIndex = 1;
            // 
            // NameRuleLabel
            // 
            this.NameRuleLabel.AutoSize = true;
            this.NameRuleLabel.Location = new System.Drawing.Point(21, 45);
            this.NameRuleLabel.Name = "NameRuleLabel";
            this.NameRuleLabel.Size = new System.Drawing.Size(61, 13);
            this.NameRuleLabel.TabIndex = 2;
            this.NameRuleLabel.Text = "命名规则：";
            // 
            // ApplyRuleButton
            // 
            this.ApplyRuleButton.Location = new System.Drawing.Point(24, 82);
            this.ApplyRuleButton.Name = "ApplyRuleButton";
            this.ApplyRuleButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyRuleButton.TabIndex = 3;
            this.ApplyRuleButton.Text = "应用规则";
            this.ApplyRuleButton.UseVisualStyleBackColor = true;
            this.ApplyRuleButton.Click += new System.EventHandler(this.ApplyRuleButton_Click);
            // 
            // VariableGrid
            // 
            this.VariableGrid.AllowUserToAddRows = false;
            this.VariableGrid.AllowUserToDeleteRows = false;
            this.VariableGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.VariableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VariableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.RuleColumn,
            this.BeginIndex,
            this.EndIndex});
            this.VariableGrid.Location = new System.Drawing.Point(24, 164);
            this.VariableGrid.Name = "VariableGrid";
            this.VariableGrid.Size = new System.Drawing.Size(585, 214);
            this.VariableGrid.TabIndex = 4;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "序号";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // RuleColumn
            // 
            this.RuleColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.RuleColumn.HeaderText = "规则";
            this.RuleColumn.Items.AddRange(new object[] {
            "自增",
            "自减"});
            this.RuleColumn.Name = "RuleColumn";
            // 
            // BeginIndex
            // 
            this.BeginIndex.HeaderText = "起始值";
            this.BeginIndex.Name = "BeginIndex";
            // 
            // EndIndex
            // 
            this.EndIndex.HeaderText = "结束值";
            this.EndIndex.Name = "EndIndex";
            // 
            // BatchRenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 390);
            this.Controls.Add(this.VariableGrid);
            this.Controls.Add(this.ApplyRuleButton);
            this.Controls.Add(this.NameRuleLabel);
            this.Controls.Add(this.NameRuleTextBox);
            this.Controls.Add(this.SelectFileButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchRenamerForm";
            this.Text = "批量重命名";
            ((System.ComponentModel.ISupportInitialize)(this.VariableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox NameRuleTextBox;
        private System.Windows.Forms.Label NameRuleLabel;
        private System.Windows.Forms.Button ApplyRuleButton;
        private System.Windows.Forms.DataGridView VariableGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RuleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndIndex;
    }
}

