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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultMassa = dialogMassa();

            if (dialogResultMassa == DialogResult.Yes)
            {
                DialogResult dialogResultLasanha = dialogLasanha();

                if (dialogResultLasanha == DialogResult.Yes)
                {
                    acertei();
                }
                else if (dialogResultLasanha == DialogResult.No)
                {
                    if (Program.listaResposta.Count > 0)
                    {
                        for (int i = 0; i < Program.listaResposta.Count; i++)
                        {
                            recursividadeDialog(Program.listaResposta.ElementAt(i));
                        }
                    }
                    else
                    {
                        var formDesisto = new FormDesisto();
                        formDesisto.Show();
                    }
                }
            }
            else if (dialogResultMassa == DialogResult.No)
            {
                List<bool> respostas = new List<bool>();

                if (Program.listaResposta.Count > 0)
                {
                    for (int i = 0; i < Program.listaResposta.Count; i++)
                    {
                        bool simNao = recursividadeDialog(Program.listaResposta.ElementAt(i));
                        respostas.Add(simNao);
                    }

                    if (respostas.Any(r => r.Equals(true)))
                    {
                        acertei();
                    }
                    else if (respostas.Any(r => r.Equals(false)))
                    {
                        var formDesisto = new FormDesisto();
                        formDesisto.Show();
                    }
                }
                else
                {
                    DialogResult dialogResultBoloChocolate = dialogBoloChocolate();

                    if (dialogResultBoloChocolate == DialogResult.Yes)
                    {
                        acertei();
                    }
                    else if (dialogResultBoloChocolate == DialogResult.No)
                    {
                        var formDesisto = new FormDesisto();
                        formDesisto.Show();
                    }
                }
            }
        }

        /// <summary>
        /// Mostro a modal que acertei
        /// </summary>
        private void acertei()
        {
            dialog(Pergunta.perguntaAcertei, Pergunta.tituloAcertei, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult dialogMassa()
        {
            return dialog(Pergunta.perguntaMassa, Pergunta.tituloPergunta, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private DialogResult dialogBoloChocolate()
        {
            return dialog(Pergunta.perguntaBoloChocolate, Pergunta.tituloPergunta, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private DialogResult dialogLasanha()
        {
            return dialog(Pergunta.perguntaLasanha, Pergunta.tituloPergunta, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private DialogResult dialog(string titulo, string pergunta, MessageBoxButtons tipoBotao, MessageBoxIcon icone)
        {
            return MessageBox.Show(titulo, pergunta, tipoBotao, icone);
        }
        

        private bool recursividadeDialog(string prato)
        {
            bool retorno = false;

            DialogResult dialogResultRecursive = dialog(Pergunta.getPergunta(prato), Pergunta.tituloConfirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResultRecursive == DialogResult.Yes)
            {
                retorno = true;
            }
            else if (dialogResultRecursive == DialogResult.No)
            {
                retorno = false;             
            }

            return retorno;
        }
    }
}
