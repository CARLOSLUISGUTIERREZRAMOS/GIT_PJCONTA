//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PJCONTA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgentesCuentas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgentesCuentas()
        {
            this.Agentes = new HashSet<Agentes>();
        }
    
        public int Agente { get; set; }
        public string avVenta { get; set; }
        public string avCobrar { get; set; }
        public string acFxCobrar { get; set; }
        public string avCredito { get; set; }
        public string avCanje { get; set; }
        public string avDebito { get; set; }
        public string avNoRep { get; set; }
        public string avIGV { get; set; }
        public string avComxVenta { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public string UsuarioReg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agentes> Agentes { get; set; }
    }
}
