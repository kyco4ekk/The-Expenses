using SkiaSharp;

namespace The_Expenses.InternalWork
{
    internal class PieColors
    {
        public static readonly Dictionary<string, SKColor> categoryColors = new Dictionary<string, SKColor>
        {
        { "Переводы", SKColor.Parse("#FF6F61") },       // Красный
        { "Топливо", SKColor.Parse("#6B5B95") },        // Фиолетовый
        { "Супермаркеты", SKColor.Parse("#88B04B") },   // Зеленый пастельный
        { "ЖКХ", SKColor.Parse("#F7CAC9") },            // Светло-розовый
        { "Аптеки", SKColor.Parse("#92A8D1") },         // Нежно-голубой
        { "Фастфуд", SKColor.Parse("#955251") },        // Коричнево-красный
        { "Красота", SKColor.Parse("#B565A7") },        // Лиловый
        { "Транспорт", SKColor.Parse("#009B77") },      // Темно-зеленый
        { "Животные", SKColor.Parse("#DD4124") },       // Оранжево-красный
        { "Услуги банка", SKColor.Parse("#D65076") },   // Розовый яркий
        { "Связь", SKColor.Parse("#45B8AC") },          // Бирюзовый
        { "Кафе", SKColor.Parse("#EFC050") },           // Желтый
        { "Медицина", SKColor.Parse("#5B5EA6") },       // Синий
        { "Развлечения", SKColor.Parse("#9B2335") },    // Винный
        { "Автоуслуги", SKColor.Parse("#DFCFBE") },     // Бежевый
        { "Цветы", SKColor.Parse("#BC243C") },          // Малиновый
        { "Одежда и обувь", SKColor.Parse("#C3447A") }, // Темный розовый
        { "Другое", SKColor.Parse("#98B4D4") }          // Лавандовый
        };
    }
}
