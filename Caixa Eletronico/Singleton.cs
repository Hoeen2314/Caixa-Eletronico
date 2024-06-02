using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caixa_Eletronico
{
    public sealed class Singleton
    {
        private Singleton(){
            contas = new List<Conta>() { new CCorrente("123", 200), new CPoupanca("1") };
            transacoes = new List<Transacao>();
        }

            private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        public List<Conta> contas;
        public List<Transacao> transacoes;
        

        Conta contaAcesso;
        Conta contaDestino;
        int operacao;

        public Conta BuscarConta(string numero)
        {
            Conta c = contas.Find(c => c.Numero == numero);

            return c;
        }

        

        public void SetConta(Conta conta)
        {
            contaAcesso = conta;
        }

        public Conta GetConta()
        {
            return contaAcesso;
        }

        public void SetContaD(Conta conta)
        {
            contaDestino = conta;
        }

        public Conta GetContaD()
        {
            return contaDestino;
        }

        public void setOperacao(int op)
        {
            operacao = op;
        }

        public int getOperacao()
        {
            return operacao;
        }
    }
}
