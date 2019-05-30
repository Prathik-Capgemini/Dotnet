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
using System.Data.SqlClient;
using System.Data;
using Capgemini.PolicyEndorsement.BusinessLayer;
using Capgemini.PolicyEndorsement.Entities;
using Capgemini.PolicyEndorsement.Exceptions;

namespace Capgemini.PolicyEndorsement.Application
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataTable customerDetails = PolicyBL.GetAllCustomerBL();
            DataTable dt = customerDetails;
            dgCustomer.ItemsSource = dt.DefaultView;
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {

            Customer customer = new Customer();
            customer.Gender = "X";
            customer.Smoker = "X";
            if (dpDob.Text == "")
            {
                MessageBox.Show("Please add the correct format of the date");
            }
            else
            {
                try
                {

                    customer.CustomerName = txtCustomerName.Text;
                    customer.Address = txtAddress.Text;
                    customer.Telephone = txtTelephone.Text;
                    if (rdGenderM.IsChecked == true)
                    {
                        customer.Gender = "M";
                    }
                    else if (rdGenderF.IsChecked == true)
                    {
                        customer.Gender = "F";
                    }
                    if (rdSmokerN.IsChecked == true)
                    {
                        customer.Smoker = "N";
                    }
                    else if (rdSmokerY.IsChecked == true)
                    {
                        customer.Smoker = "Y";
                    }


                    customer.Hobbies = txtHobbies.Text;
                    customer.Dob = Convert.ToDateTime(dpDob.Text);
                    bool res = PolicyBL.AddCustomerBL(customer);
                    MessageBox.Show("Customer Details have been added successfully");
                    BtnClear_Click(sender, e);
                    LoginGen obj = new LoginGen();
                    obj.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (PolicyException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            //txtAddress.Clear();
            //txtCustomerName.Clear();
            //txtTelephone.Clear();
            //txtHobbies.Clear();
            //rdGenderF.IsChecked = false;
            //rdGenderM.IsChecked = false;
            //rdGenderO.IsChecked = false;
            //rdSmokerY.IsChecked = false;
            //rdSmokerN.IsChecked = false;
            //dpDob.Text = "";
            //txtCustomerName.Focus();

            foreach(Control c in grdCUS.Children)
            {
                if(c is TextBox)
                {
                    (c as TextBox).Clear();
                    
                }
                if(c is RadioButton)
                {
                    (c as RadioButton).IsChecked = false;
                }

                if(c is DatePicker)
                {
                    (c as DatePicker).Text = "";
                }
            }
        }
    }
}
