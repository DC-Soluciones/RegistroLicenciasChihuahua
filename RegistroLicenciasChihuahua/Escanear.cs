using iTextSharp.text;
using iTextSharp.text.pdf;
using RegistroLicenciasChihuahua.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace RegistroLicenciasChihuahua
{
    public partial class Escanear : Form
    {
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string Docs;

        string tipotramite;
        string foliotramite;
        LicenciasCH_Entities _context;
        public Escanear(string ttramite, string folio)
        {
            InitializeComponent();
            textBox1.Text = ttramite;
            textBox2.Text = folio;
        }
        private void ListScanners()
        {

            // Clear the ListBox.
            listBox1.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
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

        private void escanear(string docucmento)
        {
            Scanner device = null;
          

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listBox1.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("Seleccione un Dispositivo de la Lista",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();



            image = device.ScanPNG();
            // Save the image


            var path = Path.Combine(textBox1.Text + "/Escaneos", docucmento+".png");


            if (File.Exists(path))
            {

                File.Delete(path);
            }


            image.SaveFile(path);

            pictureBox1.Image = new Bitmap(path);




            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            Bitmap imgbitmap = new Bitmap(img);

            Bitmap ImgCurp = new Bitmap(imgbitmap, new Size(600, 800));

            /* var path2 = Path.Combine(textBox1.Text + "/EscaneosR", textBox2.Text+".png");


             ImgCurp.Save(path2, System.Drawing.Imaging.ImageFormat.Png);*/

            var nombreD = textBox2.Text + ".JPEG";


            /* Bitmap ImgCurp = new Bitmap(imgbitmap, new Size(600, 800));*/

            var CurpFull = ruta + "/Escaneos2/" + textBox2.Text + ".JPEG";

            ImgCurp.Save(CurpFull, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        private void btn_acta_Click(object sender, EventArgs e)
        {
            escanear("Acta de Nacimiento");
        }

        private void btn_identificación_Click(object sender, EventArgs e)
        {
            escanear("Identificación");
        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            escanear("Comprobante de domicilio");
        }

        private void btn_licAnt_Click(object sender, EventArgs e)
        {
            escanear("licencia anterior");
        }

        private void btn_licActual_Click(object sender, EventArgs e)
        {
            escanear("licencia vigente");
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            escanear("Reporte de robo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PDF = ruta + "/ExpedienteElectronico/document.pdf";
            ruta = ruta + "/ExpedienteElectronico";
            


            if (!Directory.Exists(ruta))
            {
                Console.WriteLine("Creando el directorio: {0}", ruta);
                DirectoryInfo di = Directory.CreateDirectory(ruta);
            }

            using (_context = new LicenciasCH_Entities())
            {
               
                dtTramite tramite = _context.dtTramites.Where(x => x.FolioSeguimiento == textBox2.Text).FirstOrDefault();

                using (var stream = new FileStream(PDF, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        using (var reader = new  System.IO.BinaryReader(stream))
                        {
                            byte[] read = reader.ReadBytes((int)stream.Length);
                            tramite.Expediente =(read);
                            tramite.FolioAsignadoPlastico = "1";
                            _context.Entry(tramite).State = System.Data.Entity.EntityState.Modified;

                            _context.SaveChanges();
                        }
                    }
                    catch(Exception m)
                    {
                        string error = m.Message;
                    }
                }

               
            }



            Document document = new Document(iTextSharp.text.PageSize.LETTER, 0, 0, 0, 0);
            using (var stream = new FileStream(PDF, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();

                DirectoryInfo di = new DirectoryInfo(ruta + "/Escaneos2");
                //Console.WriteLine("No search pattern returns:");
                foreach (var fi in di.GetFiles())
                {
                    Docs = (ruta + "/Escaneos2/" + fi.Name);


                    using (var imageStream = new FileStream(Docs, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {

                        var image = iTextSharp.text.Image.GetInstance(imageStream);
                        document.Add(image);

                    }

                }





                document.Close();




                /* PARTE DE BORRADO*/
                DirectoryInfo di3 = new DirectoryInfo(ruta + "/Escaneos");
                FileInfo[] files = di3.GetFiles();
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
                Console.WriteLine("Files deleted successfully");

                DirectoryInfo di4 = new DirectoryInfo(ruta + "/Escaneos2");
                FileInfo[] files2 = di4.GetFiles();
                foreach (FileInfo file in files2)
                {
                    file.Delete();
                }
                Console.WriteLine("Files deleted successfully");







                MessageBox.Show("Completado con Exito");
            }



        }

        private void Escanear_Load(object sender, EventArgs e)
        {
            ListScanners();
        }
    }
}
