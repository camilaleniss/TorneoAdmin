namespace TorneoApp.ControlUsers
{
    partial class ConfirmarView
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
            this.labNombreTorneo = new System.Windows.Forms.Label();
            this.listCompetidores = new System.Windows.Forms.ListView();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.butConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNombreTorneo
            // 
            this.labNombreTorneo.AutoSize = true;
            this.labNombreTorneo.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreTorneo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNombreTorneo.Location = new System.Drawing.Point(25, 29);
            this.labNombreTorneo.Name = "labNombreTorneo";
            this.labNombreTorneo.Size = new System.Drawing.Size(226, 48);
            this.labNombreTorneo.TabIndex = 0;
            this.labNombreTorneo.Text = "Nombre Torneo Aquí\r\n\r\n";
            this.labNombreTorneo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listCompetidores
            // 
            this.listCompetidores.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listCompetidores.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompetidores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.listCompetidores.Location = new System.Drawing.Point(29, 80);
            this.listCompetidores.Name = "listCompetidores";
            this.listCompetidores.Size = new System.Drawing.Size(422, 421);
            this.listCompetidores.TabIndex = 2;
            this.listCompetidores.UseCompatibleStateImageBehavior = false;
            this.listCompetidores.View = System.Windows.Forms.View.List;
            this.listCompetidores.SelectedIndexChanged += new System.EventHandler(this.ListCompetidores_SelectedIndexChanged);
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(457, 381);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 1;
            // 
            // butConfirmar
            // 
            this.butConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(224)))), ((int)(((byte)(146)))));
            this.butConfirmar.FlatAppearance.BorderSize = 0;
            this.butConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConfirmar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConfirmar.ForeColor = System.Drawing.Color.White;
            this.butConfirmar.Location = new System.Drawing.Point(504, 347);
            this.butConfirmar.Name = "butConfirmar";
            this.butConfirmar.Size = new System.Drawing.Size(140, 28);
            this.butConfirmar.TabIndex = 3;
            this.butConfirmar.Text = "Confirmar";
            this.butConfirmar.UseVisualStyleBackColor = false;
            this.butConfirmar.Click += new System.EventHandler(this.ButConfirmar_Click);
            // 
            // ConfirmarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.butConfirmar);
            this.Controls.Add(this.listCompetidores);
            this.Controls.Add(this.controlButtons1);
            this.Controls.Add(this.labNombreTorneo);
            this.Name = "ConfirmarView";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.ImportarView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNombreTorneo;
        public ControlButtons controlButtons1;
        private System.Windows.Forms.ListView listCompetidores;
        private System.Windows.Forms.Button butConfirmar;
    }
}
