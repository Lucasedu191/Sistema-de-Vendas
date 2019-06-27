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
            this.Size = new Size(659, 81);
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Vendas;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamentos;
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasRecebers;

            this.vendaBindingSource.AddNew();
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVendaBindingSource.Current;
            }
        }

        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(658, 501);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            button1.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVendas.Where(x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
            NovoItem();
            cb_Cliente.Enabled = false;
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
        }

        private void btnNovoitem_Click(object sender, EventArgs e)
        {
          
            this.itensVendaBindingSource.EndEdit();
            dg_Vendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();

        }





        private void dg_Vendas_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduto.SelectedItem != null)
            {
                var pro = (Produto)cbProduto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in dg_Vendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);

                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }
            this.VendaCorrente.Valor = total;
        }

        private void btnFimPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o pedido?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btnNovoitem.Enabled = false;
                cbProduto.Enabled = false;
                quantidadeTextBox.Enabled = false;
                descontoTextBox.ReadOnly = false;
                descontoTextBox.Focus();
                btnFimPedido.Enabled = false;
                btnFimVenda.Enabled = true;
                codigoVendaTextBox.Enabled = false;

            }
            

        }

        private void btnFimVenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(descontoTextBox.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            descontoTextBox.Enabled = false;
            btnFimVenda.Enabled = false;
            //btnImprimir.Enabled = true;

            cb_Pgto.Enabled = true;
            this.contasReceberBindingSource.AddNew();
            this.ContaCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;

        }

        private void cb_Pgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Pgto.SelectedItem != null)
            {
                var status = (StatusPagamento)cb_Pgto.SelectedItem;
                if(status.CodigoStatus == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    btnFinalizar.Enabled = true;
                    txt_Data_Vencimento.Enabled = false;
                }
                else if(status.CodigoStatus == 2)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    this.ContaCorrente.DataPagamento = null;
                    txt_Data_Vencimento.Enabled = true;
                    btnFinalizar.Enabled = true;
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            txt_Data_Vencimento.Enabled = false;
            btnFinalizar.Enabled = false;
            cb_Pgto.Enabled = false;
            btnImprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada com sucesso!");
        }
    }
}
