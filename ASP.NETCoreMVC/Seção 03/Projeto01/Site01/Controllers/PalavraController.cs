using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        private DatabaseContext _db;

        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var palavras = _db.Palavras.ToList();

            return View(palavras);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar()
        {
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            return View("Cadastrar");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
