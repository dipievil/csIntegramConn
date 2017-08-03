using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntegramConn
{
    public class IntegramService : IIntegramServices
    {
        private static void NotificarTelegram(string autor, string mensagem)
        {
            const string CANAL_KEY = "ci8tA2mq4Q1";
            string urlCanal = "https://integram.org/" + CANAL_KEY;
            string mensagemJSON = "{\"text\":\"*" + autor + "*: " + mensagem+"\"}";

            WebClient clienteTelegram = new WebClient();
            
            var resposta = clienteTelegram.UploadData(urlCanal, "POST", Encoding.UTF8.GetBytes(mensagemJSON));
        }

        public bool EnviarAlerta(string autor, string mensagem)
        {
            bool retornoAlerta = false;
            
            try
            {
                NotificarTelegram(autor,mensagem);
                retornoAlerta = true;
            } catch {
                retornoAlerta = false;
            }

            return retornoAlerta;
        }
    }
}
