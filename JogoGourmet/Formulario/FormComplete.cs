using System;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class FormComplete : Form
    {
        public FormComplete()
        {
            InitializeComponent();
            this.ShowIcon = false;
            ActiveControl = this.textBox1;
        }

        public FormComplete(string resposta)
        {
            InitializeComponent();
            this.label1.Text = resposta;
            this.ShowIcon = false;
        }

        private string tipo;
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.listaResposta.Add(this.textBox1.Text);
            Program.listaResposta.Add(getTipo());

            Acao.Btn_Click_Close(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acao.Btn_Click_Close(this);
        }
    }
}
