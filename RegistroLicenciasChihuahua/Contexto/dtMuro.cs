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
    
    public partial class dtMuro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtMuro()
        {
            this.dtMuroDetalles = new HashSet<dtMuroDetalle>();
        }
    
        public int MuroId { get; set; }
        public Nullable<int> EmpresaId { get; set; }
        public Nullable<int> VinculoId { get; set; }
        public string ModuloClave { get; set; }
        public Nullable<int> CreadorId { get; set; }
        public string Titulo { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
    
        public virtual dtEmpresa dtEmpresa { get; set; }
        public virtual dtModulo dtModulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtMuroDetalle> dtMuroDetalles { get; set; }
    }
}