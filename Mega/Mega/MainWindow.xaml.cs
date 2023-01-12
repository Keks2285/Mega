using Mega.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mega
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a =0;
        Order order = new Order();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (ModelsRepository.DishesList.Count==0)
            {
                var req = new RestRequest("/getDishes", Method.Get);
                req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                var res = Helper.client.Get(req);
                ModelsRepository.DishesList = JsonConvert.DeserializeObject<BindingList<Dishes>>(res.Content);
            }
            Menu.ItemsSource = ModelsRepository.DishesList;
        }

        private void AddInOreder_Click(object sender, RoutedEventArgs e)
        {
            if (Menu.SelectedItem != null)
            {
                OrderList.Items.Add(Menu.SelectedItem);
                order.AllDishes.Add(Menu.SelectedItem as Dishes);
                a = 0;
                foreach (Dishes item in OrderList.Items)
                {
                    a += item.Cost;
                }
                TotalPrice.Content="итоговая стоимость: "+a.ToString();
            }
        }

        private void OrderList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && OrderList.SelectedItem != null){
                OrderList.Items.Remove(OrderList.SelectedItem);
                order.AllDishes.Remove(OrderList.SelectedItem as Dishes);
                a = 0;
                foreach (Dishes item in OrderList.Items)
                {
                    a += item.Cost;
                }
                TotalPrice.Content = "итоговая стоимость: " + a.ToString();
            }
        }

        private void CeateOrder_Click(object sender, RoutedEventArgs e)
        {
            
            if (OrderList.Items.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одно блюдо");
                return;
            }
            
            string code = "";
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                code+= rnd.Next(0, 9);
            }
            int totalPrice = 0;
            List<int> idDishes = new List<int>();
            foreach (var dishes in order.AllDishes )
            {
                idDishes.Add(dishes.ID_Dishes);
                totalPrice += dishes.Cost;
            }
            var req = new RestRequest("/createOrder", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("tablenumber", code);
            req.AddParameter("dateorder", DateTime.Now);
           // req.AddParameter("listdishes", idDishes ToString());
            req.AddParameter("cost", totalPrice);
            dynamic data =  JsonConvert.DeserializeObject<dynamic>(Helper.client.Post(req).Content);
            string idOrder=data["id"];
            foreach (var id in idDishes)
            {
                var reqDishInOrder = new RestRequest("/createDishesInOrder", Method.Post);
                reqDishInOrder.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                reqDishInOrder.AddParameter("dish_id", id.ToString());
                reqDishInOrder.AddParameter("order_id", idOrder);
                data = Helper.client.Post(reqDishInOrder);
            }
            MessageBox.Show("Ваш заказ оформлен, его номер: "+code);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            BindingList<Dishes> _search= new BindingList<Dishes>();
            foreach (Dishes item in ModelsRepository.DishesList.Where(
                item => item.NameDishes.Contains(NameDish.Text) 
                ))
            {
                _search.Add(item);
            }

            Menu.ItemsSource = _search;
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            Window W = new Authorization();
            W.Show();
            this.Hide();
        }
    }
}
