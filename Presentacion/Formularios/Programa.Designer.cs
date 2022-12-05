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
            this.botones = new System.Windows.Forms.Panel();
            this.Btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelMenuL.SuspendLayout();
            this.botones.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuL
            // 
            this.panelMenuL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(59)))));
            this.panelMenuL.Controls.Add(this.botones);
            this.panelMenuL.Controls.Add(this.btn_Salir);
            this.panelMenuL.Controls.Add(this.panelLogo);
            this.panelMenuL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuL.Location = new System.Drawing.Point(0, 0);
            this.panelMenuL.Name = "panelMenuL";
            this.panelMenuL.Size = new System.Drawing.Size(250, 703);
            this.panelMenuL.TabIndex = 0;
            // 
            // botones
            // 
            this.botones.Controls.Add(this.Btn_Clientes);
            this.botones.Controls.Add(this.btn_Productos);
            this.botones.Controls.Add(this.btn_Facturar);
            this.botones.Location = new System.Drawing.Point(3, 156);
            this.botones.Name = "botones";
            this.botones.Size = new System.Drawing.Size(247, 190);
            this.botones.TabIndex = 7;
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.BackColor = System.Drawing.Color.White;
            this.Btn_Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Clientes.FlatAppearance.BorderSize = 0;
            this.Btn_Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clientes.Location = new System.Drawing.Point(0, 100);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Size = new System.Drawing.Size(247, 40);
            this.Btn_Clientes.TabIndex = 0;
            this.Btn_Clientes.Text = "Clientes";
            this.Btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Clientes.UseVisualStyleBackColor = false;
            this.Btn_Clientes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackColor = System.Drawing.Color.White;
            this.btn_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Productos.FlatAppearance.BorderSize = 0;
            this.btn_Productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Productos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Productos.Location = new System.Drawing.Point(0, 50);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(247, 50);
            this.btn_Productos.TabIndex = 0;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos.UseVisualStyleBackColor = false;
            this.btn_Productos.Click += new System.EventHandler(this.btn_FA_Click);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.BackColor = System.Drawing.Color.White;
            this.btn_Facturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Facturar.FlatAppearance.BorderSize = 0;
            this.btn_Facturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturar.Location = new System.Drawing.Point(0, 0);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(247, 50);
            this.btn_Facturar.TabIndex = 0;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Facturar.UseVisualStyleBackColor = false;
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
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
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 150);
            this.panelLogo.TabIndex = 0;
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
            this.botones.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuL;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Btn_Clientes;
        private System.Windows.Forms.Panel botones;
    }
}

