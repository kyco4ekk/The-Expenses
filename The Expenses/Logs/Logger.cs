using System.IO;

namespace The_Expenses.Logs
{
    internal static class Logger
    {
        private static string logFilePath = Path.Combine(AppContext.BaseDirectory, "log.txt");

        public static void ClearLog()
        {
            File.WriteAllText(logFilePath, string.Empty);
        }
        public static void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}:\t{message}");
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Не удалось записать лог: {ex.Message}");
            }
        }
        public static void LogError(string message, Exception ex)
        {         
            Log($"Ошибка: {message} - {ex.Message}");
        }
    }
}
