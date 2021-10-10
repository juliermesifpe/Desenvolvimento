using _Serie.Models;
using _Serie.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Controllers
{
    public class SerieController : Controller
    {
        static SerieRepositorio serieRepositorio = new SerieRepositorio();

        public IActionResult Index()
        {
            IEnumerable<String> listOfDirectories = Directory.EnumerateDirectories("Views");
            ViewBag.listOfDirectories = listOfDirectories;

            IEnumerable<string> files = Directory.EnumerateFiles("Views");
            ViewBag.files = files;

            // "*" pode ser subistituido por "*.txt" ou por outra extensão"
            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("Views", "*", SearchOption.AllDirectories);
            ViewBag.allFilesInAllFolders = allFilesInAllFolders;

            return View("Index", ViewBag);
        }

        public IActionResult Salvar(Serie entidade)
        {
            serieRepositorio.Salvar(entidade);

            serieRepositorio.EscreverFileAdicionar(entidade);

            return View("Lista", serieRepositorio.Listar());
        }

        public IActionResult Listar()
        {
            //serieRepositorio.Listar();
            ViewBag.Adicionar = serieRepositorio.LerFileAdicionar();
            ViewBag.Cadastrar = serieRepositorio.LerFileCadastrar();
            return View("Lista", ViewBag);
        }

    }
}
