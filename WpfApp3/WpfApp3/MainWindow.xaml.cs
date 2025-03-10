using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculadora
{
    public partial class MainWindow : Window
    {
        private string input = "";
        private double num1 = 0, num2 = 0;
        private char operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string content = button.Content.ToString();

            if (double.TryParse(content, out _))
            {
                input += content;
                txtResultado.Text = input;
            }
            else if (content == "C")
            {
                input = "";
                num1 = num2 = 0;
                txtResultado.Text = "";
            }
            else if (content == "=")
            {
                num2 = double.Parse(input);
                double result = 0;

                switch (operation)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/': result = num2 != 0 ? num1 / num2 : 0; break;
                }

                txtResultado.Text = result.ToString();
                input = result.ToString();
            }
            else
            {
                num1 = double.Parse(input);
                operation = content[0];
                input = "";
            }
        }
    }
}
