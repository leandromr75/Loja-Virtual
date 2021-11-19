using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.wwwroot.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("leandromrxx75@gmail.com", "#lecoteco1975#");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" +
                "<b>Nome:   </b> {0} <br />" +
                "<b>E-mail: </b> {1} <br />" +
                "<b>Texto:  </b> {2} <br />" +
                "<br /> E-mail enviado automaticamente do site LojaVirtual",
                contato.Nome,
                contato.Email,
                contato.Texto
             );

            MailMessage message = new MailMessage();
            message.From = new MailAddress("leandromrxx75@gmail.com");
            message.To.Add("leandromrxx75@gmail.com");
            message.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            message.Body = corpoMsg;
            message.IsBodyHtml = true;

            smtp.Send(message);
        }
    }
}
