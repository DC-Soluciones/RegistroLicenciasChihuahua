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
    
    public partial class dtBitacoraAlmacenEvidencia
    {
        public int BitacoraAlmacenEvidenciaId { get; set; }
        public Nullable<int> MovimientoId { get; set; }
        public string PathImagen { get; set; }
        public Nullable<System.DateTime> FechaEvidencia { get; set; }
    
        public virtual dtBitacoraAlmacen dtBitacoraAlmacen { get; set; }
    }
}
