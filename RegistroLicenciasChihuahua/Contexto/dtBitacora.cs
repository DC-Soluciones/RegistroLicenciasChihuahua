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
    
    public partial class dtBitacora
    {
        public int BitacoraId { get; set; }
        public string ModuloClave { get; set; }
        public Nullable<int> EmpresaId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<int> RelId { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Accion { get; set; }
        public string Comentarios { get; set; }
    
        public virtual dtEmpresa dtEmpresa { get; set; }
        public virtual dtModulo dtModulo { get; set; }
    }
}
