namespace Caixa_Eletronico
{
    partial class frmCxe
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
            btnAcessar = new Button();
            label1 = new Label();
            txbCNum = new TextBox();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(260, 219);
            btnAcessar.Margin = new Padding(3, 2, 3, 2);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(170, 68);
            btnAcessar.TabIndex = 0;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(52, 128);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "Conta:";
            // 
            // txbCNum
            // 
            txbCNum.Location = new Point(179, 134);
            txbCNum.Margin = new Padding(3, 2, 3, 2);
            txbCNum.Name = "txbCNum";
            txbCNum.Size = new Size(365, 23);
            txbCNum.TabIndex = 2;
            // 
            // frmCxe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txbCNum);
            Controls.Add(label1);
            Controls.Add(btnAcessar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCxe";
            Text = "Caixa Eletrônico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private Label label1;
        private TextBox txbCNum;
    }
}