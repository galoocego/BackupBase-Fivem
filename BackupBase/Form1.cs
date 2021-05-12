using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BackupBase
{
    public partial class frmPrincipal : Form
    {
        public string portugues = "S";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://galocego.vercel.app");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/channels/841140239783165983");
        }

        private string ProcurarPasta()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSource.Text = ProcurarPasta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblDestino.Text = ProcurarPasta();
        }

        class Configuracoes
        {
            public string source { get; set; }
            public string destino { get; set; }
            public string usuario { get; set; }
            public string senha { get; set; }
            public string banco { get; set; }
            public string portugues { get; set; }

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string path = "conf.json";
            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    Configuracoes items = JsonConvert.DeserializeObject<Configuracoes>(json);

                    lblSource.Text = items.source;
                    lblDestino.Text = items.destino;
                    txtUsuario.Text = items.usuario;
                    txtSenha.Text = items.senha;
                    txtBanco.Text = items.banco;
                    portugues = items.portugues;
                    cmdLinguagem.Text = items.portugues;
                }
            }
            else
            {
                cmdLinguagem.Text = "Português";
            }
        }

        public bool ValidarCampos()
        {
            if (lblSource.Text == "")
            {
                string mensagem = (this.portugues == "S") ? ("O campo com o local do MySQL é obrigatório") : ("The field path of MySQL is required");
                MessageBox.Show(mensagem, "Warning");
                return false;

            }

            if (lblDestino.Text == "")
            {
                string mensagem = (this.portugues == "S") ? ("O campo com o local de destino para Salvar é obrigatório") : ("The field Save Path path is required");
                MessageBox.Show(mensagem, "Warning");
                return false;
            }

            if (txtUsuario.Text == "")
            {
                string mensagem = (this.portugues == "S") ? ("O campo do usuário do banco é obrigatório, geralmente é utilizado root") : ("The field user of database is required, usually is root");
                MessageBox.Show(mensagem, "Warning");
                return false;
            }

            return true;
        }

        private void cmdSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Configuracoes data = new Configuracoes()
                {
                    source = lblSource.Text.Replace("\\", @"\"),
                    destino = lblDestino.Text.Replace("\\", @"\"),
                    usuario = txtUsuario.Text,
                    senha = txtSenha.Text,
                    banco = txtBanco.Text,
                    portugues = cmdLinguagem.Text
                };

                File.WriteAllText(@"conf.json", JsonConvert.SerializeObject(data));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmdLinguagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool lang = (cmdLinguagem.Text=="Português")?(true):(false);
            labelDestino.Text = (lang) ? ("Local para salvar") : ("Path to save file");
            labelNomeBanco.Text = (lang) ? ("Nome do banco") : ("Database name");
            labelSenha.Text = (lang) ? ("Senha") : ("Password");
            labelSource.Text = (lang) ? ("Pasta bin do MySQL") : ("Bin folder of MySQL");
            labelUser.Text = (lang) ? ("Usuário") : ("User");
            cmdAjuda.Text = (lang) ? ("Ajuda") : ("Help");
            cmdSalvar.Text = (lang) ? ("Salvar") : ("Save");
            lblLinguagem.Text = (lang) ? ("Linguagem") : ("Language");
            btnPesquisa2.Text = (lang) ? ("Procurar") : ("Search");
            btnPesquisar1.Text = (lang) ? ("Procurar") : ("Search");
            grbBanco.Text = (lang) ? ("Sobre o banco de dados") : ("Information of your database");
        }
    }
}
