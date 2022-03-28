namespace DatabindingTutorial.Example4
{
    partial class FrmPrincipal
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
            this.dgrDepts = new System.Windows.Forms.DataGridView();
            this.dgrEmps = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDepts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmps)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrDepts
            // 
            this.dgrDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDepts.Location = new System.Drawing.Point(12, 37);
            this.dgrDepts.Name = "dgrDepts";
            this.dgrDepts.Size = new System.Drawing.Size(492, 163);
            this.dgrDepts.TabIndex = 0;
            // 
            // dgrEmps
            // 
            this.dgrEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEmps.Location = new System.Drawing.Point(12, 235);
            this.dgrEmps.Name = "dgrEmps";
            this.dgrEmps.Size = new System.Drawing.Size(492, 175);
            this.dgrEmps.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 444);
            this.Controls.Add(this.dgrEmps);
            this.Controls.Add(this.dgrDepts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrDepts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrDepts;
        private System.Windows.Forms.DataGridView dgrEmps;
    }
}

