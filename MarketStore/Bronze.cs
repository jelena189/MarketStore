using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Bronze : Card
    {
        public Bronze() { }

        public Bronze(string fName, string lName, float turnover) : base(fName, lName, turnover)
        {
            SetDiscountRate();
        }

        public override void SetDiscountRate()
        {
            if (Turnover < 100)
                DiscountRate = 0.0f;
            else if (Turnover < 300)
                DiscountRate = 0.01f;
            else
                DiscountRate = 0.035f;
        }
    }
}
