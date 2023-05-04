namespace BankApp
{
    partial class ContaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSaldo = new System.Windows.Forms.Button();
            this.buttonSaque = new System.Windows.Forms.Button();
            this.buttonDeposito = new System.Windows.Forms.Button();
            this.buttonTransferencia = new System.Windows.Forms.Button();
            this.labelResposta = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBoxConta = new System.Windows.Forms.TextBox();
            this.labelConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaldo
            // 
            this.buttonSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaldo.Location = new System.Drawing.Point(12, 12);
            this.buttonSaldo.Name = "buttonSaldo";
            this.buttonSaldo.Size = new System.Drawing.Size(175, 57);
            this.buttonSaldo.TabIndex = 0;
            this.buttonSaldo.Text = "Saldo";
            this.buttonSaldo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonSaldo.UseVisualStyleBackColor = true;
            this.buttonSaldo.Click += new System.EventHandler(this.buttonSaldo_Click);
            // 
            // buttonSaque
            // 
            this.buttonSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaque.Location = new System.Drawing.Point(193, 12);
            this.buttonSaque.Name = "buttonSaque";
            this.buttonSaque.Size = new System.Drawing.Size(175, 57);
            this.buttonSaque.TabIndex = 1;
            this.buttonSaque.Text = "Saque";
            this.buttonSaque.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonSaque.UseVisualStyleBackColor = true;
            this.buttonSaque.Click += new System.EventHandler(this.buttonSaque_Click);
            // 
            // buttonDeposito
            // 
            this.buttonDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeposito.Location = new System.Drawing.Point(374, 12);
            this.buttonDeposito.Name = "buttonDeposito";
            this.buttonDeposito.Size = new System.Drawing.Size(235, 57);
            this.buttonDeposito.TabIndex = 2;
            this.buttonDeposito.Text = "Deposito";
            this.buttonDeposito.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonDeposito.UseVisualStyleBackColor = true;
            this.buttonDeposito.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTransferencia
            // 
            this.buttonTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTransferencia.Location = new System.Drawing.Point(615, 12);
            this.buttonTransferencia.Name = "buttonTransferencia";
            this.buttonTransferencia.Size = new System.Drawing.Size(328, 57);
            this.buttonTransferencia.TabIndex = 3;
            this.buttonTransferencia.Text = "Transferencia";
            this.buttonTransferencia.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonTransferencia.UseVisualStyleBackColor = true;
            this.buttonTransferencia.Click += new System.EventHandler(this.buttonTransferencia_Click);
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResposta.Location = new System.Drawing.Point(23, 96);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(155, 65);
            this.labelResposta.TabIndex = 4;
            this.labelResposta.Text = "label1";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValor.Location = new System.Drawing.Point(23, 209);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(145, 65);
            this.labelValor.TabIndex = 5;
            this.labelValor.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValor.Location = new System.Drawing.Point(174, 209);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(210, 71);
            this.textBoxValor.TabIndex = 6;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmar.Location = new System.Drawing.Point(23, 362);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(469, 74);
            this.buttonConfirmar.TabIndex = 7;
            this.buttonConfirmar.Text = "Confirmar Operacao";
            this.buttonConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // textBoxConta
            // 
            this.textBoxConta.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxConta.Location = new System.Drawing.Point(751, 212);
            this.textBoxConta.Name = "textBoxConta";
            this.textBoxConta.Size = new System.Drawing.Size(210, 71);
            this.textBoxConta.TabIndex = 9;
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConta.Location = new System.Drawing.Point(420, 212);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(325, 65);
            this.labelConta.TabIndex = 8;
            this.labelConta.Text = "ContaDestino:";
            // 
            // ContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 500);
            this.Controls.Add(this.textBoxConta);
            this.Controls.Add(this.labelConta);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelResposta);
            this.Controls.Add(this.buttonTransferencia);
            this.Controls.Add(this.buttonDeposito);
            this.Controls.Add(this.buttonSaque);
            this.Controls.Add(this.buttonSaldo);
            this.Name = "ContaForm";
            this.Text = "ContaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaldo;
        private System.Windows.Forms.Button buttonSaque;
        private System.Windows.Forms.Button buttonDeposito;
        private System.Windows.Forms.Button buttonTransferencia;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxConta;
        private System.Windows.Forms.Label labelConta;
    }
}