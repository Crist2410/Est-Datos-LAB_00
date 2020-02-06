using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Est_Datos_LAB_00.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Est_Datos_LAB_00.Controllers
{
    public class UsuariosController : Controller
    {
        public static List<UsuariosModel> A_Usuarios = new List<UsuariosModel>();

        // GET: VISTA INDEX
        public ActionResult Index()
        {
            return View();
        }

        // GET: VISTA Mostrar Usuarios
        public ActionResult MostrarUsuarios()
        {
            ViewBag.Usuarios = A_Usuarios;
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        var pokemon = new PokemonModel
        //        {
        //            Name = collection["Name"],
        //            Number = int.Parse(collection["Number"])
        //        };

        //        if (pokemon.Save())
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            return View(pokemon);
        //        }
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
        public IActionResult CreateUsuarios(IFormCollection collection)
        {
            UsuariosModel Usuario = new UsuariosModel();

            Usuario.Nombre = collection["Nombre"];
            Usuario.Apellido = collection["Apellido"];
            Usuario.Telefono = int.Parse(collection["Telefono"]);
            Usuario.Info = collection["Info"];

            A_Usuarios.Add(Usuario);
            ViewBag.Usuarios = A_Usuarios;
            return View("MostrarUsuarios");
        }


        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}