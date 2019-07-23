namespace TorneoApp.Gui
{
    partial class CambiarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCategorias = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.butIniciar = new System.Windows.Forms.Button();
            this.butSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCategorias
            // 
            this.listCategorias.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listCategorias.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.listCategorias.Location = new System.Drawing.Point(30, 65);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Size = new System.Drawing.Size(361, 122);
            this.listCategorias.TabIndex = 0;
            this.listCategorias.UseCompatibleStateImageBehavior = false;
            this.listCategorias.View = System.Windows.Forms.View.List;
            this.listCategorias.SelectedIndexChanged += new System.EventHandler(this.ListCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona la categoria a la que deseas\r\nmover el competidor";
            // 
            // butIniciar
            // 
            this.butIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.butIniciar.FlatAppearance.BorderSize = 0;
            this.butIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIniciar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIniciar.ForeColor = System.Drawing.Color.White;
            this.butIniciar.Location = new System.Drawing.Point(52, 210);
            this.butIniciar.Name = "butIniciar";
            this.butIniciar.Size = new System.Drawing.Size(140, 28);
            this.butIniciar.TabIndex = 2;
            this.butIniciar.Text = "Mover";
            this.butIniciar.UseVisualStyleBackColor = false;
            this.butIniciar.Click += new System.EventHandler(this.ButIniciar_Click);
            // 
            // butSaveChanges
            // 
            this.butSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            this.butSaveChanges.FlatAppearance.BorderSize = 0;
            this.butSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSaveChanges.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSaveChanges.ForeColor = System.Drawing.Color.White;
            this.butSaveChanges.Location = new System.Drawing.Point(239, 210);
            this.butSaveChanges.Name = "butSaveChanges";
            this.butSaveChanges.Size = new System.Drawing.Size(140, 28);
            this.butSaveChanges.TabIndex = 3;
            this.butSaveChanges.Text = "Cancelar";
            this.butSaveChanges.UseVisualStyleBackColor = false;
            this.butSaveChanges.Click += new System.EventHandler(this.ButSaveChanges_Click);
            // 
            // CambiarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 265);
            this.Controls.Add(this.butSaveChanges);
            this.Controls.Add(this.butIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarCategoria";
            this.Text = "CambiarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butIniciar;
        private System.Windows.Forms.Button butSaveChanges;
    }
}