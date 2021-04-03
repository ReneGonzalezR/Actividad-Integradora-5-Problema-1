using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_5_Problema_1
{
    class Cuenta : ICuenta
    {
        public Cuenta(double valor)
        {
            Saldo = valor;
        }
        public double Saldo { get; set; }
        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }
        public void Retirar(double valor)
        {
            Saldo = Saldo + valor;
        }
        public bool SaldoNegativo()
        {
            if (Saldo < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
