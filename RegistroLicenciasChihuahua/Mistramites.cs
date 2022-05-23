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
    public partial class Mistramites : Form
    {
        LicenciasCH_Entities _context;
        public static string userRol;
        public static string userI;
        public Mistramites(string RolUsuario, string user)
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
                var idus = _context.dtUsuarios.Where(x => x.NombreUsuario == userI).FirstOrDefault();
                try
                {
                    if (userRol == "Supervisor" || userRol == "Administrador")
                    {
                        gv_Tramites.DataSource = _context.dtTramites.Take(50).ToList();
                    }
                    else
                    {
                        gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == idus.UsuarioId).ToList();
                    }
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (_context = new LicenciasCH_Entities())
            {
                if (txt_Busqueda.Text != "")
                {
                    gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == 5 && (x.Curp.Contains(txt_Busqueda.Text) || x.FolioSeguimiento.Contains(txt_Busqueda.Text))).ToList();
                }
                else if (txt_Nombre.Text != "")
                {
                    gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == 5 && (x.Nombre.Contains(txt_Nombre.Text))).ToList();

                }
                else if (txt_Licencia.Text != "")
                {
                    gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == 5 && (x.NumeroLicencia.Contains(txt_Licencia.Text))).ToList();

                }
                else
                {
                    gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == 5).ToList();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (_context = new LicenciasCH_Entities())
            {
                gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == 5).ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (_context = new LicenciasCH_Entities())
            {
                gv_Tramites.DataSource = _context.dtTramites.Where(x => x.UsuarioCreador == 5).ToList();
                txt_Busqueda.Text = "";
                txt_Licencia.Text = "";
                txt_Nombre.Text = "";
            }
        }

        private void gv_Tramites_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userRol == "Supervisor" || userRol == "Administrador")
            {
                var myValue = gv_Tramites[0, e.RowIndex].Value.ToString();
                var id = Convert.ToInt32(gv_Tramites[0, e.RowIndex].Value.ToString());
                Registro registro = new Registro(myValue, "", id, "");

                registro.FormBorderStyle = FormBorderStyle.Sizable;
                registro.StartPosition = FormStartPosition.CenterScreen;
                registro.Size = new Size(1200, 750);
                registro.Show();
            }
        }
    }
}
