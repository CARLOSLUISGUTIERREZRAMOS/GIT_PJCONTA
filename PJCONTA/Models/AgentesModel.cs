using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PJCONTA.Models
{
    public class AgentesModel
    {
        public int Codigo { get; set; }
        [Display(Name ="Cod Res")]
        public string CodigoRes { get; set; }
        [Display(Name = "Cod Int")]
        public string CodigoInt { get; set; }
        [Display(Name = "Razon Social")]
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        [Display(Name = "Tipo Agente")]
        public string NombreTipoAgente { get; set; }
        [Display(Name = "Tipo Agencia")]        
        public string NombreTipoAgencia { get; set; }
        public string Localidad { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Ag Master")]
        public string NombreAgenteMaster { get; set; }










    }


    [MetadataType(typeof(AgentesModel))]
    public partial class Agentes
    {
        
    }
}   