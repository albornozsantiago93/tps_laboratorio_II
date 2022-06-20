namespace AlbornozSantiago
{
    partial class FrmInforme
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
            this.rchInforme = new System.Windows.Forms.RichTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnExportarInforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchInforme
            // 
            this.rchInforme.Location = new System.Drawing.Point(41, 32);
            this.rchInforme.Name = "rchInforme";
            this.rchInforme.Size = new System.Drawing.Size(1058, 427);
            this.rchInforme.TabIndex = 0;
            this.rchInforme.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(41, 489);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 34);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnExportarInforme
            // 
            this.btnExportarInforme.Location = new System.Drawing.Point(41, 552);
            this.btnExportarInforme.Name = "btnExportarInforme";
            this.btnExportarInforme.Size = new System.Drawing.Size(198, 34);
            this.btnExportarInforme.TabIndex = 2;
            this.btnExportarInforme.Text = "Exportar informe";
            this.btnExportarInforme.UseVisualStyleBackColor = true;
            this.btnExportarInforme.Click += new System.EventHandler(this.btnExportarInforme_Click);
            // 
            // FrmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 628);
            this.Controls.Add(this.btnExportarInforme);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.rchInforme);
            this.Name = "FrmInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.FrmInforme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchInforme;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnExportarInforme;
    }
}