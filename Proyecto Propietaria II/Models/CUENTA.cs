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
    
    public partial class CUENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUENTA()
        {
            this.TARJETA_DEBITO = new HashSet<TARJETA_DEBITO>();
        }
    
        public decimal Numero_cuenta { get; set; }
        public string Cedula_usuario { get; set; }
        public int balanceActual_cuenta { get; set; }
        public int balanceDisponible_cuenta { get; set; }
        public int consumoTotal_cuenta { get; set; }
        public int consumoCorte_cuenta { get; set; }
        public decimal ingresos_cuenta { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARJETA_DEBITO> TARJETA_DEBITO { get; set; }
    }
}
