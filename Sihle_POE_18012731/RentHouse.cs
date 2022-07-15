using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihle_POE_18012731
{
    class RentHouse : Expense
    {
        public double amount;


        public RentHouse(double amount)
        {

            this.amount = amount;
        }

        public double getRentHouse()
        {
            return this.amount;
        }
        public void setRentHouse(double rent)
        {
            this.amount = rent;
        }
        public override double Sum()
        {
            double showCalculations = (amount);
            return showCalculations;
        }
    }
}
