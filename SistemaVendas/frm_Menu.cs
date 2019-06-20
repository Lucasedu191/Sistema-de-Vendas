using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_CadProdutos_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();
        }

        private void btn_cadCategorias_Click(object sender, EventArgs e)
        {
            frm_Categoria frm = new frm_Categoria();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categoria frm = new frm_Categoria();
            frm.Show();
        }
    }
}
