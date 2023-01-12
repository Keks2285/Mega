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
    /// Логика взаимодействия для EmployerCreate.xaml
    /// </summary>
    public partial class EmployerCreate : Window
    {
        public EmployerCreate()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window w = new KadrWindow();
            w.Show();
            this.Hide();
        }

        private void CreateEmployer_Click(object sender, RoutedEventArgs e)
        {
            if (!validateEmplouer()) return;
            try
            {
                var req = new RestRequest("/createEmploye", Method.Post);
                req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                req.AddParameter("firstname", FirstNameTb.Text);
                req.AddParameter("lastname", LastNameTb.Text);
                req.AddParameter("middlename", MiddleNameTb.Text);
                req.AddParameter("email", EmailTb.Text);
                req.AddParameter("password", PasswordTb.Text);
                req.AddParameter("passportNumber", NomerTb.Text);
                req.AddParameter("passportSiries", SeriaTb.Text);
                req.AddParameter("snils",SNILSTb.Text);
                req.AddParameter("position", PostTb.Text);
                req.AddParameter("salary", SalaryTb.Text);
                var res = Helper.client.Post(req);
                dynamic data = JsonConvert.DeserializeObject<dynamic>(res.Content);
            }
            catch
            {

            }
        }

        private bool validateEmplouer()
        {

            if (PostTb.Text == null)
            {
                MessageBox.Show("Введите должность");
                return false;
            }

            if (!Helper.CheckEmail(EmailTb.Text))
            {
                MessageBox.Show("Некорректная почта");
                return false;
            };
            if (SeriaTb.Text.Contains("_"))
            {
                MessageBox.Show("Некорректная серия");
                return false;
            }
            if (NomerTb.Text.Contains("_"))
            {
                MessageBox.Show("Некорректная серия");
                return false;
            }
            if (!Helper.CheckFIO(FirstNameTb.Text) || FirstNameTb.Text.Length < 2)
            {
                MessageBox.Show("Неккоректная фамилия");
                return false;
            };

            if (!Helper.CheckFIO(LastNameTb.Text) || LastNameTb.Text.Length < 2)
            {
                MessageBox.Show("Неккоректное имя");
                return false;
            };

            if (!Helper.CheckFIO(MiddleNameTb.Text) && MiddleNameTb.Text != "")
            {
                MessageBox.Show("Неккоректное отчество");
                return false;
            };

            return true;
        }



    }
}
