using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihle_POE_18012731
{
    class newFeatureSavings:Expense
    {
        protected double price;
        protected string reasonOfSaving;
        protected double yearsOrMonth;
        protected double rateOrInterest;

        public newFeatureSavings(double price, string reasonOfSaving, double yearsOrMonth, double rateOrInterest)
        {
            this.price = price;
            this.reasonOfSaving = reasonOfSaving;
            this.yearsOrMonth = yearsOrMonth;
            this.rateOrInterest = rateOrInterest;
        }
        public override double Sum()
        {
            //
            //Simple interest is interest calculated only on the initial amount that you invested.
            // The general formula for calculating simple interest is

            //Where: A= P(1 +in)
            //A= accumulated amount(final)
            //P= principal amount(initial)
            //i= interest written as decimal
            //n= number of years
            double A = 0.0;
            double P = 0.0;
            double i = 0.0;
            double n = 0.0;


            P = price;
            i = rateOrInterest / 100;
            n = yearsOrMonth;

            //calculataions 

            A = P * (1 + i * n);
            double month = yearsOrMonth * 12;
            return A;
        }
        public double EveryMonthSaving()
        {
            //
            //Simple interest is interest calculated only on the initial amount that you invested.
           // The general formula for calculating simple interest is

                      //Where: A= P(1 +in)
                      //A= accumulated amount(final)
                      //P= principal amount(initial)
                      //i= interest written as decimal
                      //n= number of years
            double A = 0.0;
            double P = 0.0;
            double i = 0.0;
            double n = 0.0;


            P = price;
            i = rateOrInterest / 100;
            n = yearsOrMonth;

            //calculataions 

            A = P * (1 + i * n);
            double month = yearsOrMonth * 12;
            return A / month;
        }
    }
}
