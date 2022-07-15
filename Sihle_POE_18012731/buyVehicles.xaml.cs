using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Sihle_POE_18012731
{
    /// <summary>
    /// Interaction logic for buyVehicles.xaml
    /// </summary>
    public partial class buyVehicles : Window
    {
        public buyVehicles()
        {
            InitializeComponent();
        }

        private void backs_Click(object sender, RoutedEventArgs e)
        {
            back();
        }
        private Boolean back()
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want go to previous page?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                new homeloan().Show();
                return true;
            }
            else
            {

                return false;
            }
        }

        private void quitApplication_Click(object sender, RoutedEventArgs e)
        {
            quit();
        }
        private Boolean quit()
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to quit?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
                return true;
            }
            else
            {

                return false;
            }
        }


        public delegate void delgation(string b);

        public class ForReport
        {

            public String a { get; set; }
            public double b { get; set; }
        }
        List<Expense> All_vehicle = new List<Expense>();
        double store;
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string model;
                double InsurancePremium;
                double purchasePrice;
                double totalDeposit;
                double interestRate;

                model = txtModelAndMake.Text;
                purchasePrice = Convert.ToDouble(txtPurchaseprice.Text);
                totalDeposit = Convert.ToDouble(txtTotalDeposit.Text);
                interestRate = Convert.ToDouble(txtInterest.Text);
                InsurancePremium = Convert.ToDouble(txtInsurancepremium.Text);


                All_vehicle.Add(new PurchaseVehicle(model, purchasePrice, totalDeposit, interestRate, InsurancePremium));
                System.Windows.Forms.MessageBox.Show("The Expenses Stored", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();


                foreach (PurchaseVehicle sihle in All_vehicle)
                {
                    store = sihle.Sum();

                }

                string con = "Total Of Vehicle Installment:= " + store;
                Notify.Content = con;
                double app = store + MainWindow.store+homeloan.store;

                if (app > MainWindow.income * 0.75)
                {
                    delgation d = delegate (string n)
                    {
                        System.Windows.Forms.MessageBox.Show("total expenses, including loan repayments, exceed 75% of their income.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    };

                    foreach (CalculateExpenses s1 in MainWindow.All_expenses)
                    {

                        List<ForReport> forReports = new List<ForReport>()
                                                    {

                                                     new ForReport(){a="your monthly income is:", b= s1.getIncome()},
                                                     new ForReport(){a="your tax expenses is:", b=s1.getTax()},
                                                     new ForReport(){a="your grocery expenses are:", b=s1.GetGroceries()},
                                                     new ForReport(){a="your water and lightrs expenses are:", b=s1.GetWaterAndLights()},
                                                     new ForReport(){a="your travel expenses are:", b=s1.GetTravel()},
                                                     new ForReport(){a="your cellphone expenses are:", b=s1.GetCellPhone()},
                                                     new ForReport(){a="your other expenses are:", b=s1.GetOther() },
                                                     new ForReport(){a="Monthly installment for car is:", b=store},
                                                     new ForReport(){a="Monthly installment for Homeloan is:", b=homeloan.store}};


                        var orderDescending = from n in forReports
                                              orderby n.b descending
                                              select n;

                        string descending = "";

                        foreach (var r in orderDescending)
                        {
                            descending += r.a + "" + r.b + "\n";
                        }

                        rctVehicleReport.Document.Blocks.Add(new Paragraph(new Run(descending.ToString())));
                    }


                }
                else
                {
                    foreach (CalculateExpenses s1 in MainWindow.All_expenses)
                    {

                        List<ForReport> forReports = new List<ForReport>()
                                                    {

                                                     new ForReport(){a="your monthly income is:", b= s1.getIncome()},
                                                     new ForReport(){a="your tax expenses is:", b=s1.getTax()},
                                                     new ForReport(){a="your grocery expenses are:", b=s1.GetGroceries()},
                                                     new ForReport(){a="your water and lightrs expenses are:", b=s1.GetWaterAndLights()},
                                                     new ForReport(){a="your travel expenses are:", b=s1.GetTravel()},
                                                     new ForReport(){a="your cellphone expenses are:", b=s1.GetCellPhone()},
                                                     new ForReport(){a="your other expenses are:", b=s1.GetOther() },
                                                     new ForReport(){a="Monthly installment for car is:", b=store},
                                                    new ForReport(){a="Monthly installment for Homeloan is:", b=homeloan.store}};


                        var orderDescending = from n in forReports
                                              orderby n.b descending
                                              select n;


                        string descending = "";

                        foreach (var r in orderDescending)
                        {
                            descending += r.a + "" + r.b + "\n";
                        }
                        rctVehicleReport.Document.Blocks.Add(new Paragraph(new Run(descending.ToString())));
                    }
                }
            }


            catch (Exception er)
            {
                System.Windows.Forms.MessageBox.Show(er.Message, "Error Say", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Clear()
        {
            txtInsurancepremium.Clear();
            txtInterest.Clear();
            txtModelAndMake.Clear();
            txtPurchaseprice.Clear();
            txtTotalDeposit.Clear();
        }

    }
}
