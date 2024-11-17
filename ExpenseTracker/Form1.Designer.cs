namespace ExpenseTracker
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtpDate = new DateTimePicker();
            txtAmount = new NumericUpDown();
            txtCategory = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            txtFilter = new TextBox();
            clearFiltersButton = new Button();
            totalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDate.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(687, 75);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.DecimalPlaces = 2;
            txtAmount.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txtAmount.Location = new Point(687, 133);
            txtAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 25);
            txtAmount.TabIndex = 1;
            txtAmount.ThousandsSeparator = true;
            // 
            // txtCategory
            // 
            txtCategory.AccessibleName = "txtCategory";
            txtCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCategory.Location = new Point(687, 104);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Category";
            txtCategory.Size = new Size(200, 23);
            txtCategory.TabIndex = 2;
            txtCategory.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(687, 162);
            button1.Name = "button1";
            button1.Size = new Size(200, 58);
            button1.TabIndex = 3;
            button1.Text = "Add Expense";
            button1.UseVisualStyleBackColor = false;
            button1.Click += addExpense_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.Size = new Size(669, 465);
            dataGridView1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(687, 430);
            button2.Name = "button2";
            button2.Size = new Size(200, 23);
            button2.TabIndex = 5;
            button2.Text = "Delete Selected";
            button2.UseVisualStyleBackColor = false;
            button2.Click += deleteSelected_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Silver;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(687, 517);
            button3.Name = "button3";
            button3.Size = new Size(200, 23);
            button3.TabIndex = 6;
            button3.Text = "Filter Expenses";
            button3.UseVisualStyleBackColor = false;
            button3.Click += filterExpenses_Click;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFilter.Location = new Point(687, 488);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(200, 23);
            txtFilter.TabIndex = 7;
            // 
            // clearFiltersButton
            // 
            clearFiltersButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearFiltersButton.BackColor = SystemColors.ActiveCaption;
            clearFiltersButton.FlatAppearance.BorderSize = 0;
            clearFiltersButton.FlatStyle = FlatStyle.Flat;
            clearFiltersButton.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearFiltersButton.Location = new Point(687, 459);
            clearFiltersButton.Name = "clearFiltersButton";
            clearFiltersButton.Size = new Size(200, 23);
            clearFiltersButton.TabIndex = 8;
            clearFiltersButton.Text = "Clear Filters";
            clearFiltersButton.UseVisualStyleBackColor = false;
            clearFiltersButton.Click += clearFilters_Click;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.BackColor = Color.FromArgb(224, 224, 224);
            totalLabel.FlatStyle = FlatStyle.Flat;
            totalLabel.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            totalLabel.Location = new Point(687, 223);
            totalLabel.Name = "totalLabel";
            totalLabel.Padding = new Padding(8, 25, 8, 25);
            totalLabel.Size = new Size(200, 69);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Total Spent (Last 30 Days):\r\n";
            totalLabel.TextAlign = ContentAlignment.TopCenter;
            totalLabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 552);
            Controls.Add(totalLabel);
            Controls.Add(clearFiltersButton);
            Controls.Add(txtFilter);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtCategory);
            Controls.Add(txtAmount);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Expense Tracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private NumericUpDown txtAmount;
        private TextBox txtCategory;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private TextBox txtFilter;
        private Button clearFiltersButton;
        private Label totalLabel;
    }
}
