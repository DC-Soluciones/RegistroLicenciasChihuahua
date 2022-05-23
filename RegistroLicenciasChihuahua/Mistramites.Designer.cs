
namespace RegistroLicenciasChihuahua
{
    partial class Mistramites
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mistramites));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Licencia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_Tramites = new System.Windows.Forms.DataGridView();
            this.tramiteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioSeguimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLicenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTramiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniosVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExpedicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complexionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTramitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licenciasCH_QADataSet = new RegistroLicenciasChihuahua.LicenciasCH_QADataSet();
            this.dtTramitesTableAdapter = new RegistroLicenciasChihuahua.LicenciasCH_QADataSetTableAdapters.dtTramitesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tramites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTramitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenciasCH_QADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis trámites";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.38739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9009F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Busqueda, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Nombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Licencia, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 62);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folio/CURP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "N° de licencia";
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Location = new System.Drawing.Point(3, 21);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(141, 20);
            this.txt_Busqueda.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(150, 21);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(141, 20);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Licencia
            // 
            this.txt_Licencia.Location = new System.Drawing.Point(297, 21);
            this.txt_Licencia.Name = "txt_Licencia";
            this.txt_Licencia.Size = new System.Drawing.Size(141, 20);
            this.txt_Licencia.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(9)))), ((int)(((byte)(115)))));
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(444, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(31)))), ((int)(((byte)(89)))));
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(551, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Todo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(31)))), ((int)(((byte)(89)))));
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(660, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Limpiar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 136);
            this.panel1.TabIndex = 2;
            // 
            // gv_Tramites
            // 
            this.gv_Tramites.AutoGenerateColumns = false;
            this.gv_Tramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Tramites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tramiteIdDataGridViewTextBoxColumn,
            this.folioSeguimientoDataGridViewTextBoxColumn,
            this.curpDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.tipoLicenciaDataGridViewTextBoxColumn,
            this.tipoTramiteDataGridViewTextBoxColumn,
            this.aniosVigenciaDataGridViewTextBoxColumn,
            this.fechaExpedicionDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.complexionDataGridViewTextBoxColumn,
            this.mensajePagoDataGridViewTextBoxColumn,
            this.rFCDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.municipioNDataGridViewTextBoxColumn});
            this.gv_Tramites.DataSource = this.dtTramitesBindingSource;
            this.gv_Tramites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Tramites.Location = new System.Drawing.Point(0, 136);
            this.gv_Tramites.Name = "gv_Tramites";
            this.gv_Tramites.Size = new System.Drawing.Size(916, 402);
            this.gv_Tramites.TabIndex = 3;
            this.gv_Tramites.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Tramites_CellContentDoubleClick);
            // 
            // tramiteIdDataGridViewTextBoxColumn
            // 
            this.tramiteIdDataGridViewTextBoxColumn.DataPropertyName = "TramiteId";
            this.tramiteIdDataGridViewTextBoxColumn.HeaderText = "TramiteId";
            this.tramiteIdDataGridViewTextBoxColumn.Name = "tramiteIdDataGridViewTextBoxColumn";
            this.tramiteIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tramiteIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // folioSeguimientoDataGridViewTextBoxColumn
            // 
            this.folioSeguimientoDataGridViewTextBoxColumn.DataPropertyName = "FolioSeguimiento";
            this.folioSeguimientoDataGridViewTextBoxColumn.HeaderText = "FolioSeguimiento";
            this.folioSeguimientoDataGridViewTextBoxColumn.Name = "folioSeguimientoDataGridViewTextBoxColumn";
            // 
            // curpDataGridViewTextBoxColumn
            // 
            this.curpDataGridViewTextBoxColumn.DataPropertyName = "Curp";
            this.curpDataGridViewTextBoxColumn.HeaderText = "Curp";
            this.curpDataGridViewTextBoxColumn.Name = "curpDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            // 
            // tipoLicenciaDataGridViewTextBoxColumn
            // 
            this.tipoLicenciaDataGridViewTextBoxColumn.DataPropertyName = "TipoLicencia";
            this.tipoLicenciaDataGridViewTextBoxColumn.HeaderText = "TipoLicencia";
            this.tipoLicenciaDataGridViewTextBoxColumn.Name = "tipoLicenciaDataGridViewTextBoxColumn";
            // 
            // tipoTramiteDataGridViewTextBoxColumn
            // 
            this.tipoTramiteDataGridViewTextBoxColumn.DataPropertyName = "TipoTramite";
            this.tipoTramiteDataGridViewTextBoxColumn.HeaderText = "TipoTramite";
            this.tipoTramiteDataGridViewTextBoxColumn.Name = "tipoTramiteDataGridViewTextBoxColumn";
            // 
            // aniosVigenciaDataGridViewTextBoxColumn
            // 
            this.aniosVigenciaDataGridViewTextBoxColumn.DataPropertyName = "AniosVigencia";
            this.aniosVigenciaDataGridViewTextBoxColumn.HeaderText = "AniosVigencia";
            this.aniosVigenciaDataGridViewTextBoxColumn.Name = "aniosVigenciaDataGridViewTextBoxColumn";
            // 
            // fechaExpedicionDataGridViewTextBoxColumn
            // 
            this.fechaExpedicionDataGridViewTextBoxColumn.DataPropertyName = "FechaExpedicion";
            this.fechaExpedicionDataGridViewTextBoxColumn.HeaderText = "FechaExpedicion";
            this.fechaExpedicionDataGridViewTextBoxColumn.Name = "fechaExpedicionDataGridViewTextBoxColumn";
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // complexionDataGridViewTextBoxColumn
            // 
            this.complexionDataGridViewTextBoxColumn.DataPropertyName = "Complexion";
            this.complexionDataGridViewTextBoxColumn.HeaderText = "Complexion";
            this.complexionDataGridViewTextBoxColumn.Name = "complexionDataGridViewTextBoxColumn";
            // 
            // mensajePagoDataGridViewTextBoxColumn
            // 
            this.mensajePagoDataGridViewTextBoxColumn.DataPropertyName = "MensajePago";
            this.mensajePagoDataGridViewTextBoxColumn.HeaderText = "MensajePago";
            this.mensajePagoDataGridViewTextBoxColumn.Name = "mensajePagoDataGridViewTextBoxColumn";
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // municipioNDataGridViewTextBoxColumn
            // 
            this.municipioNDataGridViewTextBoxColumn.DataPropertyName = "MunicipioN";
            this.municipioNDataGridViewTextBoxColumn.HeaderText = "MunicipioN";
            this.municipioNDataGridViewTextBoxColumn.Name = "municipioNDataGridViewTextBoxColumn";
            // 
            // dtTramitesBindingSource
            // 
            this.dtTramitesBindingSource.DataMember = "dtTramites";
            this.dtTramitesBindingSource.DataSource = this.licenciasCH_QADataSet;
            // 
            // licenciasCH_QADataSet
            // 
            this.licenciasCH_QADataSet.DataSetName = "LicenciasCH_QADataSet";
            this.licenciasCH_QADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtTramitesTableAdapter
            // 
            this.dtTramitesTableAdapter.ClearBeforeFill = true;
            // 
            // Mistramites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 538);
            this.Controls.Add(this.gv_Tramites);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mistramites";
            this.Text = "Mistramites";
            this.Load += new System.EventHandler(this.Mistramites_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Tramites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTramitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenciasCH_QADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Licencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gv_Tramites;
        private LicenciasCH_QADataSet licenciasCH_QADataSet;
        private System.Windows.Forms.BindingSource dtTramitesBindingSource;
        private LicenciasCH_QADataSetTableAdapters.dtTramitesTableAdapter dtTramitesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramiteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioSeguimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLicenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTramiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniosVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExpedicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complexionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioNDataGridViewTextBoxColumn;
    }
}