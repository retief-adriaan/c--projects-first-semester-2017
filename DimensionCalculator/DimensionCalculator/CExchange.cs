using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionCalculator
{
    class CExchange
    {
        // properties with accessors and mutators
        private double fromAmount;
            public double FromAmount
            {
                get { return fromAmount; }
                set { fromAmount = value; }
            }
        private double toAmount;
            public double ToAmount
            {
                get { return toAmount; }
                set { fromAmount = value; }
            }
        //-----------------------------------------------
        // methods
        //-----------------------------------------------
        //ctor
        public CExchange(double from)
        {
            fromAmount = from;
        }

        // calculating toAmount
        public void calcToAmount(double amount, double rateA, double rateB)
        {
            toAmount = Math.Round(amount * 1 / rateA * rateB, 2);
        }
    }
}
