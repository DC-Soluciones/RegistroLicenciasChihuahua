using RegistroLicenciasChihuahua.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLicenciasChihuahua
{
    public partial class Busqueda : Form
    {
        LicenciasCH_Entities _context;
        LicHistoricoEntities _contextHist;
        CultureInfo culture = new CultureInfo("pt-BR");
        public GroupBox groupBox = new GroupBox();
        dtTramite cIUDADANO;
        string usuario;
        public static string UserRol;
        string code = null;
        int idusuarioc;
        public Busqueda(string user, string userRol, int IDuser)
        {
            InitializeComponent();
            usuario = user;
            UserRol = userRol;
            idusuarioc = IDuser;
            if (userRol != "Supervisor" && userRol != "Administrador" &&  userRol != "Capturista")
            {
                btn_Editactual.Text = "Visualizar";
                btn_Editactual.Image = null;
                btn_Editactual.TextAlign = ContentAlignment.MiddleCenter;
                //btn_Editactual.Visible = false;
            }
        }
        public void Load()
        {
            Thread.Sleep(3000);
        }
        private void btn_nuevoregistro_Click(object sender, EventArgs e)
        {
            if (txt_Curp.Text != "")
            {
                if (this.panelbusqueda.Controls.Count > 0)
                    this.panelbusqueda.Controls.RemoveAt(0);
                Registro registro = new Registro(txt_Curp.Text, usuario, 0, "", idusuarioc, "nuevo");
                registro.TopLevel = false;
                registro.Dock = DockStyle.Fill;
                panelbusqueda.Controls.Clear();
                panelbusqueda.Controls.Add(registro);
                panelbusqueda.Tag = registro;
                registro.Show(); 
            }
            else
            {
                MessageBox.Show("Favor de ingresar datos correctos");
            }
        }
        private bool CurpValida(string curp)
        {
            var re = @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
            Regex rx = new Regex(re, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var validado = rx.IsMatch(curp);

            if (!validado)  //Coincide con el formato general?
                return false;

            //Validar que coincida el dígito verificador
            if (!curp.EndsWith(DigitoVerificador(curp.ToUpper())))
                return false;

            return true; //Validado
        }
        private string DigitoVerificador(string curp17)
        {
            //Fuente https://consultas.curp.gob.mx/CurpSP/
            var diccionario = "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            var suma = 0.0;
            var digito = 0.0;
            for (var i = 0; i < 17; i++)
                suma = suma + diccionario.IndexOf(curp17[i]) * (18 - i);
            digito = 10 - suma % 10;
            if (digito == 10) return "0";
            return digito.ToString();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            tbc_actual.TabPages.Clear();
            tbc_Historica.TabPages.Clear();
            if (txt_Curp.Text != "" && CurpValida(txt_Curp.Text))
            {
                Loading loading = new Loading();
                loading.Show();

                Task task = new Task(Load);
                task.Start();
                await task;

                _context = new LicenciasCH_Entities();


                var licenciasact = (from d in _context.dtTramites
                                where d.Curp == txt_Curp.Text  && d.FechaVencimiento > System.DateTime.Now
                                select d).OrderByDescending(x => x.FechaCreacion).ToList();
                foreach(var l in licenciasact)
                {
                    var tplic = _context.dtTipoLicencias.Where(x => x.Clave == l.TipoLicencia).FirstOrDefault();
                    
                    tbc_actual.TabPages.Add(l.TramiteId.ToString(),  tplic.Nombre);
                }

                var cdActual = (from d in _context.dtTramites
                                where d.Curp == txt_Curp.Text
                                select d).OrderByDescending(x => x.FechaCreacion).FirstOrDefault();

                if (cdActual != null)
                {
                    pnl_TextActual.Visible = false;
                    btn_nuevoregistro.Visible = true;
                    pnl_noRegistro.Visible = false;
                    pnl_registro.Visible = true;
                    txt_Nombre.Text = cdActual.Nombre;
                    txt_ApellidoP.Text = cdActual.ApellidoPaterno;
                    txt_ApellidoM.Text = cdActual.ApellidoMaterno;

                    lbl_NombreActual.Text = cdActual.Nombre + " " + cdActual.ApellidoPaterno + " " + cdActual.ApellidoMaterno;
                    lbl_NoLicActual.Text = cdActual.NumeroLicencia;
                    lbl_LicActual.Text = cdActual.TipoLicencia;
                    lbl_StatusActual.Text = cdActual.Estatus;
                    lbl_VigenciaActual.Text = cdActual.AniosVigencia.ToString();
                    lbl_ExpedicionActual.Text = cdActual.FechaExpedicion.Value.ToShortDateString();
                    lbl_VencimientoActual.Text = cdActual.FechaVencimiento.Value.ToShortDateString();
                    lbl_RfcActual.Text = cdActual.RFC;
                    gb_DatoActual.Visible = true;
                    pnl_TextActual.Visible = false;
                    lbl_EditAct.Text = cdActual.TramiteId.ToString();
                    if(cdActual.FotoLic!=null)
                    {
                        MemoryStream ms = new MemoryStream(cdActual.FotoLic, 0, cdActual.FotoLic.Length);
                        ms.Write(cdActual.FotoLic, 0, cdActual.FotoLic.Length);
                        Image returnImage = Image.FromStream(ms, true);
                        pb_Ciudadano.Image = returnImage;
                        pb_Ciudadano.Visible = true;
                    }
                    else
                    {
                        pb_Ciudadano.Image = null; pb_Ciudadano.Visible = false;
                    }

                    //code = Encriptar(lbl_EditAct.Text);
                    //Qr(code);
                    //btn_LeerQ3.Visible = true;
                    //var codedes = DesEncriptar(code);
                }
                else
                {
                    btn_nuevoregistro.Visible = true;
                    pnl_noRegistro.Visible = true;
                    gb_DatoActual.Visible = false;
                    pnl_actual.Visible = true;
                    pnl_TextActual.Visible = true;
                    //txt_actual.Visible = true;
                    //btn_LeerQ3.Visible = false;
                    //pictureBox1.Visible = false;
                }

                using (_contextHist = new LicHistoricoEntities())
                {

                    var listcd = (from d in _contextHist.dtTramites
                                  where d.Curp == txt_Curp.Text && d.FechaVencimiento > System.DateTime.Now
                                  select d).ToList();
                    foreach (var l in listcd)
                    {
                        var tplic = _context.dtTipoLicencias.Where(x => x.Clave == l.TipoLicencia).FirstOrDefault();

                        tbc_Historica.TabPages.Add(l.TramiteId.ToString(), tplic.Nombre);
                    }
                    if (listcd.Count() > 0)
                    {
                        cIUDADANO = listcd.OrderByDescending(x => x.FechaCreacion).FirstOrDefault();

                        pnl_histo.Visible = true;
                        pnl_histoText.Visible = false;

                        txt_Nombre.Text = cIUDADANO.Nombre;
                        txt_ApellidoP.Text = cIUDADANO.ApellidoPaterno;
                        txt_ApellidoM.Text = cIUDADANO.ApellidoMaterno;

                        lbl_Nombre.Text = cIUDADANO.Nombre + " " + cIUDADANO.ApellidoPaterno + " " + cIUDADANO.ApellidoMaterno;
                        lbl_NoLicencia.Text = cIUDADANO.NumeroLicencia;
                        lbl_Licencia.Text = cIUDADANO.TipoLicencia;
                        lbl_Status.Text = cIUDADANO.Estatus;
                        lbl_Vigencia.Text = cIUDADANO.AniosVigencia.ToString();
                        lbl_Expedicion.Text = cIUDADANO.FechaExpedicion.Value.ToShortDateString();
                        lbl_Vencimiento.Text = cIUDADANO.FechaVencimiento.Value.ToShortDateString();
                        lbl_Rfc.Text = cIUDADANO.RFC;
                        gb_DatoHisto.Visible = true;
                        lbl_EditHistorica.Text = cIUDADANO.TramiteId.ToString();
                        if(cIUDADANO.FotoLic!=null)
                        {
                            MemoryStream ms = new MemoryStream(cIUDADANO.FotoLic, 0, cIUDADANO.FotoLic.Length);
                            ms.Write(cIUDADANO.FotoLic, 0, cIUDADANO.FotoLic.Length);
                            Image returnImage = Image.FromStream(ms, true);
                            pb_Ciudadano.Image = returnImage;
                            pb_Ciudadano.Visible = true;
                        }
                        else
                        {
                            pb_Ciudadano.Image = null;
                            pb_Ciudadano.Visible = false;
                        }
                        if (listcd.Count > 1)
                        {
                            //btn_Siguiente.Visible = true;
                        }
                    }
                    else
                    {
                        gb_DatoHisto.Visible = false;
                        pnl_histo.Visible = false;
                        pnl_histoText.Visible = true;
                    }


                }

                loading.Close();
            }
            else
            {
                MessageBox.Show("Favor de ingresar una CURP valida");
            }
        }



        public string Encriptar(string _cadenaAencriptar)
        {
            int id = Convert.ToInt32(_cadenaAencriptar);
            string result = string.Empty;
            var tramite = _context.dtTramites.Where(x => x.TramiteId == id).FirstOrDefault();
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public void Qr(string code)
        {
            QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();
            ASCIIEncoding ASSCII = new ASCIIEncoding();
            var z = QR.CreateQrCode(ASSCII.GetBytes(code), QRCoder.QRCodeGenerator.ECCLevel.H);
            QRCoder.PngByteQRCode png = new QRCoder.PngByteQRCode();
            png.SetQRCodeData(z);
            var arr = png.GetGraphic(10);
            MemoryStream ms = new MemoryStream();
            ms.Write(arr, 0, arr.Length);
            Bitmap b = new Bitmap(ms);
            //pictureBox1.Image = b;

        }

        private void btn_LeerQ3_Click(object sender, EventArgs e)
        {
            int coddes = Convert.ToInt32(DesEncriptar(code));
            var tramite = _context.dtTramites.Where(x => x.TramiteId == coddes).FirstOrDefault();
            //LecturaQR QR = new LecturaQR(tramite.TramiteId);
            //QR.Show();
        }

        private void btn_EditHistorica_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(txt_Curp.Text, "", Convert.ToInt32(lbl_EditHistorica.Text), "Historica", idusuarioc, "nuevo");
            registro.FormBorderStyle = FormBorderStyle.Sizable;
            registro.StartPosition = FormStartPosition.CenterScreen;
            registro.Size = new Size(1300, 850);

            registro.ShowDialog();
          
        }

        private void btn_Editactual_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(txt_Curp.Text, "", Convert.ToInt32(lbl_EditAct.Text), "Actual", idusuarioc, "nuevo");

            registro.FormBorderStyle = FormBorderStyle.Sizable;
            registro.StartPosition = FormStartPosition.CenterScreen;
            registro.Size = new Size(1300, 850);
            registro.ShowDialog(); 
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Curp.Text = "";
            txt_Nombre.Text = "";
            txt_ApellidoP.Text = "";
            txt_ApellidoM.Text = "";
            pnl_registro.Visible = false;
            pnl_noRegistro.Visible = false;
            btn_nuevoregistro.Visible = false;
        }

        private void tbc_actual_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int currentTab = tbc_actual.SelectedIndex;
                int tabName = Convert.ToInt32(tbc_actual.TabPages[currentTab].Name);
                _context = new LicenciasCH_Entities();

                var cdActual = (from d in _context.dtTramites
                                where d.TramiteId == tabName
                                select d).OrderByDescending(x => x.FechaCreacion).FirstOrDefault();

                if (cdActual != null)
                {
                    pnl_noRegistro.Visible = false;
                    pnl_registro.Visible = true;
                    txt_Nombre.Text = cdActual.Nombre;
                    txt_ApellidoP.Text = cdActual.ApellidoPaterno;
                    txt_ApellidoM.Text = cdActual.ApellidoMaterno;

                    lbl_NombreActual.Text = cdActual.Nombre + " " + cdActual.ApellidoPaterno + " " + cdActual.ApellidoMaterno;
                    lbl_NoLicActual.Text = cdActual.NumeroLicencia;
                    lbl_LicActual.Text = cdActual.TipoLicencia;
                    lbl_StatusActual.Text = cdActual.Estatus;
                    lbl_VigenciaActual.Text = cdActual.AniosVigencia.ToString();
                    lbl_ExpedicionActual.Text = cdActual.FechaExpedicion.Value.ToShortDateString();
                    lbl_VencimientoActual.Text = cdActual.FechaVencimiento.Value.ToShortDateString();
                    lbl_RfcActual.Text = cdActual.RFC;
                    gb_DatoActual.Visible = true;
                    //txt_actual.Visible = false;
                    lbl_EditAct.Text = cdActual.TramiteId.ToString();
                    if(cdActual.FotoLic!=null)
                    {
                        MemoryStream ms = new MemoryStream(cdActual.FotoLic, 0, cdActual.FotoLic.Length);
                        ms.Write(cdActual.FotoLic, 0, cdActual.FotoLic.Length);
                        Image returnImage = Image.FromStream(ms, true);
                        pb_Ciudadano.Image = returnImage;
                        pb_Ciudadano.Visible = true;
                    }
                    else
                    {
                        pb_Ciudadano.Image = null; pb_Ciudadano.Visible = false;
                    }


                }
            }
            catch
            {

            }
        }

        private void tbc_Historica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentTab = tbc_actual.SelectedIndex;
            int tabName = Convert.ToInt32(tbc_Historica.TabPages[currentTab].Name);
            using (_contextHist = new LicHistoricoEntities())
            {

                var listcd = (from d in _contextHist.dtTramites
                              where d.TramiteId == tabName
                              select d).FirstOrDefault();
            
                txt_Nombre.Text = cIUDADANO.Nombre;
                txt_ApellidoP.Text = cIUDADANO.ApellidoPaterno;
                txt_ApellidoM.Text = cIUDADANO.ApellidoMaterno;

                lbl_Nombre.Text = cIUDADANO.Nombre + " " + cIUDADANO.ApellidoPaterno + " " + cIUDADANO.ApellidoMaterno;
                lbl_NoLicencia.Text = cIUDADANO.NumeroLicencia;
                lbl_Licencia.Text = cIUDADANO.TipoLicencia;
                lbl_Status.Text = cIUDADANO.Estatus;
                lbl_Vigencia.Text = cIUDADANO.AniosVigencia.ToString();
                lbl_Expedicion.Text = cIUDADANO.FechaExpedicion.Value.ToShortDateString();
                lbl_Vencimiento.Text = cIUDADANO.FechaVencimiento.Value.ToShortDateString();
                lbl_Rfc.Text = cIUDADANO.RFC;
                gb_DatoHisto.Visible = true;
                lbl_EditHistorica.Text = cIUDADANO.TramiteId.ToString();
                if(cIUDADANO.FotoLic!=null)
                {
                    MemoryStream ms = new MemoryStream(cIUDADANO.FotoLic, 0, cIUDADANO.FotoLic.Length);
                    ms.Write(cIUDADANO.FotoLic, 0, cIUDADANO.FotoLic.Length);
                    Image returnImage = Image.FromStream(ms, true);
                    pb_Ciudadano.Image = returnImage;
                    pb_Ciudadano.Visible = true;
                }
                else
                {
                    pb_Ciudadano.Image = null;
                    pb_Ciudadano.Visible = false;
                }
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
