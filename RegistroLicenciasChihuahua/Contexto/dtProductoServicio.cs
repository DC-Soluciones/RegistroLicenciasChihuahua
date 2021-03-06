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
    
    public partial class dtProductoServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtProductoServicio()
        {
            this.dtArchivoes = new HashSet<dtArchivo>();
            this.dtCampaniaProductoes = new HashSet<dtCampaniaProducto>();
            this.dtNotas = new HashSet<dtNota>();
            this.dtOportunidadProductoes = new HashSet<dtOportunidadProducto>();
            this.dtProductoAlmacens = new HashSet<dtProductoAlmacen>();
            this.dtTareas = new HashSet<dtTarea>();
        }
    
        public int ProductoServicioId { get; set; }
        public Nullable<int> CategoriaId { get; set; }
        public int EmpresaId { get; set; }
        public string Clave { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> UnidadMedidaId { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string Clasificacion { get; set; }
        public string Tecnologia { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> UsuarioCreadorId { get; set; }
        public Nullable<int> UsuarioModificoId { get; set; }
        public string Foto { get; set; }
        public Nullable<bool> PublicadoWeb { get; set; }
        public string Url { get; set; }
        public Nullable<bool> Inventariable { get; set; }
        public string Moneda { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtArchivo> dtArchivoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCampaniaProducto> dtCampaniaProductoes { get; set; }
        public virtual dtCategoriaProducto dtCategoriaProducto { get; set; }
        public virtual dtEmpresa dtEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtNota> dtNotas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtOportunidadProducto> dtOportunidadProductoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtProductoAlmacen> dtProductoAlmacens { get; set; }
        public virtual dtUnidadMedita dtUnidadMedita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTarea> dtTareas { get; set; }
    }
}
