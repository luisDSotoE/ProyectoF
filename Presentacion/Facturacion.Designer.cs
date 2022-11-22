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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINVENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btnGuardaarFac = new System.Windows.Forms.Button();
            this.labTipo = new System.Windows.Forms.Label();
            this.labCantidad = new System.Windows.Forms.Label();
            this.labProducto = new System.Windows.Forms.Label();
            this.labNumero = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(154, 141);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Tipo,
            this.FECHAINVENTARIO,
            this.Codigo,
            this.Producto,
            this.Cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(11, 374);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 186);
            this.dataGridView1.TabIndex = 24;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            // 
            // FECHAINVENTARIO
            // 
            this.FECHAINVENTARIO.HeaderText = "Fecha de inventario";
            this.FECHAINVENTARIO.MinimumWidth = 6;
            this.FECHAINVENTARIO.Name = "FECHAINVENTARIO";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 233);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 22;
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Location = new System.Drawing.Point(135, 284);
            this.btnCancelarFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(67, 31);
            this.btnCancelarFactura.TabIndex = 21;
            this.btnCancelarFactura.Text = "Cancelar";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            // 
            // btnGuardaarFac
            // 
            this.btnGuardaarFac.Location = new System.Drawing.Point(206, 284);
            this.btnGuardaarFac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardaarFac.Name = "btnGuardaarFac";
            this.btnGuardaarFac.Size = new System.Drawing.Size(67, 31);
            this.btnGuardaarFac.TabIndex = 20;
            this.btnGuardaarFac.Text = "Guardar";
            this.btnGuardaarFac.UseVisualStyleBackColor = true;
            // 
            // labTipo
            // 
            this.labTipo.AutoSize = true;
            this.labTipo.Location = new System.Drawing.Point(58, 233);
            this.labTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTipo.Name = "labTipo";
            this.labTipo.Size = new System.Drawing.Size(58, 13);
            this.labTipo.TabIndex = 19;
            this.labTipo.Text = "Comprador";
            // 
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.Location = new System.Drawing.Point(58, 143);
            this.labCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(49, 13);
            this.labCantidad.TabIndex = 18;
            this.labCantidad.Text = "Cantidad";
            // 
            // labProducto
            // 
            this.labProducto.AutoSize = true;
            this.labProducto.Location = new System.Drawing.Point(58, 99);
            this.labProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProducto.Name = "labProducto";
            this.labProducto.Size = new System.Drawing.Size(50, 13);
            this.labProducto.TabIndex = 17;
            this.labProducto.Text = "Producto";
            // 
            // labNumero
            // 
            this.labNumero.AutoSize = true;
            this.labNumero.Location = new System.Drawing.Point(58, 193);
            this.labNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNumero.Name = "labNumero";
            this.labNumero.Size = new System.Drawing.Size(37, 13);
            this.labNumero.TabIndex = 16;
            this.labNumero.Text = "Precio";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 93);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Facturacion";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnGuardaarFac);
            this.Controls.Add(this.labTipo);
            this.Controls.Add(this.labCantidad);
            this.Controls.Add(this.labProducto);
            this.Controls.Add(this.labNumero);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Facturacion";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINVENTARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btnGuardaarFac;
        private System.Windows.Forms.Label labTipo;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.Label labProducto;
        private System.Windows.Forms.Label labNumero;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}