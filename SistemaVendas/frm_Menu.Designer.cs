﻿namespace SistemaVendas
{
    partial class frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CadProdutos = new System.Windows.Forms.Button();
            this.btn_cadCategorias = new System.Windows.Forms.Button();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCategoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosCategoriaToolStripMenuItem
            // 
            this.produtosCategoriaToolStripMenuItem.Name = "produtosCategoriaToolStripMenuItem";
            this.produtosCategoriaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.produtosCategoriaToolStripMenuItem.Text = "Produtos / Categoria";
            this.produtosCategoriaToolStripMenuItem.Click += new System.EventHandler(this.produtosCategoriaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // btn_CadProdutos
            // 
            this.btn_CadProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadProdutos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CadProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CadProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CadProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadProdutos.ForeColor = System.Drawing.Color.White;
            this.btn_CadProdutos.Image = global::SistemaVendas.Properties.Resources.cadastro_produtos_40_x_40;
            this.btn_CadProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CadProdutos.Location = new System.Drawing.Point(50, 42);
            this.btn_CadProdutos.Name = "btn_CadProdutos";
            this.btn_CadProdutos.Size = new System.Drawing.Size(86, 80);
            this.btn_CadProdutos.TabIndex = 2;
            this.btn_CadProdutos.Text = "Cadastrar Produtos";
            this.btn_CadProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CadProdutos.UseVisualStyleBackColor = false;
            this.btn_CadProdutos.Click += new System.EventHandler(this.btn_CadProdutos_Click);
            // 
            // btn_cadCategorias
            // 
            this.btn_cadCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadCategorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cadCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cadCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadCategorias.ForeColor = System.Drawing.Color.White;
            this.btn_cadCategorias.Image = global::SistemaVendas.Properties.Resources.devolucao_fornecedores_40x40;
            this.btn_cadCategorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadCategorias.Location = new System.Drawing.Point(155, 42);
            this.btn_cadCategorias.Name = "btn_cadCategorias";
            this.btn_cadCategorias.Size = new System.Drawing.Size(86, 80);
            this.btn_cadCategorias.TabIndex = 3;
            this.btn_cadCategorias.Text = "Categorias";
            this.btn_cadCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadCategorias.UseVisualStyleBackColor = false;
            this.btn_cadCategorias.Click += new System.EventHandler(this.btn_cadCategorias_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::SistemaVendas.Properties.Resources.fundo_sistema_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 287);
            this.Controls.Add(this.btn_cadCategorias);
            this.Controls.Add(this.btn_CadProdutos);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_CadProdutos;
        private System.Windows.Forms.Button btn_cadCategorias;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
    }
}

