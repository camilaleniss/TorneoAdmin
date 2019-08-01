namespace TorneoApp
{
    partial class Inicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.butNew = new System.Windows.Forms.Button();
            this.butLast = new System.Windows.Forms.Button();
            this.butLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(283, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo Admin";
            // 
            // butNew
            // 
            this.butNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(164)))), ((int)(((byte)(159)))));
            this.butNew.FlatAppearance.BorderSize = 0;
            this.butNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNew.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNew.ForeColor = System.Drawing.Color.White;
            this.butNew.Location = new System.Drawing.Point(359, 342);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(164, 33);
            this.butNew.TabIndex = 1;
            this.butNew.Text = "Nuevo Torneo";
            this.butNew.UseVisualStyleBackColor = false;
            this.butNew.Click += new System.EventHandler(this.ButNew_Click);
            // 
            // butLast
            // 
            this.butLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            this.butLast.FlatAppearance.BorderSize = 0;
            this.butLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLast.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLast.ForeColor = System.Drawing.Color.White;
            this.butLast.Location = new System.Drawing.Point(359, 411);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(164, 33);
            this.butLast.TabIndex = 2;
            this.butLast.Text = "Torneo Guardado";
            this.butLast.UseVisualStyleBackColor = false;
            this.butLast.Click += new System.EventHandler(this.ButLast_Click);
            // 
            // butLogOut
            // 
            this.butLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLogOut.BackgroundImage")));
            this.butLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLogOut.FlatAppearance.BorderSize = 0;
            this.butLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogOut.Location = new System.Drawing.Point(812, 12);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(40, 50);
            this.butLogOut.TabIndex = 6;
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Click += new System.EventHandler(this.ButLogOut_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 575);
            this.Controls.Add(this.butLogOut);
            this.Controls.Add(this.butLast);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button butLast;
        private System.Windows.Forms.Button butLogOut;
    }
}

