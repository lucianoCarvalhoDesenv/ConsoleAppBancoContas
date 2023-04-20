using System;

namespace ConsoleAppBancoContas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<Carteira> ListaCorrentistas = new List<Carteira>();
                int NumConta = 0;
                int Entrada;
                do
                {
                    Console.WriteLine("1 - Para Cadastrar Conta");
                    Console.WriteLine("2 - Para Cadastrar Sacar");
                    Console.WriteLine("3 - Listar Todas Contas");
                    Console.WriteLine("9 - Para Cadastrar Sair");
                    Entrada = Convert.ToInt32(Console.ReadLine());
                    switch (Entrada)
                    {
                        case 1:
                            NumConta++;
                            ListaCorrentistas.Add(CadastrarCarteira(NumConta));
                            break;
                        case 2:
                            Console.WriteLine("Entre com Proprietario da Conta");
                            string nome = Console.ReadLine();
                            Carteira carteira = ListaCorrentistas.FirstOrDefault(c => c.Dono == nome);
                            Console.WriteLine("Entre com valor para Saque");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            bool transacaoOk = carteira.Sacar(valor);
                            if (transacaoOk)
                                Console.WriteLine("Saque realizado com sucesso");
                            else
                                Console.WriteLine("Nao foi possivel realizar essa operacao!");
                            break;

                        case 3:
                            foreach (var c in ListaCorrentistas)
                                Console.WriteLine($"Nome:{c.Dono} Saldo:{c.Saldo}");
                            break;


                    }
                } while (Entrada != 9);

            }
        }
    }
}
