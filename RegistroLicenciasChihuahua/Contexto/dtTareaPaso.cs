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
    
    public partial class dtTareaPaso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtTareaPaso()
        {
            this.dtTareaPasoArchivoes = new HashSet<dtTareaPasoArchivo>();
        }
    
        public int PasoId { get; set; }
        public int TareaId { get; set; }
        public string Titulo { get; set; }
        public Nullable<bool> Completada { get; set; }
        public Nullable<System.DateTime> FechaCompletada { get; set; }
        public Nullable<int> UsuarioCompletoId { get; set; }
        public Nullable<int> Orden { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string Comentarios { get; set; }
    
        public virtual dtTarea dtTarea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTareaPasoArchivo> dtTareaPasoArchivoes { get; set; }
    }
}
