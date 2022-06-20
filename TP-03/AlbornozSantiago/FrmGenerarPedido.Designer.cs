namespace AlbornozSantiago
{
    partial class FrmGenerarPedido
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lstListaProductosCliente = new System.Windows.Forms.ListBox();
            this.txtNobreCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtNroDeTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstProductosEnStock = new System.Windows.Forms.ListBox();
            this.btnAgregarProductoAListaCliente = new System.Windows.Forms.Button();
            this.btnQuitarProductoAListaCliente = new System.Windows.Forms.Button();
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.cmbEmpleadoACargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListaProductosCliente
            // 
            this.lstListaProductosCliente.FormattingEnabled = true;
            this.lstListaProductosCliente.ItemHeight = 25;
            this.lstListaProductosCliente.Location = new System.Drawing.Point(45, 449);
            this.lstListaProductosCliente.Name = "lstListaProductosCliente";
            this.lstListaProductosCliente.Size = new System.Drawing.Size(343, 479);
            this.lstListaProductosCliente.TabIndex = 0;
            // 
            // txtNobreCliente
            // 
            this.txtNobreCliente.Location = new System.Drawing.Point(45, 145);
            this.txtNobreCliente.Name = "txtNobreCliente";
            this.txtNobreCliente.Size = new System.Drawing.Size(229, 31);
            this.txtNobreCliente.TabIndex = 1;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(45, 309);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(229, 31);
            this.txtDireccionCliente.TabIndex = 2;
            // 
            // txtNroDeTelefonoCliente
            // 
            this.txtNroDeTelefonoCliente.Location = new System.Drawing.Point(45, 396);
            this.txtNroDeTelefonoCliente.Name = "txtNroDeTelefonoCliente";
            this.txtNroDeTelefonoCliente.Size = new System.Drawing.Size(229, 31);
            this.txtNroDeTelefonoCliente.TabIndex = 3;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(45, 222);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(229, 31);
            this.txtApellidoCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 946);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total a pagar";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(45, 1000);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(76, 25);
            this.lblTotalAPagar.TabIndex = 9;
            this.lblTotalAPagar.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nro de telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Productos en stock";
            // 
            // lstProductosEnStock
            // 
            this.lstProductosEnStock.FormattingEnabled = true;
            this.lstProductosEnStock.ItemHeight = 25;
            this.lstProductosEnStock.Location = new System.Drawing.Point(725, 145);
            this.lstProductosEnStock.Name = "lstProductosEnStock";
            this.lstProductosEnStock.Size = new System.Drawing.Size(457, 779);
            this.lstProductosEnStock.TabIndex = 12;
            // 
            // btnAgregarProductoAListaCliente
            // 
            this.btnAgregarProductoAListaCliente.Location = new System.Drawing.Point(478, 449);
            this.btnAgregarProductoAListaCliente.Name = "btnAgregarProductoAListaCliente";
            this.btnAgregarProductoAListaCliente.Size = new System.Drawing.Size(121, 66);
            this.btnAgregarProductoAListaCliente.TabIndex = 13;
            this.btnAgregarProductoAListaCliente.Text = "+";
            this.btnAgregarProductoAListaCliente.UseVisualStyleBackColor = true;
            this.btnAgregarProductoAListaCliente.Click += new System.EventHandler(this.btnAgregarProductoAListaCliente_Click);
            // 
            // btnQuitarProductoAListaCliente
            // 
            this.btnQuitarProductoAListaCliente.Location = new System.Drawing.Point(478, 544);
            this.btnQuitarProductoAListaCliente.Name = "btnQuitarProductoAListaCliente";
            this.btnQuitarProductoAListaCliente.Size = new System.Drawing.Size(121, 66);
            this.btnQuitarProductoAListaCliente.TabIndex = 14;
            this.btnQuitarProductoAListaCliente.Text = "-";
            this.btnQuitarProductoAListaCliente.UseVisualStyleBackColor = true;
            this.btnQuitarProductoAListaCliente.Click += new System.EventHandler(this.btnQuitarProductoAListaCliente_Click);
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.Location = new System.Drawing.Point(444, 839);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(233, 89);
            this.btnGenerarVenta.TabIndex = 15;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = true;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // cmbEmpleadoACargo
            // 
            this.cmbEmpleadoACargo.FormattingEnabled = true;
            this.cmbEmpleadoACargo.Location = new System.Drawing.Point(159, 12);
            this.cmbEmpleadoACargo.Name = "cmbEmpleadoACargo";
            this.cmbEmpleadoACargo.Size = new System.Drawing.Size(242, 33);
            this.cmbEmpleadoACargo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Atendido Por";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Location = new System.Drawing.Point(478, 20);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(105, 25);
            this.lblHoraActual.TabIndex = 18;
            this.lblHoraActual.Text = "Hora Actual";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1037, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 41);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmGenerarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 1091);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblHoraActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEmpleadoACargo);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.btnQuitarProductoAListaCliente);
            this.Controls.Add(this.btnAgregarProductoAListaCliente);
            this.Controls.Add(this.lstProductosEnStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNroDeTelefonoCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtNobreCliente);
            this.Controls.Add(this.lstListaProductosCliente);
            this.Name = "FrmGenerarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo pedido";
            this.Load += new System.EventHandler(this.FrmGenerarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListBox lstListaProductosCliente;
        private System.Windows.Forms.TextBox txtNobreCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtNroDeTelefonoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstProductosEnStock;
        private System.Windows.Forms.Button btnAgregarProductoAListaCliente;
        private System.Windows.Forms.Button btnQuitarProductoAListaCliente;
        private System.Windows.Forms.Button btnGenerarVenta;
        private System.Windows.Forms.ComboBox cmbEmpleadoACargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Button btnVolver;
    }
}