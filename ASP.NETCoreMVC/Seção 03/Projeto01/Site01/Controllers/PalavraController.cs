﻿using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Library.Filters;
using Site01.Models;
using System.Linq;

namespace Site01.Controllers
{
    [Login]
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
            return View(new Palavra());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);

                _db.SaveChanges();

                TempData["Mensagem"] = $"A palavra '{palavra.Nome}' foi adicionada com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Palavra palavra = _db.Palavras.Find(id);

            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);

                _db.SaveChanges();

                TempData["Mensagem"] = $"A palavra '{palavra.Nome}' foi atualizada com sucesso!";

                return RedirectToAction("Index");
            }

            return View("Cadastrar", palavra);
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            Palavra palavra = _db.Palavras.Find(id);

            _db.Palavras.Remove(palavra);

            _db.SaveChanges();

            TempData["Mensagem"] = $"A palavra '{palavra.Nome}' foi removida com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
