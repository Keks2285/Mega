using Newtonsoft.Json;
using RestSharp;
using Mega.Models;
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
    /// Логика взаимодействия для WarehousesSuppliesWindow.xaml
    /// </summary>
    public partial class WarehousesSuppliesWindow : Window
    {
        public WarehousesSuppliesWindow()
        {
            InitializeComponent();
            Supplies.ItemsSource = ModelsRepository.SupliesList;
            WarehousesList.ItemsSource = ModelsRepository.WarehousesList;
            ModelsRepository.WarehousesList.ListChanged += _warehouse_ListChanged;
            ModelsRepository.SupliesList.ListChanged += _supply_ListChanged;
            Supplies.ItemsSource = ModelsRepository.SupliesList;
        }

        private void CreateWareHousebtn_Click(object sender, RoutedEventArgs e)
        {
            var req = new RestRequest("/createWareHouse", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
             req.AddParameter("adres", Adres.Text);
             req.AddParameter("cells", CellsTb.Text);
            req.AddParameter("amount", AmmountTb.Text);
            //req.AddParameter("date", DateSupply.SelectedDate!.Value.ToString("yyyy.MM.dd hh:mm"));
            //req.AddParameter("warehouse_id", (WarehousesList.SelectedItem as Warehouse)!.ID_Warehouse);
            var res = Helper.client.Post(req);
            dynamic data = JsonConvert.DeserializeObject<dynamic>(res.Content);
            ModelsRepository.WarehousesList.Add(new Warehouse
            {
                ID_Warehouse = data["id"],
                Adres = Adres.Text,
                Cells = Convert.ToInt32(CellsTb.Text),
                Amount = Convert.ToInt32(AmmountTb.Text)

            });
        }


        private void _warehouse_ListChanged(object? sender, ListChangedEventArgs e)
        {

            
                var req = new RestRequest("/updateWareHouse", Method.Post);
                req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                req.AddParameter("id", (WarehousesList.SelectedItem as Warehouse).ID_Warehouse);
                req.AddParameter("adres", (WarehousesList.SelectedItem as Warehouse).Adres);
                req.AddParameter("cells", (WarehousesList.SelectedItem as Warehouse).Cells);
                req.AddParameter("amount", (WarehousesList.SelectedItem as Warehouse).Amount);
                var res = Helper.client.Post(req);

            
        }


        private void _supply_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (Supplies.SelectedItem == null) return;

            var req = new RestRequest("/updateSupply", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("id", (Supplies.SelectedItem as Supply).ID_Supply);
            req.AddParameter("provider", (Supplies.SelectedItem as Supply).Provider);
            req.AddParameter("date", (Supplies.SelectedItem as Supply).DateSupply);
            req.AddParameter("cost", (Supplies.SelectedItem as Supply).CostSupply);
            var res = Helper.client.Post(req);


        }

        private void WarehousesList_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Warehouse wh = (WarehousesList.SelectedItem as Warehouse);

            if (e.Key == Key.Delete && WarehousesList.SelectedItem != null)
            {
                MessageBoxButton button = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show("Вы хотите удалить склад, это приведет к удалению\n всех связанных с ним данных.\n Продолжить?", "Предупреждение", button, icon, MessageBoxResult.Yes);
                if (result == MessageBoxResult.Yes)
                {
                    var reqDeleteEmployer = new RestRequest("/removeWareHouse", Method.Post);
                    reqDeleteEmployer.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    reqDeleteEmployer.AddParameter("id", wh.ID_Warehouse);
                    var resDeleteEmployer = Helper.client.Post(reqDeleteEmployer);
                }
                else
                {
                    // _employers.AddNew();
                    ModelsRepository.WarehousesList.Add(wh);
                    return;
                }

            }
        }

        private void Supplies_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Supply sup = (Supplies.SelectedItem as Supply);

            if (e.Key == Key.Delete && Supplies.SelectedItem != null)
            {
                MessageBoxButton button = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result;
                result = MessageBox.Show("Вы хотите удалить эту поставку, это приведет к удалению\n всех связанных с ней данных.\n Продолжить?", "Предупреждение", button, icon, MessageBoxResult.Yes);
                if (result == MessageBoxResult.Yes)
                {
                    var reqDeleteEmployer = new RestRequest("/removeSupply", Method.Post);
                    reqDeleteEmployer.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    reqDeleteEmployer.AddParameter("id", sup.ID_Supply);
                    var resDeleteEmployer = Helper.client.Post(reqDeleteEmployer);
                }
                else
                {
                    // _employers.AddNew();
                    ModelsRepository.SupliesList.Add(sup);
                    return;
                }

            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Stocker();
            this.Hide();
            w.Show();
        }
    }
}
