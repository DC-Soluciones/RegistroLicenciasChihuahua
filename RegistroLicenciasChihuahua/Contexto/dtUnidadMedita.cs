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
    
    public partial class dtUnidadMedita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtUnidadMedita()
        {
            this.dtProductoServicios = new HashSet<dtProductoServicio>();
        }
    
        public int UnidadMedidaId { get; set; }
        public string UnidadMedidaDsc { get; set; }
        public Nullable<int> EmpresaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtProductoServicio> dtProductoServicios { get; set; }
    }
}
