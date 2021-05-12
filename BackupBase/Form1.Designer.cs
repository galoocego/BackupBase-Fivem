
namespace BackupBase
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.labelDestino = new System.Windows.Forms.Label();
            this.btnPesquisa2 = new System.Windows.Forms.Button();
            this.btnPesquisar1 = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.cmdAjuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSource = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.TextBox();
            this.grbBanco = new System.Windows.Forms.GroupBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.labelNomeBanco = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.cmdLinguagem = new System.Windows.Forms.ComboBox();
            this.lblLinguagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(18, 88);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(88, 13);
            this.labelDestino.TabIndex = 6;
            this.labelDestino.Text = "Local para salvar";
            // 
            // btnPesquisa2
            // 
            this.btnPesquisa2.Location = new System.Drawing.Point(338, 84);
            this.btnPesquisa2.Name = "btnPesquisa2";
            this.btnPesquisa2.Size = new System.Drawing.Size(72, 21);
            this.btnPesquisa2.TabIndex = 2;
            this.btnPesquisa2.Text = "Procurar";
            this.btnPesquisa2.UseVisualStyleBackColor = true;
            this.btnPesquisa2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPesquisar1
            // 
            this.btnPesquisar1.Location = new System.Drawing.Point(338, 51);
            this.btnPesquisar1.Name = "btnPesquisar1";
            this.btnPesquisar1.Size = new System.Drawing.Size(72, 21);
            this.btnPesquisar1.TabIndex = 1;
            this.btnPesquisar1.Text = "Procurar";
            this.btnPesquisar1.UseVisualStyleBackColor = true;
            this.btnPesquisar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(2, 55);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(104, 13);
            this.labelSource.TabIndex = 9;
            this.labelSource.Text = "Pasta bin do MySQL";
            this.labelSource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(339, 207);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(72, 21);
            this.cmdSalvar.TabIndex = 6;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click_1);
            // 
            // cmdAjuda
            // 
            this.cmdAjuda.Location = new System.Drawing.Point(339, 254);
            this.cmdAjuda.Name = "cmdAjuda";
            this.cmdAjuda.Size = new System.Drawing.Size(72, 21);
            this.cmdAjuda.TabIndex = 7;
            this.cmdAjuda.Text = "Ajuda";
            this.cmdAjuda.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BackupBase.Properties.Resources.discord1;
            this.pictureBox1.Location = new System.Drawing.Point(256, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BackupBase.Properties.Resources.galocego;
            this.pictureBox2.Location = new System.Drawing.Point(16, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 68);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblSource
            // 
            this.lblSource.Location = new System.Drawing.Point(109, 51);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(223, 20);
            this.lblSource.TabIndex = 8;
            // 
            // lblDestino
            // 
            this.lblDestino.Location = new System.Drawing.Point(109, 85);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(223, 20);
            this.lblDestino.TabIndex = 9;
            // 
            // grbBanco
            // 
            this.grbBanco.Controls.Add(this.txtBanco);
            this.grbBanco.Controls.Add(this.labelNomeBanco);
            this.grbBanco.Controls.Add(this.txtSenha);
            this.grbBanco.Controls.Add(this.labelSenha);
            this.grbBanco.Controls.Add(this.txtUsuario);
            this.grbBanco.Controls.Add(this.labelUser);
            this.grbBanco.Location = new System.Drawing.Point(38, 115);
            this.grbBanco.Name = "grbBanco";
            this.grbBanco.Size = new System.Drawing.Size(341, 81);
            this.grbBanco.TabIndex = 3;
            this.grbBanco.TabStop = false;
            this.grbBanco.Text = "Sobre o banco de dados MySQL";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(101, 49);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(158, 20);
            this.txtBanco.TabIndex = 5;
            // 
            // labelNomeBanco
            // 
            this.labelNomeBanco.AutoSize = true;
            this.labelNomeBanco.Location = new System.Drawing.Point(12, 52);
            this.labelNomeBanco.Name = "labelNomeBanco";
            this.labelNomeBanco.Size = new System.Drawing.Size(83, 13);
            this.labelNomeBanco.TabIndex = 24;
            this.labelNomeBanco.Text = "Nome do banco";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(218, 23);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(109, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(179, 26);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 22;
            this.labelSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(55, 23);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(108, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 26);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 13);
            this.labelUser.TabIndex = 20;
            this.labelUser.Text = "Usuário";
            // 
            // cmdLinguagem
            // 
            this.cmdLinguagem.FormattingEnabled = true;
            this.cmdLinguagem.Items.AddRange(new object[] {
            "Português",
            "English"});
            this.cmdLinguagem.Location = new System.Drawing.Point(109, 15);
            this.cmdLinguagem.Name = "cmdLinguagem";
            this.cmdLinguagem.Size = new System.Drawing.Size(223, 21);
            this.cmdLinguagem.TabIndex = 17;
            this.cmdLinguagem.SelectedIndexChanged += new System.EventHandler(this.cmdLinguagem_SelectedIndexChanged);
            // 
            // lblLinguagem
            // 
            this.lblLinguagem.AutoSize = true;
            this.lblLinguagem.Location = new System.Drawing.Point(44, 18);
            this.lblLinguagem.Name = "lblLinguagem";
            this.lblLinguagem.Size = new System.Drawing.Size(59, 13);
            this.lblLinguagem.TabIndex = 18;
            this.lblLinguagem.Text = "Linguagem";
            this.lblLinguagem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLinguagem.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 295);
            this.Controls.Add(this.lblLinguagem);
            this.Controls.Add(this.cmdLinguagem);
            this.Controls.Add(this.grbBanco);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdAjuda);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.btnPesquisar1);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.btnPesquisa2);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<GaloCego Scripts/> - Backup DataBase";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbBanco.ResumeLayout(false);
            this.grbBanco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Button btnPesquisa2;
        private System.Windows.Forms.Button btnPesquisar1;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdAjuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lblSource;
        private System.Windows.Forms.TextBox lblDestino;
        private System.Windows.Forms.GroupBox grbBanco;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label labelNomeBanco;
        private System.Windows.Forms.ComboBox cmdLinguagem;
        private System.Windows.Forms.Label lblLinguagem;
    }
}

