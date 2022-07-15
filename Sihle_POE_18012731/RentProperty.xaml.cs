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
    /// Interaction logic for RentProperty.xaml
    /// </summary>
     public delegate void delgation(string b);

        public class ForReport
        {

            public String a { get; set; }
            public double b { get; set; }
        }

    public partial class RentProperty : Window
    {
        public RentProperty()
        {
            InitializeComponent();
            rdbyes.IsEnabled = false;
            rdbno.IsEnabled = false;
        }

        public static List<Expense> All_rent = new List<Expense>();

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
                new buyVehicle().ShowDialog();
                return true;
            }
            else
            {

                return false;
            }
        }

        private void rdbno_Click(object sender, RoutedEventArgs e)
        {
            foreach (CalculateExpenses sihle_ in MainWindow.All_expenses)
            {

                List<ForReport> forReports = new List<ForReport>()
                                                    {

                                                     new ForReport(){a="your monthly income is:", b= sihle_.getIncome()},
                                                     new ForReport(){a="your tax expenses is:", b=sihle_.getTax()},
                                                     new ForReport(){a="your grocery expenses are:", b=sihle_.GetGroceries()},
                                                     new ForReport(){a="your water and lightrs expenses are:", b=sihle_.GetWaterAndLights()},
                                                     new ForReport(){a="your travel expenses are:", b=sihle_.GetTravel()},
                                                     new ForReport(){a="your cellphone expenses are:", b=sihle_.GetCellPhone()},
                                                     new ForReport(){a="your other expenses are:", b=sihle_.GetOther()},
                                                     new ForReport(){a="Your rent is:", b=amount}
                                                    };


                var orderDescending = from n in forReports
                                      orderby n.b descending
                                      select n;



                foreach (var r in orderDescending)
                {
                    string descending = "";
                    descending= r.a + "" + r.b;

                    rctVehicleReport.Document.Blocks.Add(new Paragraph(new Run(descending.ToString())));
        

                }
               
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

        double store;
        double amount;

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                amount = Convert.ToDouble(txtRent.Text);

                All_rent.Add(new RentHouse(amount));
                System.Windows.Forms.MessageBox.Show("The Expenses Stored", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();

            
                foreach (RentHouse sihle in All_rent)
                {
                    store = sihle.Sum();

                }

                string con = "Total Of Rent:= " + store;
                Notify.Content = con;

                rdbno.IsEnabled = true;
                rdbyes.IsEnabled = true;


            }
            catch (Exception er)
            {
                System.Windows.Forms.MessageBox.Show(er.Message, "Error Say", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Clear()
        {
            txtRent.Clear();
        }
    }
}
