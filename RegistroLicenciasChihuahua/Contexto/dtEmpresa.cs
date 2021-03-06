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
    
    public partial class dtEmpresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtEmpresa()
        {
            this.dtActividads = new HashSet<dtActividad>();
            this.dtAgrupadors = new HashSet<dtAgrupador>();
            this.dtApartados = new HashSet<dtApartado>();
            this.dtArchivoes = new HashSet<dtArchivo>();
            this.dtAreas = new HashSet<dtArea>();
            this.dtAtributoes = new HashSet<dtAtributo>();
            this.dtBitacoras = new HashSet<dtBitacora>();
            this.dtBitacoraAlmacens = new HashSet<dtBitacoraAlmacen>();
            this.dtCampanias = new HashSet<dtCampania>();
            this.dtCampos = new HashSet<dtCampos>();
            this.dtCategoriaProductoes = new HashSet<dtCategoriaProducto>();
            this.dtContactoes = new HashSet<dtContacto>();
            this.dtContestadoFormularios = new HashSet<dtContestadoFormulario>();
            this.dtCoordenadas = new HashSet<dtCoordenada>();
            this.dtCrmAsignacions = new HashSet<dtCrmAsignacion>();
            this.dtCuentas = new HashSet<dtCuenta>();
            this.dtDestinos = new HashSet<dtDestino>();
            this.dtDispositivoHistorials = new HashSet<dtDispositivoHistorial>();
            this.dtProductoServicios = new HashSet<dtProductoServicio>();
            this.dtEmpresaUsuarios = new HashSet<dtEmpresaUsuario>();
            this.dtEtapas = new HashSet<dtEtapa>();
            this.dtEvaluacions = new HashSet<dtEvaluacion>();
            this.dtFacturas = new HashSet<dtFactura>();
            this.dtFacturaCategorias = new HashSet<dtFacturaCategoria>();
            this.dtGastoReportes = new HashSet<dtGastoReporte>();
            this.dtGrupoes = new HashSet<dtGrupo>();
            this.dtGrupoUsuarios = new HashSet<dtGrupoUsuario>();
            this.dtListaPrecios = new HashSet<dtListaPrecio>();
            this.dtMarkers = new HashSet<dtMarker>();
            this.dtMetas = new HashSet<dtMeta>();
            this.dtMetricas = new HashSet<dtMetrica>();
            this.dtModuloAsignacions = new HashSet<dtModuloAsignacion>();
            this.dtMuroes = new HashSet<dtMuro>();
            this.dtNotas = new HashSet<dtNota>();
            this.dtObjetivoes = new HashSet<dtObjetivo>();
            this.dtOportunidads = new HashSet<dtOportunidad>();
            this.dtOportunidadContactoes = new HashSet<dtOportunidadContacto>();
            this.dtPagoHistorials = new HashSet<dtPagoHistorial>();
            this.dtProyectoes = new HashSet<dtProyecto>();
            this.dtRegistroTokens = new HashSet<dtRegistroToken>();
            this.dtReunions = new HashSet<dtReunion>();
            this.dtSources = new HashSet<dtSource>();
            this.dtStatus = new HashSet<dtStatu>();
            this.dtTareas = new HashSet<dtTarea>();
            this.dtTareaRecursos = new HashSet<dtTareaRecurso>();
            this.dtTemplatePasos = new HashSet<dtTemplatePaso>();
            this.dtTickets = new HashSet<dtTicket>();
            this.dtUsuarios = new HashSet<dtUsuario>();
            this.dtValors = new HashSet<dtValor>();
            this.dtZonas = new HashSet<dtZona>();
            this.dtCorreoHistorials = new HashSet<dtCorreoHistorial>();
        }
    
        public int EmpresaId { get; set; }
        public string RazonSocial { get; set; }
        public string EmpresaDsc { get; set; }
        public string RFC { get; set; }
        public string Logotipo { get; set; }
        public string URL { get; set; }
        public string url_pitch { get; set; }
        public string angelist { get; set; }
        public string Email { get; set; }
        public string TwitterPitch { get; set; }
        public string TwitterUsuario { get; set; }
        public string Crunchbase { get; set; }
        public string Telefono { get; set; }
        public string Problem_solucion { get; set; }
        public string ProductCategory { get; set; }
        public string Descripcion { get; set; }
        public string OportunidadMercado { get; set; }
        public string revenueField { get; set; }
        public string FinancialStatus { get; set; }
        public string fundingNeeds { get; set; }
        public string keyMileStones { get; set; }
        public string LegalStatus { get; set; }
        public string competitiveAdvantage { get; set; }
        public string Whytoinvest { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaInicioOperacion { get; set; }
        public Nullable<System.DateTime> FechaUltimoPago { get; set; }
        public string TipoSubscripcionCode { get; set; }
        public Nullable<int> UsuarioCreadorId { get; set; }
        public string PaqueteCodigo { get; set; }
        public Nullable<bool> EtapasDefault { get; set; }
        public Nullable<decimal> MontoNotificacion { get; set; }
        public string ClausuladoFinanciamiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtActividad> dtActividads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtAgrupador> dtAgrupadors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtApartado> dtApartados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtArchivo> dtArchivoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtArea> dtAreas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtAtributo> dtAtributoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtBitacora> dtBitacoras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtBitacoraAlmacen> dtBitacoraAlmacens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCampania> dtCampanias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCampos> dtCampos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCategoriaProducto> dtCategoriaProductoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtContacto> dtContactoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtContestadoFormulario> dtContestadoFormularios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCoordenada> dtCoordenadas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCrmAsignacion> dtCrmAsignacions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCuenta> dtCuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtDestino> dtDestinos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtDispositivoHistorial> dtDispositivoHistorials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtProductoServicio> dtProductoServicios { get; set; }
        public virtual dtPaquete dtPaquete { get; set; }
        public virtual dtTipoSubscripcion dtTipoSubscripcion { get; set; }
        public virtual dtUsuario dtUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtEmpresaUsuario> dtEmpresaUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtEtapa> dtEtapas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtEvaluacion> dtEvaluacions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtFactura> dtFacturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtFacturaCategoria> dtFacturaCategorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtGastoReporte> dtGastoReportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtGrupo> dtGrupoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtGrupoUsuario> dtGrupoUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtListaPrecio> dtListaPrecios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtMarker> dtMarkers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtMeta> dtMetas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtMetrica> dtMetricas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtModuloAsignacion> dtModuloAsignacions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtMuro> dtMuroes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtNota> dtNotas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtObjetivo> dtObjetivoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtOportunidad> dtOportunidads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtOportunidadContacto> dtOportunidadContactoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtPagoHistorial> dtPagoHistorials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtProyecto> dtProyectoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtRegistroToken> dtRegistroTokens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtReunion> dtReunions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtSource> dtSources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtStatu> dtStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTarea> dtTareas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTareaRecurso> dtTareaRecursos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTemplatePaso> dtTemplatePasos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtTicket> dtTickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtUsuario> dtUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtValor> dtValors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtZona> dtZonas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtCorreoHistorial> dtCorreoHistorials { get; set; }
    }
}
