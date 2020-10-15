using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiarsT2.DB;
using DiarsT2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiarsT2.Controllers
{
    public class TypeController : Controller
    {
        private readonly AppPokemonContext cnx;

        public TypeController()
        {
            cnx = new AppPokemonContext();
        }

        public IActionResult Index()
        {
            var tipos = cnx.Tipos.ToList();
            return View(tipos);
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Type type)
        {
            cnx.Tipos.Add(type);
            cnx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
