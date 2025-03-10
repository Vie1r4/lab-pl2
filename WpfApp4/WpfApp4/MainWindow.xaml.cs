using System;
using System.Windows;

namespace Calculadora
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);
                string operacao = txtOperacao.Text;
                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        break;
                    case "/":
                        if (valor2 == 0)
                        {
                            txtResultado.Text = "Divisão por zero";
                            return;
                        }
                        resultado = valor1 / valor2;
                        break;
                    default:
                        txtResultado.Text = "Operador errado";
                        return;
                }

                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                txtResultado.Text = "Erro!";
            }
        }
    }
}
