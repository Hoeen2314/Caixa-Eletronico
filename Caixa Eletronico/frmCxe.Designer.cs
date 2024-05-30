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
            btnAcessar.Location = new Point(297, 292);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(194, 90);
            btnAcessar.TabIndex = 0;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(59, 171);
            label1.Name = "label1";
            label1.Size = new Size(85, 35);
            label1.TabIndex = 1;
            label1.Text = "Conta:";
            // 
            // txbCNum
            // 
            txbCNum.Location = new Point(205, 179);
            txbCNum.Name = "txbCNum";
            txbCNum.Size = new Size(417, 27);
            txbCNum.TabIndex = 2;
            // 
            // frmCxe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbCNum);
            Controls.Add(label1);
            Controls.Add(btnAcessar);
            Name = "frmCxe";
            Text = "frmCxe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private Label label1;
        private TextBox txbCNum;
    }
}