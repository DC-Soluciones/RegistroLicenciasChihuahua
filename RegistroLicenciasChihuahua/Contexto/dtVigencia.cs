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
    
    public partial class dtVigencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtVigencia()
        {
            this.dtImportes = new HashSet<dtImporte>();
        }
    
        public int VigenciaId { get; set; }
        public string TipoTramite { get; set; }
        public int TipoLicenciaId { get; set; }
        public Nullable<int> AniosVigencia { get; set; }
        public string Nombre { get; set; }
        public string TipoVig { get; set; }
        public bool Active { get; set; }
        public int UsuarioCreador { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<int> UsuarioModificador { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtImporte> dtImportes { get; set; }
        public virtual dtTipoLicencia dtTipoLicencia { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
        public virtual dtUsuario dtUsuario1 { get; set; }
    }
}
