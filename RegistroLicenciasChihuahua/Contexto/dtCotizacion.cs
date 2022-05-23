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
    
    public partial class dtCotizacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtCotizacion()
        {
            this.dtCotizacionDetalles = new HashSet<dtCotizacionDetalle>();
            this.dtCotizacionDetalleSvas = new HashSet<dtCotizacionDetalleSva>();
        }
    
        public int CotizacionId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string EstatusClave { get; set; }
        public Nullable<int> TotalLineasSuma { get; set; }
        public Nullable<decimal> TotalCargoInicial { get; set; }
        public Nullable<decimal> TotalPagoMensual { get; set; }
        public Nullable<decimal> TotalRentaServicio { get; set; }
        public Nullable<decimal> TotalPagoMensualEquipo { get; set; }
        public Nullable<int> UsuarioCreadorId { get; set; }
        public string NombreContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public string Segmento { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> UsuarioModificoId { get; set; }
        public Nullable<System.DateTime> FechaEstatus { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string NombreComercial { get; set; }
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string CP { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public Nullable<int> CuentaId { get; set; }
        public string Tipo { get; set; }
        public string TipoCliente { get; set; }
        public string FormaPago { get; set; }
        public Nullable<int> TipoClienteId { get; set; }
        public Nullable<int> FormaPagoId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCotizacionDetalle> dtCotizacionDetalles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCotizacionDetalleSva> dtCotizacionDetalleSvas { get; set; }
    }
}
