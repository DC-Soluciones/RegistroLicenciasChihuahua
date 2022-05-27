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
    public partial class Dashboard : Form
    {
        LicenciasCH_Entities _context;
        int idUser;
        public static string userDashboard;

        public static string RolUsuario = "Supervisor";
        public Dashboard(dtUsuario usuario)
        {
            InitializeComponent();
            using (_context = new LicenciasCH_Entities())
            {
                var rol = _context.dtRols.Where(x => x.RolId == usuario.RolId).FirstOrDefault();
                idUser = usuario.UsuarioId;
                lbl_UserName.Text = usuario.NombreUsuario;
                lbl_Rol.Text = rol.Rol;
                userDashboard = usuario.NombreUsuario;
                RolUsuario = rol.Rol;
            }


        }

        public void loadform(object Form)
        {

            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btn_menu_busqueda_Click(object sender, EventArgs e)
        {
            loadform(new Busqueda(userDashboard, RolUsuario, idUser));
        }

        private void btn_mistramites_Click(object sender, EventArgs e)
        {
            loadform(new Mistramites(RolUsuario, idUser));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_escaner_Click(object sender, EventArgs e)
        {
            //Escanear escanear = new Escanear();
            //escanear.Show();
        }
    }
}
