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
    public partial class frm_Categoria : Form
    {
        public frm_Categoria()
        {
            InitializeComponent();
        }

        private void frm_Categoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cadastro Realizado com sucesso!");            
            }

        }

        private bool valida()
        {
            if(txtCategoria.Text.Trim()== string.Empty)
            {
                MessageBox.Show("O campo de categoria é obrigatório");
                txtCategoria.Focus();
                return false;
            }
            return true;
        }

        private void tnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.CategoriaPossuiProdutos(this.categoriaAtual))
                    MessageBox.Show("Você não pode excluir essa categoria, porque existe produtos nela");
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluída com sucesso!");
                }
                
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
            
        }

        public Categoria categoriaAtual
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProdutos(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == categoria.Codigo);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }
    }
}
