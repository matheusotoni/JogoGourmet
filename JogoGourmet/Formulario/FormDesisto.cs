using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class FormDesisto : Form
    {
        public FormDesisto()
        {
            InitializeComponent();
            this.ShowIcon = false;
            ActiveControl = this.txtPratoPensou;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var pratoPensou = txtPratoPensou.Text;

            if (pratoPensou.Length <= 0)
            {
                MessageBox.Show(Pergunta.perguntaObrigatoriaPratoPensou, Pergunta.titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var resposta = pratoPensou + Pergunta.resposta;                

                //Mostro o formulario com a resposta
                var form = new FormComplete(resposta);
                form.Text = pratoPensou;
                form.setTipo(pratoPensou);
                form.Show();

                //fecho o formulario "desisto"
                Acao.Btn_Click_Close(this);
            }
        }

        /// <summary>
        /// Fecho o formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Acao.Btn_Click_Close(this);
        }
    }
}
