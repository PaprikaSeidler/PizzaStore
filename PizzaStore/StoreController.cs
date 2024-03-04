using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class StoreController
    {
        public void Start()
        {
            //Oprettelse af pizza objecter
            Pizza pizza1 = new Pizza("Margarita", 69);
            Pizza pizza2 = new Pizza("Calzone", 80);
            Pizza pizza3 = new Pizza("Big Mamma", 90);

            //Oprettelse af customer objekter
            Customer customer1 = new Customer("Jura Casper", "København");
            Customer customer2 = new Customer("Casper den sultne pige", "København", true);
            Customer customer3 = new Customer("Supernørden Casper", "København", true);

            //Oprettelse af order objecter som indeholder pizza og customer
            Order order1 = new Order(pizza1, customer1, "1", true);
            Order order2 = new Order(pizza2, customer2, "2", false);
            Order order3 = new Order(pizza3, customer3, "3", "No tomato", true);

            //Oprettelse af reciept objecter som indeholder order og customer
            Reciept reciept1 = new Reciept(order1, customer1);
            Reciept reciept2 = new Reciept(order2, customer2);
            Reciept reciept3 = new Reciept(order3, customer3);

            //Udskrivelse af reciept
            Console.WriteLine(reciept1);
            Console.WriteLine();
            Console.WriteLine(reciept2);
            Console.WriteLine();
            Console.WriteLine(reciept3);
           
        }
    }
}
