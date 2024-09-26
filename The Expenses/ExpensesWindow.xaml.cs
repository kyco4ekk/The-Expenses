using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using The_Expenses.ExternalWorking;
using The_Expenses.InternalWork;

namespace The_Expenses
{
    internal class DateGroup
    {
        public string Date { get; set; }
        public List<CategoryInfo> Purchases { get; set; }
    }
    public partial class ExpensesWindow : Window
    {
        private PieChart pieChartInstance;
        private PieChartWindow pieWindow;
        public ExpensesWindow()
        {
            InitializeComponent();

            LoadExpenses();
        }
        private void LoadExpenses()
        {
            ExpensesDataBase dataBase = new ExpensesDataBase();
            ExpensesManager expensesManager = new ExpensesManager(dataBase.GetData());

            List<Purchase> purchases = expensesManager.GetPurchases();
            purchases.Reverse();

            var groupedExpenses = purchases
                .GroupBy(p => p.DateTime.Date)
                .Select(g => new DateGroup
                {
                    Date = g.Key.ToShortDateString(),
                    Purchases = g.Select(p => new CategoryInfo
                    {
                        Price = $"{p.Price} ₽",
                        CategoryName = p.Category,
                        Time = p.DateTime.ToShortTimeString()
                    }).ToList()
                }).ToList();

            // Привязываем данные к ListBox
            expensesListBox.ItemsSource = groupedExpenses;
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ExpensesDataBase expensesDataBase = new ExpensesDataBase();

            Button clickedButton = sender as Button;
            var purchase = clickedButton.DataContext as CategoryInfo;

            if (purchase != null)
            {
                decimal price = Convert.ToDecimal(purchase.Price.Replace(" ₽", ""));
                expensesDataBase.DeleteData(price, purchase.CategoryName);

                // Обновляем данные в текущем окне, не закрывая его
                LoadExpenses();                
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }    
}
