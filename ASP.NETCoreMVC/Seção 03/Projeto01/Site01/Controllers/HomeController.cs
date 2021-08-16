using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "alexfabiany@outlook.com" && usuario.Senha == "123456")
                {
                    /*
                    // Criar Seção
                    HttpContext.Session.SetString("Login", "true");
                    HttpContext.Session.SetInt32("UserID", 13);
                    HttpContext.Session.SetString("Login", Serialized Object);

                    // Ler Seção
                    string logado = HttpContext.Session.GetString("Login");
                    int? logged = HttpContext.Session.GetInt32("UserID");
                    */

                    HttpContext.Session.SetString("Login", "true");

                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "As informações não conferem!";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}
