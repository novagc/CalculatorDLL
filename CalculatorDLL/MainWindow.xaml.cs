﻿using System;
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
        private readonly string _info = "info";

        private bool _isBig;
        private bool _isDouble;
        private bool _end;

        private int _selectedFunc;
        private object[] _numbers;

        public MainWindow()
        {
            InitializeComponent();
            _isBig = Math.Abs(Width - 300) < 1;
            _end = true;
            _selectedFunc = -1;
            _numbers = new object[4];
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
            if (_end)
            {
                ConsoleBlock.Text = "0";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "0";
            }
        }

        private void N1_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "1";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "1";
            }
        }

        private void N2_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "2";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "2";
            }
        }

        private void N3_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "3";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "3";
            }
        }

        private void N4_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "4";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "4";
            }
        }

        private void N5_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "5";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "5";
            }
        }

        private void N6_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "6";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "6";
            }
        }

        private void N7_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "7";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "7";
            }
        }

        private void N8_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "8";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "8";
            }
        }

        private void N9_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            if (_end)
            {
                ConsoleBlock.Text = "9";
                _end = false;
            }
            else
            {
                ConsoleBlock.Text += "9";
            }
        }

        private void C0_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = 0;
            _end = true;
        }

        private void C1_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = 1;
            _end = true;
        }

        private void C2_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = 2;
            _end = true;
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
            _isDouble = true;
            if (!ConsoleBlock.Text.Contains(","))
            {
                if (_end)
                {
                    _end = false;
                    ConsoleBlock.Text = "0,";
                }
                else
                {
                    ConsoleBlock.Text += ",";
                }
            }
        }

        private void C5_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = 3;
            _end = true;
        }

        private void C6_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = -1;
            _end = true;

            if ((bool) _numbers[1])
                ExtraFunctions.Instance.Sin((double) _numbers[0]);
            else
                ExtraFunctions.Instance.Sin(Convert.ToDouble((int) _numbers[0]));
        }

        private void C7_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = -1;
            _end = true;

            if ((bool)_numbers[1])
                ExtraFunctions.Instance.Cos((double)_numbers[0]);
            else
                ExtraFunctions.Instance.Cos(Convert.ToDouble((int)_numbers[0]));
        }

        private void C8_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = -1;
            _end = true;

            if ((bool)_numbers[1])
                ExtraFunctions.Instance.Tan((double)_numbers[0]);
            else
                ExtraFunctions.Instance.Tan(Convert.ToDouble((int)_numbers[0]));
        }

        private void C9_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);

            ReadNumber();

            _selectedFunc = -1;
            _end = true;

            if ((bool)_numbers[1])
                ExtraFunctions.Instance.Cot((double)_numbers[0]);
            else
                ExtraFunctions.Instance.Cot(Convert.ToDouble((int)_numbers[0]));
        }

        private void C10_MouseDown(object sender, MouseEventArgs e)
        {
            Label_MouseDown(sender as Label);
            MessageBox.Show(_info);
        }

        private void C11_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedFunc == -1)
            {
                _end = true;
            }
            else
            {
                ReadNumber();

                
            }
        }

        private string Calculate()
        {
            if (_selectedFunc == 0)
            {
                if ((bool)_numbers[1] && (bool)_numbers[3])
                {
                    return BasicFunctions.DivideDouble(
                        (bool)_numbers[1] ? (double)_numbers[0] : (int)_numbers[0],
                        (bool)_numbers[3] ? (double)_numbers[2] : (int)_numbers[2]).ToString();
                }
                else
                {
                    return BasicFunctions.DivideInt((int)_numbers[0], (int)_numbers[2]).ToString();
                }
            }
            else if (_selectedFunc == 1)
            {
                if ((bool)_numbers[1] && (bool)_numbers[3])
                {
                    return BasicFunctions.MultiplyDouble(
                        (bool)_numbers[1] ? (double)_numbers[0] : (int)_numbers[0],
                        (bool)_numbers[3] ? (double)_numbers[2] : (int)_numbers[2]).ToString();
                }
                else
                {
                    return BasicFunctions.MultiplyInt((int)_numbers[0], (int)_numbers[2]).ToString();
                }
            }
            else if (_selectedFunc == 2)
            {
                if ((bool)_numbers[1] && (bool)_numbers[3])
                {
                    return BasicFunctions.MinusDouble(
                        (bool)_numbers[1] ? (double)_numbers[0] : (int)_numbers[0],
                        (bool)_numbers[3] ? (double)_numbers[2] : (int)_numbers[2]).ToString();
                }
                else
                {
                    return BasicFunctions.MinusInt((int)_numbers[0], (int)_numbers[2]).ToString();
                }
            }
            else
            {
                if ((bool)_numbers[1] && (bool)_numbers[3])
                {
                    return BasicFunctions.PlusDouble(
                        (bool)_numbers[1] ? (double)_numbers[0] : (int)_numbers[0],
                        (bool)_numbers[3] ? (double)_numbers[2] : (int)_numbers[2]).ToString();
                }
                else
                {
                    return BasicFunctions.PlusInt((int)_numbers[0], (int)_numbers[2]).ToString();
                }
            }
        }

        private void ReadNumber()
        {
            int offset = _selectedFunc == -1 ? 0 : 2;

            if (_isDouble)
                _numbers[offset] = double.Parse(ConsoleBlock.Text);
            else
                _numbers[offset] = int.Parse(ConsoleBlock.Text);
            _numbers[offset + 1] = _isDouble;
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
    //C11   =
}
