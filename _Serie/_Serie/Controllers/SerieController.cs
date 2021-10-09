using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Controllers
{
    public class SerieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
