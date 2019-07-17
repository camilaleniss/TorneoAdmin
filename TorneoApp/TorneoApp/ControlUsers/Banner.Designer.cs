namespace TorneoApp.ControlUsers
{
    partial class Banner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banner));
            this.labInicio = new System.Windows.Forms.Label();
            this.labArrow1 = new System.Windows.Forms.Label();
            this.labCategoria = new System.Windows.Forms.Label();
            this.labArrow2 = new System.Windows.Forms.Label();
            this.labSubCat = new System.Windows.Forms.Label();
            this.butLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labInicio
            // 
            this.labInicio.AutoSize = true;
            this.labInicio.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.labInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labInicio.Location = new System.Drawing.Point(18, 19);
            this.labInicio.Name = "labInicio";
            this.labInicio.Size = new System.Drawing.Size(62, 22);
            this.labInicio.TabIndex = 0;
            this.labInicio.Text = "Inicio";
            this.labInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labInicio.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labArrow1
            // 
            this.labArrow1.AutoSize = true;
            this.labArrow1.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.labArrow1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(164)))), ((int)(((byte)(159)))));
            this.labArrow1.Location = new System.Drawing.Point(98, 19);
            this.labArrow1.Name = "labArrow1";
            this.labArrow1.Size = new System.Drawing.Size(22, 22);
            this.labArrow1.TabIndex = 1;
            this.labArrow1.Text = ">";
            this.labArrow1.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labCategoria
            // 
            this.labCategoria.AutoSize = true;
            this.labCategoria.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.labCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labCategoria.Location = new System.Drawing.Point(140, 19);
            this.labCategoria.Name = "labCategoria";
            this.labCategoria.Size = new System.Drawing.Size(99, 22);
            this.labCategoria.TabIndex = 2;
            this.labCategoria.Text = "Categoria";
            this.labCategoria.Click += new System.EventHandler(this.Label3_Click);
            // 
            // labArrow2
            // 
            this.labArrow2.AutoSize = true;
            this.labArrow2.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.labArrow2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(164)))), ((int)(((byte)(159)))));
            this.labArrow2.Location = new System.Drawing.Point(260, 19);
            this.labArrow2.Name = "labArrow2";
            this.labArrow2.Size = new System.Drawing.Size(22, 22);
            this.labArrow2.TabIndex = 3;
            this.labArrow2.Text = ">";
            // 
            // labSubCat
            // 
            this.labSubCat.AutoSize = true;
            this.labSubCat.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.labSubCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labSubCat.Location = new System.Drawing.Point(288, 19);
            this.labSubCat.Name = "labSubCat";
            this.labSubCat.Size = new System.Drawing.Size(133, 22);
            this.labSubCat.TabIndex = 4;
            this.labSubCat.Text = "SubCategoria";
            this.labSubCat.Click += new System.EventHandler(this.Label5_Click);
            // 
            // butLogOut
            // 
            this.butLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLogOut.BackgroundImage")));
            this.butLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLogOut.FlatAppearance.BorderSize = 0;
            this.butLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogOut.Location = new System.Drawing.Point(663, 3);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(40, 50);
            this.butLogOut.TabIndex = 5;
            this.butLogOut.UseVisualStyleBackColor = true;
            // 
            // Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.butLogOut);
            this.Controls.Add(this.labSubCat);
            this.Controls.Add(this.labArrow2);
            this.Controls.Add(this.labCategoria);
            this.Controls.Add(this.labArrow1);
            this.Controls.Add(this.labInicio);
            this.Name = "Banner";
            this.Size = new System.Drawing.Size(706, 56);
            this.Load += new System.EventHandler(this.Banner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInicio;
        private System.Windows.Forms.Label labArrow1;
        private System.Windows.Forms.Label labCategoria;
        private System.Windows.Forms.Label labArrow2;
        private System.Windows.Forms.Label labSubCat;
        private System.Windows.Forms.Button butLogOut;
    }
}
