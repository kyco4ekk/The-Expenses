using LiveChartsCore;
using LiveChartsCore.Kernel;
using SkiaSharp;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using The_Expenses.ExternalWorking;
using The_Expenses.InternalWork;
using The_Expenses.Logs;

namespace The_Expenses
{
    public partial class PieChartWindow : Window
    {
        public List<ISeries> Series { get; set; }
        private PieChart pieChartInstance;
        private PieChartWindow pieWindow;

        public PieChartWindow(List<ISeries> series)
        {
            InitializeComponent();
            Series = series; // Получаем актуальные данные для диаграммы
            DataContext = this; // Устанавливаем контекст данных

            pieChartInstance = new PieChart();
            this.DataContext = this;
            LoadCategoriesWithColors();
            LoadExpenses();
        }           
        private void LoadCategoriesWithColors()
        {
            ExpensesDataBase dataBase = new ExpensesDataBase();
            ExpensesManager expensesManager = new ExpensesManager(dataBase.GetData());

            List<Purchase> purchases = expensesManager.GetPurchasesByCategory();            
            var uniqueCategories = purchases.Select(p => p.Category).Distinct();

            var categoryInfoList = new List<CategoryInfo>();

            int i = 0;
            foreach (var category in uniqueCategories)
            {               
                if (PieColors.categoryColors.TryGetValue(category, out SKColor skColor))
                {
                    var wpfColor = Color.FromArgb(
                        skColor.Alpha, skColor.Red, skColor.Green, skColor.Blue);

                    var colorBrush = new SolidColorBrush(wpfColor);

                    categoryInfoList.Add(new CategoryInfo
                    {
                        Price = $"{purchases[i++].Price} ₽",
                        CategoryName = category,
                        CategoryColor = colorBrush
                    });
                }
            }
            categoriesListBox.ItemsSource = categoryInfoList;
            allSumTextBox.Text = $"{purchases.Sum(p => p.Price).ToString()} ₽";
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
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ExpensesButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Width == 600)
            {
                this.Width = 940; 
                closeButton.Margin = new Thickness(908, closeButton.Margin.Top, closeButton.Margin.Right, closeButton.Margin.Bottom);

                expensesListBox.Visibility = Visibility.Visible;
                turnLeft.Visibility = Visibility.Visible;
            }            
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

                MessageBox.Show("Диаграмма будет обновлена. Просто откройте ее заново!");
                Close();               
            }
        }

        private void TurnLeft_Click(object sender, RoutedEventArgs e)
        {
            if (this.Width == 940)
            {
                this.Width = 600; 
                closeButton.Margin = new Thickness(568, closeButton.Margin.Top, closeButton.Margin.Right, closeButton.Margin.Bottom);

                expensesListBox.Visibility = Visibility.Collapsed; 
                turnLeft.Visibility = Visibility.Collapsed;
            }
        }
    }
}
