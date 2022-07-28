namespace AlbornozSantiago
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.btnAgregarNuevoEmpleado = new System.Windows.Forms.Button();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.Location = new System.Drawing.Point(42, 58);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(308, 86);
            this.btnGenerarPedido.TabIndex = 1;
            this.btnGenerarPedido.Text = "Generar Pedido";
            this.btnGenerarPedido.UseVisualStyleBackColor = true;
            this.btnGenerarPedido.Click += new System.EventHandler(this.btnGenerarPedido_Click);
            // 
            // btnAgregarNuevoEmpleado
            // 
            this.btnAgregarNuevoEmpleado.Location = new System.Drawing.Point(42, 321);
            this.btnAgregarNuevoEmpleado.Name = "btnAgregarNuevoEmpleado";
            this.btnAgregarNuevoEmpleado.Size = new System.Drawing.Size(308, 86);
            this.btnAgregarNuevoEmpleado.TabIndex = 2;
            this.btnAgregarNuevoEmpleado.Text = "Agregar nuevo empleado";
            this.btnAgregarNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoEmpleado.Click += new System.EventHandler(this.btnAgregarNuevoEmpleado_Click);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(42, 474);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(308, 86);
            this.btnGenerarInforme.TabIndex = 3;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(42, 611);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(308, 86);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(42, 188);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(308, 86);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Lista de productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 793);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnAgregarNuevoEmpleado);
            this.Controls.Add(this.btnGenerarPedido);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.Button btnAgregarNuevoEmpleado;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProductos;
    }
}
