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
    
    public partial class dtCorreoHistorial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtCorreoHistorial()
        {
            this.dtEmpresas = new HashSet<dtEmpresa>();
        }
    
        public int TrackId { get; set; }
        public string CorrreoDe { get; set; }
        public string CorreoPara { get; set; }
        public string CorreoCC { get; set; }
        public string Subject { get; set; }
        public string Texto { get; set; }
        public string EmailUID { get; set; }
        public Nullable<int> EmailId { get; set; }
        public System.DateTime FechaDescarga { get; set; }
        public Nullable<System.DateTime> FechaCorreo { get; set; }
        public Nullable<int> UsuarioDescargoId { get; set; }
        public string Archivos { get; set; }
        public Nullable<bool> TieneAdjunto { get; set; }
        public string MessageID { get; set; }
        public string Protocolo { get; set; }
        public Nullable<bool> DescargaCompleta { get; set; }
        public string HTML { get; set; }
        public string CorreoOrigen { get; set; }
    
        public virtual dtCuentaCorreo dtCuentaCorreo { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtEmpresa> dtEmpresas { get; set; }
    }
}
