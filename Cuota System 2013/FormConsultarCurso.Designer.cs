﻿namespace Cuota_System_2013
{
    partial class FormConsultarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarCurso));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_modifCursos = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dgv_modifCursos);
            this.groupBox1.Controls.Add(this.btn_volver);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(30, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(885, 407);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar datos de los Cursos";
            // 
            // dgv_modifCursos
            // 
            this.dgv_modifCursos.AllowUserToAddRows = false;
            this.dgv_modifCursos.AllowUserToDeleteRows = false;
            this.dgv_modifCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_modifCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modifCursos.Location = new System.Drawing.Point(6, 21);
            this.dgv_modifCursos.Name = "dgv_modifCursos";
            this.dgv_modifCursos.ReadOnly = true;
            this.dgv_modifCursos.Size = new System.Drawing.Size(872, 275);
            this.dgv_modifCursos.TabIndex = 30;
            this.dgv_modifCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modifCursos_CellContentClick);
            // 
            // btn_volver
            // 
            this.btn_volver.Image = global::Cuota_System_2013.Properties.Resources.Volver_ico;
            this.btn_volver.Location = new System.Drawing.Point(6, 331);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(57, 45);
            this.btn_volver.TabIndex = 29;
            this.btn_volver.UseVisualStyleBackColor = true;
            // 
            // FormConsultarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cuota_System_2013.Properties.Resources.Fondo_20132;
            this.ClientSize = new System.Drawing.Size(944, 624);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConsultarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCurso";
            this.Load += new System.EventHandler(this.FormModificarCurso_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_modifCursos;
        private System.Windows.Forms.Button btn_volver;
    }
}