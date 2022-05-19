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
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

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
    }
}
