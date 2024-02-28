using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Reciept
    {
        #region instance field
        public Order
            _order;
        #endregion

        #region constructor
        public Reciept(Order order)
        {
            _order = order; 
        }
        #endregion

        #region properties
        Order Order
        {
            get { return _order; }
        }
        #endregion
        

        #region method
        public override string ToString()
        {
            return $"Reciept for order:\n" +
                   $"{Order}\n" +
                   $"Tax: +25%\n" +
                   $"Delivery cost: 40 kr.\n" +
                   $"Total price: {Order.CalculateTotalPrice()}";
        }
        #endregion
    }
}
