using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Gold : Card
    {

        public Gold() { }

        public Gold(string fName, string lName, float turnover) : base(fName, lName, turnover)
        {

            SetDiscountRate();
        }

        public override void SetDiscountRate()
        {
            if (Turnover < 100)
                DiscountRate = 0.02f;
            else if (Turnover < 800)
            {
                int nrOfAddition = (int)Turnover / 100;
                DiscountRate = 0.02f + (float)nrOfAddition / 100;
            }
            else
                DiscountRate = 0.1f;
        }
    }
}
