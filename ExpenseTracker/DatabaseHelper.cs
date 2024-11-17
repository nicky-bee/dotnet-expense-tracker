using System.Data.SQLite;
using System.Data;

public class DatabaseHelper {
    private readonly string _connectionString;

    public DatabaseHelper(string dbPath) {
        _connectionString = $"Data Source={dbPath};Version=3;";
    }

    public bool ExecuteQuery(string query, SQLiteParameter[] parameters = null) {
        try {
            using (var connection = new SQLiteConnection(_connectionString)) {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection)) {
                    if (parameters != null) {
                        command.Parameters.AddRange(parameters);
                    }

                    command.ExecuteNonQuery();
                }

                return true;
            }
        }
        catch (Exception e) {
            Console.WriteLine($"Error: {e.Message}");
            return false;
        }
    }

    public DataTable GetData(string query, SQLiteParameter[] parameters = null) {
        var table = new DataTable();
        using (var connection = new SQLiteConnection(_connectionString)) {
            connection.Open();
            using (var command = new SQLiteCommand(query, connection)) {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                using (var adapter = new SQLiteDataAdapter(command)) {
                    adapter.Fill(table);
                }
            }
        }
        return table;
    }

    public bool TableExists(string tableName) {
        using var connection = new SQLiteConnection(_connectionString);
        connection.Open();
        string query = "SELECT name FROM sqlite_master WHERE type='table' AND name=@tableName";

        using var command = new SQLiteCommand(query, connection);
        command.Parameters.AddWithValue("@tableName", tableName);
        using var reader = command.ExecuteReader();
        return reader.HasRows;
    }
}