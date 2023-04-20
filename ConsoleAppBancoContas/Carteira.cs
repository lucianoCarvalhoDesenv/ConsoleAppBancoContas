using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBancoContas
{
    public class Carteira
    {
        public int NumeroDaConta { get; set; }
        public string Dono { get; set; }
        public double Saldo { get; set; }

        public bool Sacar(double valor)
        {
            if (valor > Saldo)
                return false;

            Saldo = Saldo - valor;
            return true;
        }
        public bool Depositar(double valor)
        {
            return true;
        }
        public bool Transferir(Carteira contaDestino, double valor)
        {
            return true;
        }
    }
}
