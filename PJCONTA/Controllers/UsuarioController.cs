using PJCONTA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PJCONTA.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {

            IngresosContext db = new IngresosContext();
            List<Usuario> lista = db.Usuario.Where(a => a.UserCar == "SISTEMAS").ToList();

            return View(lista);
        }
    }
}