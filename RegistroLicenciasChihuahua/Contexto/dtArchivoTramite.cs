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
    
    public partial class dtArchivoTramite
    {
        public int ArchivoId { get; set; }
        public Nullable<int> TramiteId { get; set; }
        public string Ruta { get; set; }
        public string Extension { get; set; }
        public Nullable<int> UsuarioCreador { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string Nombre { get; set; }
    
        public virtual dtTramite dtTramite { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
    }
}
