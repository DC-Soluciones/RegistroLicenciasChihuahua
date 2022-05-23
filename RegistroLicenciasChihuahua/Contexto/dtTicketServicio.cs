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
    
    public partial class dtTicketServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtTicketServicio()
        {
            this.dtArchivoes = new HashSet<dtArchivo>();
        }
    
        public int TicketServicioId { get; set; }
        public Nullable<int> SolicitanteId { get; set; }
        public Nullable<int> CuentaId { get; set; }
        public Nullable<int> ContactoId { get; set; }
        public Nullable<int> CategoriaId { get; set; }
        public Nullable<int> SubCategoriaId { get; set; }
        public Nullable<int> PrioridadId { get; set; }
        public Nullable<int> EstatusId { get; set; }
        public Nullable<int> AsignacionId { get; set; }
        public Nullable<bool> EsInterno { get; set; }
        public string Origen { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string NoImp { get; set; }
        public string CasoCSC { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<int> UsuarioCreador { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> UsuarioModifico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtArchivo> dtArchivoes { get; set; }
        public virtual dtCategoria dtCategoria { get; set; }
        public virtual dtSubCategoria dtSubCategoria { get; set; }
    }
}