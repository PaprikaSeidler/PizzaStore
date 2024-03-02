﻿using PizzaStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
    {
        #region instance field
        private Pizza
            _pizza;

        private Customer
            _customer;

        private string _orderNo;
        private string _note;
        private double _tax;
        private double _deliveryCost;
        private bool _takeAway;
        #endregion

        #region constructor
        public Order(Pizza pizza, Customer customer, string orderNo, bool isTakeAway)
        {
            _pizza = pizza;
            _customer = customer;
            _orderNo = orderNo;
            _takeAway = isTakeAway;
            
        }
        public Order(Pizza pizza, Customer customer, string orderNo, string note, bool isTakeAway) : this(pizza, customer, orderNo, isTakeAway)
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

        public string OrderNo
        {
            get { return _orderNo; }
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
    