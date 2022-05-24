﻿using PUE.Controllers;
using RegistroLicenciasChihuahua.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLicenciasChihuahua
{
    public partial class Registro : Form
    {

        string CURPC = "";
        LicHistoricoEntities _contextHist;
        LicenciasCH_Entities _context;
        dtTramite ciudadano;
        string Usuario;

        public Registro(string curp, string usuario, int id, string bd)
        {
            InitializeComponent();

            if (curp != "")
            {
                _context = new LicenciasCH_Entities();
                cb_Tlicencia.DataSource = _context.dtTipoLicencias.Where(x => x.Activo == true).ToList();
                Usuario = usuario;
                CURPC = curp;

                if (id != 0)
                {
                    txt_Id.Text = id.ToString();
                    CargarEdicion(id, bd);
                }
                else
                {
                    txt_Curp.Text = CURPC;
                    txt_Fexpedicion.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
                    txt_Fantiguedad.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

                    string anio = CURPC.Substring(4, 2);
                    string mes = CURPC.Substring(6, 2);
                    string dia = CURPC.Substring(8, 2);
                    string fecha = dia + '-' + mes + '-' + anio;
                    txt_Fnacimiento.Text = fecha;
                    if (CURPC != "")
                    {

                        _context = new LicenciasCH_Entities();
                        ciudadano = (from d in _context.dtTramites
                                     where d.Curp == txt_Curp.Text
                                     select d).OrderByDescending(x => x.FechaCreacion).FirstOrDefault();

                        if (ciudadano != null)
                        {
                            txt_Nombre.Text = ciudadano.Nombre;
                            txt_ApellidoP.Text = ciudadano.ApellidoPaterno;
                            txt_ApellidoM.Text = ciudadano.ApellidoMaterno;
                            cb_Ecivil.Text = ciudadano.EstadoCivil;
                            //  txt_Fnacimiento.Text = ciudadano.FechaNacimiento.Value.ToShortDateString();
                            txt_Rfc.Text = ciudadano.RFC;
                            cb_Sexo.Text = ciudadano.Sexo == "M" ? "Masculino" : "Femenino";
                            cb_Nacionalidad.Text = ciudadano.Nacionalidad;
                            cb_Tidentificacion.Text = ciudadano.TipoIdentificacion;
                            txt_NoIdentificacion.Text = ciudadano.NoId;
                            txt_Telefono.Text = ciudadano.Telefono;
                            cb_ComprobanteDom.Text = ciudadano.ComporbanteDomicilio;
                            txt_NoComprobante.Text = ciudadano.NoComprobante;
                            txt_Ocupacion.Text = ciudadano.Ocupacion;
                        }
                        else
                        {

                            using (_contextHist = new LicHistoricoEntities())
                            {

                                ciudadano = (from d in _contextHist.dtTramites
                                             where d.Curp == txt_Curp.Text
                                             select d).OrderByDescending(x => x.FechaCreacion).FirstOrDefault();
                                if (ciudadano != null)
                                {

                                    txt_Nombre.Text = ciudadano.Nombre;
                                    txt_ApellidoP.Text = ciudadano.ApellidoPaterno;
                                    txt_ApellidoM.Text = ciudadano.ApellidoMaterno;
                                    cb_Ecivil.Text = ciudadano.EstadoCivil;
                                    //txt_Fnacimiento.Text = ciudadano.FechaNacimiento.Value.ToShortDateString();
                                    txt_Rfc.Text = ciudadano.RFC;
                                    cb_Sexo.Text = ciudadano.Sexo == "M" ? "Masculino" : "Femenino";
                                    cb_Nacionalidad.Text = ciudadano.Nacionalidad;
                                    cb_Tidentificacion.Text = ciudadano.TipoIdentificacion;
                                    txt_NoIdentificacion.Text = ciudadano.NoId;
                                    txt_Telefono.Text = ciudadano.Telefono;
                                    cb_ComprobanteDom.Text = ciudadano.ComporbanteDomicilio;
                                    txt_NoComprobante.Text = ciudadano.NoComprobante;
                                    txt_Ocupacion.Text = ciudadano.Ocupacion;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar datos correctos");
            }
        }




        private void CargarEdicion(int id, string bd)
        {
            _context = new LicenciasCH_Entities();


            if (bd == "Actual" || bd == "")
            {


                ciudadano = (from d in _context.dtTramites
                             where d.TramiteId == id
                             select d).OrderByDescending(x => x.FechaCreacion).FirstOrDefault();


            }
            else if (bd == "Historica")
            {
                _contextHist = new LicHistoricoEntities();

                ciudadano = (from d in _contextHist.dtTramites
                             where d.TramiteId == id
                             select d).OrderByDescending(x => x.FechaCreacion).FirstOrDefault();
            }

            if (ciudadano.Sexo == "M")
            {
                cb_Sexo.Text = "Masculino";
            }
            if (ciudadano.Sexo == "F")
            {
                cb_Sexo.Text = "Femenino";
            }
            if (ciudadano.Sexo == "O")
            {
                cb_Sexo.Text = "Otro";
            }
            switch (ciudadano.TipoTramite)
            {
                case "E":
                    cb_Ttramite.Text = "Reposición";
                    break;
                case "R":
                    cb_Ttramite.Text = "Reposición";
                    break;
                case "C":
                    cb_Ttramite.Text = "Renovación";
                    break;
                case "I":
                    cb_Ttramite.Text = "Reimpresión";
                    break;
                case "O":
                    cb_Ttramite.Text = "Robo";
                    break;
                case "X":
                    cb_Ttramite.Text = "Extravio";
                    break;
            }

         
            txt_Curp.Text = ciudadano.Curp;
            cb_Tlicencia.SelectedValue = ciudadano.TipoLicencia;
            LoadTramiteVigencia(ciudadano.AniosVigencia);
         //   cb_Vigencia.Text.Contains(ciudadano.AniosVigencia.ToString());
            txt_Importe.Text = ciudadano.Importe.ToString();
            txt_Folio.Text = ciudadano.FolioSeguimiento;
            txt_Fexpedicion.Text = ciudadano.FechaExpedicion.Value.ToShortDateString();
            txt_Fvencimiento.Text = ciudadano.FechaVencimiento.Value.ToShortDateString();
            txt_Fantiguedad.Text = ciudadano.FechaAntiguedad.Value.ToShortDateString();
            txt_Licanterior.Text = ciudadano.LicenciaAnterior;
            txt_Nombre.Text = ciudadano.Nombre;
            txt_ApellidoP.Text = ciudadano.ApellidoPaterno;
            txt_ApellidoM.Text = ciudadano.ApellidoMaterno;
            cb_Ecivil.Text = ciudadano.EstadoCivil;
            txt_Fnacimiento.Text = ciudadano.FechaNacimiento.Value.ToShortDateString();
            txt_Rfc.Text = ciudadano.RFC;

            cb_Nacionalidad.Text = ciudadano.Nacionalidad;
            cb_Tidentificacion.Text = ciudadano.TipoIdentificacion;
            txt_NoIdentificacion.Text = ciudadano.NoId;
            txt_Telefono.Text = ciudadano.Telefono;
            cb_ComprobanteDom.Text = ciudadano.ComporbanteDomicilio;
            txt_NoComprobante.Text = ciudadano.NoComprobante;
            txt_Ocupacion.Text = ciudadano.Ocupacion;
            txt_NContacto.Text = ciudadano.Ben1Nombre;
            txt_APContacto.Text = ciudadano.Ben1APaterno;
            txt_AMContacto.Text = ciudadano.Ben1AMaterno;
            txt_TelContacto.Text = ciudadano.TipoTel;
            txt_Calle.Text = ciudadano.Calle;
            txt_NoExterior.Text = ciudadano.NoExterior;
            txt_NoInterior.Text = ciudadano.NoInterior;
            txt_CP.Text = ciudadano.CodigoPostal;
            cb_Estado.Text = ciudadano.EstadoN;
            cb_Municipio.SelectedText = ciudadano.MunicipioN;
            txt_Colonia.Text = ciudadano.ColoniaN;
            txt_NTutor.Text = ciudadano.NombreTutor;
            txt_APTutor.Text = ciudadano.APaternoTutor;
            txt_AMTutor.Text = ciudadano.AMaternoTutor;
            txt_Licanterior.Text = ciudadano.LicenciaAnterior == null ? ciudadano.NumeroLicencia : ciudadano.LicenciaAnterior;
            //Vigencia();

        }
        public Boolean IsValid(Form form)
        {
            if (cb_Tlicencia.SelectedValue.ToString() == "E" || cb_Tlicencia.SelectedValue.ToString() == "P")
            {
                return form.Controls.OfType<TextBox>().Any(x => x.Tag.ToString() == "Required"
                 && string.IsNullOrEmpty(x.Text) && Visible == true);
            }
            else
            {
                return true;
            }

        }
        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licenciasCHDataSetMunicipios.dtMunicipio' Puede moverla o quitarla según sea necesario.
            this.dtMunicipioTableAdapter.Fill(this.licenciasCHDataSetMunicipios.dtMunicipio);
            // TODO: esta línea de código carga datos en la tabla 'licenciasCHDataSet.dtTipoLicencias' Puede moverla o quitarla según sea necesario.
            this.dtTipoLicenciasTableAdapter.Fill(this.licenciasCHDataSet.dtTipoLicencias);

        }

        private void pnl_Menor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Biometricos_Click(object sender, EventArgs e)
        {
            if (this.panelregistro.Controls.Count > 0)
                this.panelregistro.Controls.RemoveAt(0);
            Biometricos biometricos = new Biometricos();
            biometricos.TopLevel = false;
            biometricos.Dock = DockStyle.Fill;
            panelregistro.Controls.Clear();
            panelregistro.Controls.Add(biometricos);
            panelregistro.Tag = biometricos;
            biometricos.Show();
        }

        private void cb_Tlicencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vigencia();

            if (Convert.ToString(cb_Tlicencia.SelectedValue) == "E" || Convert.ToString(cb_Tlicencia.SelectedValue) == "P")
            {
                pnl_Menor.Visible = true;
            }
            else
            {
                pnl_Menor.Visible = false;
            }
        }

        public void Vigencia()
        {
            using (_context = new LicenciasCH_Entities())
            {

                string tipolic1 = cb_Tlicencia.SelectedValue == null ? "B" : cb_Tlicencia.SelectedValue.ToString();
                var tplic = _context.dtTipoLicencias.Where(x => x.Clave == tipolic1).Select(x => x).FirstOrDefault();
                int tipolic = tplic.TipoLicenciaId;
          
                if (cb_Ttramite.Text == "Nueva")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "E" && x.TipoLicenciaId == tipolic).ToList();

                }
                else if (cb_Ttramite.Text == "Reposición")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "R" && x.TipoLicenciaId == tipolic).ToList();
                }
                else if (cb_Ttramite.Text == "Renovación")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "C" && x.TipoLicenciaId == tipolic).ToList();
                }
                else if (cb_Ttramite.Text == "Reimpresión")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "I" && x.TipoLicenciaId == tipolic).ToList();
                }
                else if (cb_Ttramite.Text == "Robo")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "O" && x.TipoLicenciaId == tipolic).ToList();
                }
                else if (cb_Ttramite.Text == "Extravio")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "X" && x.TipoLicenciaId == tipolic).ToList();
                }
                cb_Vigencia.ValueMember = "VigenciaId";
                cb_Vigencia.DisplayMember = "Nombre";

                using (_context = new LicenciasCH_Entities())
                {
                    int vigid = Convert.ToInt32(cb_Vigencia.SelectedValue);
                    var impo = _context.dtImportes.Where(x => x.VigenciaId == vigid).FirstOrDefault();
                    if (impo != null)
                    {
                        txt_Importe.Text = impo.Monto.ToString("0.00");
                    }
                    else
                    {
                        txt_Importe.Text = "";
                    }
                }
            }
        }


        public void LoadTramiteVigencia(int anios)
        {
            using (_context = new LicenciasCH_Entities())
            {

                string tipolic1 = cb_Tlicencia.SelectedValue == null ? "B" : cb_Tlicencia.SelectedValue.ToString();
                var tplic = _context.dtTipoLicencias.Where(x => x.Clave == tipolic1).Select(x => x).FirstOrDefault();
                int tipolic = tplic.TipoLicenciaId;
             

                if (cb_Ttramite.Text == "Nueva")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "E" && x.TipoLicenciaId == tipolic).ToList();
                    

                }
                else if (cb_Ttramite.Text == "Reposición")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "R" && x.TipoLicenciaId == tipolic).ToList();
                }
                else if (cb_Ttramite.Text == "Renovación")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "C" && x.TipoLicenciaId == tipolic).ToList();
                    cb_Vigencia.ValueMember = "VigenciaId";
                    cb_Vigencia.DisplayMember = "Nombre";
                    var SELECT  = _context.dtVigencias.Where(x => x.TipoTramite == "C" && x.TipoLicenciaId == tipolic && x.AniosVigencia == anios).Select(X=>X.VigenciaId).FirstOrDefault();
                    cb_Vigencia.SelectedValue = SELECT;
                }
                else if (cb_Ttramite.Text == "Reimpresión")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "I" && x.TipoLicenciaId == tipolic).ToList();
                }
                else if (cb_Ttramite.Text == "Robo")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "O" && x.TipoLicenciaId == tipolic).ToList();
                }
                else if (cb_Ttramite.Text == "Extravio")
                {
                    cb_Vigencia.DataSource = _context.dtVigencias.Where(x => x.TipoTramite == "X" && x.TipoLicenciaId == tipolic).ToList();
                }
             
         
                using (_context = new LicenciasCH_Entities())
                {
                    int vigid = Convert.ToInt32(cb_Vigencia.SelectedValue);
                    var impo = _context.dtImportes.Where(x => x.VigenciaId == vigid).FirstOrDefault();
                    if (impo != null)
                    {
                        txt_Importe.Text = impo.Monto.ToString("0.00");
                    }
                    else
                    {
                        txt_Importe.Text = "";
                    }
                }
            }
        }

        private void cb_Ttramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vigencia();
        }

        private void cb_Vigencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vigencia();
            using (_context = new LicenciasCH_Entities())
            {
                int vigid = Convert.ToInt32(cb_Vigencia.SelectedValue);
                var impo = _context.dtImportes.Where(x => x.VigenciaId == vigid).FirstOrDefault();
                if (impo != null)
                {
                    txt_Importe.Text = impo.Monto.ToString("0.00");
                }
                else
                {
                    txt_Importe.Text = "";
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var iduser = new dtUsuario();
            var usuarioid1 = 0;
            using (_context = new LicenciasCH_Entities())
            {
                iduser = _context.dtUsuarios.Where(x => x.NombreUsuario == Usuario).FirstOrDefault();

                if (iduser == null)
                {
                    usuarioid1 = 5;
                }
                else
                {
                    usuarioid1 = iduser.UsuarioId;
                }
                if (!IsValid(this))
                {
                    MessageBox.Show("Necesita llenar campos obligatorios");
                }
                else
                {
                    dtTramite dtramite = new dtTramite();
                    if (txt_Id.Text != "")
                    {
                        int idtr = Convert.ToInt32(txt_Id.Text);
                        dtramite = _context.dtTramites.Where(x => x.TramiteId == idtr).FirstOrDefault();

                    }
                    if (dtramite != null && txt_Id.Text != "")
                    {
                        updateTramite(usuarioid1);
                    }
                    else
                    {

                        try
                        {
                            dtCiudadano dciudadano = new dtCiudadano();
                            dtramite = new dtTramite();

                            var anv = _context.dtVigencias.Where(x => x.Nombre == cb_Vigencia.Text).FirstOrDefault();
                            var clave = cb_Tlicencia.SelectedValue.ToString();
                            var tlic = _context.dtTipoLicencias.Where(x => x.Clave == clave).FirstOrDefault();
                            dciudadano.Activo = true;
                            dciudadano.AMaterno = txt_ApellidoM.Text;
                            dciudadano.AniosVigencia = anv.AniosVigencia;
                            dciudadano.APaterno = txt_ApellidoP.Text;
                            dciudadano.Calle = txt_Calle.Text;
                            dciudadano.Colonia = 0;
                            dciudadano.CP = txt_CP.Text;
                            dciudadano.Curp = txt_Curp.Text;
                            dciudadano.FechaCreacion = System.DateTime.Now;
                            dciudadano.Nombre = txt_Nombre.Text;
                            dciudadano.NumExt = txt_NoExterior.Text;
                            dciudadano.NumInt = txt_NoInterior.Text;
                            dciudadano.TipoLicencia = tlic.TipoLicenciaId;
                            dciudadano.UsuarioCreador = Convert.ToInt32(usuarioid1);

                            dtramite.TipoLicencia = cb_Tlicencia.SelectedValue.ToString();
                            if (cb_Ttramite.SelectedItem.ToString() == "Nueva")
                            {
                                dtramite.TipoTramite = "E";
                            }
                            if (cb_Ttramite.SelectedItem.ToString() == "Reposición")
                            {
                                dtramite.TipoTramite = "R";
                            }
                            if (cb_Ttramite.SelectedItem.ToString() == "Renovación")
                            {
                                dtramite.TipoTramite = "C";
                            }
                            if (cb_Ttramite.SelectedItem.ToString() == "Reimpresión")
                            {
                                dtramite.TipoTramite = "I";
                            }
                            if (cb_Ttramite.SelectedItem.ToString() == "Robo")
                            {
                                dtramite.TipoTramite = "O";
                            }
                            if (cb_Ttramite.SelectedItem.ToString() == "Extravio")
                            {
                                dtramite.TipoTramite = "X";
                            }
                            dtramite.UsuarioCreador = Convert.ToInt32(usuarioid1);
                            // dtramite.TipoTramite = Convert.ToString(cb_Ttramite.SelectedValue);
                            dtramite.AniosVigencia = Convert.ToInt32(anv.AniosVigencia);
                            dtramite.Importe = Convert.ToDecimal(txt_Importe.Text);
                            dtramite.FolioSeguimiento = txt_Folio.Text;
                            dtramite.FechaExpedicion = DateTime.Parse(txt_Fexpedicion.Text);
                            dtramite.FechaVencimiento = DateTime.Parse(txt_Fvencimiento.Text);
                            dtramite.FechaAntiguedad = txt_Fantiguedad.Text != "" ? DateTime.Parse(txt_Fantiguedad.Text) : DateTime.Parse(System.DateTime.Now.ToString());
                            dtramite.LicenciaAnterior = txt_Licanterior.Text;
                            dtramite.Nombre = txt_Nombre.Text;
                            dtramite.ApellidoPaterno = txt_ApellidoP.Text;
                            dtramite.ApellidoMaterno = txt_ApellidoM.Text;
                            dtramite.FechaCreacion = DateTime.Parse(System.DateTime.Now.ToString());
                            if (cb_Sexo.Text == "Masculino")
                            {
                                dtramite.Sexo = "M";
                            }
                            if (cb_Sexo.Text == "Femenino")
                            {
                                dtramite.Sexo = "F";
                            }
                            if (cb_Sexo.Text == "Otro")
                            {
                                dtramite.Sexo = "O";
                            }
                            dtramite.DestinoId = 29;//iduser.Modulo;
                                                    //revisar generacion
                            dtramite.FolioSeguimiento = dtramite.TramiteId.ToString().PadLeft(8, '0');
                            dtramite.Curp = txt_Curp.Text;
                            dtramite.FechaNacimiento = DateTime.Parse(txt_Fnacimiento.Text);
                            dtramite.RFC = txt_Rfc.Text;
                            dtramite.EstadoCivil = cb_Ecivil.SelectedItem.ToString();
                            dtramite.Nacionalidad = cb_Nacionalidad.SelectedItem.ToString();
                            dtramite.Telefono = txt_Telefono.Text;
                            dtramite.Ocupacion = txt_Ocupacion.Text;
                            dtramite.TipoIdentificacion = cb_Tidentificacion.SelectedItem.ToString();
                            dtramite.NoId = txt_NoIdentificacion.Text;
                            dtramite.ComporbanteDomicilio = cb_ComprobanteDom.SelectedItem.ToString();
                            dtramite.NoComprobante = txt_NoComprobante.Text;
                            dtramite.Ben1Nombre = txt_NContacto.Text;
                            dtramite.Ben1AMaterno = txt_AMContacto.Text;
                            dtramite.Ben1APaterno = txt_APContacto.Text;
                            dtramite.TipoTel = txt_TelContacto.Text;
                            dtramite.Calle = txt_Calle.Text;
                            dtramite.NoExterior = txt_NoExterior.Text;
                            dtramite.NoInterior = txt_NoInterior.Text;
                            dtramite.CodigoPostal = txt_CP.Text;
                            dtramite.EstadoN = cb_Estado.SelectedItem.ToString();
                            dtramite.MunicipioN = cb_Municipio.Text;
                            dtramite.ColoniaN = txt_Colonia.Text;
                            dtramite.NombreTutor = txt_NTutor.Text;
                            dtramite.APaternoTutor = txt_APTutor.Text;
                            dtramite.AMaternoTutor = txt_AMTutor.Text;
                            dtramite.Estatus = "Registro";
                            dtramite.FechaEstatus = DateTime.Parse(txt_Fnacimiento.Text);
                            int consecutivo = 1;
                            string CodigoDestino = "";
                            string NumeroLicencia = "";
                            string letraConsecutiva = "A";
                            int minimoBloque = 1;
                            int maximoBloque = 999999;

                            var conseclic = (from c in _context.dtTramites
                                             where c.DestinoId == 29//iduser.Modulo
                                             orderby c.ConsecutivoDestino descending
                                             select new
                                             {
                                                 c.ConsecutivoDestino,
                                                 c.LetraConsecutiva
                                             }).FirstOrDefault();
                            if (conseclic != null)
                            {
                                //Obtenemos la letra consecutiva general


                                //Si nos pasamos del maximo en el consecutivo parcial, reiniciamos la cuenta y nos vamos a la siguiente letra
                                if (conseclic.ConsecutivoDestino >= maximoBloque)
                                {
                                    consecutivo = minimoBloque;
                                    if (conseclic.LetraConsecutiva == null || conseclic.LetraConsecutiva == "")
                                    {

                                        letraConsecutiva = "A";
                                    }
                                    else
                                    {
                                        letraConsecutiva = conseclic.LetraConsecutiva;
                                    }
                                    letraConsecutiva = VarUtil.FindNextChar(letraConsecutiva.ToUpper());

                                }
                                else
                                {
                                    //Si no hemos revasado el último bloque solo sumamos uno al consecutivo parcial
                                    if (conseclic.LetraConsecutiva == null)
                                    {
                                        letraConsecutiva = "A";
                                    }
                                    else
                                    {
                                        letraConsecutiva = conseclic.LetraConsecutiva;
                                    }
                                    consecutivo = VarUtil.getInt(conseclic.ConsecutivoDestino) + 1;
                                }

                            }
                            else
                            {
                                letraConsecutiva = "A";

                                consecutivo = 1;
                            }

                            dtramite.ConsecutivoDestino = consecutivo;
                            dtramite.LetraConsecutiva = letraConsecutiva;
                            using (_context = new LicenciasCH_Entities())
                            {
                                _context.dtCiudadanoes.Add(dciudadano);
                                dtramite.CiudadanoId = dciudadano.CiudadanoId;
                                _context.dtTramites.Add(dtramite);
                                _context.SaveChanges();

                                MessageBox.Show("Registro guardado exitosamente!");
                                dtramite.FolioSeguimiento = dtramite.TramiteId.ToString().PadLeft(8, '0');
                                _context.SaveChanges();
                                txt_Folio.Text = dtramite.FolioSeguimiento;

                                btn_Biometricos.Visible = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            string error = ex.Message;
                            MessageBox.Show("Ocurrio un problema al guardar el registro, favor de revisar los datos.");
                        }
                    }
                }
            }
        }

        private void updateTramite(int usId)
        {
            int tramite = Convert.ToInt32(txt_Id.Text);
            using (_context = new LicenciasCH_Entities())
            {
                dtTramite dtramite = _context.dtTramites.Where(x => x.TramiteId == tramite).FirstOrDefault();

                var anv = _context.dtVigencias.Where(x => x.Nombre == cb_Vigencia.Text).FirstOrDefault();


                dtramite.TipoLicencia = cb_Tlicencia.SelectedValue.ToString();
                if (cb_Ttramite.SelectedItem.ToString() == "Nueva")
                {
                    dtramite.TipoTramite = "E";
                }
                if (cb_Ttramite.SelectedItem.ToString() == "Reposición")
                {
                    dtramite.TipoTramite = "R";
                }
                if (cb_Ttramite.SelectedItem.ToString() == "Renovación")
                {
                    dtramite.TipoTramite = "C";
                }
                if (cb_Ttramite.SelectedItem.ToString() == "Reimpresión")
                {
                    dtramite.TipoTramite = "I";
                }
                if (cb_Ttramite.SelectedItem.ToString() == "Robo")
                {
                    dtramite.TipoTramite = "O";
                }
                if (cb_Ttramite.SelectedItem.ToString() == "Extravio")
                {
                    dtramite.TipoTramite = "X";
                }
                dtramite.UsuarioCreador = Convert.ToInt32(usId);
                // dtramite.TipoTramite = Convert.ToString(cb_Ttramite.SelectedValue);
                dtramite.AniosVigencia = Convert.ToInt32(cb_Vigencia.SelectedValue);
                dtramite.Importe = Convert.ToDecimal(txt_Importe.Text);
                dtramite.FolioSeguimiento = txt_Folio.Text;
                dtramite.FechaExpedicion = DateTime.Parse(txt_Fexpedicion.Text);
                dtramite.FechaVencimiento = DateTime.Parse(txt_Fvencimiento.Text);
                dtramite.FechaAntiguedad = txt_Fantiguedad.Text != "" ? DateTime.Parse(txt_Fantiguedad.Text) : DateTime.Parse(System.DateTime.Now.ToString());
                dtramite.LicenciaAnterior = txt_Licanterior.Text;
                dtramite.Nombre = txt_Nombre.Text;
                dtramite.ApellidoPaterno = txt_ApellidoP.Text;
                dtramite.ApellidoMaterno = txt_ApellidoM.Text;
                dtramite.FechaCreacion = DateTime.Parse(System.DateTime.Now.ToString());
                if (cb_Sexo.Text == "Masculino")
                {
                    dtramite.Sexo = "M";
                }
                if (cb_Sexo.Text == "Femenino")
                {
                    dtramite.Sexo = "F";
                }
                if (cb_Sexo.Text == "Otro")
                {
                    dtramite.Sexo = "O";
                }
                dtramite.DestinoId = 29;//iduser.Modulo;
                                        //revisar generacion
                                        //dtramite.FolioSeguimiento = dtramite.TramiteId.ToString().PadLeft(8, '0');
                dtramite.Curp = txt_Curp.Text;
                dtramite.FechaNacimiento = DateTime.Parse(txt_Fnacimiento.Text);
                dtramite.RFC = txt_Rfc.Text;
                dtramite.EstadoCivil = cb_Ecivil.SelectedItem.ToString();
                dtramite.Nacionalidad = cb_Nacionalidad.SelectedItem.ToString();
                dtramite.Telefono = txt_Telefono.Text;
                dtramite.Ocupacion = txt_Ocupacion.Text;
                dtramite.TipoIdentificacion = cb_Tidentificacion.SelectedItem.ToString();
                dtramite.NoId = txt_NoIdentificacion.Text;
                dtramite.ComporbanteDomicilio = cb_ComprobanteDom.SelectedItem.ToString();
                dtramite.NoComprobante = txt_NoComprobante.Text;
                dtramite.Ben1Nombre = txt_NContacto.Text;
                dtramite.Ben1AMaterno = txt_AMContacto.Text;
                dtramite.Ben1APaterno = txt_APContacto.Text;
                dtramite.TipoTel = txt_TelContacto.Text;
                dtramite.Calle = txt_Calle.Text;
                dtramite.NoExterior = txt_NoExterior.Text;
                dtramite.NoInterior = txt_NoInterior.Text;
                dtramite.CodigoPostal = txt_CP.Text;
                dtramite.EstadoN = cb_Estado.SelectedItem.ToString();
                dtramite.MunicipioN = cb_Municipio.Text;
                dtramite.ColoniaN = txt_Colonia.Text;
                dtramite.NombreTutor = txt_NTutor.Text;
                dtramite.APaternoTutor = txt_APTutor.Text;
                dtramite.AMaternoTutor = txt_AMTutor.Text;
                dtramite.Estatus = "Registro";
                dtramite.FechaEstatus = DateTime.Parse(txt_Fnacimiento.Text);
                try
                {
                    _context.SaveChanges();
                    MessageBox.Show("Tramite actualizado exitosamente");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error al guardar los datos, favor de corroborar la información");
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dtMunicipioTableAdapter.FillBy(this.licenciasCHDataSetMunicipios.dtMunicipio);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
