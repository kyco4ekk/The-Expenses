namespace The_Expenses.InternalWork
{
    internal class ExpensesManager
    {
        private readonly List<Purchase> purchases;
        public ExpensesManager(List<Purchase> purchases)
        {
            this.purchases = purchases;
        }

        // Получить покупки в указанном диапазоне дат. нужно ли ?
        // (нет существующей реализации, есть лишь идея :D)
        public List<Purchase> GetPurchasesByDateRange(DateTime startDate, DateTime endDate)
        {
            return purchases.Where(p => p.DateTime >= startDate && p.DateTime <= endDate).ToList();
        }
        public List<Purchase> GetPurchasesByCategory()
        {
            var categorySums = purchases
            .GroupBy(p => p.Category)
            .Select(g => new Purchase { Category = g.Key, Price = g.Sum(p => p.Price) });

            return categorySums.ToList();
        }
        public List<Purchase> GetPurchases()
        {
            return purchases.ToList();
        }
    }
}
