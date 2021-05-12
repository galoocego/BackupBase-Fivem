using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Agendador
{
    public partial class Form1 : Form
    {
        public Form1()
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

        class Configuracoes
        {
            public string source { get; set; }
            public string destino { get; set; }
            public string usuario { get; set; }
            public string senha { get; set; }
            public string banco { get; set; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 5000;
            t.Tick += new EventHandler(Fechar);
            t.Start();
        }

        private void Fechar(object sender, EventArgs e)
        {
            string path = "conf.json";
            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    Configuracoes items = JsonConvert.DeserializeObject<Configuracoes>(json);

                    string comando = items.source + @"\mysqldump.exe";
                    comando += " -u " + items.usuario;

                    if (items.senha != "")
                    {
                        comando += " -p" + items.senha;
                    }

                    DateTime data = DateTime.Now;
                    string texto = data.ToString("yyyyMMddHHmmss");

                    comando += " -h localhost " + items.banco + @" > " + items.destino + @"\backup" + texto + ".sql";

                    Process p = new Process();
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = "cmd.exe";
                    info.RedirectStandardInput = true;
                    info.UseShellExecute = false;

                    p.StartInfo = info;
                    p.Start();

                    using (StreamWriter sw = p.StandardInput)
                    {
                        if (sw.BaseStream.CanWrite)
                        {
                            sw.WriteLine(comando);
                        }
                    }
                }
                Thread.Sleep(30000);
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi encontrado o banco ou o MySQL, reveja o arquivo de configuração.");
            }
        }
    }
}
