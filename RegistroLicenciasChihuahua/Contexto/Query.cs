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
    
    public partial class Query
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaVigenciaIni { get; set; }
        public Nullable<System.DateTime> FechaVigenciaFin { get; set; }
        public string EstatusId { get; set; }
        public string Fotografia { get; set; }
        public int EmpresaId { get; set; }
        public short RolId { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> PuestoId { get; set; }
        public string Descripcion { get; set; }
        public Nullable<short> EstadoId { get; set; }
        public Nullable<bool> NotificacionesDiarias { get; set; }
        public Nullable<bool> NotificacionesTareas { get; set; }
        public Nullable<bool> NotificacionesReuniones { get; set; }
        public string Cluster { get; set; }
        public Nullable<int> Clave { get; set; }
        public Nullable<int> RegionId { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> Modulo { get; set; }
        public string Curp { get; set; }
    }
}