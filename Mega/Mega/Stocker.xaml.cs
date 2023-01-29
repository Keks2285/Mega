using System;
using System.Collections.Generic;
using System.Linq;
using Mega.Models;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using RestSharp;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Mega
{
    /// <summary>
    /// Логика взаимодействия для Stocker.xaml
    /// </summary>
    public partial class Stocker : Window
    {
        public Stocker()
        {
            InitializeComponent();
            if (ModelsRepository.IngridientsList.Count == 0)
            {
                try
                {
                    var req = new RestRequest("/getIngridients", Method.Get);
                    req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    var res = Helper.client.Get(req);
                    ModelsRepository.IngridientsList = JsonConvert.DeserializeObject<BindingList<Ingridients>>(res.Content);
                }
                catch
                {
                    return;
                }
            }
            if (ModelsRepository.WarehousesList.Count == 0)
            {
                try
                {
                    var req = new RestRequest("/getWarehouses", Method.Get);
                    req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    var res = Helper.client.Get(req);
                    ModelsRepository.WarehousesList = JsonConvert.DeserializeObject<BindingList<Warehouse>>(res.Content);
                }
                catch
                {
                    return;
                }
            }
            if (ModelsRepository.SupliesList.Count == 0)
            {
                try
                {
                    var req = new RestRequest("/getSupplies", Method.Get);
                    req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    var res = Helper.client.Get(req);
                    ModelsRepository.SupliesList = JsonConvert.DeserializeObject<BindingList<Supply>>(res.Content);
                }
                catch
                {
                    return;
                }
            }
            IngridientsGrid.ItemsSource = ModelsRepository.IngridientsList;
            WarehousesList.ItemsSource = ModelsRepository.WarehousesList;
        }

        private void SuppliesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void CreateSupplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IngridientsGrid.Items.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы однин ингридиент");
                return;
            }
            if (WarehousesList.SelectedItem==null)
            {
                MessageBox.Show("Выберите склад");
                return;
            }
            if (DateSupply.SelectedDate == null)
            {
                MessageBox.Show("Выберите дату");
                return;
            }
            if (WarehousesList.SelectedItem==null)
            {
                MessageBox.Show("Выберите склад");
                return;
            }
            var req = new RestRequest("/createSupply", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            // req.AddParameter("listdishes", idDishes ToString());
            req.AddParameter("cost", CostTb.Text);
            req.AddParameter("provider", Provider.Text);
            req.AddParameter("date", DateSupply.SelectedDate!.Value.ToString("yyyy-MM-dd hh:mm"));
            req.AddParameter("warehouse_id", (WarehousesList.SelectedItem as Warehouse)!.ID_Warehouse);
            dynamic data = JsonConvert.DeserializeObject<dynamic>(Helper.client.Post(req).Content);
            string idSupply = data["id"];
            ModelsRepository.SupliesList.Add(
                new Supply { 
                ID_Supply= Convert.ToInt32( idSupply),
                DateSupply = DateSupply.SelectedDate!.Value.ToString("yyyy.MM.dd hh:mm"),
                CostSupply = Convert.ToInt32(CostTb.Text),
                Provider = Provider.Text,
                Warehouse_ID = (WarehousesList.SelectedItem as Warehouse)!.ID_Warehouse
                }
                );
            foreach (var item in IngridientsInSupplyGrid.Items)
            {
                var reqDishInOrder = new RestRequest("/createDeliverIngridients", Method.Post);
                reqDishInOrder.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                reqDishInOrder.AddParameter("ingredients_id", (item as Ingridients).ID_Ingredients);
                reqDishInOrder.AddParameter("supply_id", idSupply);
                data = Helper.client.Post(reqDishInOrder);
            }










        }

        private void AddInSupplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IngridientsGrid != null)
            {
                IngridientsInSupplyGrid.Items.Add(IngridientsGrid.SelectedItem);
            }
        }

        private void IngridientsInSupplyGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && IngridientsInSupplyGrid.SelectedItem != null) 
                IngridientsInSupplyGrid.Items.Remove(IngridientsInSupplyGrid.SelectedItem);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new WarehousesSuppliesWindow();
            w.Show();
            this.Hide();
        }
    }
}
