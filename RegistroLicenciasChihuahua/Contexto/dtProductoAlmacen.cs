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
    
    public partial class dtProductoAlmacen
    {
        public int ProductoId { get; set; }
        public int AlmacenId { get; set; }
        public Nullable<double> Cantidad { get; set; }
    
        public virtual dtAlmacen dtAlmacen { get; set; }
        public virtual dtProductoServicio dtProductoServicio { get; set; }
    }
}
