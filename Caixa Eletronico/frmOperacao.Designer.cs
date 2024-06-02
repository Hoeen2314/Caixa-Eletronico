namespace Caixa_Eletronico
{
    partial class frmOperacao
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
            components = new System.ComponentModel.Container();
            numericUpDown1 = new NumericUpDown();
            btnRealizar = new Button();
            lblOperacao = new Label();
            label2 = new Label();
            txbConta = new TextBox();
            lblConta = new Label();
            transacaoBindingSource = new BindingSource(components);
            dgvTransacoes1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transacaoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransacoes1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(324, 206);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnRealizar
            // 
            btnRealizar.Location = new Point(343, 270);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(75, 23);
            btnRealizar.TabIndex = 1;
            btnRealizar.Text = "Realizar";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(361, 138);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(38, 15);
            lblOperacao.TabIndex = 2;
            lblOperacao.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 208);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor:";
            // 
            // txbConta
            // 
            txbConta.Location = new Point(333, 235);
            txbConta.Name = "txbConta";
            txbConta.Size = new Size(100, 23);
            txbConta.TabIndex = 4;
            txbConta.Visible = false;
            // 
            // lblConta
            // 
            lblConta.AutoSize = true;
            lblConta.Location = new Point(280, 238);
            lblConta.Name = "lblConta";
            lblConta.Size = new Size(42, 15);
            lblConta.TabIndex = 5;
            lblConta.Text = "Conta:";
            lblConta.Visible = false;
            // 
            // transacaoBindingSource
            // 
            transacaoBindingSource.DataSource = typeof(Classes.Transacao);
            // 
            // dgvTransacoes1
            // 
            dgvTransacoes1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacoes1.Location = new Point(627, 140);
            dgvTransacoes1.Name = "dgvTransacoes1";
            dgvTransacoes1.Size = new Size(240, 150);
            dgvTransacoes1.TabIndex = 6;
            // 
            // frmOperacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(dgvTransacoes1);
            Controls.Add(lblConta);
            Controls.Add(txbConta);
            Controls.Add(label2);
            Controls.Add(lblOperacao);
            Controls.Add(btnRealizar);
            Controls.Add(numericUpDown1);
            Name = "frmOperacao";
            Text = "frmOperacao";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transacaoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransacoes1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button btnRealizar;
        private Label lblOperacao;
        private Label label2;
        private TextBox txbConta;
        private Label lblConta;
        private BindingSource transacaoBindingSource;
        private DataGridView dgvTransacoes1;
    }
}