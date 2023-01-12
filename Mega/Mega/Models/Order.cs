using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mega.Models
{
    public class Order : INotifyPropertyChanged
    {
        public int ID_Order { get; set; }
        public int TableNumber { get; set; }
        public string DateOrder { get; set; }
        public int Cost { get; set; }
        private string _status;
        public string Status {
            get {
                return _status;
            }
            set {
                if (value == null)
                {
                    MessageBox.Show("Статус не может быть пустым");
                    return;
                }
                _status = value;
                OnPropertyChanged("Status");
            }
        }
        public List<Dishes> AllDishes = new List<Dishes>();

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
