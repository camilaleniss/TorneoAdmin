namespace TorneoApp.ControlUsers
{
    partial class CompetenciaController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetenciaController));
            this.butSanda = new System.Windows.Forms.Button();
            this.labNombreTorneo = new System.Windows.Forms.Label();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.butFormas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butSanda
            // 
            this.butSanda.FlatAppearance.BorderSize = 0;
            this.butSanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSanda.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.butSanda.Image = ((System.Drawing.Image)(resources.GetObject("butSanda.Image")));
            this.butSanda.Location = new System.Drawing.Point(151, 190);
            this.butSanda.Name = "butSanda";
            this.butSanda.Size = new System.Drawing.Size(166, 158);
            this.butSanda.TabIndex = 0;
            this.butSanda.Text = "Sanda";
            this.butSanda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butSanda.UseVisualStyleBackColor = true;
            this.butSanda.Click += new System.EventHandler(this.ButSanda_Click);
            // 
            // labNombreTorneo
            // 
            this.labNombreTorneo.AutoSize = true;
            this.labNombreTorneo.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreTorneo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNombreTorneo.Location = new System.Drawing.Point(50, 54);
            this.labNombreTorneo.Name = "labNombreTorneo";
            this.labNombreTorneo.Size = new System.Drawing.Size(206, 22);
            this.labNombreTorneo.TabIndex = 1;
            this.labNombreTorneo.Text = "Nombre Torneo Aqui";
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(472, 399);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 2;
            // 
            // butFormas
            // 
            this.butFormas.FlatAppearance.BorderSize = 0;
            this.butFormas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFormas.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.butFormas.Image = ((System.Drawing.Image)(resources.GetObject("butFormas.Image")));
            this.butFormas.Location = new System.Drawing.Point(373, 190);
            this.butFormas.Name = "butFormas";
            this.butFormas.Size = new System.Drawing.Size(166, 158);
            this.butFormas.TabIndex = 3;
            this.butFormas.Text = "Formas";
            this.butFormas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butFormas.UseVisualStyleBackColor = true;
            this.butFormas.Click += new System.EventHandler(this.ButFormas_Click);
            // 
            // CompetenciaController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.butFormas);
            this.Controls.Add(this.controlButtons1);
            this.Controls.Add(this.labNombreTorneo);
            this.Controls.Add(this.butSanda);
            this.Name = "CompetenciaController";
            this.Size = new System.Drawing.Size(706, 519);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSanda;
        private System.Windows.Forms.Label labNombreTorneo;
        public ControlButtons controlButtons1;
        private System.Windows.Forms.Button butFormas;
    }
}
