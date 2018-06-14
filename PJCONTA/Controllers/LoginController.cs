using PJCONTA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PJCONTA.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Validacion(Usuario u) {

            if (!ModelState.IsValid)
                return View("Index");

            try
            {
                //Empleando using para no dejar conexiones abiertas inncesarias 
                using (var db = new IngresosContext())
                {   
                    return RedirectToAction("Index","Home");
                }
            }
            catch (Exception ex){
                ModelState.AddModelError("Error al agregar al alumno",ex);
                return View();

            }
                                   
        }

        public ActionResult Test() {
            IngresosContext db = new IngresosContext();
            List<Usuario> lista = db.Usuario.Where(a => a.UserCar == "COUNTER").ToList();

            return View();
        }
    }
}