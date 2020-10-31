using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    abstract class Card
    {
        #region Atributes
        
        string _firstName;
        string _lastName;
        float _discountRate;
        float _turnover;

        #endregion

        #region Properties

        public string FirstName { get { return _firstName; } }

        public string LastName {get { return _lastName;} }

        public float DiscountRate
        {
            get
            {
                return _discountRate;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("discountRate","Discount rate cannot be a negative number!");
                else
                    _discountRate = value;
            }
        }

        public float Turnover
        {
            get
            {
                return _turnover;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("turnover","Turnover cannot be a negative number!");
                else
                    _turnover = value;
            }
        }

        #endregion

        #region Constructors

        public Card()
        {

        }

        public Card(string firstName, string lastName, float turnover)
        {
            if (firstName == "" || lastName == "")
                throw new ArgumentOutOfRangeException("","First name and last name arguments cannot be empty!");
            if (turnover < 0)
                throw new ArgumentOutOfRangeException("turnover","Turnover cannot be a negative number!");
            _firstName = firstName;
            _lastName = lastName;
            _discountRate = 0;
            _turnover = turnover;
        }

        #endregion

        #region Methods

        public abstract void SetDiscountRate();
        
        public string Purchase(double purchaseValue)            
        {                                                 
            double discount = _discountRate * purchaseValue;
            double total = purchaseValue - discount;

            return "Purchase value: " + purchaseValue.ToString("c2") + "\n"
                + "Discount rate: " + _discountRate * 100 + "% \n"     
                + "Discount: " + discount.ToString("c2") + "\n"
                + "Total: " + total.ToString("c2") + "\n";
        }

        #endregion
    }
}
