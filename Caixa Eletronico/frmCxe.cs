using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class frmCxe : Form
    {
        Singleton s;
        public frmCxe()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Conta conta = s.BuscarConta(txbCNum.Text);
            if (conta != null){
                s.SetConta(conta);
                frmPrincipal frmprincipal = new frmPrincipal();
                frmprincipal.ShowDialog();
                this.Close();
            }
            else{
                MessageBox.Show("Erro: conta não existente!");

            }
            
        }

        private void txbCNum_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
