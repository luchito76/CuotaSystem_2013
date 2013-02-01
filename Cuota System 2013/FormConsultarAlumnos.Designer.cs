namespace Cuota_System_2013
{
    partial class FormConsultarAlumnos
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
            this.dgvALumno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvALumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvALumno
            // 
            this.dgvALumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvALumno.Location = new System.Drawing.Point(67, 54);
            this.dgvALumno.Name = "dgvALumno";
            this.dgvALumno.Size = new System.Drawing.Size(687, 150);
            this.dgvALumno.TabIndex = 0;
            // 
            // FormConsultarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 393);
            this.Controls.Add(this.dgvALumno);
            this.Name = "FormConsultarAlumnos";
            this.Text = "FormConsultarAlumnos";
            this.Load += new System.EventHandler(this.FormConsultarAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvALumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvALumno;
    }
}