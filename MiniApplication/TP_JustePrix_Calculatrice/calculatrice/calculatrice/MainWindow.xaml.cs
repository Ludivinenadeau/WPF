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

namespace calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;


        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "5";
        }

        
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = resultTxtBox.Text + "9";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnSoustract_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void btnDivided_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 + double.Parse(resultTxtBox.Text);
            resultTxtBox.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(resultTxtBox.Text);
                resultTxtBox.Text = total2.ToString();
                total1 = 0;
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
        }


    }
}
    

