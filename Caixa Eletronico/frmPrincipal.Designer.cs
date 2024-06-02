namespace Caixa_Eletronico
{
    partial class frmPrincipal
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
            btnVoltar = new Button();
            btnDepositar = new Button();
            btnSacar = new Button();
            btnTransferir = new Button();
            btnVerExtrato = new Button();
            label1 = new Label();
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(10, 9);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(162, 36);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(180, 97);
            btnDepositar.Margin = new Padding(3, 2, 3, 2);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(354, 34);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(180, 154);
            btnSacar.Margin = new Padding(3, 2, 3, 2);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(354, 36);
            btnSacar.TabIndex = 2;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(180, 216);
            btnTransferir.Margin = new Padding(3, 2, 3, 2);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(354, 34);
            btnTransferir.TabIndex = 3;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnVerExtrato
            // 
            btnVerExtrato.Location = new Point(180, 268);
            btnVerExtrato.Margin = new Padding(3, 2, 3, 2);
            btnVerExtrato.Name = "btnVerExtrato";
            btnVerExtrato.Size = new Size(354, 36);
            btnVerExtrato.TabIndex = 4;
            btnVerExtrato.Text = "Ver Extrato";
            btnVerExtrato.UseVisualStyleBackColor = true;
            btnVerExtrato.Click += btnVerExtrato_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Saldo: R$";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(606, 25);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(34, 15);
            lblSaldo.TabIndex = 6;
            lblSaldo.Text = "00,00";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btnVerExtrato);
            Controls.Add(btnTransferir);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(btnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnDepositar;
        private Button btnSacar;
        private Button btnTransferir;
        private Button btnVerExtrato;
        private Label label1;
        private Label lblSaldo;
    }
}