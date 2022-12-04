namespace Presentacion
{
    partial class Programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            this.panelMenuL = new System.Windows.Forms.Panel();
            this.sub3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel_SudMenuFact = new System.Windows.Forms.Panel();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_Fact = new System.Windows.Forms.Button();
            this.panelSudMenuInicio = new System.Windows.Forms.Panel();
            this.btn_FA = new System.Windows.Forms.Button();
            this.btn_INICIO = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuL.SuspendLayout();
            this.sub3.SuspendLayout();
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
            this.panelMenuL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(59)))));
            this.panelMenuL.Controls.Add(this.sub3);
            this.panelMenuL.Controls.Add(this.button1);
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
            // sub3
            // 
            this.sub3.BackColor = System.Drawing.Color.Gainsboro;
            this.sub3.Controls.Add(this.button2);
            this.sub3.Controls.Add(this.button4);
            this.sub3.Dock = System.Windows.Forms.DockStyle.Top;
            this.sub3.Location = new System.Drawing.Point(0, 368);
            this.sub3.Name = "sub3";
            this.sub3.Size = new System.Drawing.Size(250, 80);
            this.sub3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Usuario";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Clientes";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(112)))), ((int)(((byte)(47)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(37)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "PERSONAL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(29)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(0, 649);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 40);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // panel_SudMenuFact
            // 
            this.panel_SudMenuFact.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_SudMenuFact.Controls.Add(this.btn_Facturar);
            this.panel_SudMenuFact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SudMenuFact.Location = new System.Drawing.Point(0, 282);
            this.panel_SudMenuFact.Name = "panel_SudMenuFact";
            this.panel_SudMenuFact.Size = new System.Drawing.Size(250, 46);
            this.panel_SudMenuFact.TabIndex = 4;
            this.panel_SudMenuFact.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_SudMenuFact_Paint);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Facturar.FlatAppearance.BorderSize = 0;
            this.btn_Facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturar.Location = new System.Drawing.Point(0, 0);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(250, 50);
            this.btn_Facturar.TabIndex = 0;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Facturar.UseVisualStyleBackColor = true;
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
            // 
            // btn_Fact
            // 
            this.btn_Fact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(112)))), ((int)(((byte)(47)))));
            this.btn_Fact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fact.FlatAppearance.BorderSize = 0;
            this.btn_Fact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(37)))));
            this.btn_Fact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(37)))));
            this.btn_Fact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Fact.Location = new System.Drawing.Point(0, 242);
            this.btn_Fact.Name = "btn_Fact";
            this.btn_Fact.Size = new System.Drawing.Size(250, 40);
            this.btn_Fact.TabIndex = 3;
            this.btn_Fact.Text = "FACTURA";
            this.btn_Fact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Fact.UseVisualStyleBackColor = false;
            this.btn_Fact.Click += new System.EventHandler(this.btn_Fact_Click);
            // 
            // panelSudMenuInicio
            // 
            this.panelSudMenuInicio.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSudMenuInicio.Controls.Add(this.btn_FA);
            this.panelSudMenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSudMenuInicio.Location = new System.Drawing.Point(0, 190);
            this.panelSudMenuInicio.Name = "panelSudMenuInicio";
            this.panelSudMenuInicio.Size = new System.Drawing.Size(250, 52);
            this.panelSudMenuInicio.TabIndex = 2;
            this.panelSudMenuInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSudMenuInicio_Paint);
            // 
            // btn_FA
            // 
            this.btn_FA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FA.FlatAppearance.BorderSize = 0;
            this.btn_FA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_FA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_FA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FA.Location = new System.Drawing.Point(0, 0);
            this.btn_FA.Name = "btn_FA";
            this.btn_FA.Size = new System.Drawing.Size(250, 50);
            this.btn_FA.TabIndex = 0;
            this.btn_FA.Text = "Productos";
            this.btn_FA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FA.UseVisualStyleBackColor = true;
            this.btn_FA.Click += new System.EventHandler(this.btn_FA_Click);
            // 
            // btn_INICIO
            // 
            this.btn_INICIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(112)))), ((int)(((byte)(47)))));
            this.btn_INICIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_INICIO.FlatAppearance.BorderSize = 0;
            this.btn_INICIO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(37)))));
            this.btn_INICIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(89)))), ((int)(((byte)(37)))));
            this.btn_INICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INICIO.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_INICIO.Location = new System.Drawing.Point(0, 150);
            this.btn_INICIO.Name = "btn_INICIO";
            this.btn_INICIO.Size = new System.Drawing.Size(250, 40);
            this.btn_INICIO.TabIndex = 1;
            this.btn_INICIO.Text = "INICIO";
            this.btn_INICIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_INICIO.UseVisualStyleBackColor = false;
            this.btn_INICIO.Click += new System.EventHandler(this.btn_INICIO_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 150);
            this.panelLogo.TabIndex = 0;
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(29)))));
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
            this.pictureBox1.Location = new System.Drawing.Point(34, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 703);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panelMenuL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Programa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Programa_FormClosing);
            this.panelMenuL.ResumeLayout(false);
            this.sub3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_FA;
        private System.Windows.Forms.Button btn_INICIO;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Fact;
        private System.Windows.Forms.Panel panel_SudMenuFact;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel sub3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

