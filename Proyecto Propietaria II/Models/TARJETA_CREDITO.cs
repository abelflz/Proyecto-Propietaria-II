//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Propietaria_II.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TARJETA_CREDITO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TARJETA_CREDITO()
        {
            this.TRANSACCIONES = new HashSet<TRANSACCIONES>();
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public string ID_tarjeta { get; set; }
        public string ID_concurrencia { get; set; }
        public System.DateTime FechaVencimiento_tarjeta { get; set; }
        public string CVV_tajeta { get; set; }
        public string PIN_tarjeta { get; set; }
    
        public virtual CONCURRENCIA CONCURRENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACCIONES> TRANSACCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
