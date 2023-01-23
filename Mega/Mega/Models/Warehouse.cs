using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace Mega.Models
{
    public class Warehouse : INotifyPropertyChanged
    {

        public int ID_Warehouse { get; set; }

        private int _cells;
        public int Cells { 
            get {
                return _cells;
            } 
            set {
                if (value <= 0)
                {
                    MessageBox.Show("Количество ячеек не может быть меньше или равно 0");
                    return;
                }
                _cells = value;
                OnPropertyCahnged("Cells");
            } 
        }
        private string _adres;
        public string Adres { 
            get { 
                return _adres; 
            } 
            set {
                if (value.Length<=2)
                {
                    MessageBox.Show("Адрес слишком короткий");
                    return;
                }
                _adres = value;
                OnPropertyCahnged("Adres");
            }
        }
        private int _amount;
        public int Amount { 
            get {
                
                return _amount;
            } 
            set {
                if (value <= 0)
                {
                    MessageBox.Show("Количество не может быть меньше или равно 0");
                    return;
                }
                _amount = value;
                OnPropertyCahnged("Amount");
            } 
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyCahnged(string propertyName)
        {
            PropertyChanged?.Invoke(propertyName, new PropertyChangedEventArgs(propertyName));
        }
    }
}
