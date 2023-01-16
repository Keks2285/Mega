using Mega.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mega
{
    public class ModelsRepository
    {
        //public static void init()
        //{
        //    IngridientsList.ListChanged += _ingridient_CollectionChanged;
        //}


        //private static void _ingridient_CollectionChanged(object sender, ListChangedEventArgs e)
        //{
        //    //MessageBox.Show((sender as Ingridients).NameIngredients);
        //   // MessageBox.Show(((Ingridients)sender).NameIngredients);
        //    //var req = new RestRequest("/updateIngridient", Method.Post);
        //    //req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
        //    //req.AddParameter("id", (sender as Ingridients).ID_Ingredients );
        //    //req.AddParameter("name", (sender as Ingridients).ID_Ingredients);
        //    //var res = Helper.client.Post(req);
        //}

        public static BindingList<Dishes> DishesList = new BindingList<Dishes>();
        public static BindingList<Employees> EmployeesList = new BindingList<Employees>();
        public static BindingList<Order> OrderList = new BindingList<Order>();
        public static BindingList<DishesInOrder> DishesInOrderList = new BindingList<DishesInOrder>();
        public static BindingList<Ingridients> IngridientsList = new BindingList<Ingridients>();
    }
}
