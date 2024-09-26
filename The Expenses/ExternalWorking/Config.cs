using System.IO;
using The_Expenses.InternalWork;

namespace The_Expenses.ExternalWorking
{
    internal class Config
    {
        private static string dataDirectory = AppContext.BaseDirectory;        

        public static readonly string dataBasePath = Path.Combine(dataDirectory, "purchase_history.db");        

        public static readonly string connectionString = $"Data Source={dataBasePath}";        
    }

}
