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
    
    public partial class spfLicenciasDigitale
    {
        public long FolioControl { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string CodigoPostal { get; set; }
        public string MunicipioDesc { get; set; }
        public string EstadoDesc { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public string NumeroLicencia { get; set; }
        public string NumeroLicenciaAnterior { get; set; }
        public int TipoLicencia { get; set; }
        public string TipoLicenciaDesc { get; set; }
        public string Nacionalidad { get; set; }
        public Nullable<System.DateTime> FechaAntiguedad { get; set; }
        public string NumeroExpediente { get; set; }
        public bool DonadorVoluntario { get; set; }
        public bool SinRestricciones { get; set; }
        public bool Lentes { get; set; }
        public bool Protesis { get; set; }
        public bool Auditivo { get; set; }
        public bool LentesContacto { get; set; }
        public bool VehiculoAdaptado { get; set; }
        public bool VehiculoAutomatico { get; set; }
        public string Restricciones { get; set; }
        public byte[] HuellaConductor { get; set; }
        public byte[] FotografiaConductor { get; set; }
        public string FirmaConductor { get; set; }
        public short Estatus { get; set; }
        public string EstatusDesc { get; set; }
        public string Referencia { get; set; }
        public System.DateTime FechaConsulta { get; set; }
        public string UsuarioEntregaPVC { get; set; }
        public System.DateTime FechaEntregaPVC { get; set; }
        public long FolioPVC { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FechaSistema { get; set; }
        public int OrigenTramite { get; set; }
        public int OrigenRegistro { get; set; }
        public long NumeroOperacion { get; set; }
    }
}