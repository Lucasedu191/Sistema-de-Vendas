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
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.codigoVendaTextBox = new System.Windows.Forms.TextBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensVendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.btnNovoitem = new System.Windows.Forms.Button();
            codigoCategoriaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoCategoriaLabel
            // 
            codigoCategoriaLabel.AutoSize = true;
            codigoCategoriaLabel.Location = new System.Drawing.Point(89, 20);
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
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Sistema.DAL.Produto);
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "CodigoCategoria", true));
            this.cb_Cliente.DataSource = this.pessoasBindingSource;
            this.cb_Cliente.DisplayMember = "Descricao";
            this.cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(134, 17);
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
            this.button1.Location = new System.Drawing.Point(306, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovoitem);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(this.codigoProdutoComboBox);
            this.groupBox1.Controls.Add(this.itensVendaDataGridView);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.quantidadeTextBox);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.codigoVendaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 415);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(Sistema.DAL.ItensVenda);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(118, 96);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
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
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Sistema.DAL.Venda);
            // 
            // itensVendaDataGridView
            // 
            this.itensVendaDataGridView.AllowUserToAddRows = false;
            this.itensVendaDataGridView.AllowUserToDeleteRows = false;
            this.itensVendaDataGridView.AutoGenerateColumns = false;
            this.itensVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensVendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.itensVendaDataGridView.DataSource = this.itensVendaBindingSource;
            this.itensVendaDataGridView.Location = new System.Drawing.Point(6, 122);
            this.itensVendaDataGridView.Name = "itensVendaDataGridView";
            this.itensVendaDataGridView.ReadOnly = true;
            this.itensVendaDataGridView.Size = new System.Drawing.Size(589, 273);
            this.itensVendaDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo Produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // codigoProdutoComboBox
            // 
            this.codigoProdutoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.codigoProdutoComboBox.DataSource = this.produtoBindingSource;
            this.codigoProdutoComboBox.DisplayMember = "Descricao";
            this.codigoProdutoComboBox.FormattingEnabled = true;
            this.codigoProdutoComboBox.Location = new System.Drawing.Point(118, 40);
            this.codigoProdutoComboBox.Name = "codigoProdutoComboBox";
            this.codigoProdutoComboBox.Size = new System.Drawing.Size(100, 21);
            this.codigoProdutoComboBox.TabIndex = 9;
            this.codigoProdutoComboBox.ValueMember = "CodigoCategoria";
            // 
            // btnNovoitem
            // 
            this.btnNovoitem.Location = new System.Drawing.Point(259, 96);
            this.btnNovoitem.Name = "btnNovoitem";
            this.btnNovoitem.Size = new System.Drawing.Size(75, 23);
            this.btnNovoitem.TabIndex = 5;
            this.btnNovoitem.Text = "Novo Item";
            this.btnNovoitem.UseVisualStyleBackColor = true;
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(630, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoCategoriaLabel);
            this.Controls.Add(this.cb_Cliente);
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox codigoVendaTextBox;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox codigoProdutoComboBox;
        private System.Windows.Forms.DataGridView itensVendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnNovoitem;
    }
}