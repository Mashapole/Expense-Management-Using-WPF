using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihle_POE_18012731
{
    class CalculateExpenses : Expense
    {
        //this variable is going to store income
        public double income;
        //this variable is going to store tax
        public double tax;
        public double groceries;
        public double waterAndLights;
        public double travel;
        public double Cellphone;
        public double other;

        public CalculateExpenses(double income, double tax, double groceries, double waterAndLight, double travel, double Cellphone, double other)
        {
            //
            this.income = income;
            this.tax = tax;
            this.groceries = groceries;
            this.waterAndLights = waterAndLight;
            this.travel = travel;
            this.Cellphone = Cellphone;
            this.other = other;

        }

        public double getIncome()
        {
            return this.income;
        }


        public void setIncome(int income)
        {
            this.income = income;
        }


        public double getTax()
        {
            return this.tax;
        }

        public void getTax(int tax)
        {

            this.tax = tax;
        }



        public double GetGroceries()
        {

            return this.groceries;
        }


        public void setGroceries(int groceries)
        {
            this.groceries = groceries;
        }

        public double GetWaterAndLights()
        {

            return this.waterAndLights;
        }



        public void setWaterAndLight(int water)
        {
            this.waterAndLights = water;
        }

        public double GetTravel()
        {

            return this.travel;
        }



        public void setTravel(int travel)
        {
            this.travel = travel;
        }
        public double GetCellPhone()
        {

            return this.Cellphone;
        }

        public void SetPhone(int phone)
        {
            this.Cellphone = phone;
        }


        public double GetOther()
        {

            return this.other;
        }

        public void GetOther(int other)
        {
            this.other = other;
        }


        //this method is calculating total for all expenses 
        public override double Sum()
        {

            double showCalculations = (tax + groceries + waterAndLights + travel + Cellphone + other);
            return showCalculations;
        }
    }
}
