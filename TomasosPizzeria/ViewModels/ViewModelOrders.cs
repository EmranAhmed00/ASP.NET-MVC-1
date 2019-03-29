using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomasosPizzeria.Models;

namespace TomasosPizzeria.ViewModels
{
    public class ViewModelOrders
    {
        public List<Bestallning> orderDetails { get; set; }
        public List<Kund> customerDetails { get; set; }
        public Kund newCustomers { get; set; }
        public List<Produkt> productName { get; set; }
        public List<Matratt> orderedDishes { get; set; }
        public Matratt currentDish { get; set; }
        public List<MatrattTyp> dishTypes { get; set; }
        public Kund loggedCustomer { get; set; }
        public Dictionary<string, List<Matratt>> dishByTypes { get; set; }

        public Dictionary<Matratt, string> dishIngredients { get; set; }


        public ViewModelOrders()
        {
            orderDetails = new List<Bestallning>();
            customerDetails = new List<Kund>();
            productName = new List<Produkt>();
            orderedDishes = new List<Matratt>();
            currentDish = new Matratt();
            dishTypes = new List<MatrattTyp>();
            newCustomers = new Kund();
            loggedCustomer = new Kund();
            dishByTypes = new Dictionary<string, List<Matratt>>();

            dishIngredients = new Dictionary<Matratt, string>();
        }

    }
}
