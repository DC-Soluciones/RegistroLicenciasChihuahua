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
    
    public partial class dtFolioConocer
    {
        public int FolioConocerId { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Curp { get; set; }
        public string Sexo { get; set; }
        public string FolioConocer { get; set; }
        public Nullable<System.DateTime> FechaCertificado { get; set; }
        public string TipoCertificado { get; set; }
        public string Organizacion { get; set; }
        public string Municipio { get; set; }
        public Nullable<int> UsuarioCreador { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
    
        public virtual dtUsuario dtUsuario { get; set; }
    }
}