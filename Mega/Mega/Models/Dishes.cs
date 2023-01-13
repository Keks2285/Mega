using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace Mega.Models
{
    public class Dishes:INotifyPropertyChanged
    {
        public int ID_Dishes { get; set; }

        private string _nameDishes;
        public string NameDishes { 
            get { 
                return _nameDishes; 
            }
            set {
                if (value.Length < 3){
                    MessageBox.Show("Название слишком короткое");
                    return;
                }
                _nameDishes = value; 
            }
        }
        private int _cost;
        public int Cost { 
            get {
                return _cost;
            }
            set {
                if (value <= 0)
                {
                    MessageBox.Show("Стоимость не может быть меньше 0");
                    return;
                }
                _cost = value;
                OnPropertyChanged("Cost");
            }
        }
        private int _weight;
        public int Weight {
            get { 
                return _weight; 
            }
            set {
                if (value <= 0)
                {
                    MessageBox.Show("Вес не может быть меньше или равен 0");
                    return;
                }
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
