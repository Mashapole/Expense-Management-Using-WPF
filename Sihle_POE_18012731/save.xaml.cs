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
    /// Interaction logic for save.xaml
    /// </summary>
    public partial class save : Window
    {
        public save()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

         
                double price = Convert.ToDouble(txtPrice.Text);
                string reason = txtReason.Text;
                double n = Convert.ToDouble(txtyears.Text);
                double rate = Convert.ToDouble(txtInterest.Text);

                List<Expense> save = new List<Expense>();

                save.Add(new newFeatureSavings(price, reason, n, rate));

                System.Windows.Forms.MessageBox.Show("The Expenses Stored", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cleear();

                double store = 0.0;
                double store2 = 0.0;
                foreach (newFeatureSavings i in save)
                {
                    store = i.Sum();
                    store2 = i.EveryMonthSaving();

                }


                string n1, n2, n3;
                n1 = "To Reach goal, You will have to save" + store2.ToString() + " " + "Every Month";
                n2 = "For period of:\t"+n;
                n3="To reach Your goal of :" + "R " + store;
                Notify.Content = n1;
                Notify2.Content = n2;
                Notify3.Content = n3;
            }
            catch (Exception er)
            {
                System.Windows.Forms.MessageBox.Show(er.Message, "Error Say", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Cleear()
        {
            txtInterest.Clear();
            txtPrice.Clear();
            txtReason.Clear();
            txtyears.Clear();
        }
    }
}
