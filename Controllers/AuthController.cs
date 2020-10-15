using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiarsT2.DB;
using DiarsT2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiarsT2.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppPokemonContext cnx;
        public AuthController()
        {
            cnx = new AppPokemonContext();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (!string.IsNullOrEmpty(user.Username))
            {
                var encontrado = cnx.Usuarios.Where(o => o.Username == user.Username && o.Password == user.Password).FirstOrDefault();
                if (encontrado != null)
                {
                    HttpContext.Session.SetString("UserId", encontrado.Id.ToString());
                    return RedirectToAction("Index", "Pokemon");
                }
            }
            ViewBag.LoginError = "Credenciales invalidas";
            return View();
        }
    }
}
