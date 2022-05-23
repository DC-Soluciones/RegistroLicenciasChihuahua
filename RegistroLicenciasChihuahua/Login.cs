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
    public partial class Login : Form
    {
        LicenciasCH_Entities _context;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginEnter();
        }

        private void loginEnter()
        {
            using (_context = new LicenciasCH_Entities())
            {
                try
                {
                    var user = _context.dtUsuarios.Where(x => x.NombreUsuario == txt_Usuario.Text && x.Contrasenia == txt_Contraseña.Text).FirstOrDefault();
                    if (user != null)
                    {
                        this.Hide();
                        Dashboard dashboard = new Dashboard(user);
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos, favor de verificar.");
                        txt_Contraseña.Text = "";
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error de conexión, verifique la red." + err.Message);
                }
            }
        }
        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginEnter();
            }
        }
    }
}
