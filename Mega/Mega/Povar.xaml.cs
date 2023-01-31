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
using System.Windows.Shapes;

namespace Mega
{
    /// <summary>
    /// Логика взаимодействия для Stocker.xaml
    /// </summary>
    public partial class Povar : Window
    {
        List<Order> Orderdata = new List<Order>();
        List<DishesInOrder> DishesInOrderData = new List<DishesInOrder>();
        BindingList<Dishes> dishes = new BindingList<Dishes>();
        public Povar()
        {
            InitializeComponent();
            var req = new RestRequest("/getOrders", Method.Get);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var res = Helper.client.Get(req);
            Orderdata = JsonConvert.DeserializeObject<List<Order>>(res.Content);
            if (ModelsRepository.OrderList.Count == 0)
                foreach (Order order in Orderdata)
                {
                    ModelsRepository.OrderList.Add(order);
                }
            OrdersGrid.ItemsSource = ModelsRepository.OrderList;

            var req1 = new RestRequest("/getDishesInOrders", Method.Get);
            req1.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var res1 = Helper.client.Get(req1);
            DishesInOrderData = JsonConvert.DeserializeObject<List<DishesInOrder>>(res1.Content);
            if (ModelsRepository.DishesInOrderList.Count == 0)
                foreach (DishesInOrder dishe in DishesInOrderData)
                {
                    ModelsRepository.DishesInOrderList.Add(dishe);
                }
            ModelsRepository.OrderList.ListChanged += _orders_CollectionChanged;
            //ModelsRepository.OrderList.ListChanged += null;
            //ModelsRepository.EmployeesList.ListChanged += _employes_CollectionChanged;
        }
        private void _orders_CollectionChanged(object sender, ListChangedEventArgs e)
        {
            if (OrdersGrid.SelectedItem == null) return;
            Order order = (Order)OrdersGrid.SelectedItem;
            var requpdateOrder = new RestRequest("/updateOrder", Method.Post);
            requpdateOrder.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            requpdateOrder.AddParameter("status", order.Status);
            requpdateOrder.AddParameter("id", order.ID_Order);
            var resupdateOrder = Helper.client.Post(requpdateOrder);
            
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void OrdersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrdersGrid.SelectedItem == null) return;
            dishes.Clear();
            List<int> Id_Dishes = new List<int>();
            foreach (DishesInOrder dishesInOrder in  ModelsRepository.DishesInOrderList.Where(item=>item.Order_ID==(OrdersGrid.SelectedItem as Order).ID_Order))
            {
                Id_Dishes.Add(dishesInOrder.Dishes_ID);
            }

            foreach(int idDish in Id_Dishes)
            {
                dishes.Add(ModelsRepository.DishesList.FirstOrDefault(item => item.ID_Dishes== idDish));
            }
            DishesDg.ItemsSource = dishes;
            //dishes = ModelsRepository.DishesList.Where(item=>item); 

        }

        private void OrdersGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && OrdersGrid.SelectedItem != null)
            {
                var reqdeleteOrder = new RestRequest("/deleteOrder", Method.Post);
                reqdeleteOrder.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                reqdeleteOrder.AddParameter("id", (OrdersGrid.SelectedItem as Order).ID_Order);
                var resdeleteOrder = Helper.client.Post(reqdeleteOrder);
            }
        }

        private void IngridientsBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new IngridientsWindow();
            w.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new MainWindow();
            this.Hide();
            w.Show();
        }
    }
}

