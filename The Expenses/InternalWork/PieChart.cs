using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Windows;
using The_Expenses.ExternalWorking;
using The_Expenses.InternalWork;

public class PieChart
{
    public List<ISeries> Series { get; set; }
    private int? highlightedIndex;

    public PieChart()
    {
        Series = new List<ISeries>();
        LoadData();
    }
    public void LoadData()
    {
        ExpensesDataBase dataBase = new ExpensesDataBase();
        ExpensesManager expensesManager = new ExpensesManager(dataBase.GetData());
        List<Purchase> purchases = expensesManager.GetPurchasesByCategory();

        Series.Clear();

        foreach (var purchase in purchases)
        {
            double value = (double)purchase.Price;
            string category = purchase.Category;

            // получаем цвет для категории
            if (PieColors.categoryColors.TryGetValue(category, out SKColor color))
            {
                Series.Add(new PieSeries<double>
                {
                    Values = new double[] { value },
                    Fill = new SolidColorPaint(color)
                });
            }
            else
            {
                MessageBox.Show("Нет такой категории");
            }
        }
    }     
}