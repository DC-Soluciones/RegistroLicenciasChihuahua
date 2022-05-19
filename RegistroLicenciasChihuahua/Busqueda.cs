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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }
        private void btn_nuevoregistro_Click(object sender, EventArgs e)
        {
            if (this.panelbusqueda.Controls.Count > 0)
                this.panelbusqueda.Controls.RemoveAt(0);
            Registro registro = new Registro();
            registro.TopLevel = false;
            registro.Dock = DockStyle.Fill;
            panelbusqueda.Controls.Clear();
            panelbusqueda.Controls.Add(registro);
            panelbusqueda.Tag = registro;
            registro.Show();
        }
    }
}
