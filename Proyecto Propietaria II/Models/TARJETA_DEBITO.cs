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
    
    public partial class TARJETA_DEBITO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TARJETA_DEBITO()
        {
            this.TRANSACCIONES = new HashSet<TRANSACCIONES>();
        }
    
        public string ID_tarjetaDebito { get; set; }
        public decimal Numero_cuenta { get; set; }
        public string CVV_tarjetaDebito { get; set; }
        public string PIN_tarjetaDebito { get; set; }
        public System.DateTime fechaVencimiento_tarjetaDebito { get; set; }
    
        public virtual CUENTA CUENTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACCIONES> TRANSACCIONES { get; set; }
    }
}