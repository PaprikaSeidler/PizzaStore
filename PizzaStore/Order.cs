using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
    {
        #region instance field
        public Pizza
            _pizza;

        public Customer
            _customer;

        private string _orderNo;
        private string _note;
        #endregion

        #region constructor
        public Order(Pizza pizza, Customer customer, string orderNo, string note)
        {
            _pizza = pizza;
            _customer = customer;
            _orderNo = orderNo;
            _note = note;
        }

        public Order(Pizza pizza, Customer customer, string orderNo)
        {
            _pizza = pizza;
            _customer = customer;
            _orderNo = orderNo;
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

        public string OrderNo
        {
            get { return _orderNo; }
        }

        public string Note
        { 
            get { return _note; } 
        }
        #endregion

        #region method
        public double CalculateTotalPrice()
        {
            double Tax = 1.25;
            double DeliveryCost = 40;

            double TotalPrice = (Pizza.Price * Tax) + DeliveryCost;

            return TotalPrice;
        }


        public override string ToString()
        {
            return $"Order no.: {OrderNo}\n" +
                   $"Customer infomation: {Customer}\n" +
                   $"Pizza ordered: {Pizza}\n" +
                   $"Note to resturant: {Note}";
        }
        #endregion
    }
}
    