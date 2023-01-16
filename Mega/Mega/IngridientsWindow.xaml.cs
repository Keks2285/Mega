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
    /// Логика взаимодействия для Ingridients.xaml
    /// </summary>
    public partial class IngridientsWindow : Window
    {
        public IngridientsWindow()
        {
            InitializeComponent();
            var req = new RestRequest("/getIngridients", Method.Get);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            var res = Helper.client.Get(req);
            List<Ingridients> IngridientData = JsonConvert.DeserializeObject<List<Ingridients>>(res.Content);
            if (ModelsRepository.IngridientsList.Count == 0)
                foreach (Ingridients ingridient in IngridientData)
                {
                    ModelsRepository.IngridientsList.Add(ingridient);
                }
            IngridientsGrid.ItemsSource = ModelsRepository.IngridientsList;
            ModelsRepository.IngridientsList.ListChanged += _ingridient_CollectionChanged;
            DishesDg.ItemsSource = ModelsRepository.DishesList;
        }

        private void _ingridient_CollectionChanged(object sender, ListChangedEventArgs e)
        {

            if (IngridientsGrid.SelectedValue == null) return;

            Ingridients ingridient = (Ingridients)IngridientsGrid.SelectedItem;
            var req = new RestRequest("/updateIngridient", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("id", ingridient.ID_Ingredients);
            req.AddParameter("name", ingridient.NameIngredients);
            var res = Helper.client.Post(req);
        }

        private void IngridientsGrid_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddIngridient_Click(object sender, RoutedEventArgs e)
        {
            if (NameIngridientTb.Text.Length < 2) {
                MessageBox.Show("Название слишком короткое или пустое");
                return;
            }

            //Ingridients ingridient = (Ingridients)IngridientsGrid.SelectedItem;
            var req = new RestRequest("/createIngridient", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("name", NameIngridientTb.Text);
            var res = Helper.client.Post(req);
            dynamic data = JsonConvert.DeserializeObject<dynamic>(res.Content);
            if (data.id.Value==0)
            {
                MessageBox.Show("Не удалось добавить ингридиент");
            }
        }
    }
}
