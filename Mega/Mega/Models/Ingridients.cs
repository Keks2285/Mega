using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Mega.Models
{
    public class Ingridients:INotifyPropertyChanged
    {
       public  Ingridients(){

        }
        public int ID_Ingredients { get; set;}

        private string _nameIngridients;
        public string NameIngredients
        { 
            get {
                return _nameIngridients; 
            }
            set {
                _nameIngridients = value;
                OnPropertyChanged("NameIngredients");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
