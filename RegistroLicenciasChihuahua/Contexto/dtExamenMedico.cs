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
    
    public partial class dtExamenMedico
    {
        public int ExamenMedicoId { get; set; }
        public int TramiteId { get; set; }
        public Nullable<System.DateTime> FechaInicioVigencia { get; set; }
        public Nullable<System.DateTime> FechaFinVigencia { get; set; }
        public Nullable<bool> Lentes { get; set; }
        public Nullable<bool> CapVs { get; set; }
        public Nullable<bool> Miopia { get; set; }
        public Nullable<bool> Ambiopia { get; set; }
        public Nullable<bool> Hiper { get; set; }
        public Nullable<bool> Astigmatismo { get; set; }
        public Nullable<bool> NormalAv { get; set; }
        public Nullable<bool> CapAud { get; set; }
        public Nullable<bool> NivelBajo { get; set; }
        public Nullable<bool> NivelMedio { get; set; }
        public Nullable<bool> SinRes { get; set; }
        public Nullable<bool> Normal { get; set; }
        public Nullable<bool> Apto { get; set; }
        public Nullable<bool> Padecimiento { get; set; }
        public Nullable<int> UsuarioCreadorId { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<int> UsuarioModificoId { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
        public string Comentarios { get; set; }
        public string OjoIzquierdo { get; set; }
        public string OjoDerecho { get; set; }
        public Nullable<int> DestinoId { get; set; }
        public Nullable<bool> CDelgada { get; set; }
        public Nullable<bool> CRegular { get; set; }
        public Nullable<bool> CAtletica { get; set; }
        public Nullable<bool> CObesa { get; set; }
        public Nullable<bool> CRobusta { get; set; }
        public Nullable<bool> PBlanco { get; set; }
        public Nullable<bool> PAmarillo { get; set; }
        public Nullable<bool> PMorenoClaro { get; set; }
        public Nullable<bool> PMoreno { get; set; }
        public Nullable<bool> PMorenoOscuro { get; set; }
        public Nullable<bool> PNegro { get; set; }
        public Nullable<bool> PCobriza { get; set; }
        public Nullable<bool> POtro { get; set; }
        public Nullable<bool> PAlbino { get; set; }
        public Nullable<bool> CaAlargada { get; set; }
        public Nullable<bool> CaCuadrada { get; set; }
        public Nullable<bool> CaOvalada { get; set; }
        public Nullable<bool> CaRedonda { get; set; }
        public Nullable<bool> CoAbundante { get; set; }
        public Nullable<bool> CoEscaso { get; set; }
        public Nullable<bool> CoRegular { get; set; }
        public Nullable<bool> CoSin { get; set; }
        public Nullable<bool> CoAlbino { get; set; }
        public Nullable<bool> CoTotal { get; set; }
        public Nullable<bool> CoCastanoClaro { get; set; }
        public Nullable<bool> CoCastanoOscuro { get; set; }
        public Nullable<bool> CoEntrecano { get; set; }
        public Nullable<bool> CoNegro { get; set; }
        public Nullable<bool> CoPelirrojo { get; set; }
        public Nullable<bool> CoRubio { get; set; }
        public Nullable<bool> CoCrespo { get; set; }
        public Nullable<bool> CoLacio { get; set; }
        public Nullable<bool> CoOndulado { get; set; }
        public Nullable<bool> CoRizado { get; set; }
        public Nullable<bool> CoParado { get; set; }
        public Nullable<bool> NGrande { get; set; }
        public Nullable<bool> NMediana { get; set; }
        public Nullable<bool> NPequena { get; set; }
        public Nullable<bool> NRecta { get; set; }
        public Nullable<bool> NRespingada { get; set; }
        public Nullable<bool> NAguilena { get; set; }
        public Nullable<bool> NAchatada { get; set; }
        public Nullable<bool> NConcavo { get; set; }
        public Nullable<bool> NConvexo { get; set; }
        public Nullable<bool> NRecto { get; set; }
        public Nullable<bool> NSinuoso { get; set; }
        public Nullable<bool> OAzul { get; set; }
        public Nullable<bool> OCafeClaro { get; set; }
        public Nullable<bool> OCafeOscuro { get; set; }
        public Nullable<bool> OMiel { get; set; }
        public Nullable<bool> OGris { get; set; }
        public Nullable<bool> Overde { get; set; }
        public Nullable<bool> ONegro { get; set; }
        public Nullable<bool> OOtro { get; set; }
        public Nullable<bool> OAlargados { get; set; }
        public Nullable<bool> ORedondos { get; set; }
        public Nullable<bool> OOvales { get; set; }
        public Nullable<bool> OGrandes { get; set; }
        public Nullable<bool> OPequenos { get; set; }
        public Nullable<bool> ORegulares { get; set; }
        public Nullable<bool> CEscasa { get; set; }
        public Nullable<bool> CRegulares { get; set; }
        public Nullable<bool> CPobladas { get; set; }
        public Nullable<bool> BGrande { get; set; }
        public Nullable<bool> BMediana { get; set; }
        public Nullable<bool> BPequena { get; set; }
        public Nullable<bool> BAbatidas { get; set; }
        public Nullable<bool> BElevadas { get; set; }
        public Nullable<bool> BSimetricas { get; set; }
        public Nullable<bool> BAsimetricas { get; set; }
        public Nullable<bool> LDelgados { get; set; }
        public Nullable<bool> LMedianos { get; set; }
        public Nullable<bool> LGruesos { get; set; }
        public Nullable<bool> LGrande { get; set; }
        public Nullable<bool> LMediana { get; set; }
        public Nullable<bool> LPequena { get; set; }
        public Nullable<bool> LInferior { get; set; }
        public Nullable<bool> LSuperior { get; set; }
        public Nullable<bool> LNinguno { get; set; }
        public Nullable<bool> Mbilovado { get; set; }
        public Nullable<bool> Mfoseta { get; set; }
        public Nullable<bool> Mborla { get; set; }
        public Nullable<bool> Mninguno { get; set; }
        public Nullable<bool> Moval { get; set; }
        public Nullable<bool> Mcuadrado { get; set; }
        public Nullable<bool> Mpunta { get; set; }
        public Nullable<bool> Mhuyente { get; set; }
        public Nullable<bool> Mprominente { get; set; }
        public Nullable<bool> Mvertical { get; set; }
        public Nullable<bool> Cicatrices { get; set; }
        public Nullable<bool> Tatuajes { get; set; }
        public Nullable<bool> Lunares { get; set; }
        public string Discapacidad { get; set; }
        public Nullable<bool> Protesis { get; set; }
        public Nullable<bool> Otras { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Alergias { get; set; }
        public Nullable<bool> MenosSesenta { get; set; }
        public Nullable<bool> Especial { get; set; }
        public Nullable<bool> Especiali { get; set; }
        public Nullable<bool> Acustico { get; set; }
        public Nullable<bool> Automatico { get; set; }
        public Nullable<bool> Dia { get; set; }
        public Nullable<bool> Acompanado { get; set; }
        public string TipoSangre { get; set; }
        public Nullable<bool> Donador { get; set; }
        public string FolioSeguimiento { get; set; }
        public string Retencion { get; set; }
    
        public virtual dtTramite dtTramite { get; set; }
    }
}
