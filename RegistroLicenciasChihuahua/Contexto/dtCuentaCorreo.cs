//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistroLicenciasChihuahua.Contexto
{
    using System;
    using System.Collections.Generic;
    
    public partial class dtCuentaCorreo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtCuentaCorreo()
        {
            this.dtCorreoHistorials = new HashSet<dtCorreoHistorial>();
        }
    
        public int EmailId { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public int Puerto { get; set; }
        public string Servidor { get; set; }
        public string ProtocoloEmail { get; set; }
        public Nullable<bool> SSL { get; set; }
        public string ModuloClave { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCorreoHistorial> dtCorreoHistorials { get; set; }
        public virtual dtModulo dtModulo { get; set; }
    }
}
