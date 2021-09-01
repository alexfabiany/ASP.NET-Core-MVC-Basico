using Site01.Models;
using System.Net;
using System.Net.Mail;

namespace Site01.Library.Mail
{
    public class EmailSender
    {
        public static void EnviarEmail(Contato contato)
        {
            string conteudo = $"Nome: {contato.Nome}<br /> E-mail: {contato.Email}<br /> Assunto: {contato.Assunto}<br /> Mensagem: {contato.Mensagem}";

            // Configurar servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha)
            };

            MailMessage mensagem = new MailMessage
            {
                From = new MailAddress(contato.Email)
            };

            mensagem.To.Add("alexfabiany@gmail.com");
            mensagem.Subject = "Formulário de contato";
            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de Contato</h1>" + conteudo;

            smtp.Send(mensagem);
        }
    }
}
