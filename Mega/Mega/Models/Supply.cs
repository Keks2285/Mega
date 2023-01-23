using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace Mega.Models
{
    public class Supply : INotifyPropertyChanged
    {
        public int ID_Supply { get;set; }
        private string _provider;
        public string Provider {
            get { 
                return _provider; 
            }
            set{
                if (value.Length<2)
                {
                    MessageBox.Show("Название слишком короткое");
                    return;
                } 
                _provider = value;
                OnPropertyChanged("Provider");
            } 
        }
        private string _datesupply;
        public string DateSupply {
            get {
                return _datesupply; 
            }
            set {
                if (!Helper.CheckDate(value))
                {
                    MessageBox.Show("Неверный формат даты");
                    return;
                }
                _datesupply = value;
                OnPropertyChanged("DateSupply");
            } 
        }
        private int _costsupply;
        public int CostSupply { 
            get { 
                return _costsupply; 
            } 
            set {
                if (value <= 0)
                {
                    MessageBox.Show("Стоимостьне может быть меньше или равно 0");
                }
                _costsupply = value;
                OnPropertyChanged("CostSupply");
            } 
        }
        public int Warehouse_ID { get; set; }
        
        public string Warehouse_Adres { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(propertyName, new PropertyChangedEventArgs(propertyName));
        }
    }
}
