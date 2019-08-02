namespace TorneoApp.ControlUsers
{
    partial class Ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listFormas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listSanda = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labNumBronce = new System.Windows.Forms.Label();
            this.labNumPlata = new System.Windows.Forms.Label();
            this.labNumOro = new System.Windows.Forms.Label();
            this.butBronce = new System.Windows.Forms.Button();
            this.butPlata = new System.Windows.Forms.Button();
            this.butOro = new System.Windows.Forms.Button();
            this.listCompetidores = new System.Windows.Forms.ListView();
            this.labNomEscuela = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.listFormas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 0;
            // 
            // listFormas
            // 
            this.listFormas.Location = new System.Drawing.Point(26, 72);
            this.listFormas.Name = "listFormas";
            this.listFormas.Size = new System.Drawing.Size(148, 408);
            this.listFormas.TabIndex = 1;
            this.listFormas.UseCompatibleStateImageBehavior = false;
            this.listFormas.SelectedIndexChanged += new System.EventHandler(this.ListFormas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.panel2.Controls.Add(this.listSanda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(258, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 495);
            this.panel2.TabIndex = 2;
            // 
            // listSanda
            // 
            this.listSanda.Location = new System.Drawing.Point(26, 72);
            this.listSanda.Name = "listSanda";
            this.listSanda.Size = new System.Drawing.Size(148, 408);
            this.listSanda.TabIndex = 1;
            this.listSanda.UseCompatibleStateImageBehavior = false;
            this.listSanda.SelectedIndexChanged += new System.EventHandler(this.ListSanda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sanda";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.panel3.Controls.Add(this.labNumBronce);
            this.panel3.Controls.Add(this.labNumPlata);
            this.panel3.Controls.Add(this.labNumOro);
            this.panel3.Controls.Add(this.butBronce);
            this.panel3.Controls.Add(this.butPlata);
            this.panel3.Controls.Add(this.butOro);
            this.panel3.Controls.Add(this.listCompetidores);
            this.panel3.Controls.Add(this.labNomEscuela);
            this.panel3.Location = new System.Drawing.Point(483, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 495);
            this.panel3.TabIndex = 3;
            // 
            // labNumBronce
            // 
            this.labNumBronce.AutoSize = true;
            this.labNumBronce.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumBronce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumBronce.Location = new System.Drawing.Point(129, 243);
            this.labNumBronce.Name = "labNumBronce";
            this.labNumBronce.Size = new System.Drawing.Size(23, 24);
            this.labNumBronce.TabIndex = 7;
            this.labNumBronce.Text = "0";
            // 
            // labNumPlata
            // 
            this.labNumPlata.AutoSize = true;
            this.labNumPlata.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumPlata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumPlata.Location = new System.Drawing.Point(129, 168);
            this.labNumPlata.Name = "labNumPlata";
            this.labNumPlata.Size = new System.Drawing.Size(23, 24);
            this.labNumPlata.TabIndex = 6;
            this.labNumPlata.Text = "0";
            // 
            // labNumOro
            // 
            this.labNumOro.AutoSize = true;
            this.labNumOro.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumOro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumOro.Location = new System.Drawing.Point(129, 93);
            this.labNumOro.Name = "labNumOro";
            this.labNumOro.Size = new System.Drawing.Size(23, 24);
            this.labNumOro.TabIndex = 5;
            this.labNumOro.Text = "0";
            // 
            // butBronce
            // 
            this.butBronce.FlatAppearance.BorderSize = 0;
            this.butBronce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBronce.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBronce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.butBronce.Image = ((System.Drawing.Image)(resources.GetObject("butBronce.Image")));
            this.butBronce.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butBronce.Location = new System.Drawing.Point(25, 222);
            this.butBronce.Name = "butBronce";
            this.butBronce.Size = new System.Drawing.Size(75, 69);
            this.butBronce.TabIndex = 4;
            this.butBronce.Text = "Bronce";
            this.butBronce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butBronce.UseVisualStyleBackColor = true;
            // 
            // butPlata
            // 
            this.butPlata.FlatAppearance.BorderSize = 0;
            this.butPlata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPlata.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPlata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.butPlata.Image = ((System.Drawing.Image)(resources.GetObject("butPlata.Image")));
            this.butPlata.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butPlata.Location = new System.Drawing.Point(25, 147);
            this.butPlata.Name = "butPlata";
            this.butPlata.Size = new System.Drawing.Size(75, 69);
            this.butPlata.TabIndex = 3;
            this.butPlata.Text = "Plata";
            this.butPlata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butPlata.UseVisualStyleBackColor = true;
            // 
            // butOro
            // 
            this.butOro.FlatAppearance.BorderSize = 0;
            this.butOro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOro.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.butOro.Image = ((System.Drawing.Image)(resources.GetObject("butOro.Image")));
            this.butOro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butOro.Location = new System.Drawing.Point(25, 72);
            this.butOro.Name = "butOro";
            this.butOro.Size = new System.Drawing.Size(75, 69);
            this.butOro.TabIndex = 2;
            this.butOro.Text = "Oro";
            this.butOro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butOro.UseVisualStyleBackColor = true;
            // 
            // listCompetidores
            // 
            this.listCompetidores.Location = new System.Drawing.Point(25, 315);
            this.listCompetidores.Name = "listCompetidores";
            this.listCompetidores.Size = new System.Drawing.Size(148, 165);
            this.listCompetidores.TabIndex = 1;
            this.listCompetidores.UseCompatibleStateImageBehavior = false;
            this.listCompetidores.View = System.Windows.Forms.View.Tile;
            // 
            // labNomEscuela
            // 
            this.labNomEscuela.AutoSize = true;
            this.labNomEscuela.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNomEscuela.Location = new System.Drawing.Point(12, 23);
            this.labNomEscuela.Name = "labNomEscuela";
            this.labNomEscuela.Size = new System.Drawing.Size(176, 24);
            this.labNomEscuela.TabIndex = 0;
            this.labNomEscuela.Text = "Nombre Escuela";
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Ranking";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.Ranking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listFormas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listSanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labNumBronce;
        private System.Windows.Forms.Label labNumPlata;
        private System.Windows.Forms.Label labNumOro;
        private System.Windows.Forms.Button butBronce;
        private System.Windows.Forms.Button butPlata;
        private System.Windows.Forms.Button butOro;
        private System.Windows.Forms.ListView listCompetidores;
        private System.Windows.Forms.Label labNomEscuela;
    }
}
