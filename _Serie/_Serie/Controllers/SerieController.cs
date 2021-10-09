using _Serie.Models;
using _Serie.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Controllers
{
    public class SerieController : Controller
    {
        static SerieRepositorio serieRepositorio = new SerieRepositorio();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Salvar(Serie entidade)
        {   
            serieRepositorio.Salvar(entidade);

            return View("Lista", serieRepositorio.Listar());
        }

        public IActionResult Listar()
        {
            return View("Lista", serieRepositorio.Listar());
        }
    }
}
