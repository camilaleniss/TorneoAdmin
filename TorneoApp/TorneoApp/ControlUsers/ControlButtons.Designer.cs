namespace TorneoApp.ControlUsers
{
    partial class ControlButtons
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
            this.butSaveChanges = new System.Windows.Forms.Button();
            this.butIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butSaveChanges
            // 
            this.butSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            this.butSaveChanges.FlatAppearance.BorderSize = 0;
            this.butSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSaveChanges.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSaveChanges.ForeColor = System.Drawing.Color.White;
            this.butSaveChanges.Location = new System.Drawing.Point(46, 65);
            this.butSaveChanges.Name = "butSaveChanges";
            this.butSaveChanges.Size = new System.Drawing.Size(140, 28);
            this.butSaveChanges.TabIndex = 0;
            this.butSaveChanges.Text = "Guardar cambios";
            this.butSaveChanges.UseVisualStyleBackColor = false;
            this.butSaveChanges.Click += new System.EventHandler(this.ButSaveChanges_Click);
            // 
            // butIniciar
            // 
            this.butIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.butIniciar.FlatAppearance.BorderSize = 0;
            this.butIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIniciar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIniciar.ForeColor = System.Drawing.Color.White;
            this.butIniciar.Location = new System.Drawing.Point(46, 18);
            this.butIniciar.Name = "butIniciar";
            this.butIniciar.Size = new System.Drawing.Size(140, 28);
            this.butIniciar.TabIndex = 1;
            this.butIniciar.Text = "Iniciar";
            this.butIniciar.UseVisualStyleBackColor = false;
            // 
            // ControlButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.butIniciar);
            this.Controls.Add(this.butSaveChanges);
            this.Name = "ControlButtons";
            this.Size = new System.Drawing.Size(234, 120);
            this.Load += new System.EventHandler(this.ControlButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSaveChanges;
        private System.Windows.Forms.Button butIniciar;
    }
}
