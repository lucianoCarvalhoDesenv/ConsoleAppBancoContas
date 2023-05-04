using ConsoleAppBancoContas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            Carteira c = new Carteira();
            c.NumeroDaConta = 1;
            c.Dono = "bob";
            c.Saldo = 0;
            Application.Run(new ContaForm(c));
        }
    }
}
