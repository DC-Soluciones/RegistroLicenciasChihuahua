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
        LicenciasCH_QAEntities _context;
        int idUser;
        public Dashboard(dtUsuario usuario)
        {
            InitializeComponent();
            using (_context = new LicenciasCH_QAEntities())
            {
                var rol = _context.dtRols.Where(x => x.RolId == usuario.RolId).FirstOrDefault();
                lbl_UserName.Text = usuario.NombreUsuario;
                lbl_Rol.Text = rol.Rol;


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
            loadform(new Busqueda());
        }

        private void btn_mistramites_Click(object sender, EventArgs e)
        {
            loadform(new Mistramites());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
