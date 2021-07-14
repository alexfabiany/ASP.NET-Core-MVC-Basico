using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();

            return View();
        }

        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                string conteudo = $"Nome: {contato.Nome}\nE-mail: {contato.Email}\nAssunto: {contato.Assunto}\nMensagem: {contato.Mensagem}";

                return new ContentResult() { Content = conteudo };
            }
            else
            {
                ViewBag.Contato = contato;

                return View("Index");
            }
        }

        /* Obter dados manualmente
        public IActionResult ReceberContato()
        {
            // POST - Request.Form
            // GET - Request.QueryString

            Contato contato = new Contato();

            contato.Nome = Request.Form["nome"];
            contato.Email = Request.Form["email"];
            contato.Assunto = Request.Form["assunto"];
            contato.Mensagem = Request.Form["mensagem"];

            string conteudo = $"Nome: {contato.Nome}\nE-mail: {contato.Email}\nAssunto: {contato.Assunto}\nMensagem: {contato.Mensagem}";

            return new ContentResult() { Content = conteudo };
        }
        */
    }
}
