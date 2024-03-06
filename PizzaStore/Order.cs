using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PizzaStore
{
    public class Order
    {
        #region instance field
        private Pizza
            _pizza;

        private Customer
            _customer;

        private static int _orderNo = 1;
        private string _note;
        private double _tax;
        private double _deliveryCost;
        private bool _takeAway;
        #endregion

        #region constructor
        public Order(Pizza pizza, Customer customer, bool isTakeAway)
           // public Order(Pizza pizza, Customer customer, string orderNo, bool isTakeAway)
        {
            _pizza = pizza;
            _customer = customer;
            _orderNo = OrderNo();
            _takeAway = isTakeAway;
            
        }
        public Order(Pizza pizza, Customer customer, string note, bool isTakeAway) : this(pizza, customer, isTakeAway)
           // public Order(Pizza pizza, Customer customer, string orderNo, string note, bool isTakeAway) : this(pizza, customer, orderNo, isTakeAway)
        {
            _note = note;
        }
        #endregion

        #region properties
        public Pizza Pizza
        {
            get { return _pizza; }
        }

        public Customer Customer
        {
            get { return _customer; }
        }

        public string Note
        { 
            get { return _note; } 
        }

        public double Tax
        {
            get { return _tax = 1.25; }
        }

        public double DeliveryCost
        {
            get { return _deliveryCost = 40; }
        }

        public bool IsTakeAway
        {
            get { return _takeAway; }
        }

        #endregion

        #region method
        //Regner totalprisen for ordren. If og if else laver forskellige udregninger alt efter hvilke conditions der er sande.
        public double CalculateTotalPrice()
        {
            double TotalPrice = Pizza.Price * Tax;

            if (IsTakeAway == true && Customer.IsClubMember == true)
            {
                double TotalPriceWithDeliveryAndDiscount = (TotalPrice * 0.95) + 40;
                return TotalPriceWithDeliveryAndDiscount;
            }

            else if (IsTakeAway == true)
            { 
                double TotalPriceWithDelivery = TotalPrice + 40;
                return TotalPriceWithDelivery;
            }
            else if (Customer.IsClubMember == true)
            {
                double TotalPriceWithDiscount = TotalPrice * 0.95;
                return TotalPriceWithDiscount;
            }

            return TotalPrice;
        }

        //Sætter OrderNo +1 hver gang det kaldes.
        public int OrderNo() 
        {
            int OrderNo = _orderNo ++;
            return OrderNo;

        }

        //ToString udskriver ordre nummer, Tostring fra Customer-klassen og Pizza-klassen samt note til ordre.
        public override string ToString()
        {
            return $"Order no.: {OrderNo()}\n" +
                   $"Customer infomation: {Customer}\n" +
                   $"Pizza ordered: {Pizza}\n" +
                   $"Note to resturant: {Note}";
        }
        #endregion
    }
}
    