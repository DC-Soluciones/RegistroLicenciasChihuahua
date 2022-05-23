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
    
    public partial class dtExamenToxico
    {
        public int ExamenToxicoId { get; set; }
        public int TramiteId { get; set; }
        public Nullable<System.DateTime> FechaInicioVigencia { get; set; }
        public Nullable<System.DateTime> FechaFinVigencia { get; set; }
        public Nullable<bool> Cocaina { get; set; }
        public Nullable<bool> Marihuana { get; set; }
        public Nullable<bool> Anfetamina { get; set; }
        public Nullable<bool> Metanfetamina { get; set; }
        public Nullable<bool> Otro { get; set; }
        public Nullable<bool> ExamenAlcoholemia { get; set; }
        public Nullable<bool> ExamenPsicometrico { get; set; }
        public Nullable<bool> Apto { get; set; }
        public Nullable<int> UsuarioCreadorId { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<int> UsuarioModificoId { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
        public string Comentarios { get; set; }
        public Nullable<int> DestinoId { get; set; }
    
        public virtual dtTramite dtTramite { get; set; }
    }
}
