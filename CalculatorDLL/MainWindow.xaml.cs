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

namespace CalculatorDLL
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isBig;

        public MainWindow()
        {
            InitializeComponent();
            _isBig = Math.Abs(Width - 400) < 1;
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Label)sender).Background = new SolidColorBrush(Color.FromRgb(230, 230, 230));
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Label)sender).Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void Label_MouseDown(Label sender)
        {
            sender.Background = new SolidColorBrush(Color.FromRgb(210, 210, 210));
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ((Label)sender).Background = new SolidColorBrush(Color.FromRgb(230, 230, 230));
        }

        private void N0_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N1_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N2_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N3_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N4_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N5_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N6_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N7_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N8_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void N9_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C0_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C1_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C2_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C3_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            CalculatorWindow.Width = (_isBig = !_isBig) ? 400 : 300;
            BaseGrid.Margin = new Thickness(10, 61, _isBig ? 110 : 10, 9.8);
            ExtraGrid.Visibility = _isBig ? Visibility.Visible : Visibility.Hidden;
        }

        private void C4_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C5_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C6_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C7_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C8_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C9_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
        }

        private void C10_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            MessageBox.Show("Info");
        }
    }

    //С0    /
    //С1    *
    //С2    -
    //С3    Extra
    //С4    ,
    //C5    +
    //C6    sin
    //C7    cos
    //C8    tan
    //C9    cot
    //C10   info
}
