using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Silver : Card
    {
        public Silver() { }

        public Silver(string fName, string lName, float turnover) : base(fName, lName, turnover)
        {
            SetDiscountRate();
        }

        public override void SetDiscountRate()
        {
            if (Turnover > 300)
                DiscountRate = 0.035f;
            else
                DiscountRate = 0.02f;
        }
    }
}
