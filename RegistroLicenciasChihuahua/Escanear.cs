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
    public partial class Escanear : Form
    {
        public Escanear()
        {
            InitializeComponent();
        }

        private void chbx_acta_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbx_acta.ThreeState)
            {
                chbx_acta.ThreeState = true;
                btn_acta.Visible = true;
            }
            else
            {
                chbx_acta.ThreeState = false;
                btn_acta.Visible = false;
            }
        }

        private void chbx_identificación_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbx_identificación.ThreeState)
            {
                chbx_identificación.ThreeState = true;
                btn_identificación.Visible = true;
            }
            else
            {
                chbx_identificación.ThreeState = false;
                btn_identificación.Visible = false;
            }
        }

        private void chbx_comprobante_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbx_comprobante.ThreeState)
            {
                chbx_comprobante.ThreeState = true;
                btn_comprobante.Visible = true;

            }
            else
            {
                chbx_comprobante.ThreeState = false;
                btn_comprobante.Visible = false;
            }
        }

        private void chbx_licAnt_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbx_licAnt.ThreeState)
            {
                chbx_licAnt.ThreeState = true;
                btn_licAnt.Visible = true;
            }
            else
            {
                chbx_licAnt.ThreeState = false;
                btn_licAnt.Visible = false;
            }
        }

        private void chbx_licActual_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbx_licActual.ThreeState)
            {
                chbx_licActual.ThreeState = true;
                btn_licActual.Visible = true;
            }
            else
            {
                chbx_licActual.ThreeState = false;
                btn_licActual.Visible = false;

            }
        }

        private void chbx_reporte_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbx_reporte.ThreeState)
            {
                chbx_reporte.ThreeState = true;
                btn_reporte.Visible = true;
            }
            else
            {
                chbx_reporte.ThreeState = false;
                btn_reporte.Visible = false;
            }
        }
    }
}
