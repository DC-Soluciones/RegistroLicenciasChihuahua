
namespace RegistroLicenciasChihuahua
{
    partial class Escanear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escanear));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chbx_acta = new System.Windows.Forms.CheckBox();
            this.chbx_identificación = new System.Windows.Forms.CheckBox();
            this.btn_identificación = new System.Windows.Forms.Button();
            this.btn_acta = new System.Windows.Forms.Button();
            this.btn_comprobante = new System.Windows.Forms.Button();
            this.chbx_comprobante = new System.Windows.Forms.CheckBox();
            this.btn_licAnt = new System.Windows.Forms.Button();
            this.chbx_licAnt = new System.Windows.Forms.CheckBox();
            this.btn_licActual = new System.Windows.Forms.Button();
            this.chbx_licActual = new System.Windows.Forms.CheckBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.chbx_reporte = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de trámite:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folio:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(518, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecciona el escáner";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 108);
            this.listBox1.TabIndex = 5;
            // 
            // chbx_acta
            // 
            this.chbx_acta.AutoSize = true;
            this.chbx_acta.Location = new System.Drawing.Point(34, 274);
            this.chbx_acta.Name = "chbx_acta";
            this.chbx_acta.Size = new System.Drawing.Size(117, 17);
            this.chbx_acta.TabIndex = 6;
            this.chbx_acta.Text = "Acta de nacimiento";
            this.chbx_acta.UseVisualStyleBackColor = true;
            this.chbx_acta.CheckedChanged += new System.EventHandler(this.chbx_acta_CheckedChanged);
            // 
            // chbx_identificación
            // 
            this.chbx_identificación.AutoSize = true;
            this.chbx_identificación.Location = new System.Drawing.Point(34, 322);
            this.chbx_identificación.Name = "chbx_identificación";
            this.chbx_identificación.Size = new System.Drawing.Size(119, 17);
            this.chbx_identificación.TabIndex = 8;
            this.chbx_identificación.Text = "Identificación oficial";
            this.chbx_identificación.UseVisualStyleBackColor = true;
            this.chbx_identificación.CheckedChanged += new System.EventHandler(this.chbx_identificación_CheckedChanged);
            // 
            // btn_identificación
            // 
            this.btn_identificación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_identificación.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_identificación.ForeColor = System.Drawing.Color.White;
            this.btn_identificación.Image = ((System.Drawing.Image)(resources.GetObject("btn_identificación.Image")));
            this.btn_identificación.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_identificación.Location = new System.Drawing.Point(211, 311);
            this.btn_identificación.Name = "btn_identificación";
            this.btn_identificación.Size = new System.Drawing.Size(114, 36);
            this.btn_identificación.TabIndex = 9;
            this.btn_identificación.Text = "Escanear";
            this.btn_identificación.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_identificación.UseVisualStyleBackColor = false;
            this.btn_identificación.Visible = false;
            this.btn_identificación.Click += new System.EventHandler(this.btn_identificación_Click);
            // 
            // btn_acta
            // 
            this.btn_acta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_acta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acta.ForeColor = System.Drawing.Color.White;
            this.btn_acta.Image = ((System.Drawing.Image)(resources.GetObject("btn_acta.Image")));
            this.btn_acta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_acta.Location = new System.Drawing.Point(211, 263);
            this.btn_acta.Name = "btn_acta";
            this.btn_acta.Size = new System.Drawing.Size(114, 36);
            this.btn_acta.TabIndex = 7;
            this.btn_acta.Text = "Escanear";
            this.btn_acta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_acta.UseVisualStyleBackColor = false;
            this.btn_acta.Visible = false;
            this.btn_acta.Click += new System.EventHandler(this.btn_acta_Click);
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_comprobante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprobante.ForeColor = System.Drawing.Color.White;
            this.btn_comprobante.Image = ((System.Drawing.Image)(resources.GetObject("btn_comprobante.Image")));
            this.btn_comprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_comprobante.Location = new System.Drawing.Point(211, 366);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.Size = new System.Drawing.Size(114, 36);
            this.btn_comprobante.TabIndex = 11;
            this.btn_comprobante.Text = "Escanear";
            this.btn_comprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_comprobante.UseVisualStyleBackColor = false;
            this.btn_comprobante.Visible = false;
            this.btn_comprobante.Click += new System.EventHandler(this.btn_comprobante_Click);
            // 
            // chbx_comprobante
            // 
            this.chbx_comprobante.AutoSize = true;
            this.chbx_comprobante.Location = new System.Drawing.Point(34, 377);
            this.chbx_comprobante.Name = "chbx_comprobante";
            this.chbx_comprobante.Size = new System.Drawing.Size(147, 17);
            this.chbx_comprobante.TabIndex = 10;
            this.chbx_comprobante.Text = "Comprobante de domicilio";
            this.chbx_comprobante.UseVisualStyleBackColor = true;
            this.chbx_comprobante.CheckedChanged += new System.EventHandler(this.chbx_comprobante_CheckedChanged);
            // 
            // btn_licAnt
            // 
            this.btn_licAnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_licAnt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_licAnt.ForeColor = System.Drawing.Color.White;
            this.btn_licAnt.Image = ((System.Drawing.Image)(resources.GetObject("btn_licAnt.Image")));
            this.btn_licAnt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_licAnt.Location = new System.Drawing.Point(211, 423);
            this.btn_licAnt.Name = "btn_licAnt";
            this.btn_licAnt.Size = new System.Drawing.Size(114, 36);
            this.btn_licAnt.TabIndex = 13;
            this.btn_licAnt.Text = "Escanear";
            this.btn_licAnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_licAnt.UseVisualStyleBackColor = false;
            this.btn_licAnt.Visible = false;
            this.btn_licAnt.Click += new System.EventHandler(this.btn_licAnt_Click);
            // 
            // chbx_licAnt
            // 
            this.chbx_licAnt.AutoSize = true;
            this.chbx_licAnt.Location = new System.Drawing.Point(34, 434);
            this.chbx_licAnt.Name = "chbx_licAnt";
            this.chbx_licAnt.Size = new System.Drawing.Size(104, 17);
            this.chbx_licAnt.TabIndex = 12;
            this.chbx_licAnt.Text = "Licencia anterior";
            this.chbx_licAnt.UseVisualStyleBackColor = true;
            this.chbx_licAnt.CheckedChanged += new System.EventHandler(this.chbx_licAnt_CheckedChanged);
            // 
            // btn_licActual
            // 
            this.btn_licActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_licActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_licActual.ForeColor = System.Drawing.Color.White;
            this.btn_licActual.Image = ((System.Drawing.Image)(resources.GetObject("btn_licActual.Image")));
            this.btn_licActual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_licActual.Location = new System.Drawing.Point(211, 476);
            this.btn_licActual.Name = "btn_licActual";
            this.btn_licActual.Size = new System.Drawing.Size(114, 36);
            this.btn_licActual.TabIndex = 15;
            this.btn_licActual.Text = "Escanear";
            this.btn_licActual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_licActual.UseVisualStyleBackColor = false;
            this.btn_licActual.Visible = false;
            this.btn_licActual.Click += new System.EventHandler(this.btn_licActual_Click);
            // 
            // chbx_licActual
            // 
            this.chbx_licActual.AutoSize = true;
            this.chbx_licActual.Location = new System.Drawing.Point(34, 487);
            this.chbx_licActual.Name = "chbx_licActual";
            this.chbx_licActual.Size = new System.Drawing.Size(104, 17);
            this.chbx_licActual.TabIndex = 14;
            this.chbx_licActual.Text = "Licencia vigente";
            this.chbx_licActual.UseVisualStyleBackColor = true;
            this.chbx_licActual.CheckedChanged += new System.EventHandler(this.chbx_licActual_CheckedChanged);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_reporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.ForeColor = System.Drawing.Color.White;
            this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reporte.Location = new System.Drawing.Point(211, 535);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(114, 36);
            this.btn_reporte.TabIndex = 17;
            this.btn_reporte.Text = "Escanear";
            this.btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Visible = false;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // chbx_reporte
            // 
            this.chbx_reporte.AutoSize = true;
            this.chbx_reporte.Location = new System.Drawing.Point(34, 546);
            this.chbx_reporte.Name = "chbx_reporte";
            this.chbx_reporte.Size = new System.Drawing.Size(103, 17);
            this.chbx_reporte.TabIndex = 16;
            this.chbx_reporte.Text = "Reporte de robo";
            this.chbx_reporte.UseVisualStyleBackColor = true;
            this.chbx_reporte.CheckedChanged += new System.EventHandler(this.chbx_reporte_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 388);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(621, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Guardar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Escanear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.chbx_reporte);
            this.Controls.Add(this.btn_licActual);
            this.Controls.Add(this.chbx_licActual);
            this.Controls.Add(this.btn_licAnt);
            this.Controls.Add(this.chbx_licAnt);
            this.Controls.Add(this.btn_comprobante);
            this.Controls.Add(this.chbx_comprobante);
            this.Controls.Add(this.btn_identificación);
            this.Controls.Add(this.chbx_identificación);
            this.Controls.Add(this.btn_acta);
            this.Controls.Add(this.chbx_acta);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Escanear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escanear";
            this.Load += new System.EventHandler(this.Escanear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chbx_acta;
        private System.Windows.Forms.Button btn_acta;
        private System.Windows.Forms.Button btn_identificación;
        private System.Windows.Forms.CheckBox chbx_identificación;
        private System.Windows.Forms.Button btn_comprobante;
        private System.Windows.Forms.CheckBox chbx_comprobante;
        private System.Windows.Forms.Button btn_licAnt;
        private System.Windows.Forms.CheckBox chbx_licAnt;
        private System.Windows.Forms.Button btn_licActual;
        private System.Windows.Forms.CheckBox chbx_licActual;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.CheckBox chbx_reporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}