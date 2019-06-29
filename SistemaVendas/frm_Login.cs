using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace SistemaVendas
{
    
    public partial class frm_Login : Form
    {
        public bool logado = false;

        public frm_Login()
        {
            InitializeComponent();
        }

        public void EferuarLogin()
        {
            var user = DataContextFactory.DataContext.Usuarios.Count(
                x => x.Usuario == txtUsuario.Text && x.Senha == txtSenha.Text);
            if(user > 0)
            {
                this.logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            EferuarLogin();
        }

        private void btn_sair_login_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
