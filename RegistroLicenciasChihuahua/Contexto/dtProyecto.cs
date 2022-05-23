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
    
    public partial class dtProyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtProyecto()
        {
            this.dtArchivoes = new HashSet<dtArchivo>();
            this.dtFacturas = new HashSet<dtFactura>();
            this.dtProyectoRoles = new HashSet<dtProyectoRole>();
            this.dtTareas = new HashSet<dtTarea>();
        }
    
        public int ProyectoId { get; set; }
        public Nullable<int> ProyectoPadreId { get; set; }
        public Nullable<int> EmpresaId { get; set; }
        public string ProyectoNombre { get; set; }
        public string ProyectoPath { get; set; }
        public Nullable<System.DateTime> ProyectoFecha { get; set; }
        public int ProyectoCreadorId { get; set; }
        public int ProyectoModificadorId { get; set; }
        public Nullable<bool> Activo { get; set; }
        public string ProyectoDescripcion { get; set; }
        public Nullable<decimal> Presupuesto { get; set; }
        public Nullable<int> CuentaId { get; set; }
        public Nullable<int> OportunidadId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtArchivo> dtArchivoes { get; set; }
        public virtual dtCuenta dtCuenta { get; set; }
        public virtual dtEmpresa dtEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtFactura> dtFacturas { get; set; }
        public virtual dtOportunidad dtOportunidad { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
        public virtual dtUsuario dtUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtProyectoRole> dtProyectoRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTarea> dtTareas { get; set; }
    }
}
