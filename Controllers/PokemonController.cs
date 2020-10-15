using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using DiarsT2.DB;
using DiarsT2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.EntityFrameworkCore.Design;

namespace DiarsT2.Controllers
{
    public class PokemonController : Controller
    {
        private readonly AppPokemonContext cnx;
        public IHostEnvironment _hostEnv;

        public PokemonController(IHostEnvironment hostEnv)
        {
            cnx = new AppPokemonContext();
            _hostEnv = hostEnv;
        }
        public IActionResult Index(string name="")
        {
            var pokemons = cnx.Pokemons.Include(o=>o.Type).AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                pokemons = pokemons.Where(o => o.Name.Contains(name));
            }
            ViewBag.Busqueda = name;
            ViewBag.UserId = HttpContext.Session.GetString("UserId");
            return View(pokemons.ToList());
        }

        [HttpGet]
        public IActionResult Register()
        {
            var types = cnx.Tipos.ToList();
            ViewBag.UserId = HttpContext.Session.GetString("UserId");
            ViewBag.Tipos = types;
            return View(new Pokemon());
        }

        [HttpPost]
        public IActionResult Register(Pokemon pokemon, IFormFile image)
        {
            if(EsValido(pokemon) && image != null)
            {
                pokemon.ImagePath = SaveImage(image);
                cnx.Pokemons.Add(pokemon);
                cnx.SaveChanges();
                ViewBag.UserId = HttpContext.Session.GetString("UserId");
                return RedirectToAction("Index");
            }

            var types = cnx.Tipos.ToList();
            ViewBag.Tipos = types;

            if(pokemon.Name == null)
            {
                ModelState.AddModelError("Name", "Este campo es obligatorio");
            }

            if (pokemon.Type == null)
            {
                ModelState.AddModelError("Type", "Este campo es obligatorio");
            }

            if (image == null)
            {
                ModelState.AddModelError("Imagen", "Este campo es obligatorio");
            }
            return View(pokemon);
        }

        [HttpPost]
        public IActionResult Capture(UserPokemon userPokemon)
        {
            var relation = cnx.UsuarioPokemons.Where(o => o.UserId == userPokemon.UserId && o.PokemonId == userPokemon.PokemonId).FirstOrDefault();
            if(relation == null)
            {
                userPokemon.Date = DateTime.Now;
                cnx.UsuarioPokemons.Add(userPokemon);
                cnx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Free(UserPokemon userPokemon)
        {
            var relation = cnx.UsuarioPokemons.Where(o => o.PokemonId == userPokemon.PokemonId && o.UserId == userPokemon.UserId).FirstOrDefault();
            cnx.UsuarioPokemons.Remove(relation);
            cnx.SaveChanges();
            return RedirectToAction("Captured");
        }

        public IActionResult Captured()
        {
            ViewBag.UserId = HttpContext.Session.GetString("UserId");
            var userId = HttpContext.Session.GetString("UserId");
            var pokemonesCapturados = cnx.UsuarioPokemons.Where(o => o.UserId.ToString() == userId).Include(o => o.Pokemon).ThenInclude(o => o.Type).ToList();
            return View(pokemonesCapturados);
        }

        private string SaveImage(IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                var basePath = _hostEnv.ContentRootPath + @"\wwwroot";
                var ruta = @"\files\" + image.FileName;

                using (var strem = new FileStream(basePath + ruta, FileMode.Create))
                {
                    image.CopyTo(strem);
                    return ruta;
                }
            }
            return null;
        }

        public bool EsValido(Pokemon pokemon)
        {

            if (string.IsNullOrEmpty(pokemon.Name))
            {
                return false;
            }

            var encontrado = cnx.Pokemons.Where(o => o.Name == pokemon.Name).FirstOrDefault();
            if (encontrado != null)
            {
                ModelState.AddModelError("Name", "Nombre no disponible");
                return false;
            }
            return true;
        }
    }
}
