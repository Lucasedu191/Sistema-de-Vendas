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
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;

            this.vendaBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            button1.Enabled = false;
        }
    }
}
