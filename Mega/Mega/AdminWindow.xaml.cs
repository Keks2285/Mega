using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        BindingList<string> dumpsList = new BindingList<string>();
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void CreatePoint_Click(object sender, RoutedEventArgs e)
        {
            var req = new RestRequest("/createbackup", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var res = Helper.client.Post(req);
           // dynamic data = JsonConvert.DeserializeObject<dynamic>(res.Content);
            dumpsList.Add(res.Content.ToString());
            MessageBox.Show("Точка сохранения успешно создана");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var req = new RestRequest("/getDumps", Method.Get);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var res = Helper.client.Get(req);
             dumpsList= JsonConvert.DeserializeObject<BindingList<string>>(res.Content);
            BackupsList.ItemsSource= dumpsList;
        }

        private void ImportPoint_Click(object sender, RoutedEventArgs e)
        {
            var req = new RestRequest("/executebackup", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("nameFile", BackupsList.SelectedValue.ToString());
            var res = Helper.client.Post(req);
            

            MessageBox.Show("Точка сохранения успешно загружена");
        }
    }
}
