using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa_Eletronico.Classes;

namespace Caixa_Eletronico
{
    public partial class frmPrincipal : Form
    {
        Singleton s;
        int operacao;

        public frmPrincipal()
        {
            InitializeComponent();
            s = Singleton.Instance;
            Conta contaAcesso = s.GetConta();
            double saldo = contaAcesso.Saldo;
            lblSaldo.Text = saldo.ToString("C");
        }

        public void Atualizar()
        {
            s = Singleton.Instance;
            Conta contaAcesso = s.GetConta();
            lblSaldo.Text = contaAcesso.Saldo.ToString("C");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            operacao = 1;
            s.setOperacao(operacao);
            frmOperacao frmopta = new frmOperacao();
            frmopta.ShowDialog();
            Atualizar();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            operacao = 2;
            s.setOperacao(operacao);
            frmOperacao frmopta = new frmOperacao();
            frmopta.ShowDialog();
            Atualizar();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            operacao = 3;
            s.setOperacao(operacao);
            frmOperacao frmopta = new frmOperacao();
            frmopta.ShowDialog();
            Atualizar();
        }

        private void btnVerExtrato_Click(object sender, EventArgs e)
        {
            operacao = 4;
            s.setOperacao(operacao);
            frmOperacao frmopta = new frmOperacao();
            frmopta.ShowDialog();
        }
    }
}
