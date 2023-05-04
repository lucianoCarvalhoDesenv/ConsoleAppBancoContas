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

        public virtual bool Sacar(double valor)
        {
            if (valor > Saldo)
                return false;

            Saldo = Saldo - valor;
            return true;
        }
        public bool Depositar(double valor)
        {
            if(valor<=0)
            return false;

            this.Saldo = this.Saldo + valor;
            return true;
        }
        public bool Transferir(Carteira contaDestino, double valor)
        {
            bool saqueOk  = this.Sacar(valor);
            if(saqueOk)
            {
                bool depositoOK =contaDestino.Depositar(valor);
                if(depositoOK)
                    return true;
                else
                {
                    this.Depositar(valor);
                    return false;
                }      
            }
            else
            return false;
           
        }
    }
}
