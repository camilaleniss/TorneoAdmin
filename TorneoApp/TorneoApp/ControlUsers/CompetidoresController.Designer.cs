﻿namespace TorneoApp.ControlUsers
{
    partial class CompetidoresController
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetidoresController));
            this.labNombreTorneo = new System.Windows.Forms.Label();
            this.butListado = new System.Windows.Forms.Button();
            this.butVerificar = new System.Windows.Forms.Button();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.SuspendLayout();
            // 
            // labNombreTorneo
            // 
            this.labNombreTorneo.AutoSize = true;
            this.labNombreTorneo.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreTorneo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNombreTorneo.Location = new System.Drawing.Point(64, 44);
            this.labNombreTorneo.Name = "labNombreTorneo";
            this.labNombreTorneo.Size = new System.Drawing.Size(206, 22);
            this.labNombreTorneo.TabIndex = 2;
            this.labNombreTorneo.Text = "Nombre Torneo Aqui";
            // 
            // butListado
            // 
            this.butListado.FlatAppearance.BorderSize = 0;
            this.butListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butListado.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.butListado.Image = ((System.Drawing.Image)(resources.GetObject("butListado.Image")));
            this.butListado.Location = new System.Drawing.Point(164, 165);
            this.butListado.Name = "butListado";
            this.butListado.Size = new System.Drawing.Size(166, 180);
            this.butListado.TabIndex = 3;
            this.butListado.Text = "Listado";
            this.butListado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butListado.UseVisualStyleBackColor = true;
            this.butListado.Click += new System.EventHandler(this.ButListado_Click);
            // 
            // butVerificar
            // 
            this.butVerificar.FlatAppearance.BorderSize = 0;
            this.butVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVerificar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVerificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.butVerificar.Image = ((System.Drawing.Image)(resources.GetObject("butVerificar.Image")));
            this.butVerificar.Location = new System.Drawing.Point(379, 165);
            this.butVerificar.Name = "butVerificar";
            this.butVerificar.Size = new System.Drawing.Size(166, 180);
            this.butVerificar.TabIndex = 4;
            this.butVerificar.Text = "Verificar asistencia";
            this.butVerificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butVerificar.UseVisualStyleBackColor = true;
            this.butVerificar.Click += new System.EventHandler(this.ButVerificar_Click);
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(472, 399);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 5;
            // 
            // CompetidoresController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.controlButtons1);
            this.Controls.Add(this.butVerificar);
            this.Controls.Add(this.butListado);
            this.Controls.Add(this.labNombreTorneo);
            this.Name = "CompetidoresController";
            this.Size = new System.Drawing.Size(706, 519);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNombreTorneo;
        private System.Windows.Forms.Button butListado;
        private System.Windows.Forms.Button butVerificar;
        public ControlButtons controlButtons1;
    }
}
