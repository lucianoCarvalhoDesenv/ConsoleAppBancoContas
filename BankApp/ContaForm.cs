using ConsoleAppBancoContas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class ContaForm : Form
    {
        private Carteira carteira;
        private int operacao = -1;
        public ContaForm(Carteira cart)
        {
            this.carteira = cart;
            InitializeComponent();
            DesabilitarVisualizaoComponentes();
        }

        private void DesabilitarVisualizaoComponentes()
        {
            this.labelResposta.Visible = false;
            this.labelValor.Visible = false;
            this.textBoxConta.Visible = false;
            this.textBoxValor.Visible = false;
            this.buttonConfirmar.Visible = false;
            this.labelConta.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.operacao = 2;
            this.DesabilitarVisualizaoComponentes();
            this.labelValor.Visible = true;
            this.textBoxValor.Visible = true;
            this.buttonConfirmar.Visible = true;
            
        }   

        private void buttonSaldo_Click(object sender, EventArgs e)
        {
            this.DesabilitarVisualizaoComponentes();

            this.labelResposta.Text = "Saldo Atual: " + carteira.Saldo;
            this.labelResposta.Visible = true;
        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            this.operacao = 1;
            this.DesabilitarVisualizaoComponentes();
            this.labelValor.Visible = true;
            this.textBoxValor.Visible = true;
            this.buttonConfirmar.Visible = true;
        }

        private void buttonTransferencia_Click(object sender, EventArgs e)
        {
            this.DesabilitarVisualizaoComponentes();

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case 1:
                    bool saqueOK = carteira.Sacar(
                    Convert.ToDouble(textBoxValor.Text));
                    if (saqueOK)
                    {
                        labelResposta.Text = "Saque Realizado com Sucesso!";
                    }
                    else
                    {
                        labelResposta.Text = "Erro Ao Realizar Operacao!";
                    }
                    labelResposta.Visible = true;
                    break;
                case 2:bool depositOK = carteira.Depositar(
                    Convert.ToDouble(textBoxValor.Text));
                    if(depositOK)
                    {
                        labelResposta.Text = "Deposito Realizado com Sucesso!";
                    }
                    else 
                    {
                        labelResposta.Text = "Erro Ao Realizar Operacao!";
                    }
                    labelResposta.Visible = true;
                    break;
            }
        }
    }
}
