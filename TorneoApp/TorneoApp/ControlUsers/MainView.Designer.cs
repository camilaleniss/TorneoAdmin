namespace TorneoApp.ControlUsers
{
    partial class MainView
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
            this.labBienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCompetidores = new System.Windows.Forms.Label();
            this.labNumCompetidores = new System.Windows.Forms.Label();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labBienvenida
            // 
            this.labBienvenida.AutoSize = true;
            this.labBienvenida.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labBienvenida.Location = new System.Drawing.Point(27, 31);
            this.labBienvenida.Name = "labBienvenida";
            this.labBienvenida.Size = new System.Drawing.Size(398, 68);
            this.labBienvenida.TabIndex = 0;
            this.labBienvenida.Text = "Bienvenido al dashboard del \r\nInserte Nombre Torneo Aqui";
            this.labBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labBienvenida.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.labNumCompetidores);
            this.panel1.Controls.Add(this.labCompetidores);
            this.panel1.Location = new System.Drawing.Point(42, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 117);
            this.panel1.TabIndex = 1;
            // 
            // labCompetidores
            // 
            this.labCompetidores.AutoSize = true;
            this.labCompetidores.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCompetidores.ForeColor = System.Drawing.Color.White;
            this.labCompetidores.Location = new System.Drawing.Point(23, 19);
            this.labCompetidores.Name = "labCompetidores";
            this.labCompetidores.Size = new System.Drawing.Size(141, 22);
            this.labCompetidores.TabIndex = 0;
            this.labCompetidores.Text = "Competidores";
            this.labCompetidores.Click += new System.EventHandler(this.LabCategorias_Click);
            // 
            // labNumCompetidores
            // 
            this.labNumCompetidores.AutoSize = true;
            this.labNumCompetidores.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumCompetidores.ForeColor = System.Drawing.Color.White;
            this.labNumCompetidores.Location = new System.Drawing.Point(185, 70);
            this.labNumCompetidores.Name = "labNumCompetidores";
            this.labNumCompetidores.Size = new System.Drawing.Size(22, 22);
            this.labNumCompetidores.TabIndex = 1;
            this.labNumCompetidores.Text = "0";
            this.labNumCompetidores.Click += new System.EventHandler(this.LabNumCategorias_Click);
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(472, 0);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 2;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.controlButtons1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labBienvenida);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labNumCompetidores;
        private System.Windows.Forms.Label labCompetidores;
        private ControlButtons controlButtons1;
    }
}
