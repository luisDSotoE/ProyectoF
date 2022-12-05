namespace Presentacion.Formularios
{
    partial class FrmCategoria
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnElimna = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(631, 558);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 30);
            this.btnActualizar.TabIndex = 37;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnElimna
            // 
            this.btnElimna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimna.Location = new System.Drawing.Point(748, 559);
            this.btnElimna.Name = "btnElimna";
            this.btnElimna.Size = new System.Drawing.Size(94, 27);
            this.btnElimna.TabIndex = 38;
            this.btnElimna.Text = "Eliminar";
            this.btnElimna.UseVisualStyleBackColor = true;
            this.btnElimna.Click += new System.EventHandler(this.btnElimna_Click);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.AllowUserToOrderColumns = true;
            this.Grilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(14, 228);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grilla.RowHeadersWidth = 15;
            this.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla.Size = new System.Drawing.Size(828, 325);
            this.Grilla.TabIndex = 39;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.BackColor = System.Drawing.Color.White;
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConsultar.Location = new System.Drawing.Point(700, 192);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(142, 26);
            this.txtConsultar.TabIndex = 35;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(618, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "Consultar:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 42;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtNombre.Location = new System.Drawing.Point(14, 189);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 26);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(11, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Descripción de la categoria:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Gestor de categorias:";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtId.Location = new System.Drawing.Point(184, 562);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 26);
            this.txtId.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Eliminar y editar por id:";
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 703);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnElimna);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnElimna;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}