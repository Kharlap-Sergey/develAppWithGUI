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
namespace task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<TextBox> items = new ObservableCollection<TextBox>();
        ObservableCollection<StackPanel> items1 = new ObservableCollection<StackPanel>();

        public MainWindow()
        {
            InitializeComponent();
            ansverResult.ItemsSource = items;

            string[] strs = { "100001 111 1 1 111110 00 000 1 1 1 1 1 0000 111 1",
                "1001010 101001 1001010 010 100 100 10 1 1",
                "00101010 10 100 100101 0100 100 101 010010 10",
                "10000 10 10 010 0100101010 0000 11110"
            };

            foreach(var st in strs)
            {
                var text = st;
                var result = new TextBox();
                result.MouseDoubleClick += ansverResult_Selected;
                result.Text = text;
                items.Add(result);
            }
        }

        private int GetAnsver(string s)
        {
            return s.Split().Where(a => a.Length == 5).Count();
        }
        private void enterString_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.Key.ToString());
            if (e.Key == Key.D0 || e.Key == Key.D1)
            {
                return;
            }
            if (e.Key == Key.Return)
            {
                var text = ((TextBox)sender).Text;
                var result = new TextBox();
                result.Text = text;
                ((TextBox)sender).Text = "";
                items.Add(result);
                return;
            }
            e.Handled = true;
        }
         
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ansverResult_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items1.Clear();
            result.ItemsSource = items1;
            foreach(var line in ansverResult.Items)
            {
                var stackPanel = new StackPanel();
                stackPanel.Children.Add(new Label{ Content = ((TextBox)line).Text});
                stackPanel.Children.Add(new Label{ Content = "колличество строк длинны 5 - " + GetAnsver((((TextBox)line).Text)).ToString()});
                items1.Add(stackPanel);
            }
        }
    }
}
