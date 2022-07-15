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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Sihle_POE_18012731
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rdbBuy.IsEnabled = false;
            rdbRent.IsEnabled = false;
        }
        

        public static double store;
        public static List<Expense> All_expenses = new List<Expense>();
        public static double income;
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        { 
                try
                {
                   
                    //this variable is going to store tax
                    double tax;
                    double groceries;
                    double waterAndLights;
                    double travel;
                    double Cellphone;
                    double other;

                    income = Convert.ToDouble(txtIncome.Text);
                    tax = Convert.ToDouble(txtTax.Text);
                    groceries = Convert.ToDouble(txtgroceries.Text);
                    waterAndLights = Convert.ToDouble(txtWaterAndLights.Text);
                    travel = Convert.ToDouble(txtTravel.Text);
                    Cellphone = Convert.ToDouble(txtCellPhone.Text);
                    other = Convert.ToDouble(txtOthers.Text);

                    All_expenses.Add(new CalculateExpenses(income, tax, groceries, waterAndLights, travel, Cellphone, other));
                    System.Windows.Forms.MessageBox.Show("The Expenses Stored", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();

                    foreach (CalculateExpenses sihle in All_expenses)
                    {
                        store = sihle.Sum();

                    }

                    string con = "Total Of Expenses:= " +store;
                    Notify.Content = con;

                    rdbBuy.IsEnabled = true;
                    rdbRent.IsEnabled = true;

                }
                catch(Exception er)
                {
                    System.Windows.Forms.MessageBox.Show(er.Message, "Error Say", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }

        private void Clear()
        {
            txtCellPhone.Clear();
            txtgroceries.Clear();
            txtIncome.Clear();
            txtOthers.Clear();
            txtTax.Clear();
            txtTravel.Clear();
            txtWaterAndLights.Clear();
        }

        private void quitApplication_Click(object sender, RoutedEventArgs e)
        {
            quit();
        }

        private Boolean quit()
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to quit?", "Quit Application", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
                return true;
            }
            else
            {

                return false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            saving();
        }

        private Boolean saving()
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to Start Saving?", "Option Savings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            { 
                this.Hide();
                new save().ShowDialog();
                return true;
            }
            else
            {

                return false;
            }
        }

        private void rdbRent_Click(object sender, RoutedEventArgs e)
        {
            Rent();
        }

        private Boolean Rent()
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to Rent Property?", "Option Rent", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                rdbBuy.IsEnabled = false;
                rdbRent.IsEnabled = true;
                this.Hide();
                new RentProperty().ShowDialog();
                return true;
            }
            else
            {

                return false;
            }
        }

        private void rdbBuy_Click(object sender, RoutedEventArgs e)
        {
            buy();
        }

        private Boolean buy()
        {

            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to Buy Property?", "Option Rent", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                rdbBuy.IsEnabled = true;
                rdbRent.IsEnabled = false;
                this.Hide();
                new homeloan().ShowDialog();
                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
