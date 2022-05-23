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
    
    public partial class dtAprobacionDatosPDV
    {
        public int ComparacionId { get; set; }
        public string NombreAtiende { get; set; }
        public string Estatus { get; set; }
        public string Calle { get; set; }
        public string NumeroInt { get; set; }
        public string NumeroExt { get; set; }
        public string Colonia { get; set; }
        public Nullable<int> CodigoPostal { get; set; }
        public string DelegacionMunicipio { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string EntreCalles { get; set; }
        public Nullable<int> CadenaId { get; set; }
        public Nullable<double> Latitud { get; set; }
        public Nullable<double> Longitud { get; set; }
        public Nullable<bool> AproboSP { get; set; }
        public Nullable<bool> AproboLZ { get; set; }
        public Nullable<bool> AproboPC { get; set; }
        public Nullable<int> DestinoId { get; set; }
        public Nullable<int> UsuarioAprobadorSP { get; set; }
        public Nullable<int> UsuarioAprobadorLZ { get; set; }
        public Nullable<int> UsuarioAprobadorPC { get; set; }
        public Nullable<System.DateTime> FechaAprobacionSP { get; set; }
        public Nullable<System.DateTime> FechaAprobacionLZ { get; set; }
        public Nullable<System.DateTime> FechaAprobacionPC { get; set; }
        public Nullable<System.DateTime> FechaContestado { get; set; }
        public Nullable<System.DateTime> FechaSincronizacion { get; set; }
        public Nullable<int> UsuarioContestadoId { get; set; }
        public Nullable<int> UsuarioModificoId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual dtDestino dtDestino { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
        public virtual dtUsuario dtUsuario1 { get; set; }
        public virtual dtUsuario dtUsuario2 { get; set; }
        public virtual dtUsuario dtUsuario3 { get; set; }
        public virtual dtUsuario dtUsuario4 { get; set; }
    }
}
