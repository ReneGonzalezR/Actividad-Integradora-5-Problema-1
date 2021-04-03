using System;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_5_Problema_1
{
    public partial class Form1 : Form
    {
        double valor = 0;
        Cuenta cuenta = new Cuenta(0);
        public Form1()
        {
            InitializeComponent();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                valor = Convert.ToDouble(txtValor.Text);
                if (valor >= 0)
                {
                    cuenta.Depositar(valor);
                }
                else
                {
                    cuenta.Retirar(valor);
                }

                lblSaldo.Text = cuenta.Saldo.ToString();

                if (cuenta.SaldoNegativo())
                {
                    MessageBox.Show("Saldo Negativo");
                    lblSaldo.ForeColor = Color.Red;
                }
                else
                {
                    lblSaldo.ForeColor = Color.Blue;
                }
            }
        }
    }
}
