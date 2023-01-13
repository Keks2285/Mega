using Mega.Models;
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

            DishesDg.ItemsSource = ModelsRepository.DishesList;
        }

        private void IngridientsGrid_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
