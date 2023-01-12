using Mega.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega
{
    public class ModelsRepository
    {
        public static BindingList<Dishes> DishesList = new BindingList<Dishes>();
        public static BindingList<Employees> EmployeesList = new BindingList<Employees>();
        public static BindingList<Order> OrderList = new BindingList<Order>();
        public static BindingList<DishesInOrder> DishesInOrderList = new BindingList<DishesInOrder>();
    }
}
