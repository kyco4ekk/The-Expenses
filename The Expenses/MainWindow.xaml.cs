using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using The_Expenses.ExternalWorking;
using The_Expenses.InternalWork;
using The_Expenses.Logs;

namespace The_Expenses
{
    public partial class MainWindow : Window
    {
        private PieChart pieChartInstance;
        private PieChartWindow pieWindow;
        private ExpensesWindow expensesWindow;
        public MainWindow()
        {
            try
            {
                Logger.ClearLog(); // чистим логи

                InitializeComponent();

                ExpensesDataBase dataBase = new ExpensesDataBase(); // проверка на существование бд
                pieChartInstance = new PieChart();
                this.DataContext = this;

                GetDefaultCategories();
            }
            catch (Exception ex)
            {
                Logger.LogError("Произошла ошибка", ex);
            }            
        }        
        private void GetDefaultCategories()
        {
            int categoriesCount = Expenses.Categories.Length;
            string[] categories = Expenses.Categories;

            for (int i = 0; i < categoriesCount; i++)
                categoryComboBox.Items.Add(categories[i]);
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }       
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ExpensesDataBase expensesDataBase = new ExpensesDataBase();
            try
            {
                bool wasOpenBefore = (pieWindow != null && pieWindow.IsVisible);
                if (wasOpenBefore)
                {
                    pieWindow.Close();
                }

                if (categoryComboBox.SelectedItem == null)
                    MessageBox.Show("Пожалуйста, выберите категорию.");
                else
                {
                    ValidPriceHandler(priceTextBox.Text);
                    Expenses expenses = new Expenses(Convert.ToDecimal(priceTextBox.Text));

                    expensesDataBase.AddData(expenses.Price, categoryComboBox.SelectedItem.ToString());

                    GetDefaultUI();

                    if (wasOpenBefore)
                    {
                        pieChartInstance.LoadData();

                        pieWindow = new PieChartWindow(pieChartInstance.Series);
                        pieWindow.Left = this.Left + this.Width;
                        pieWindow.Top = this.Top;

                        pieWindow.Closed += (s, args) => pieWindow = null;
                        pieWindow.Show();
                    }

                    MessageBox.Show("Успешно!");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Произошла ошибка", ex);
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void ValidPriceHandler(string price)
        {
            string[] piece = price.Split(',');
            if (piece.Length > 2 || piece.Length == 2 && (price.Length - 1 == piece[0].Length || price.Length - 1 == piece[1].Length))
                throw new ArgumentException("Неверный формат цены. Укажите цену товара правильно!");

            if (piece[0][0] == '0' && piece[0].Length > 1)
                throw new ArgumentException("Слишком много нулей в начале. Укажите цену товара правильно!");

            int counterSecondPiece = 0;
            for (int i = 0; i < piece.Length; i++)
            {
                for (int j = 0; j < piece[i].Length; j++)
                {
                    if (!char.IsDigit(piece[i][j]))
                        throw new ArgumentException("Цена введена неверно. Укажите цену товара правильно!");
                    if (i == 1)
                        counterSecondPiece++;
                }
            }

            if (counterSecondPiece > 2)
                throw new ArgumentException("Слишком много цифр после запятой. Такой величины не существует!");
        }        
        private void PriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int caretPosition = priceTextBox.SelectionStart;
            string word = priceTextBox.Text;

            word = word
                .Replace(".", ",")
                .Replace(" ", "")
                .Replace("б", ",")
                .Replace("ю", ",")
                .Replace("Б", ",")
                .Replace("Ю", ",");

            if (word.Length > 9)
                word = word.Substring(0, 9);

            priceTextBox.Text = word;

            if (caretPosition < word.Length)
                priceTextBox.SelectionStart = caretPosition;
            else
                priceTextBox.SelectionStart = word.Length;

            priceTextBox.SelectionLength = 0;
            priceTextBox.Focus();
        }
        private void PriceTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                addButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                e.Handled = true;
            }
        }
        private void GetDefaultUI()
        {
            priceTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
        }
        private void ShowPieChartButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (pieWindow == null || !pieWindow.IsVisible)
                {                    
                    pieChartInstance.LoadData();
                    if(pieChartInstance.Series.Count == 0)
                        throw new ArgumentException("А как рисовать диаграмму без элементов ? Сначала что-нибудь добавь.");
                    
                    pieWindow = new PieChartWindow(pieChartInstance.Series);
                    pieWindow.Left = this.Left + this.Width;  
                    pieWindow.Top = this.Top;

                    pieWindow.Closed += (s, args) => pieWindow = null;  
                    pieWindow.Show();  
                }
                else
                {
                    pieWindow.Focus();  
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Произошла ошибка", ex);
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение для учета расходов.\n" +
                "Было разработано для удобства подсчета затрат.\n\n" +
                "Функционал:\n" +
                "1. Добавление расхода для выбранной категории.\n" +
                "2. Визуальное отслеживание расходов с помощью диаграммы.\n" +
                "3. Более подробный просмотр расходов по ~датам.\n" +
                "4. Удаление неверно указанного расхода в случае оплошности.\n" +
                "Хорошего пользования!\n");
        }
    }
}