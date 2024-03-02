using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Reciept
    {
        #region instance field
        private Order
            _order;
        private Customer 
            _customer;
        #endregion

        #region constructor
        public Reciept(Order order, Customer customer)
        {
            _order = order;
            _customer = customer;
        }
        #endregion

        #region properties
        Order Order
        {
            get { return _order; }
        }

        Customer Customer 
        { 
            get { return _customer; } 
        }
        #endregion
        
        
        #region method

        public override string ToString() 
        {
            string deliveryInfo = "";
            string customerClubInfo = "";

            if (Order.IsTakeAway)
            {
                deliveryInfo = "Delivery cost: 40 kr.\n";
            }
            if (Customer.IsClubMember)
            {
                customerClubInfo = "As a Customer Clubmember you get 5% discount on order.\n";
            }


            return $"Reciept for order:\n" +
                   $"{Order}\n" +
                   $"Tax: +25%\n" +
                   $"{deliveryInfo}" +
                   $"{customerClubInfo}" +
                   $"Total price: {Order.CalculateTotalPrice()}";
        }
        #endregion
    }
}
