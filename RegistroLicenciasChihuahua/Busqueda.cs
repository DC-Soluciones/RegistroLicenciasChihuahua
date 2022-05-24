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
        public Busqueda(string user, string userRol)
        {
            InitializeComponent();
            usuario = user;
            UserRol = userRol;
            if (userRol != "Supervisor" && userRol != "Administrador" &&  userRol != "Capturista")
            {
                btn_Editactual.Visible = false;
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
                Registro registro = new Registro(txt_Curp.Text, usuario, 0, "");
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

        private async void button1_Click(object sender, EventArgs e)
        {
            tbc_actual.TabPages.Clear();
            if (txt_Curp.Text != "")
            {
                Loading loading = new Loading();
                loading.Show();

                Task task = new Task(Load);
                task.Start();
                await task;

                _context = new LicenciasCH_Entities();


                var licenciasact = (from d in _context.dtTramites
                                where d.Curp == txt_Curp.Text
                                select d).OrderByDescending(x => x.FechaCreacion).ToList();
                foreach(var l in licenciasact)
                {
                    var tplic = _context.dtTipoLicencias.Where(x => x.Clave == l.TipoLicencia).FirstOrDefault();
                    
                    tbc_actual.TabPages.Add(l.NumeroLicencia,  tplic.Nombre);
                }

                var cdActual = (from d in _context.dtTramites
                                where d.Curp == txt_Curp.Text
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
                    txt_actual.Visible = false;
                    lbl_EditAct.Text = cdActual.TramiteId.ToString();
                    try
                    {
                        MemoryStream ms = new MemoryStream(cdActual.FotoLic, 0, cdActual.FotoLic.Length);
                        ms.Write(cdActual.FotoLic, 0, cdActual.FotoLic.Length);
                        Image returnImage = Image.FromStream(ms, true);
                        pb_Ciudadano.Image = returnImage;
                        pb_Ciudadano.Visible = true;
                    }
                    catch
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
                    pnl_noRegistro.Visible = true;
                    gb_DatoActual.Visible = false;
                    txt_actual.Visible = true;
                    //btn_LeerQ3.Visible = false;
                    //pictureBox1.Visible = false;
                }

                using (_contextHist = new LicHistoricoEntities())
                {

                    var listcd = (from d in _contextHist.dtTramites
                                  where d.Curp == txt_Curp.Text
                                  select d).ToList();

                    if (listcd.Count() > 0)
                    {
                        cIUDADANO = listcd.OrderByDescending(x => x.FechaCreacion).FirstOrDefault();

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
                        try
                        {
                            MemoryStream ms = new MemoryStream(cIUDADANO.FotoLic, 0, cIUDADANO.FotoLic.Length);
                            ms.Write(cIUDADANO.FotoLic, 0, cIUDADANO.FotoLic.Length);
                            Image returnImage = Image.FromStream(ms, true);
                            pb_Ciudadano.Image = returnImage;
                            pb_Ciudadano.Visible = true;
                        }
                        catch
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
                        txt_historica.Visible = true;
                        gb_DatoHisto.Visible = false;
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
            Registro registro = new Registro("", "", Convert.ToInt32(lbl_EditHistorica.Text), "Historica");
            registro.FormBorderStyle = FormBorderStyle.Sizable;
            registro.StartPosition = FormStartPosition.CenterScreen;
            registro.Size = new Size(1300, 850);
            registro.Show();
        }

        private void btn_Editactual_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(txt_Curp.Text, "", Convert.ToInt32(lbl_EditAct.Text), "Actual");

            registro.FormBorderStyle = FormBorderStyle.Sizable;
            registro.StartPosition = FormStartPosition.CenterScreen;
            registro.Size = new Size(1300, 850);
            registro.Show();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Curp.Text = "";
            txt_Nombre.Text = "";
            txt_ApellidoP.Text = "";
            txt_ApellidoM.Text = "";
            
        }

        private void tbc_actual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
