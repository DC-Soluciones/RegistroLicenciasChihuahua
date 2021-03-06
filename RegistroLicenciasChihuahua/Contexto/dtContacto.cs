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
    
    public partial class dtContacto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtContacto()
        {
            this.dtArchivoes = new HashSet<dtArchivo>();
            this.dtCampaniaContactoes = new HashSet<dtCampaniaContacto>();
            this.dtCampaniaContactoAsignadoes = new HashSet<dtCampaniaContactoAsignado>();
            this.dtCampaniaContactoContestadoes = new HashSet<dtCampaniaContactoContestado>();
            this.dtCrmAsignacions = new HashSet<dtCrmAsignacion>();
            this.dtNotas = new HashSet<dtNota>();
            this.dtOportunidadContactoes = new HashSet<dtOportunidadContacto>();
            this.dtReunionIntegrantes = new HashSet<dtReunionIntegrante>();
            this.dtTareas = new HashSet<dtTarea>();
        }
    
        public int ContactId { get; set; }
        public int EmpresaId { get; set; }
        public Nullable<int> CuentaId { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> SourceId { get; set; }
        public bool ContactStage { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Email { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public string Url { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Calle { get; set; }
        public string CP { get; set; }
        public string Colonia { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaLead { get; set; }
        public int CreadorId { get; set; }
        public Nullable<int> ModificadorId { get; set; }
        public string TipoAcceso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtArchivo> dtArchivoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCampaniaContacto> dtCampaniaContactoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCampaniaContactoAsignado> dtCampaniaContactoAsignadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCampaniaContactoContestado> dtCampaniaContactoContestadoes { get; set; }
        public virtual dtCuenta dtCuenta { get; set; }
        public virtual dtEmpresa dtEmpresa { get; set; }
        public virtual dtSource dtSource { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
        public virtual dtUsuario dtUsuario1 { get; set; }
        public virtual dtUsuario dtUsuario2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCrmAsignacion> dtCrmAsignacions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtNota> dtNotas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtOportunidadContacto> dtOportunidadContactoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtReunionIntegrante> dtReunionIntegrantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTarea> dtTareas { get; set; }
    }
}
