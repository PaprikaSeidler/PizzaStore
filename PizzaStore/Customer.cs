using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        #region instance field
        private string _name;
        private string _phoneNo;
        private string _address;
        private bool _clubMember;        
        private static readonly Random random = new Random();
        #endregion

        #region constructor
        public Customer(string name, string address) 
        {
            _name = name;
            _phoneNo = GenerateRandomPhoneNo();
            _address = address;
        }

        public Customer(string name, string address, bool clubMember) : this(name, address)
        {
            _clubMember = clubMember;
        }
        #endregion

        #region properties
        public string Name 
        {
            get { return _name; }
        }

        public string Address
        { 
            get { return _address; }
        }

        public bool IsClubMember 
        { 
            get { return _clubMember; }
        }
        #endregion

        #region method        
        private string GenerateRandomPhoneNo()
        {
            string PhoneNo = string.Format("{0:00000000}", random.Next(10000000, 99999999));
            return PhoneNo;
        }

        public override string ToString()
        {
            return $"{Name}, {Address}, +45 {_phoneNo}";
        }
        #endregion
    }
}
                          