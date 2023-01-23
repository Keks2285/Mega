using Mega.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            ModelsRepository.DishesList.ListChanged += _dish_CollectionChanged;
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


        private void _dish_CollectionChanged(object sender, ListChangedEventArgs e)
        {
            if (DishesDg.SelectedValue == null) return;

            Dishes Dish = (Dishes)DishesDg.SelectedItem;
            var req = new RestRequest("/updateDish", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("id", Dish.ID_Dishes);
            req.AddParameter("name", Dish.NameDishes);
            req.AddParameter("cost", Dish.Cost);
            req.AddParameter("weight", Dish.Weight);
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
            Ingridients newIngridient = new Ingridients();
            newIngridient.NameIngredients = NameIngridientTb.Text;
            //Ingridients ingridient = (Ingridients)IngridientsGrid.SelectedItem;
            var req = new RestRequest("/createIngridient", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("name", NameIngridientTb.Text);
            var res = Helper.client.Post(req);
            dynamic data = JsonConvert.DeserializeObject<dynamic>(res.Content);
            if (data.id.Value=="0")
            {
                MessageBox.Show("Не удалось добавить ингридиент");
            }
            newIngridient.ID_Ingredients = Convert.ToInt32(data.id.Value);
            ModelsRepository.IngridientsList.Add(newIngridient);    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (NameDishTb.Text.Length < 2)
            {
                MessageBox.Show("Название слишком короткое или пустое");
                return;
            }
            int cost = 0;
            int weigth=0;
            if(!int.TryParse(CostTb.Text, out cost))
            {
                MessageBox.Show("Некорректная цена");
                return;
            }
            if (!int.TryParse(WeghtTb.Text, out weigth))
            {
                MessageBox.Show("Некорректный вес");
                return;
            }

            Dishes newDish = new Dishes();
            newDish.NameDishes = NameDishTb.Text;
            newDish.Cost = cost;
            newDish.Weight = weigth;

            var req = new RestRequest("/createDish", Method.Post);
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddParameter("name", NameDishTb.Text);
            req.AddParameter("cost", CostTb.Text);
            req.AddParameter("weigth",WeghtTb.Text);
            var res = Helper.client.Post(req);
            dynamic data = JsonConvert.DeserializeObject<dynamic>(res.Content);
            if (data.id.Value == "0")
            {
                MessageBox.Show("Не удалось добавить ингридиент");
            }
            newDish.ID_Dishes = Convert.ToInt32(data.id.Value);
            ModelsRepository.DishesList.Add(newDish);

        }
        private static bool IsTextAllowed(string text, int length)
        {
          
            if (text[0]=='0' && length==0)
            {
                return false; 
            }
            Regex onlyNumbers = new Regex("[^0-9]+");
            return !onlyNumbers.IsMatch(text);
        }

        private void CostTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if (CostTb.Text.ToCharArray().Where(c => c == '.').Count() == 1 && e.Text == ".") { e.Handled = false;return; }
            
            e.Handled = !IsTextAllowed(e.Text, CostTb.Text.Length);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Povar();
            this.Hide();
            w.Show();
        }
    }
}
