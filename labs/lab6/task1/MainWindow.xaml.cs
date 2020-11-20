using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using task1.Data;
namespace task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomersCollection items = new CustomersCollection();

        public MainWindow()
        {
            InitializeComponent();
            items.Deserialize();
            ansverResult.ItemsSource = items;

        }

        private int GetAnsver(string s)
        {
            return s.Split().Where(a => a.Length == 5).Count();
        }
         
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            items.Serialize();
            this.Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Address = addressTextBox.Text,
                RegistrationDate = registrationDateTextBox.Text
            };
           // MessageBox.Show(customer.ID.ToString());
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            registrationDateTextBox.Text = "";
            firstNameTextBox.Focus();
            items.AddItem(customer);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var gridparent = ((Button)sender).Parent;
            //var children = ((Grid)gridparent).Children;
            var children = ((StackPanel)gridparent).Children;
            var it = items.DeleteItem(int.Parse(((children[4] as TextBlock).Text)));
        }
    }
}
