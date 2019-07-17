namespace TorneoApp.ControlUsers
{
    partial class CategoriasView
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
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butVerSanda = new System.Windows.Forms.Button();
            this.labSanda = new System.Windows.Forms.Label();
            this.labExistsSanda = new System.Windows.Forms.Label();
            this.labOpenedSanda = new System.Windows.Forms.Label();
            this.labFinishedSanda = new System.Windows.Forms.Label();
            this.labNumExistsSanda = new System.Windows.Forms.Label();
            this.labNumOpenedSanda = new System.Windows.Forms.Label();
            this.labNumFinishedSanda = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labFinishedFormas = new System.Windows.Forms.Label();
            this.labNumOpenedFormas = new System.Windows.Forms.Label();
            this.labNumExistsFormas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butVerFormas = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(472, 0);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labNumFinishedSanda);
            this.panel1.Controls.Add(this.labNumOpenedSanda);
            this.panel1.Controls.Add(this.labNumExistsSanda);
            this.panel1.Controls.Add(this.labFinishedSanda);
            this.panel1.Controls.Add(this.labOpenedSanda);
            this.panel1.Controls.Add(this.labExistsSanda);
            this.panel1.Controls.Add(this.labSanda);
            this.panel1.Controls.Add(this.butVerSanda);
            this.panel1.Location = new System.Drawing.Point(34, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 184);
            this.panel1.TabIndex = 1;
            // 
            // butVerSanda
            // 
            this.butVerSanda.Location = new System.Drawing.Point(297, 13);
            this.butVerSanda.Name = "butVerSanda";
            this.butVerSanda.Size = new System.Drawing.Size(75, 23);
            this.butVerSanda.TabIndex = 0;
            this.butVerSanda.Text = "Ir";
            this.butVerSanda.UseVisualStyleBackColor = true;
            // 
            // labSanda
            // 
            this.labSanda.AutoSize = true;
            this.labSanda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labSanda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labSanda.Location = new System.Drawing.Point(17, 13);
            this.labSanda.Name = "labSanda";
            this.labSanda.Size = new System.Drawing.Size(71, 24);
            this.labSanda.TabIndex = 1;
            this.labSanda.Text = "Sanda";
            // 
            // labExistsSanda
            // 
            this.labExistsSanda.AutoSize = true;
            this.labExistsSanda.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExistsSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labExistsSanda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labExistsSanda.Location = new System.Drawing.Point(17, 60);
            this.labExistsSanda.Name = "labExistsSanda";
            this.labExistsSanda.Size = new System.Drawing.Size(211, 22);
            this.labExistsSanda.TabIndex = 2;
            this.labExistsSanda.Text = "Categorias existentes";
            // 
            // labOpenedSanda
            // 
            this.labOpenedSanda.AutoSize = true;
            this.labOpenedSanda.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOpenedSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labOpenedSanda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labOpenedSanda.Location = new System.Drawing.Point(17, 98);
            this.labOpenedSanda.Name = "labOpenedSanda";
            this.labOpenedSanda.Size = new System.Drawing.Size(189, 22);
            this.labOpenedSanda.TabIndex = 3;
            this.labOpenedSanda.Text = "Categorias abiertas";
            // 
            // labFinishedSanda
            // 
            this.labFinishedSanda.AutoSize = true;
            this.labFinishedSanda.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinishedSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labFinishedSanda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labFinishedSanda.Location = new System.Drawing.Point(17, 134);
            this.labFinishedSanda.Name = "labFinishedSanda";
            this.labFinishedSanda.Size = new System.Drawing.Size(219, 22);
            this.labFinishedSanda.TabIndex = 4;
            this.labFinishedSanda.Text = "Categorias terminadas";
            // 
            // labNumExistsSanda
            // 
            this.labNumExistsSanda.AutoSize = true;
            this.labNumExistsSanda.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumExistsSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumExistsSanda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labNumExistsSanda.Location = new System.Drawing.Point(350, 60);
            this.labNumExistsSanda.Name = "labNumExistsSanda";
            this.labNumExistsSanda.Size = new System.Drawing.Size(22, 22);
            this.labNumExistsSanda.TabIndex = 5;
            this.labNumExistsSanda.Text = "0";
            this.labNumExistsSanda.Click += new System.EventHandler(this.Label5_Click);
            // 
            // labNumOpenedSanda
            // 
            this.labNumOpenedSanda.AutoSize = true;
            this.labNumOpenedSanda.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumOpenedSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumOpenedSanda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labNumOpenedSanda.Location = new System.Drawing.Point(350, 98);
            this.labNumOpenedSanda.Name = "labNumOpenedSanda";
            this.labNumOpenedSanda.Size = new System.Drawing.Size(22, 22);
            this.labNumOpenedSanda.TabIndex = 6;
            this.labNumOpenedSanda.Text = "0";
            // 
            // labNumFinishedSanda
            // 
            this.labNumFinishedSanda.AutoSize = true;
            this.labNumFinishedSanda.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumFinishedSanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumFinishedSanda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labNumFinishedSanda.Location = new System.Drawing.Point(350, 134);
            this.labNumFinishedSanda.Name = "labNumFinishedSanda";
            this.labNumFinishedSanda.Size = new System.Drawing.Size(22, 22);
            this.labNumFinishedSanda.TabIndex = 7;
            this.labNumFinishedSanda.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labFinishedFormas);
            this.panel2.Controls.Add(this.labNumOpenedFormas);
            this.panel2.Controls.Add(this.labNumExistsFormas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.butVerFormas);
            this.panel2.Location = new System.Drawing.Point(34, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 184);
            this.panel2.TabIndex = 8;
            // 
            // labFinishedFormas
            // 
            this.labFinishedFormas.AutoSize = true;
            this.labFinishedFormas.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinishedFormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labFinishedFormas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labFinishedFormas.Location = new System.Drawing.Point(350, 134);
            this.labFinishedFormas.Name = "labFinishedFormas";
            this.labFinishedFormas.Size = new System.Drawing.Size(22, 22);
            this.labFinishedFormas.TabIndex = 7;
            this.labFinishedFormas.Text = "0";
            // 
            // labNumOpenedFormas
            // 
            this.labNumOpenedFormas.AutoSize = true;
            this.labNumOpenedFormas.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumOpenedFormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumOpenedFormas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labNumOpenedFormas.Location = new System.Drawing.Point(350, 98);
            this.labNumOpenedFormas.Name = "labNumOpenedFormas";
            this.labNumOpenedFormas.Size = new System.Drawing.Size(22, 22);
            this.labNumOpenedFormas.TabIndex = 6;
            this.labNumOpenedFormas.Text = "0";
            // 
            // labNumExistsFormas
            // 
            this.labNumExistsFormas.AutoSize = true;
            this.labNumExistsFormas.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumExistsFormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumExistsFormas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labNumExistsFormas.Location = new System.Drawing.Point(350, 60);
            this.labNumExistsFormas.Name = "labNumExistsFormas";
            this.labNumExistsFormas.Size = new System.Drawing.Size(22, 22);
            this.labNumExistsFormas.TabIndex = 5;
            this.labNumExistsFormas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categorias terminadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(17, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Categorias abiertas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(17, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Categorias existentes";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Formas";
            // 
            // butVerFormas
            // 
            this.butVerFormas.Location = new System.Drawing.Point(297, 13);
            this.butVerFormas.Name = "butVerFormas";
            this.butVerFormas.Size = new System.Drawing.Size(75, 23);
            this.butVerFormas.TabIndex = 0;
            this.butVerFormas.Text = "Ir";
            this.butVerFormas.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(472, 118);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(209, 381);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del Torneo aquí";
            // 
            // CategoriasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlButtons1);
            this.Name = "CategoriasView";
            this.Size = new System.Drawing.Size(706, 519);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlButtons controlButtons1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labNumExistsSanda;
        private System.Windows.Forms.Label labFinishedSanda;
        private System.Windows.Forms.Label labOpenedSanda;
        private System.Windows.Forms.Label labExistsSanda;
        private System.Windows.Forms.Label labSanda;
        private System.Windows.Forms.Button butVerSanda;
        private System.Windows.Forms.Label labNumFinishedSanda;
        private System.Windows.Forms.Label labNumOpenedSanda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labFinishedFormas;
        private System.Windows.Forms.Label labNumOpenedFormas;
        private System.Windows.Forms.Label labNumExistsFormas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butVerFormas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}
