
namespace RegistroLicenciasChihuahua
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_mistramites = new System.Windows.Forms.Button();
            this.btn_menu_busqueda = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Rol);
            this.panel1.Controls.Add(this.lbl_UserName);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_mistramites);
            this.panel1.Controls.Add(this.btn_menu_busqueda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 624);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_cerrarsesion, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_User, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 554);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(232, 70);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_cerrarsesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cerrarsesion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btn_cerrarsesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarsesion.Image")));
            this.btn_cerrarsesion.Location = new System.Drawing.Point(3, 22);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(226, 45);
            this.btn_cerrarsesion.TabIndex = 0;
            this.btn_cerrarsesion.Text = "Cerrar sesión";
            this.btn_cerrarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cerrarsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrarsesion.UseVisualStyleBackColor = false;
            // 
            // btn_User
            // 
            this.btn_User.AutoSize = true;
            this.btn_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_User.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btn_User.Location = new System.Drawing.Point(3, 0);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(226, 19);
            this.btn_User.TabIndex = 1;
            this.btn_User.Text = "Usuario";
            this.btn_User.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 624);
            this.panel2.TabIndex = 2;
            // 
            // btn_mistramites
            // 
            this.btn_mistramites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(12)))), ((int)(((byte)(106)))));
            this.btn_mistramites.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mistramites.ForeColor = System.Drawing.Color.White;
            this.btn_mistramites.Image = ((System.Drawing.Image)(resources.GetObject("btn_mistramites.Image")));
            this.btn_mistramites.Location = new System.Drawing.Point(12, 169);
            this.btn_mistramites.Name = "btn_mistramites";
            this.btn_mistramites.Size = new System.Drawing.Size(203, 38);
            this.btn_mistramites.TabIndex = 1;
            this.btn_mistramites.Text = "Mis trámites";
            this.btn_mistramites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mistramites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mistramites.UseVisualStyleBackColor = false;
            this.btn_mistramites.Click += new System.EventHandler(this.btn_mistramites_Click);
            // 
            // btn_menu_busqueda
            // 
            this.btn_menu_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(12)))), ((int)(((byte)(106)))));
            this.btn_menu_busqueda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_busqueda.ForeColor = System.Drawing.Color.White;
            this.btn_menu_busqueda.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_busqueda.Image")));
            this.btn_menu_busqueda.Location = new System.Drawing.Point(12, 125);
            this.btn_menu_busqueda.Name = "btn_menu_busqueda";
            this.btn_menu_busqueda.Size = new System.Drawing.Size(203, 38);
            this.btn_menu_busqueda.TabIndex = 0;
            this.btn_menu_busqueda.Text = "Búsqueda";
            this.btn_menu_busqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu_busqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu_busqueda.UseVisualStyleBackColor = false;
            this.btn_menu_busqueda.Click += new System.EventHandler(this.btn_menu_busqueda_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.tableLayoutPanel1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(234, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(969, 624);
            this.mainpanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.75335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.02683F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.11662F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al sistema de licencias del estado de Chihuahua";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(301, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(440, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(12, 458);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(57, 13);
            this.lbl_UserName.TabIndex = 5;
            this.lbl_UserName.Text = "UserName";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(12, 492);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(23, 13);
            this.lbl_Rol.TabIndex = 6;
            this.lbl_Rol.Text = "Rol";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 624);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_mistramites;
        private System.Windows.Forms.Button btn_menu_busqueda;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label btn_User;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_UserName;
    }
}

