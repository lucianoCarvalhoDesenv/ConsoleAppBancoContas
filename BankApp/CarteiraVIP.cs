using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBancoContas
{
    public class CarteiraVIP : Carteira
    {
        public double Limite { get; set; }

        public override bool Sacar(double valor)
        {
            if (!(valor < (this.Saldo + Limite)))
                return false;

            this.Saldo = Saldo - valor;
            return true;
        }

        public CarteiraVIP(double valorDeposito) 
        { 
            bool dOk =this.Depositar(valorDeposito);
            if (dOk)//Setando limite para 10% do primeiro deposito
                this.Limite = 0.1 * valorDeposito;
            else
                this.Limite = 0;
        }
    }
}
