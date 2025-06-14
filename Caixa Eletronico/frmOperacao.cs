﻿using System;
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
    public partial class frmOperacao : Form
    {
        Singleton s;
        public frmOperacao()
        {
            InitializeComponent();
            s = Singleton.Instance;
            int oprecao = s.getOperacao();
            if (oprecao == 1)
            {
                lblOperacao.Text = "Deposito";
                this.Text = "Depositar";
            }
            if (oprecao == 2)
            {
                lblOperacao.Text = "Saque";
                this.Text = "Sacar";
            }
            if (oprecao == 3)
            {
                lblOperacao.Text = "Transferir";
                txbConta.Visible = true;
                lblConta.Visible = true;
                this.Text = "Transferir";
            }
            if (oprecao == 4)
            {
                Recarregar();
                dgvTransacoes1.Visible = true;
                this.Text = "Extrato";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public class Transacao1
        {
            public double valor;
            public char tipo;
            public Transacao duplicata;
            public string numero;
        }

        public void Recarregar()
        {
            Conta contaA = s.GetConta();
            frmPrincipal frmprin = new frmPrincipal();
            var source = new BindingSource();
            source.DataSource = contaA.Transacoes;
            dgvTransacoes1.DataSource = source;
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            int operacao = s.getOperacao();
            Conta contaA = s.GetConta();
            frmPrincipal frmprin = new frmPrincipal();
            if (operacao == 1)
            {
                contaA.Depositar(Convert.ToDouble(numericUpDown1.Value));
                s.transacoes.Add(new Transacao(Convert.ToDouble(numericUpDown1.Value), 'D', contaA));
                this.Close();
            }
            if (operacao == 2)
            {
                contaA.Sacar(Convert.ToDouble(numericUpDown1.Value));
                s.transacoes.Add(new Transacao(Convert.ToDouble(numericUpDown1.Value), 'S', contaA));
                this.Close();
            }
            if (operacao == 3)
            {
                s.SetContaD(s.BuscarConta(txbConta.Text));
                Conta contaD = s.GetContaD();
                contaA.Transferir(contaD, Convert.ToDouble(numericUpDown1.Value));

                s.transacoes.Add(new Transacao(Convert.ToDouble(numericUpDown1.Value), 'S', contaA));
                s.transacoes[s.transacoes.Count - 1].Duplicata = contaD.Transacoes[contaD.Transacoes.Count - 1];

                s.transacoes.Add(new Transacao(Convert.ToDouble(numericUpDown1.Value), 'D', contaD));
                s.transacoes[s.transacoes.Count - 1].Duplicata = s.transacoes[s.transacoes.Count - 1];

                this.Close();
            }
            if (operacao == 4)
            {
                Recarregar();
                dgvTransacoes1.Visible = true;
                this.Close();
            }
        }

        private void dgvTransacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOperacao_Load(object sender, EventArgs e)
        {

        }
    }
}
