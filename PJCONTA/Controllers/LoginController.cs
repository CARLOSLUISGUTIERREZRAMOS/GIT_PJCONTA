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

            IngresosContext db = new IngresosContext();
            List<Usuario> lista = db.Usuario.Where(a => a.UserCar == "COUNTER").ToList();

            return View();
        }

        public ActionResult Validacion() {
            return View("Home");
        }
    }
}