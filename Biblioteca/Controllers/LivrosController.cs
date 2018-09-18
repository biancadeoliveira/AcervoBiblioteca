using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(IFormCollection values)
        {
            var dados = values["Resenha"];
            var a = new Livros();
            //a.insert(values);
            
            return dados;
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}