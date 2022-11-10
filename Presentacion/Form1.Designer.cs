namespace Presentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenuL = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel_SudMenuFact = new System.Windows.Forms.Panel();
            this.btn_costos = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_Fact = new System.Windows.Forms.Button();
            this.panelSudMenuInicio = new System.Windows.Forms.Panel();
            this.btn_Maquinaria = new System.Windows.Forms.Button();
            this.btn_SM = new System.Windows.Forms.Button();
            this.btn_FA = new System.Windows.Forms.Button();
            this.btn_INICIO = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuL.SuspendLayout();
            this.panel_SudMenuFact.SuspendLayout();
            this.panelSudMenuInicio.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuL
            // 
            this.panelMenuL.AutoScroll = true;
            this.panelMenuL.BackColor = System.Drawing.Color.ForestGreen;
            this.panelMenuL.Controls.Add(this.btn_Salir);
            this.panelMenuL.Controls.Add(this.panel_SudMenuFact);
            this.panelMenuL.Controls.Add(this.btn_Fact);
            this.panelMenuL.Controls.Add(this.panelSudMenuInicio);
            this.panelMenuL.Controls.Add(this.btn_INICIO);
            this.panelMenuL.Controls.Add(this.panelLogo);
            this.panelMenuL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuL.Location = new System.Drawing.Point(0, 0);
            this.panelMenuL.Name = "panelMenuL";
            this.panelMenuL.Size = new System.Drawing.Size(250, 703);
            this.panelMenuL.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(0, 649);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 40);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // panel_SudMenuFact
            // 
            this.panel_SudMenuFact.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_SudMenuFact.Controls.Add(this.btn_costos);
            this.panel_SudMenuFact.Controls.Add(this.btn_Admin);
            this.panel_SudMenuFact.Controls.Add(this.btn_Facturar);
            this.panel_SudMenuFact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SudMenuFact.Location = new System.Drawing.Point(0, 376);
            this.panel_SudMenuFact.Name = "panel_SudMenuFact";
            this.panel_SudMenuFact.Size = new System.Drawing.Size(250, 121);
            this.panel_SudMenuFact.TabIndex = 4;
            this.panel_SudMenuFact.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_SudMenuFact_Paint);
            // 
            // btn_costos
            // 
            this.btn_costos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_costos.FlatAppearance.BorderSize = 0;
            this.btn_costos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_costos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_costos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_costos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_costos.Location = new System.Drawing.Point(0, 80);
            this.btn_costos.Name = "btn_costos";
            this.btn_costos.Size = new System.Drawing.Size(250, 40);
            this.btn_costos.TabIndex = 4;
            this.btn_costos.Text = "Costos por articulos";
            this.btn_costos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_costos.UseVisualStyleBackColor = true;
            this.btn_costos.Click += new System.EventHandler(this.btn_costos_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(0, 40);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(250, 40);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Administrar pedidos";
            this.btn_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Facturar.FlatAppearance.BorderSize = 0;
            this.btn_Facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturar.Location = new System.Drawing.Point(0, 0);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(250, 40);
            this.btn_Facturar.TabIndex = 0;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Facturar.UseVisualStyleBackColor = true;
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
            // 
            // btn_Fact
            // 
            this.btn_Fact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fact.FlatAppearance.BorderSize = 0;
            this.btn_Fact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fact.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fact.Location = new System.Drawing.Point(0, 297);
            this.btn_Fact.Name = "btn_Fact";
            this.btn_Fact.Size = new System.Drawing.Size(250, 79);
            this.btn_Fact.TabIndex = 3;
            this.btn_Fact.Text = "FACTURA Y CONTROL DE INVENTARIO";
            this.btn_Fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fact.UseVisualStyleBackColor = true;
            this.btn_Fact.Click += new System.EventHandler(this.btn_Fact_Click);
            // 
            // panelSudMenuInicio
            // 
            this.panelSudMenuInicio.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSudMenuInicio.Controls.Add(this.btn_Maquinaria);
            this.panelSudMenuInicio.Controls.Add(this.btn_SM);
            this.panelSudMenuInicio.Controls.Add(this.btn_FA);
            this.panelSudMenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSudMenuInicio.Location = new System.Drawing.Point(0, 145);
            this.panelSudMenuInicio.Name = "panelSudMenuInicio";
            this.panelSudMenuInicio.Size = new System.Drawing.Size(250, 152);
            this.panelSudMenuInicio.TabIndex = 2;
            this.panelSudMenuInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSudMenuInicio_Paint);
            // 
            // btn_Maquinaria
            // 
            this.btn_Maquinaria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Maquinaria.FlatAppearance.BorderSize = 0;
            this.btn_Maquinaria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Maquinaria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Maquinaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maquinaria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maquinaria.Location = new System.Drawing.Point(0, 117);
            this.btn_Maquinaria.Name = "btn_Maquinaria";
            this.btn_Maquinaria.Size = new System.Drawing.Size(250, 29);
            this.btn_Maquinaria.TabIndex = 2;
            this.btn_Maquinaria.Text = "Maquinaria y equipos.";
            this.btn_Maquinaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Maquinaria.UseVisualStyleBackColor = true;
            this.btn_Maquinaria.Click += new System.EventHandler(this.btn_Maquinaria_Click);
            // 
            // btn_SM
            // 
            this.btn_SM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SM.FlatAppearance.BorderSize = 0;
            this.btn_SM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_SM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SM.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SM.Location = new System.Drawing.Point(0, 56);
            this.btn_SM.Name = "btn_SM";
            this.btn_SM.Size = new System.Drawing.Size(250, 61);
            this.btn_SM.TabIndex = 1;
            this.btn_SM.Text = "Semillas y materiales para la siembra.";
            this.btn_SM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SM.UseVisualStyleBackColor = true;
            this.btn_SM.Click += new System.EventHandler(this.btn_SM_Click);
            // 
            // btn_FA
            // 
            this.btn_FA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FA.FlatAppearance.BorderSize = 0;
            this.btn_FA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_FA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_FA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FA.Location = new System.Drawing.Point(0, 0);
            this.btn_FA.Name = "btn_FA";
            this.btn_FA.Size = new System.Drawing.Size(250, 56);
            this.btn_FA.TabIndex = 0;
            this.btn_FA.Text = "Fertilizantes y agroquímicos.";
            this.btn_FA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FA.UseVisualStyleBackColor = true;
            this.btn_FA.Click += new System.EventHandler(this.btn_FA_Click);
            // 
            // btn_INICIO
            // 
            this.btn_INICIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_INICIO.FlatAppearance.BorderSize = 0;
            this.btn_INICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INICIO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INICIO.Location = new System.Drawing.Point(0, 100);
            this.btn_INICIO.Name = "btn_INICIO";
            this.btn_INICIO.Size = new System.Drawing.Size(250, 45);
            this.btn_INICIO.TabIndex = 1;
            this.btn_INICIO.Text = "INICIO";
            this.btn_INICIO.UseVisualStyleBackColor = true;
            this.btn_INICIO.Click += new System.EventHandler(this.btn_INICIO_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(250, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(852, 703);
            this.PanelGeneral.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 703);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panelMenuL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenuL.ResumeLayout(false);
            this.panel_SudMenuFact.ResumeLayout(false);
            this.panelSudMenuInicio.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuL;
        private System.Windows.Forms.Panel panelSudMenuInicio;
        private System.Windows.Forms.Button btn_Maquinaria;
        private System.Windows.Forms.Button btn_SM;
        private System.Windows.Forms.Button btn_FA;
        private System.Windows.Forms.Button btn_INICIO;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Fact;
        private System.Windows.Forms.Panel panel_SudMenuFact;
        private System.Windows.Forms.Button btn_costos;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

