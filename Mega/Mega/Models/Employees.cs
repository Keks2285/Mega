using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mega.Models
{
    public class Employees :INotifyPropertyChanged
    {

        public int ID_Employees { get; set; }

        private string _surename;
        public string Surename { 
            get { 
                return _surename;
            }
            set{
                if (value == null || value == "")
                {
                    _surename = value;
                    OnPropertyChanged("Surename");
                    return;
                }
                if (value.Length < 2)
                {
                    MessageBox.Show("Отчество слишком короткое");
                    return;
                }
                if (!Helper.CheckFIO(value))
                {
                    MessageBox.Show("Отчество должно содержать только кирилицу");
                    return;
                }
                _surename = value;
                OnPropertyChanged("Surname");
            }
        }

        private string _name;
        public string Name { 
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 2)
                {
                    MessageBox.Show("Имя слишком короткое");
                    return;
                }
                if (!Helper.CheckFIO(value))
                {
                    MessageBox.Show("Имя должно содержать только кирилицу");
                    return;
                }
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _lastName;
        public string LastName {
            get { 
                return _lastName;
            }
            set
            {
                if (value.Length < 2)
                {
                    MessageBox.Show("Фамилия слишком короткая");
                    return;
                }
                if (!Helper.CheckFIO(value))
                {
                    MessageBox.Show("Фамилия должно содержать только кирилицу");
                    return;
                }
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        private int _pasportNumber;
        public int PasportNumber {
            get{
                return _pasportNumber;
            }
            set{
                _pasportNumber = value;
                OnPropertyChanged("PasportNumber");
            }
        }
        private int _pasportSiries;
        public int PasportSiries {
            get{
                return  _pasportSiries;
            }
            set{
                _pasportSiries = value;
                OnPropertyChanged("PasportSiries");
            }
        }
        private string _snils;
        public string Snils {
            get { 
                return _snils;
            }
            set { 
                _snils= value;
                OnPropertyChanged("Snils");
            }
        }
        private string _position;
        public string Position { 
            get { 
                return _position; 
            }
            set { 
                _position = value;
                OnPropertyChanged("Position");
            }
        }
        private int _salary;
        public int Salary {
            get { 
                return _salary;
            }
            set { 
                _salary = value;
                OnPropertyChanged("Salary");
            } 
        }
        private string _email;
        public string Email { 
            get { 
                return _email; 
            }
            set { 
                _email = value;
                OnPropertyChanged("Email");
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
