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
    
    public partial class spfPadLicencia
    {
        public int idPersona { get; set; }
        public string Nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string cp { get; set; }
        public Nullable<System.DateTime> fechaAlta { get; set; }
        public string expediente { get; set; }
        public Nullable<System.DateTime> fechaAntiguedad { get; set; }
        public Nullable<System.DateTime> fecha1raExpedicion { get; set; }
    }
}
