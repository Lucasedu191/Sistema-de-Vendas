namespace SistemaVendas
{
    partial class frm_venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoCategoriaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label dataVencimentoLabel;
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_Vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFimVenda = new System.Windows.Forms.Button();
            this.btnFimPedido = new System.Windows.Forms.Button();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descontoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox1 = new System.Windows.Forms.TextBox();
            this.btnNovoitem = new System.Windows.Forms.Button();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.codigoVendaTextBox = new System.Windows.Forms.TextBox();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Pgto = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Data_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.btnFinalizar = new System.Windows.Forms.Button();
            codigoCategoriaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            dataVencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoCategoriaLabel
            // 
            codigoCategoriaLabel.AutoSize = true;
            codigoCategoriaLabel.Location = new System.Drawing.Point(89, 14);
            codigoCategoriaLabel.Name = "codigoCategoriaLabel";
            codigoCategoriaLabel.Size = new System.Drawing.Size(39, 13);
            codigoCategoriaLabel.TabIndex = 1;
            codigoCategoriaLabel.Text = "Cliente";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(29, 16);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(29, 71);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(29, 96);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(29, 43);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 8;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(158, 309);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(34, 13);
            valorLabel1.TabIndex = 10;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(136, 338);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(56, 13);
            descontoLabel.TabIndex = 12;
            descontoLabel.Text = "Desconto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(130, 372);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(62, 13);
            valorPagoLabel.TabIndex = 14;
            valorPagoLabel.Text = "Valor Pago:";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataSource = this.pessoasBindingSource;
            this.cb_Cliente.DisplayMember = "Descricao";
            this.cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(134, 11);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(121, 21);
            this.cb_Cliente.TabIndex = 2;
            this.cb_Cliente.ValueMember = "Codigo";
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(Sistema.DAL.Pessoas);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(dataVencimentoLabel);
            this.groupBox1.Controls.Add(this.txt_Data_Vencimento);
            this.groupBox1.Controls.Add(codigoStatusLabel);
            this.groupBox1.Controls.Add(this.cb_Pgto);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(this.dg_Vendas);
            this.groupBox1.Controls.Add(this.cbProduto);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnFimVenda);
            this.groupBox1.Controls.Add(this.btnFimPedido);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(this.valorPagoTextBox);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(this.descontoTextBox);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(this.valorTextBox1);
            this.groupBox1.Controls.Add(this.btnNovoitem);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.quantidadeTextBox);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.codigoVendaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 419);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(118, 94);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 20;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Sistema.DAL.Produto);
            // 
            // dg_Vendas
            // 
            this.dg_Vendas.AutoGenerateColumns = false;
            this.dg_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.Column1});
            this.dg_Vendas.DataSource = this.itensVendaBindingSource;
            this.dg_Vendas.Location = new System.Drawing.Point(6, 125);
            this.dg_Vendas.Name = "dg_Vendas";
            this.dg_Vendas.Size = new System.Drawing.Size(550, 145);
            this.dg_Vendas.TabIndex = 19;
            this.dg_Vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_Vendas_CellFormatting_1);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodigoProduto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(Sistema.DAL.ItensVenda);
            // 
            // cbProduto
            // 
            this.cbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.cbProduto.DataSource = this.produtoBindingSource;
            this.cbProduto.DisplayMember = "Descricao";
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(118, 41);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 21);
            this.cbProduto.TabIndex = 19;
            this.cbProduto.ValueMember = "Codigo";
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(23, 369);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 23);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnFimVenda
            // 
            this.btnFimVenda.Enabled = false;
            this.btnFimVenda.Location = new System.Drawing.Point(23, 338);
            this.btnFimVenda.Name = "btnFimVenda";
            this.btnFimVenda.Size = new System.Drawing.Size(93, 23);
            this.btnFimVenda.TabIndex = 17;
            this.btnFimVenda.Text = "Finalizar Venda";
            this.btnFimVenda.UseVisualStyleBackColor = true;
            this.btnFimVenda.Click += new System.EventHandler(this.btnFimVenda_Click);
            // 
            // btnFimPedido
            // 
            this.btnFimPedido.Location = new System.Drawing.Point(23, 306);
            this.btnFimPedido.Name = "btnFimPedido";
            this.btnFimPedido.Size = new System.Drawing.Size(93, 23);
            this.btnFimPedido.TabIndex = 16;
            this.btnFimPedido.Text = "Finalizar Pedido";
            this.btnFimPedido.UseVisualStyleBackColor = true;
            this.btnFimPedido.Click += new System.EventHandler(this.btnFimPedido_Click);
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.valorPagoTextBox.Location = new System.Drawing.Point(198, 369);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.ReadOnly = true;
            this.valorPagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorPagoTextBox.TabIndex = 15;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Sistema.DAL.Venda);
            // 
            // descontoTextBox
            // 
            this.descontoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.descontoTextBox.Location = new System.Drawing.Point(198, 335);
            this.descontoTextBox.Name = "descontoTextBox";
            this.descontoTextBox.ReadOnly = true;
            this.descontoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descontoTextBox.TabIndex = 13;
            // 
            // valorTextBox1
            // 
            this.valorTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.valorTextBox1.Location = new System.Drawing.Point(198, 306);
            this.valorTextBox1.Name = "valorTextBox1";
            this.valorTextBox1.ReadOnly = true;
            this.valorTextBox1.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox1.TabIndex = 11;
            // 
            // btnNovoitem
            // 
            this.btnNovoitem.Location = new System.Drawing.Point(259, 96);
            this.btnNovoitem.Name = "btnNovoitem";
            this.btnNovoitem.Size = new System.Drawing.Size(75, 23);
            this.btnNovoitem.TabIndex = 5;
            this.btnNovoitem.Text = "Novo Item";
            this.btnNovoitem.UseVisualStyleBackColor = true;
            this.btnNovoitem.Click += new System.EventHandler(this.btnNovoitem_Click);
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(118, 68);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // codigoVendaTextBox
            // 
            this.codigoVendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.codigoVendaTextBox.Location = new System.Drawing.Point(118, 13);
            this.codigoVendaTextBox.Name = "codigoVendaTextBox";
            this.codigoVendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoVendaTextBox.TabIndex = 1;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Sistema.DAL.ContasReceber);
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Location = new System.Drawing.Point(335, 311);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(76, 13);
            codigoStatusLabel.TabIndex = 20;
            codigoStatusLabel.Text = "Forma de Pgto";
            // 
            // cb_Pgto
            // 
            this.cb_Pgto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasReceberBindingSource, "CodigoStatus", true));
            this.cb_Pgto.DataSource = this.statusPagamentoBindingSource;
            this.cb_Pgto.DisplayMember = "Status";
            this.cb_Pgto.Enabled = false;
            this.cb_Pgto.FormattingEnabled = true;
            this.cb_Pgto.Location = new System.Drawing.Point(417, 306);
            this.cb_Pgto.Name = "cb_Pgto";
            this.cb_Pgto.Size = new System.Drawing.Size(121, 21);
            this.cb_Pgto.TabIndex = 21;
            this.cb_Pgto.ValueMember = "CodigoStatus";
            this.cb_Pgto.SelectedIndexChanged += new System.EventHandler(this.cb_Pgto_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(Sistema.DAL.StatusPagamento);
            // 
            // dataVencimentoLabel
            // 
            dataVencimentoLabel.AutoSize = true;
            dataVencimentoLabel.Location = new System.Drawing.Point(319, 346);
            dataVencimentoLabel.Name = "dataVencimentoLabel";
            dataVencimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataVencimentoLabel.TabIndex = 21;
            dataVencimentoLabel.Text = "Data Vencimento:";
            // 
            // txt_Data_Vencimento
            // 
            this.txt_Data_Vencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataVencimento", true));
            this.txt_Data_Vencimento.Enabled = false;
            this.txt_Data_Vencimento.Location = new System.Drawing.Point(417, 342);
            this.txt_Data_Vencimento.Name = "txt_Data_Vencimento";
            this.txt_Data_Vencimento.Size = new System.Drawing.Size(152, 20);
            this.txt_Data_Vencimento.TabIndex = 22;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(417, 381);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(93, 23);
            this.btnFinalizar.TabIndex = 23;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(596, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoCategoriaLabel);
            this.Controls.Add(this.cb_Cliente);
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox codigoVendaTextBox;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.Button btnNovoitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox valorPagoTextBox;
        private System.Windows.Forms.TextBox descontoTextBox;
        private System.Windows.Forms.TextBox valorTextBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFimVenda;
        private System.Windows.Forms.Button btnFimPedido;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.DataGridView dg_Vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox cb_Pgto;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DateTimePicker txt_Data_Vencimento;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
    }
}