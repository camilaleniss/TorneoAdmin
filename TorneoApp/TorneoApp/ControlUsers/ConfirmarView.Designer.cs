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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmarView));
            this.labNombreTorneo = new System.Windows.Forms.Label();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.button1 = new System.Windows.Forms.Button();
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
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(457, 381);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(102, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Importar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConfirmarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
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
        private ControlButtons controlButtons1;
        private System.Windows.Forms.Button button1;
    }
}
