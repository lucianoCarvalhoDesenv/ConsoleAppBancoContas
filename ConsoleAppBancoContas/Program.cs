using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppBancoContas
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Carteira> ListaCorrentistas = new List<Carteira>();
            int NumConta = 0;
            int Entrada = 0;
            do
            {

                Console.WriteLine("1 - Para Cadastrar Conta");
                Console.WriteLine("2 - Para  Sacar");
                Console.WriteLine("3 - Listar Todas Contas");
                Console.WriteLine("4 - Para  Depositar");
                Console.WriteLine("5 - Para  Transferir");
                Console.WriteLine("9 - Para Sair");
                Entrada = Convert.ToInt32(Console.ReadLine());
                switch (Entrada)
                {
                    case 1:
                        NumConta++;
                        ListaCorrentistas.Add(CadastrarCarteira(NumConta));
                        break;
                    case 2:
                        Sacar(ListaCorrentistas);
                        break;
                    case 3:
                        foreach (var c in ListaCorrentistas)
                            Console.WriteLine($"Id:{c.NumeroDaConta} Nome:{c.Dono} Saldo:{c.Saldo}");
                        break;
                    case 4:
                        Depositar(ListaCorrentistas);
                        break;
                    case 5:
                        Transferencia(ListaCorrentistas);
                        break;



                }
                Console.ReadKey();
                Console.Clear();
            } while (Entrada != 9);

           
        }

        public static void Transferencia(List<Carteira> ListaCorrentistas)
        {
            Console.WriteLine("Entre com numero da conta origem:");
            int cOrigemID = Convert.ToInt32(Console.ReadLine());
            Carteira cartOri = ListaCorrentistas.FirstOrDefault(c => c.NumeroDaConta == cOrigemID);
            if (cartOri is null)
            {
                Console.WriteLine("Entrada Invalida!");
                return;
            }
            Console.WriteLine("Entre com numero da conta Destino:");
            int cDestinoID = Convert.ToInt32(Console.ReadLine());
            Carteira cartDest = ListaCorrentistas.FirstOrDefault(c => c.NumeroDaConta == cDestinoID);
            if (cartDest is null)
            {
                Console.WriteLine("Entrada Invalida!");
                return;
            }

            Console.WriteLine("Entre com valor da Transferencia:");
            double valorT = Convert.ToDouble(Console.ReadLine());
            bool transOK = cartOri.Transferir(cartDest, valorT);
            if (transOK)
                Console.WriteLine("Transferencia Realizada com sucesso");
            else
                Console.WriteLine("Nao foi possivel Realizar Operacao!");
        }

        public static void Depositar(List<Carteira> ListaCorrentistas)
        {
            Console.WriteLine("Informe o numero da conta");
            int ContaId = Convert.ToInt32(Console.ReadLine());
            Carteira carteiraAtual = ListaCorrentistas.FirstOrDefault(c => c.NumeroDaConta == ContaId);
            if (carteiraAtual is null)
                Console.WriteLine("Carteira nao encontrada! operacao abortada!");
            else
            {
                Console.WriteLine("Qual valor do deposito");
                double valorD = Convert.ToDouble(Console.ReadLine());
                bool depositoOK = carteiraAtual.Depositar(valorD);
                if (depositoOK)
                    Console.WriteLine("Operacao Realizada com sucesso!");
                else
                    Console.WriteLine("Nao foi possivel realizar esta operacao");
            }
        }

        public static void Sacar(List<Carteira> ListaCorrentistas)
        {
            Console.WriteLine("Entre com Proprietario da Conta");
            string nome = Console.ReadLine();
            Carteira carteira = ListaCorrentistas.FirstOrDefault(c => c.Dono == nome);
            if (carteira is null)
                Console.WriteLine("Carteira nao encontrada! operacao abortada!");
            else
            {
                Console.WriteLine("Entre com valor para Saque");
                double valor = Convert.ToDouble(Console.ReadLine());
                bool transacaoOk = carteira.Sacar(valor);
                if (transacaoOk)
                    Console.WriteLine("Saque realizado com sucesso");
                else
                    Console.WriteLine("Nao foi possivel realizar essa operacao!");
            }
        }

        private static Carteira CadastrarCarteira(int numConta)
        {
            Carteira novaCarteira = new Carteira();
            novaCarteira.NumeroDaConta = numConta;
            novaCarteira.Saldo = 0;
            Console.WriteLine("Qual seu Nome?");
            novaCarteira.Dono = Console.ReadLine();

            Console.WriteLine("Deseja Realizar um Deposito Inicial e se tornar VIP?");
            string resp = Console.ReadLine();
            if (resp.ToUpper().StartsWith("S"))
            {
                Console.WriteLine("Valor para Deposito:");
                double valor = Convert.ToDouble(Console.ReadLine());
                CarteiraVIP cVIP = new CarteiraVIP(valor);
                cVIP.NumeroDaConta = novaCarteira.NumeroDaConta;
                cVIP.Dono = novaCarteira.Dono;
                novaCarteira = cVIP;
            }

            Console.WriteLine("Carteira Criada com sucesso!" +
                " numero da conta:" + novaCarteira.NumeroDaConta);

            return novaCarteira;
        }
    }
}




