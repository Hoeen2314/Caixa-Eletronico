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
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(185, 48);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(206, 129);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(405, 45);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(206, 206);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(405, 48);
            btnSacar.TabIndex = 2;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(206, 288);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(405, 45);
            btnTransferir.TabIndex = 3;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            // 
            // btnVerExtrato
            // 
            btnVerExtrato.Location = new Point(206, 357);
            btnVerExtrato.Name = "btnVerExtrato";
            btnVerExtrato.Size = new Size(405, 48);
            btnVerExtrato.TabIndex = 4;
            btnVerExtrato.Text = "Ver Extrato";
            btnVerExtrato.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(620, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Saldo: R$";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(692, 33);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(44, 20);
            lblSaldo.TabIndex = 6;
            lblSaldo.Text = "00,00";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btnVerExtrato);
            Controls.Add(btnTransferir);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(btnVoltar);
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