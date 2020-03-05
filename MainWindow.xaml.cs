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

namespace Wpf_Sharp
{

    //">_<"

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int offset = 120;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox Box = new TextBox
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 30,
                Margin = new Thickness(21, offset, 0, 0),
            };
            gMine.Children.Add(Box);
            Box.Focus();
            offset += 45;
            Box.TextChanged += Resultat;
        }

        private void Resultat(object sender, object args)
        {
            int result = 0;
            foreach (object obj in gMine.Children)
            {
                if (obj is TextBox)
                {
                    TextBox tBox = (TextBox)obj;
                    int re = Convert.ToInt32(tBox.Text);
                    result += re;
                }
            }

            Label.Content = "Result " + result;
        }

        
    }
}
