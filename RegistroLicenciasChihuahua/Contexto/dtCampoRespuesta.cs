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
    
    public partial class dtCampoRespuesta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtCampoRespuesta()
        {
            this.dtModuloRespuestaOpcions = new HashSet<dtModuloRespuestaOpcion>();
        }
    
        public int RespuestaId { get; set; }
        public Nullable<int> CampoId { get; set; }
        public string Valor { get; set; }
        public string Texto { get; set; }
        public Nullable<decimal> ValorNumerico { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual dtCampos dtCampos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtModuloRespuestaOpcion> dtModuloRespuestaOpcions { get; set; }
    }
}
