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
    
    public partial class dtCotizacionDetalleSva
    {
        public int CotizacionDetalleSVAId { get; set; }
        public int CotizacionId { get; set; }
        public int CotizacionDetalleId { get; set; }
        public int SvaId { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioMensual { get; set; }
        public string Tipo { get; set; }
    
        public virtual dtCotizacion dtCotizacion { get; set; }
        public virtual dtCotizacionDetalle dtCotizacionDetalle { get; set; }
        public virtual dtMoviqSva dtMoviqSva { get; set; }
    }
}
