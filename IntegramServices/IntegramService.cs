﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntegramServices
{
    public class IntegramServices
    {
        private static void NotificarTelegram(string autor, string mensagem)
        {
            const string CANAL_KEY = "csH95I4r9QL";
            string urlCanal = "https://integram.org/" + CANAL_KEY;
            string mensagemJSON = "{\"" + autor +"\":\""+mensagem+"\"}";

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
            } catch (Exception e)
            {
                retornoAlerta = false;
            }

            return retornoAlerta;
        }
    }
}
