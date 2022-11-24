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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnGuardaarFac = new System.Windows.Forms.Button();
            this.labCantidad = new System.Windows.Forms.Label();
            this.labProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CargarDatos = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 173);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 22;
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
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.Location = new System.Drawing.Point(77, 176);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(40, 16);
            this.labCantidad.TabIndex = 18;
            this.labCantidad.Text = "fecha";
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
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 703);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnGuardaarFac);
            this.Controls.Add(this.labCantidad);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btnGuardaarFac;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.Label labProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CargarDatos;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}