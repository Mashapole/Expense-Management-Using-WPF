using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihle_POE_18012731
{
    class PurchaseVehicle : Expense
    {
        public string ModelandMake;
        public double purchasePrice;
        public double totalDeposit;
        public double interestRate;
        public double InsurancePremium;

        public PurchaseVehicle(string ModelandMake, double purchasePrice, double totalDeposit, double interestRate, double InsurancePremium)
        {
            this.ModelandMake = ModelandMake;
            this.purchasePrice = purchasePrice;
            this.totalDeposit = totalDeposit;
            this.interestRate = interestRate;
            this.InsurancePremium = InsurancePremium;
        }


        public string getModelandMake()
        {
            return this.ModelandMake;
        }

        public void setModelandMake(string ModelandMake)
        {
            this.ModelandMake = ModelandMake;
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


        public double getInsurancePremium(double InsurancePremium)
        {
            return this.InsurancePremium;
        }


        public void setInsurancePremium(double InsurancePremium)
        {
            this.InsurancePremium = InsurancePremium;
        }
        public override double Sum()
        {
            double accumulate, principle, i;
            int n;

            principle = purchasePrice - totalDeposit;
            n = 5;
            i = interestRate / 100;
            double month = (5 * 12.0);
            accumulate = (principle * (1 + i * n));

            return (accumulate/month)+InsurancePremium;
        }

    }
}