namespace Presentacion
{
    partial class Facturacion
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
            this.txtIdF = new System.Windows.Forms.TextBox();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnGuardaarFac = new System.Windows.Forms.Button();
            this.labProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CargarDatos = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdF
            // 
            this.txtIdF.Location = new System.Drawing.Point(163, 132);
            this.txtIdF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdF.Name = "txtIdF";
            this.txtIdF.Size = new System.Drawing.Size(157, 22);
            this.txtIdF.TabIndex = 22;
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Location = new System.Drawing.Point(180, 350);
            this.btnCancelarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(89, 38);
            this.btnCancelarFactura.TabIndex = 21;
            this.btnCancelarFactura.Text = "Cancelar";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            // 
            // btnGuardaarFac
            // 
            this.btnGuardaarFac.Location = new System.Drawing.Point(275, 350);
            this.btnGuardaarFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardaarFac.Name = "btnGuardaarFac";
            this.btnGuardaarFac.Size = new System.Drawing.Size(89, 38);
            this.btnGuardaarFac.TabIndex = 20;
            this.btnGuardaarFac.Text = "Guardar";
            this.btnGuardaarFac.UseVisualStyleBackColor = true;
            // 
            // labProducto
            // 
            this.labProducto.AutoSize = true;
            this.labProducto.Location = new System.Drawing.Point(77, 135);
            this.labProducto.Name = "labProducto";
            this.labProducto.Size = new System.Drawing.Size(65, 16);
            this.labProducto.TabIndex = 17;
            this.labProducto.Text = "Id_facutra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Facturacion";
            // 
            // CargarDatos
            // 
            this.CargarDatos.Location = new System.Drawing.Point(406, 350);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(94, 38);
            this.CargarDatos.TabIndex = 27;
            this.CargarDatos.Text = "Cargar";
            this.CargarDatos.UseVisualStyleBackColor = true;
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 471);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(828, 220);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtIdC
            // 
            this.txtIdC.Location = new System.Drawing.Point(163, 173);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(157, 22);
            this.txtIdC.TabIndex = 29;
            this.txtIdC.TextChanged += new System.EventHandler(this.txtIdC_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(163, 216);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(157, 22);
            this.txtFecha.TabIndex = 30;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(163, 254);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(157, 22);
            this.txtIdP.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id_cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Id_producto";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(532, 350);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(85, 38);
            this.btnInsertar.TabIndex = 35;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(659, 350);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 38);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(429, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 703);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdP);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtIdC);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdF);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnGuardaarFac);
            this.Controls.Add(this.labProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Facturacion";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdF;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btnGuardaarFac;
        private System.Windows.Forms.Label labProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CargarDatos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdC;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}