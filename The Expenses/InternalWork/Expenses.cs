namespace The_Expenses.InternalWork
{
    internal class Expenses
    {
        private static readonly string[] categories = new string[]
        {
            "Переводы", "Топливо", "Супермаркеты",
            "ЖКХ", "Аптеки", "Фастфуд",
            "Красота", "Транспорт", "Животные",
            "Услуги банка", "Связь", "Кафе",
            "Медицина", "Развлечения", "Автоуслуги",
            "Цветы", "Одежда и обувь", "Другое"
        };
        public static string[] Categories
        {
            get
            {
                return categories;
            }
        }
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
        }
        public Expenses(decimal price)
        {
            ValidePrice(price);
            this.price = price;
        }
        private void ValidePrice(decimal price)
        {
            if (price <= 0)
                throw new ArgumentException("Цена введена неверно.");
        }
    }
}
