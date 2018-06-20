using PJCONTA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PJCONTA.Controllers
{
    public class AgentesController : Controller
    {
        // GET: Agentes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaAgentes() {
            int codigo = 1000441;
            using (var db = new IngresosContext())
            {
                db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                try
                {
                    var informacion = from AG in db.Agentes
                                      join TA in db.TipoAgente on AG.TipoAgente equals TA.IdTipo
                                      join TAGC in db.TipoAgencia on AG.TipoAgencia equals TAGC.Codigo
                                      join AGTM in db.AgentesMaster on AG.CodigoMaster equals AGTM.CodigoMaster
                                      where AG.Estado == "A"
                                      select new AgentesModel {
                                          Codigo = AG.Codigo,
                                          CodigoRes = AG.CodigoRes,
                                          CodigoInt = AG.CodigoInt,
                                          NombreAgenteMaster = AGTM.Nombre,
                                          NombreTipoAgencia = TAGC.Nombre,
                                          Nombre = AG.Nombre,
                                          NombreTipoAgente = TA.Nombre,
                                          Direccion = AG.Direccion,
                                          Localidad = AG.Localidad,
                                          RazonSocial = AG.RazonSocial,
                                          Ruc = AG.Ruc,
                                          Telefono1 = AG.Telefono1
                                      };
                    //String valor =  informacion.FirstOrDefault().ToString();
                    return View(informacion.ToList().Take(100).OrderByDescending(ag => ag.Codigo));
                    
                }
                catch(Exception e)
                {
                    return null;
                }

            }



            
        }
    }
}