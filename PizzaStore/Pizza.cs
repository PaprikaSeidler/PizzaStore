using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        #region instance field
        private string _name;
        private int _price;
        #endregion

        #region constructor
        public Pizza(string name, int price)
        {
            _name = name;
            _price = price;
        }
        #endregion
        
        #region properties
        public string Name
        { 
            get { return _name; } 
        }

        public int Price
        {
            get { return _price; }
        }
        #endregion

        #region method
        //ToString udskriver navn og pris for en pizza
        public override string ToString()
        {
            return $"{Name}, {Price} kr.";
        }

        #endregion
    }
}
