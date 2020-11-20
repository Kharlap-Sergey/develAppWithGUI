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

namespace task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            Formula formuala = new Formula();
            InitializeComponent();
            this.DataContext = formuala;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            
            var formula = (Formula)this.DataContext;
            ResultTextBlock.Text = $"Лаб. раб. №1 ст.гр.10701219 Харлап С.А.\n" +
                $"x = {formula.X},\ny = {formula.Y},\nz = {formula.Z},\nРезультат = {formula.GetAnsver()}";
        }
    }
}
