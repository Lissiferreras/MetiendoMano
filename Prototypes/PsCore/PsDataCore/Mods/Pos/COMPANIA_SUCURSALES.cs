//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PsDataCore.Mods.Pos
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPANIA_SUCURSALES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPANIA_SUCURSALES()
        {
            this.CLIENTES = new HashSet<CLIENTES>();
            this.SERVICIOS = new HashSet<SERVICIOS>();
            this.TRANSACCIONES = new HashSet<TRANSACCIONES>();
        }
    
        public int ID { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string TEL1 { get; set; }
        public string TEL2 { get; set; }
        public string FAX { get; set; }
        public string CORREO1 { get; set; }
        public string CORREO2 { get; set; }
        public Nullable<int> SUBBARRIOID { get; set; }
        public string DIRECCION { get; set; }
        public string CODIGOPOSTAL { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<int> COMPANIAID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
        public virtual COMPANIA COMPANIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOS> SERVICIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACCIONES> TRANSACCIONES { get; set; }
    }
}
