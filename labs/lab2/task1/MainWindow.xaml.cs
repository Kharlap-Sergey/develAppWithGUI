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
            var el = this.FormulaChoseStackPanel.Children;
            ((RadioButton)el[0]).IsChecked = true;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            
            var formula = (Formula)this.DataContext;
            var ans = $"Лаб. раб. №1 ст.гр.10701219 Харлап С.А.\n" +
                $"x = {formula.X},\ny = {formula.Y},\nz = {formula.Z},\nРезультат = {formula.GetAnsver()}";
            double max = maxCalculationCheckBox.IsChecked == true ? formula.GetMaxAbs() : formula.GetMax();
                ans += $"\nmax = {max}";

            ResultTextBlock.Text = ans;
        }
        private void FormulaChoseStackPanel_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            try
            {
                Formula.U -= Math.Cos;
            }
            catch { }
            try
            {
                Formula.U -= Math.Sin;
            }
            catch { }
            try
            {
                Formula.U -= Math.Log10;
            }
            catch { }
            switch (pressed.Content.ToString())
            {
                case "Cos(x)":
                    {
                        Formula.U += Math.Cos;
                        break;
                    }
                case "Sin(x)":
                    {
                        Formula.U += Math.Sin;
                        break;
                    }
                case "lg(x)":
                    {
                        Formula.U += Math.Log10;
                        break;
                    }
            }
        }
    }
}
