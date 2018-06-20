using PJCONTA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Text;


namespace PJCONTA.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario u)
        {

            if (!ModelState.IsValid)
                return View("Login");

            try
            {
                //Empleando using para no dejar conexiones abiertas inncesarias 
                using (IngresosContext db = new IngresosContext())

                {
                    //return RedirectToAction("Index", "Home");

                    var Hash = Encrypt.GetMD5(u.UserPass);
                    var obj = db.Usuario.Where(uModel => uModel.IdUsuario.Equals(u.IdUsuario) && uModel.UserPass == Hash).FirstOrDefault();

                    if (obj == null)
                    {
                        ViewBag.MensajeError = "Credenciales no validas";
                        return View("Login");

                    }
                    else
                    {

                        Session["IdUsuario"] = obj.IdUsuario.ToString();
                        Session["UserNom"] = obj.UserNom.ToString();
                        Session["UserApe"] = obj.UserApe.ToString();
                        Session["UserCar"] = obj.UserCar.ToString();
                        return RedirectToAction("Index");
                    }




                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar al alumno", ex);
                return View();

            }

        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        

    }

    public class Encrypt
    {
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }

}