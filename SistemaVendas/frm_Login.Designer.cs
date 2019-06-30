namespace SistemaVendas
{
    partial class frm_Login
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_sair_login = new System.Windows.Forms.Button();
            usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.BackColor = System.Drawing.Color.Transparent;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            usuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            usuarioLabel.Location = new System.Drawing.Point(162, 53);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(64, 18);
            usuarioLabel.TabIndex = 1;
            usuarioLabel.Text = "Usuário:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            senhaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            senhaLabel.Location = new System.Drawing.Point(167, 102);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(54, 18);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "Senha:";
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataSource = typeof(Sistema.DAL.Usuarios);
            // 
            // txtUsuario
            // 
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "usuario", true));
            this.txtUsuario.Location = new System.Drawing.Point(242, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "senha", true));
            this.txtSenha.Location = new System.Drawing.Point(242, 100);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = global::SistemaVendas.Properties.Resources.cadeado_icone_55x45;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(161, 208);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 48);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_sair_login
            // 
            this.btn_sair_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sair_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair_login.ForeColor = System.Drawing.Color.White;
            this.btn_sair_login.Image = global::SistemaVendas.Properties.Resources.deletar_32x32;
            this.btn_sair_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair_login.Location = new System.Drawing.Point(291, 208);
            this.btn_sair_login.Name = "btn_sair_login";
            this.btn_sair_login.Size = new System.Drawing.Size(99, 39);
            this.btn_sair_login.TabIndex = 6;
            this.btn_sair_login.Text = "Sair";
            this.btn_sair_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair_login.UseVisualStyleBackColor = false;
            this.btn_sair_login.Click += new System.EventHandler(this.btn_sair_login_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVendas.Properties.Resources.login_escuro;
            this.ClientSize = new System.Drawing.Size(542, 317);
            this.Controls.Add(this.btn_sair_login);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_sair_login;
    }
}