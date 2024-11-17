using System.Data;
using System.Data.SQLite;
using MaterialSkin.Controls;

namespace ExpenseTracker {
    public partial class Form1 : MaterialForm {
        private readonly DatabaseHelper _databaseHelper;
        private bool isFiltering = false;

        public Form1() {
            InitializeComponent();

            _databaseHelper = new DatabaseHelper("Data Source=ExpenseTracker.db;");

            if (!_databaseHelper.TableExists("Expenses")) {
                string createTableQuery = @"
                    CREATE TABLE Expenses (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Date TEXT NOT NULL,
                        Category TEXT NOT NULL,
                        Amount REAL NOT NULL
                    )";
                _databaseHelper.ExecuteQuery(createTableQuery);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            LoadData();
            LoadCategorySuggestions();
            UpdateTotal();

            clearFiltersButton.Visible = false;
        }

        private void LoadData(string? filterCategory = null) {
            string query;

            if (string.IsNullOrEmpty(filterCategory)) {
                query = "SELECT * FROM Expenses";
                isFiltering = false;
            } else {
                query = "SELECT * FROM Expenses WHERE Category = @Category";
                isFiltering = true;
            }

            // Filter categories if the filter text box is filled in.
            var parameters = new List<SQLiteParameter>();
            if (!string.IsNullOrEmpty(filterCategory)) {
                parameters.Add(new SQLiteParameter("@Category", filterCategory));
            }

            DataTable dataTable = _databaseHelper.GetData(query, parameters.ToArray());

            if (dataTable != null) {
                dataGridView1.DataSource = dataTable;
            } else {
                MessageBox.Show("Failed to load data.");
            }

            // 'Clear Filters' button visibility
            clearFiltersButton.Visible = isFiltering;

            // Update Total Label
            UpdateTotal();
        }

        private void ClearInputs() {
            txtCategory.Text = string.Empty;
            txtAmount.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }

        private void LoadCategorySuggestions() {
            // Get all unique categories from the database
            string query = "SELECT DISTINCT Category FROM Expenses";
            DataTable dataTable = _databaseHelper.GetData(query);

            List<string> categories = new List<string>();

            // Add categories to dropdown menu
            foreach (DataRow row in dataTable.Rows) {
                categories.Add(row["Category"].ToString());
            }

            // Set the autocompletes for the dropdown menus to work
            txtCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFilter.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Populate the dropdown menus with the category list
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(categories.ToArray());
            txtCategory.AutoCompleteCustomSource = autoCompleteCollection;
            txtFilter.AutoCompleteCustomSource = autoCompleteCollection;

        }

        private void UpdateTotal() {
            // Calculate the sum of Amount for the last 30 days
            string query = @"
                SELECT IFNULL(SUM(Amount), 0) AS TotalSpent
                FROM Expenses
                WHERE Date >= DATE('now', '-30 days')";

            DataTable dataTable = _databaseHelper.GetData(query);

            if (dataTable != null && dataTable.Rows.Count > 0) {
                decimal totalSpent = Convert.ToDecimal(dataTable.Rows[0]["TotalSpent"]);

                totalLabel.Text = $"Total Spent (Last 30 Days):\n${totalSpent:0.00}";
            } else {
                totalLabel.Text = "Total Spent (Last 30 Days):\n$0.00";
            }
        }

        /* ========== GUI EVENTS ========== */

        private void addExpense_Click(object sender, EventArgs e) {
            // Get inputs from the form controls
            string category = txtCategory.Text.Trim();
            string amountStr = txtAmount.Text.Trim();
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            // Validate inputs
            if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(amountStr) || !decimal.TryParse(amountStr, out decimal amount)) {
                MessageBox.Show("Please provide valid input for all fields.");
                return;
            }

            if (amount <= 0) {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            // Insert into the database
            string query = "INSERT INTO Expenses (Date, Category, Amount) VALUES (@date, @category, @amount)";
            var parameters = new SQLiteParameter[] {
                new SQLiteParameter("@date", date),
                new SQLiteParameter("@category", category),
                new SQLiteParameter("@amount", amount)
            };

            if (_databaseHelper.ExecuteQuery(query, parameters)) {
                MessageBox.Show("Expense added successfully!");
                ClearInputs(); // Clear the input fields
                LoadData(); // Refresh the DataGridView
            } else {
                MessageBox.Show("Failed to add expense.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void deleteSelected_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected record(s)?",
                                                     "Confirm Deletion",
                                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes) {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows) {
                        // Get the ID of the selected record from the ID column
                        int id = Convert.ToInt32(row.Cells["Id"].Value);

                        string deleteQuery = "DELETE FROM Expenses WHERE Id = @Id";
                        SQLiteParameter[] parameters = new SQLiteParameter[] {
                            new SQLiteParameter("@Id", id)
                        };

                        if (_databaseHelper.ExecuteQuery(deleteQuery, parameters)) {
                            dataGridView1.Rows.Remove(row);
                        } else {
                            MessageBox.Show("Failed to delete the record with ID " + id);
                        }
                    }
                    LoadData();
                }
            } else {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void filterExpenses_Click(object sender, EventArgs e) {
            string selectedCategory = txtFilter.Text.Trim();

            if (!string.IsNullOrEmpty(selectedCategory)) {
                LoadData(selectedCategory);
            } else {
                MessageBox.Show("Please enter or select a category to filter.");
            }
        }

        private void clearFilters_Click(object sender, EventArgs e) {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
