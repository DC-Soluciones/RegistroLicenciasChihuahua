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
    
    public partial class dtBitacoraLicencia
    {
        public int BitacoraId { get; set; }
        public string FolioInicial { get; set; }
        public string FolioFinal { get; set; }
        public Nullable<int> ModuloInicial { get; set; }
        public Nullable<int> ModuloFinal { get; set; }
        public Nullable<int> EstatusInicial { get; set; }
        public Nullable<int> EstatusFinal { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual dtDestino dtDestino { get; set; }
        public virtual dtEstatusLicencia dtEstatusLicencia { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
    }
}
