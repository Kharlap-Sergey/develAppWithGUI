using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
        
        public class ID
        {
            public int I { set; get; }
            public int J { set; get; }
        }
        public MainWindow()
        {
            Formula formula = new Formula();
            InitializeComponent();

            this.DataContext = formula;
            ExecuteButton.IsEnabled = false;
        }

    
        private void ExecuteButton_Click(object sender, RoutedEventArgs e = null)
        {

            var formula = (Formula)this.DataContext;

            var n = formula.N;
            var k = formula.K;
            var m = formula.M;
            bool buf = true;
            for(int i = 2; i <= n; i++)
            {
                if( ((TextBox)(((StackPanel)(table.Items[i])).Children[k])).Text != "0")
                {
                    buf = false;
                    break;
                }
            }
             ((TextBox)(((StackPanel)(table.Items[1])).Children[k])).Text = buf ? "0": "1";
        }

        private void Cell_DoubleClick(object sender, RoutedEventArgs e)
        {
            var ID = (ID)((TextBox)sender).DataContext;
            iTextBlock.Text = ID.I.ToString();
            jTextBlock.Text = ID.J.ToString();
            var formula = (Formula)this.DataContext;
            formula.K = ID.J;
            ExecuteButton_Click(ExecuteButton);    
          
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            var formula = (Formula)this.DataContext;
            ObservableCollection<StackPanel> collection = new ObservableCollection<StackPanel>();
            table.ItemsSource = collection;

            var rm = new Random();
            int n = formula.N, m = formula.M;
            for (int i = 0; i <= n; i++)
            {
                var t = new StackPanel();
                t.Orientation = Orientation.Horizontal;
                for (int j = 0; j <= m; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        if (j == 0) t.Children.Add(new Label { Content = $"{i}", Width = 100,
                            HorizontalContentAlignment = HorizontalAlignment.Center});
                        else t.Children.Add(new Label { Content = $"{j}", Width = 100,
                            HorizontalContentAlignment = HorizontalAlignment.Center});
                    }
                    else
                    {
                        var newBox = new TextBox
                        {
                            Width = 100,
                            HorizontalContentAlignment = HorizontalAlignment.Center,
                            Text = $"{rm.Next(0, 9999)}",
                        };
                        newBox.MouseDoubleClick += Cell_DoubleClick;
                        newBox.DataContext = new ID{ I = i, J = j};
                        t.Children.Add(newBox);
                    }
                }
                collection.Add(t);
            }
            ((StackPanel)(table.Items[0])).Width = ((StackPanel)(table.Items[1])).Width;
            ExecuteButton.IsEnabled = true;

        }
    }
}
