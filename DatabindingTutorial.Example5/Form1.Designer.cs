namespace DatabindingTutorial.Example5
{
    partial class Form1
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
            this.lstEmps = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomDept = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDepts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrDepts
            // 
            this.dgrDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDepts.Location = new System.Drawing.Point(3, 12);
            this.dgrDepts.Name = "dgrDepts";
            this.dgrDepts.Size = new System.Drawing.Size(528, 233);
            this.dgrDepts.TabIndex = 0;
            // 
            // lstEmps
            // 
            this.lstEmps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEmps.FormattingEnabled = true;
            this.lstEmps.ItemHeight = 16;
            this.lstEmps.Location = new System.Drawing.Point(537, 49);
            this.lstEmps.Name = "lstEmps";
            this.lstEmps.Size = new System.Drawing.Size(343, 196);
            this.lstEmps.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dept.Name";
            // 
            // txtNomDept
            // 
            this.txtNomDept.Location = new System.Drawing.Point(91, 251);
            this.txtNomDept.Name = "txtNomDept";
            this.txtNomDept.Size = new System.Drawing.Size(411, 22);
            this.txtNomDept.TabIndex = 3;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(647, 251);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(233, 22);
            this.txtEmpName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emp.Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 291);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomDept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEmps);
            this.Controls.Add(this.dgrDepts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDepts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrDepts;
        private System.Windows.Forms.ListBox lstEmps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomDept;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
    }
}

