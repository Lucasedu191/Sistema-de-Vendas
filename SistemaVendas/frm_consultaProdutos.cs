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
    public partial class frm_consultaProdutos : Form
    {
        public frm_consultaProdutos()
        {
            InitializeComponent();
        }

        private void frm_consultaProdutos_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)cb_Categoria.SelectedValue);
        }

        public void Pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == codigoCategoria);
        }
    }
}
