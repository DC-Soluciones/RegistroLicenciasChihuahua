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
    
    public partial class dtMuroDetalleUsuario
    {
        public int MuroDetalleId { get; set; }
        public int UsuarioDestinoId { get; set; }
        public Nullable<bool> Leido { get; set; }
        public Nullable<System.DateTime> FechaLeido { get; set; }
    
        public virtual dtMuroDetalle dtMuroDetalle { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
    }
}
