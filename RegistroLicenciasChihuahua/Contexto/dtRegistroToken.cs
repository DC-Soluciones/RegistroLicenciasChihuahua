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
    
    public partial class dtRegistroToken
    {
        public int TokenId { get; set; }
        public string Token { get; set; }
        public string TokenTipo { get; set; }
        public Nullable<int> EmpresaId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaConfirmacion { get; set; }
        public string EstatusCodigo { get; set; }
    
        public virtual dtEmpresa dtEmpresa { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
    }
}