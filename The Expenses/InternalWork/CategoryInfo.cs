using System.ComponentModel;
using System.Windows.Media;

namespace The_Expenses.InternalWork
{
    public class CategoryInfo : INotifyPropertyChanged
    {
        private bool _isDeleteVisible;
        public bool IsDeleteVisible
        {
            get => _isDeleteVisible;
            set
            {
                _isDeleteVisible = value;
                OnPropertyChanged(nameof(IsDeleteVisible));
            }
        }
        public string CategoryName { get; set; }
        public string Price { get; set; }
        public Brush CategoryColor { get; set; }
        public string Time { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
