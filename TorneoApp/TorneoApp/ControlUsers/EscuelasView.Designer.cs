namespace TorneoApp.ControlUsers
{
    partial class EscuelasView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listEscuelas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labPuntosFormas = new System.Windows.Forms.Label();
            this.labPuntosSanda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listCompetidores = new System.Windows.Forms.ListView();
            this.labNomEscuela = new System.Windows.Forms.Label();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.listEscuelas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 1;
            // 
            // listEscuelas
            // 
            this.listEscuelas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listEscuelas.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEscuelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.listEscuelas.Location = new System.Drawing.Point(20, 57);
            this.listEscuelas.Name = "listEscuelas";
            this.listEscuelas.Size = new System.Drawing.Size(163, 420);
            this.listEscuelas.TabIndex = 1;
            this.listEscuelas.UseCompatibleStateImageBehavior = false;
            this.listEscuelas.View = System.Windows.Forms.View.List;
            this.listEscuelas.SelectedIndexChanged += new System.EventHandler(this.ListEscuelas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escuelas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.panel2.Controls.Add(this.labPuntosFormas);
            this.panel2.Controls.Add(this.labPuntosSanda);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listCompetidores);
            this.panel2.Controls.Add(this.labNomEscuela);
            this.panel2.Location = new System.Drawing.Point(250, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 396);
            this.panel2.TabIndex = 2;
            // 
            // labPuntosFormas
            // 
            this.labPuntosFormas.AutoSize = true;
            this.labPuntosFormas.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPuntosFormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labPuntosFormas.Location = new System.Drawing.Point(395, 83);
            this.labPuntosFormas.Name = "labPuntosFormas";
            this.labPuntosFormas.Size = new System.Drawing.Size(22, 22);
            this.labPuntosFormas.TabIndex = 7;
            this.labPuntosFormas.Text = "0";
            // 
            // labPuntosSanda
            // 
            this.labPuntosSanda.AutoSize = true;
            this.labPuntosSanda.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPuntosSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labPuntosSanda.Location = new System.Drawing.Point(395, 20);
            this.labPuntosSanda.Name = "labPuntosSanda";
            this.labPuntosSanda.Size = new System.Drawing.Size(22, 22);
            this.labPuntosSanda.TabIndex = 6;
            this.labPuntosSanda.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(235, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puntos formas";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(235, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puntos sanda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Competidores";
            // 
            // listCompetidores
            // 
            this.listCompetidores.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listCompetidores.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompetidores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.listCompetidores.Location = new System.Drawing.Point(22, 131);
            this.listCompetidores.Name = "listCompetidores";
            this.listCompetidores.Size = new System.Drawing.Size(395, 250);
            this.listCompetidores.TabIndex = 2;
            this.listCompetidores.UseCompatibleStateImageBehavior = false;
            this.listCompetidores.View = System.Windows.Forms.View.List;
            this.listCompetidores.SelectedIndexChanged += new System.EventHandler(this.ListCompetidores_SelectedIndexChanged);
            // 
            // labNomEscuela
            // 
            this.labNomEscuela.AutoSize = true;
            this.labNomEscuela.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNomEscuela.Location = new System.Drawing.Point(18, 18);
            this.labNomEscuela.Name = "labNomEscuela";
            this.labNomEscuela.Size = new System.Drawing.Size(176, 24);
            this.labNomEscuela.TabIndex = 1;
            this.labNomEscuela.Text = "Nombre Escuela";
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(489, 414);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 3;
            // 
            // EscuelasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlButtons1);
            this.Name = "EscuelasView";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.EscuelasView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listEscuelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listCompetidores;
        private System.Windows.Forms.Label labNomEscuela;
        private System.Windows.Forms.Label labPuntosFormas;
        private System.Windows.Forms.Label labPuntosSanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ControlButtons controlButtons1;
    }
}
