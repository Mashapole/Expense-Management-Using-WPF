using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihle_POE_18012731
{
    class HomeLoan : Expense
    {
        public int numberOfMonths;
        public double purchasePrice;
        public double totalDeposit;
        public double interestRate;

        public HomeLoan(double price, double deposit, double interest, int month)
        {
            this.purchasePrice = price;
            this.totalDeposit = deposit;
            this.interestRate = interest;
            this.numberOfMonths = month;
        }


        public double getPurchase()
        {
            return this.purchasePrice;
        }

        public void setPurchase(int price)
        {
            this.purchasePrice = price;
        }


        public double getDeposit()
        {
            return this.totalDeposit;
        }

        public void setDeposit(int deposit)
        {

            this.totalDeposit = deposit;
        }



        public double getInterest()
        {

            return this.interestRate;
        }



        public void setInterest(double interest)
        {
            this.interestRate = interest;
        }


        public int getMonths()
        {
            return this.numberOfMonths;
        }


        public void setMonths(int months)
        {
            this.numberOfMonths = months;
        }

        public override double Sum()
        {
            double accumulate, principle,
           i;
            int n;

            principle = purchasePrice - totalDeposit;
            n = numberOfMonths / 12;
            i = interestRate / 100;

            accumulate = (principle * (1 + i * n));
            return accumulate / numberOfMonths;

        }
    }
}
