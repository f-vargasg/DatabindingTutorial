namespace DatabindingTutorial.WinformUI
{
    partial class Form2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPassengers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassengerFilter = new System.Windows.Forms.TextBox();
            this.txtAirplaneFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(589, 248);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Passengers on selected plane:";
            // 
            // lstPassengers
            // 
            this.lstPassengers.FormattingEnabled = true;
            this.lstPassengers.Location = new System.Drawing.Point(539, 79);
            this.lstPassengers.Name = "lstPassengers";
            this.lstPassengers.Size = new System.Drawing.Size(204, 147);
            this.lstPassengers.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(85, 248);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(349, 20);
            this.txtModel.TabIndex = 9;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 36);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(501, 196);
            this.grid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Filter:";
            // 
            // txtPassengerFilter
            // 
            this.txtPassengerFilter.Location = new System.Drawing.Point(573, 53);
            this.txtPassengerFilter.Name = "txtPassengerFilter";
            this.txtPassengerFilter.Size = new System.Drawing.Size(140, 20);
            this.txtPassengerFilter.TabIndex = 17;
            this.txtPassengerFilter.TextChanged += new System.EventHandler(this.txtPassengerFilter_TextChanged);
            // 
            // txtAirplaneFilter
            // 
            this.txtAirplaneFilter.Location = new System.Drawing.Point(373, 10);
            this.txtAirplaneFilter.Name = "txtAirplaneFilter";
            this.txtAirplaneFilter.Size = new System.Drawing.Size(140, 20);
            this.txtAirplaneFilter.TabIndex = 19;
            this.txtAirplaneFilter.TextChanged += new System.EventHandler(this.txtAirplaneFilter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Filter:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 303);
            this.Controls.Add(this.txtAirplaneFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassengerFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPassengers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.grid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPassengers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassengerFilter;
        private System.Windows.Forms.TextBox txtAirplaneFilter;
        private System.Windows.Forms.Label label5;
    }
}