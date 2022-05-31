using RegistroLicenciasChihuahua.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLicenciasChihuahua
{
    public partial class Mistramites : Form
    {
        public void Loading()
        {
            Thread.Sleep(3000);
        }
        LicenciasCH_Entities _context;
        public static string userRol;
         int userI;
        public Mistramites(string RolUsuario, int user)
        {
            userRol = RolUsuario;
            userI = user;
            InitializeComponent();
            gv_Tramites.DataSource = null;

            if (userRol != "Supervisor" && userRol != "Administrador")
            {

                txt_Licencia.Visible = false;
                label3.Visible = false;

            }
        }

        private void Mistramites_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'licenciasCH_QADataSet.dtTramites' Puede moverla o quitarla según sea necesario.
            gv_Tramites.DataSource = null;
            using (_context = new LicenciasCH_Entities())
            {
              
                try
                {
                    if (userRol == "Supervisor" || userRol == "Administrador")
                    {
                        gv_Tramites.DataSource = _context.dtTramites.Where(x=>x.FechaCreacion.Year == System.DateTime.Now.Year && x.FechaCreacion.Month == System.DateTime.Now.Month && x.FechaCreacion.Day == System.DateTime.Now.Day).ToList();
                    }
                    else
                    {
                        gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == userI && x.FechaCreacion.Year == System.DateTime.Now.Year && x.FechaCreacion.Date.Month == System.DateTime.Now.Month && x.FechaCreacion.Date.Day == System.DateTime.Now.Day).ToList();
                    }
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            loading.Show();

            Task task = new Task(Loading);
            task.Start();
            await task;
            using (_context = new LicenciasCH_Entities())
            {
                List<dtTramite> n = new List<dtTramite>();
       
                if (txt_Busqueda.Text != "")
                {
                    n= _context.dtTramites.Where(x => x.UsuarioCreador == userI && (x.Curp.Contains(txt_Busqueda.Text) || x.FolioSeguimiento.Contains(txt_Busqueda.Text))).ToList();
                   
                }
                else if (txt_Nombre.Text != "")
                {
                    n = _context.dtTramites.Where(x => x.UsuarioCreador == userI && (x.Nombre.Contains(txt_Nombre.Text))).ToList();

                }
                else if (txt_Licencia.Text != "")
                {
                    n = _context.dtTramites.Where(x => x.UsuarioCreador == userI && (x.NumeroLicencia.Contains(txt_Licencia.Text))).ToList();

                }
                else if (dtp_Inicio.Value!=null && dtp_Fin.Value != null)
                {
                    n = _context.dtTramites.Where(x => x.UsuarioCreador == userI && ((x.FechaCreacion.Year >= dtp_Inicio.Value.Year && x.FechaCreacion.Year <= dtp_Fin.Value.Year) && (x.FechaCreacion.Month >= dtp_Inicio.Value.Month && x.FechaCreacion.Month <= dtp_Fin.Value.Month) && (x.FechaCreacion.Day >= dtp_Inicio.Value.Day && x.FechaCreacion.Day <= dtp_Fin.Value.Day))).ToList();

                }
                else
                {
                    //gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == userI && x.FechaCreacion.Date == System.DateTime.Now.Date).ToList();
                }
                foreach (var i in n)
                {
                    i.TipoLicencia = _context.dtTipoLicencias.Where(x => x.Clave == i.TipoLicencia).Select(x => x.Nombre).FirstOrDefault();
                    if (i.TipoTramite == "E")
                    {
                        i.TipoTramite = "Nueva";
                    }
                    else if (i.TipoTramite == "R")
                    {
                        i.TipoTramite = "Canje";
                    }
                    else if (i.TipoTramite == "C")
                    {
                        i.TipoTramite = "Renovación";
                    }
                    else if (i.TipoTramite == "I")
                    {
                        i.TipoTramite = "Reimpresión";
                    }
                    else if (i.TipoTramite == "O")
                    {
                        i.TipoTramite = "Robo";
                    }
                    else if (i.TipoTramite == "X")
                    {
                        i.TipoTramite = "Extravio";
                    }
                }
                gv_Tramites.DataSource = n;
            }
            loading.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (_context = new LicenciasCH_Entities())
            {
                if (userRol == "Supervisor" || userRol == "Administrador")
                {
                    gv_Tramites.DataSource = _context.dtTramites.Where(x => x.FechaCreacion.Year == System.DateTime.Now.Year && x.FechaCreacion.Month == System.DateTime.Now.Month && x.FechaCreacion.Day == System.DateTime.Now.Day).ToList();

                }
                else
                {
                    gv_Tramites.DataSource = _context.dtTramites.Where(x => x.FechaCreacion.Year == System.DateTime.Now.Year && x.FechaCreacion.Month == System.DateTime.Now.Month && x.FechaCreacion.Day == System.DateTime.Now.Day && x.UsuarioCreador == userI).ToList();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (_context = new LicenciasCH_Entities())
            {
                gv_Tramites.DataSource = null;
                //gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == userI).ToList();
                txt_Busqueda.Text = "";
                txt_Licencia.Text = "";
                txt_Nombre.Text = "";
                dtp_Inicio.Value = System.DateTime.Now;
                dtp_Fin.Value = System.DateTime.Now;
            }
        }

        private void gv_Tramites_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (userRol == "Supervisor" || userRol == "Administrador")
                {
                    var myValue = gv_Tramites[0, e.RowIndex].Value.ToString();
                    var id = Convert.ToInt32(gv_Tramites[0, e.RowIndex].Value.ToString());
                    Registro registro = new Registro(myValue, "", id, "", userI, "edicion");

                    registro.FormBorderStyle = FormBorderStyle.Sizable;
                    registro.StartPosition = FormStartPosition.CenterScreen;
                    registro.Size = new Size(1200, 750);
                    registro.ShowDialog();
                }
            }
            catch
            {

            }
        }

     
    }
}
