using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet
{
    public static class Pergunta
    {
        public static string perguntaMassa = "O prato que você pensou é massa?";
        public static string perguntaLasanha = "O prato que você pensou é Lasanha?";
        public static string perguntaAcertei = "Acertei novamente!";
        public static string perguntaPrato = "Qual prato você pensou?";
        public static string perguntaBoloChocolate = "O prato que você pensou é Bolo de chocolate?";

        public static string tituloAcertei = "Acertei";
        public static string tituloDesisto = "Desisto";
        public static string tituloConfirm = "Confirm";
        public static string tituloPergunta = "Pergunta";
        public static string titulo = "";

        public static string perguntaObrigatoriaPratoPensou = "Insira o prato que você pensou!";

        public static string resposta = " é _________, mas Lasanha não.";
        public static string getPergunta(string pratoTipo)
        {
            return "O prato que você pensou é " + pratoTipo + " ?";
        }
    }
}
