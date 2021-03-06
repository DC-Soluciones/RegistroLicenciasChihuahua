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
    
    public partial class dtObjetivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtObjetivo()
        {
            this.dtArchivoes = new HashSet<dtArchivo>();
            this.dtObjetivo1 = new HashSet<dtObjetivo>();
            this.dtObjetivoHistorials = new HashSet<dtObjetivoHistorial>();
            this.dtTareas = new HashSet<dtTarea>();
        }
    
        public int ObjetivoId { get; set; }
        public int EmpresaId { get; set; }
        public Nullable<int> ObjetivoPadreId { get; set; }
        public string Texto { get; set; }
        public Nullable<int> UsuarioObjetivoId { get; set; }
        public Nullable<int> GrupoObjetivoId { get; set; }
        public Nullable<int> PorcentajeAvance { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public int UsuarioCreadorId { get; set; }
        public int UsuarioModificoId { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> MetricaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtArchivo> dtArchivoes { get; set; }
        public virtual dtEmpresa dtEmpresa { get; set; }
        public virtual dtGrupo dtGrupo { get; set; }
        public virtual dtMetrica dtMetrica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtObjetivo> dtObjetivo1 { get; set; }
        public virtual dtObjetivo dtObjetivo2 { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
        public virtual dtUsuario dtUsuario1 { get; set; }
        public virtual dtUsuario dtUsuario2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtObjetivoHistorial> dtObjetivoHistorials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTarea> dtTareas { get; set; }
    }
}
