using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mega
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        bool result = false;
        string FirstName = "";
        string LastName = "";
        string Role = "";
        int Id = 0;
        public Authorization()
        {
            InitializeComponent();
        }

        private async void AuthorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTb.Text;
            string password = PasswordPb.Password;
            await Task.Run(() => auth(email, password));
            switch (Role)
            {
                case "Администратор":
                    { 
                        Window W = new AdminWindow();
                        W.Show();
                        this.Hide();
                        break;
                    }
                case "Кадровый менеджер":
                    {
                        Window W = new KadrWindow();
                        W.Show();
                        this.Hide();
                        break;
                    }
                case "Повар":
                    {
                        Window W = new Povar();
                        W.Show();
                        this.Hide();
                        break;
                    }
                case "Кладовщик":
                    {
                        Window W = new Stocker();
                        W.Show();
                        this.Hide();
                        break;
                    }
            }
        }

        public void auth(string _email, string _password)
        {
            if (_email.Length == 0 || _password.Length == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            try
            {
                var req = new RestRequest("/authorization", Method.Post);
                req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                req.AddParameter("email", _email);
                req.AddParameter("password", _password);
                var res = Helper.client.Post(req);
                dynamic data = JsonConvert.DeserializeObject<dynamic>(res.Content);

               
                if (!data.status.Value) {
                    MessageBox.Show("Такого пользователя нет");
                    result = false; return;
                }
               
                FirstName = Convert.ToString(data.firstname);
                LastName = Convert.ToString(data.lastname);
                Role = Convert.ToString(data.position);
                Id = Convert.ToInt32(data.employer_id);

            }
            catch (Exception e)
            {
                //  MessageBox.Show(e.Message);
            }
        }

    }
}
