using System.Data.SQLite;
using System.IO;
using The_Expenses.InternalWork;
using The_Expenses.Logs;

namespace The_Expenses.ExternalWorking
{
    internal class ExpensesDataBase
    {
        public ExpensesDataBase()
        {
            try
            {
                if (!File.Exists(Config.dataBasePath))
                {
                    CreateTable();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Ошибка при создании базы данных", ex);
            }
        }
        private void CreateTable()
        {
            using (var connection = new SQLiteConnection(Config.connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS purchase_history 
                    (
                        price DECIMAL(10, 2) NOT NULL, 
                        category TEXT NOT NULL, 
                        dateTime DATETIME NOT NULL
                    )";
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void AddData(decimal price, string category)
        {
            using (var connection = new SQLiteConnection(Config.connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO purchase_history (price, category, dateTime) VALUES (@pr, @cat, @dt)";
                    command.Parameters.AddWithValue("@pr", price);
                    command.Parameters.AddWithValue("@cat", category);
                    command.Parameters.AddWithValue("@dt", DateTime.Now);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public List<Purchase> GetData()
        {
            List<Purchase> purchases = new List<Purchase>();
            try
            {
                using (var connection = new SQLiteConnection(Config.connectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT price, category, dateTime FROM purchase_history";

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                purchases.Add(new Purchase
                                {
                                    Price = reader.GetDecimal(0),
                                    Category = reader.GetString(1),
                                    DateTime = reader.GetDateTime(2)
                                });
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Произошла ошибка", ex);
            }
            return purchases;
        }
        public void DeleteData(decimal price, string category)
        {
            using (var connection = new SQLiteConnection(Config.connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM purchase_history WHERE price = @pr AND category = @cat";
                    command.Parameters.AddWithValue("@pr", price);
                    command.Parameters.AddWithValue("@cat", category);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Logger.Log($"{rowsAffected} запись(и) успешно удалены.");
                    }
                    else
                    {
                        Logger.Log($"Запись не найдена.");
                    }
                }
                connection.Close();
            }
        }
    }
}