using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionCalculator
{
    class CInterest
    {
        // members + accessors & mutators
        private double startAmount;
            public double StartAmount
            {
                get { return startAmount; }
                set { startAmount = value; }
            }
        private double interest;
            public double Interest
            {
                get { return interest; }
                set { interest = value; }
            }
        private double period;
            public double Period
            {
                get { return period; }
                set { period = value; }
            }
        private double endAmount;
            public double EndAmount
            {
                get { return endAmount; }
                set { endAmount = value; }
            }
        //-----------------------------------------------
        // methods
        //-----------------------------------------------
        //ctor
        public CInterest(double s=0.0, double i=0.0, double p=0.0)
        {
            startAmount = s;
            interest = i;
            period = p;
            endAmount = 0.0;
        }

        public double CalculateInterestSimple(double s, double i)
        {
            // calculate simple interest for one period
            endAmount = Math.Round(s * (1 + i), 2);
            return endAmount;
        }

        public double CalculateInterestSimple(double s, double i, double p)
        {
            // calculate simple interest for the specified period
            endAmount = Math.Round(s * Math.Pow((1 + i), p), 2);
            return endAmount;
        }

        public double CalculateInterestCompound(double start, double interest, int number, double period)
        {
            // calculate compound interest for the specified period
            if (number == 0) number = 1;
            endAmount = Math.Round(start * Math.Pow(1 + interest / number, number * period), 2);
            return endAmount;
        }

    }
}
