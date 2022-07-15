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
    /// Interaction logic for homeloan.xaml
    /// </summary>
    public partial class homeloan : Window
    {
        public homeloan()
        {
            InitializeComponent();
            rdbyes.IsEnabled = false;
            rdbno.IsEnabled = false;
        }
        public delegate void delgation(string b);

        public class ForReport
        {

            public String a { get; set; }
            public double b { get; set; }
        }
        public static List<Expense> all = new List<Expense>();
        public static double store;
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double price;
                double deposit;
                double interest;
                int years;

                price = Convert.ToDouble(txtPurchasePrice.Text);
                deposit = Convert.ToDouble(txtTotaldeposit.Text);
                interest = Convert.ToDouble(txtInterest.Text);
                years = Convert.ToInt32(txtNumber.Text);


                all.Add(new HomeLoan(price, deposit, interest, years));
                System.Windows.Forms.MessageBox.Show("The Expenses Stored", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();


                foreach (HomeLoan sihle in all)
                {
                    store = sihle.Sum();

                    if (Convert.ToDouble(MainWindow.income) > Convert.ToDouble(store))
                    {

                        if (years >= 240 && years <= 360)
                        {

                            string con = "Total Of Home Installment:= " + store;
                            Notify.Content = con;
                            double app = store + MainWindow.store;

                            rdbyes.IsEnabled = true;
                            rdbno.IsEnabled = true;

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Can You Please Enter Months between 240 and 360 ", "Error Say", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                    else
                    {
                        System.Windows.Forms.MessageBox.Show("The Homeloan is Higher than your pay", "Error Says", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            txtInterest.Clear();
            txtNumber.Clear();
            txtPurchasePrice.Clear();
            txtTotaldeposit.Clear();
        }

        private void rdbyes_Click(object sender, RoutedEventArgs e)
        {
            yes();

        }

        private Boolean yes()
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to Buy Vehicle?", "Option Buy Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                rdbyes.IsEnabled = true;
                rdbno.IsEnabled = false;
                this.Hide();
                new buyVehicles().ShowDialog();
                return true;
            }
            else
            {

                return false;
            }
        }
        private void rdbno_Click(object sender, RoutedEventArgs e)
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
                                                     new ForReport(){a="Monthly installment for homeloan is:", b=store} };


                var orderDescending = from n in forReports
                                      orderby n.b descending
                                      select n;


                string descending = "";

                foreach (var r in orderDescending)
                {
                    descending+= r.a + "" + r.b+"\n";
                }
                rctVehicleReport.Document.Blocks.Add(new Paragraph(new Run(descending.ToString())));
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


        private void back_Click(object sender, RoutedEventArgs e)
        {
            back2();
        }
        private Boolean back2()
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want go to previous page?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                new MainWindow().Show();
                return true;
            }
            else
            {

                return false;
            }
        }

    }
}
