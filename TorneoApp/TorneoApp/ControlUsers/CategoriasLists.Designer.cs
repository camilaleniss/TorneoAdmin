namespace TorneoApp.ControlUsers
{
    partial class CategoriasLists
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
            this.listCategorias = new System.Windows.Forms.ListView();
            this.labCategoria = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listCompetidores = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butCambiar = new System.Windows.Forms.Button();
            this.labEdad = new System.Windows.Forms.Label();
            this.labNivel = new System.Windows.Forms.Label();
            this.labPeso = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.labEscuela = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.listCategorias);
            this.panel1.Controls.Add(this.labCategoria);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 254);
            this.panel1.TabIndex = 0;
            // 
            // listCategorias
            // 
            this.listCategorias.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listCategorias.Location = new System.Drawing.Point(21, 53);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Size = new System.Drawing.Size(376, 187);
            this.listCategorias.TabIndex = 1;
            this.listCategorias.UseCompatibleStateImageBehavior = false;
            this.listCategorias.View = System.Windows.Forms.View.List;
            this.listCategorias.SelectedIndexChanged += new System.EventHandler(this.ListCategorias_SelectedIndexChanged);
            // 
            // labCategoria
            // 
            this.labCategoria.AutoSize = true;
            this.labCategoria.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labCategoria.Location = new System.Drawing.Point(17, 17);
            this.labCategoria.Name = "labCategoria";
            this.labCategoria.Size = new System.Drawing.Size(109, 22);
            this.labCategoria.TabIndex = 0;
            this.labCategoria.Text = "Categorias";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.panel2.Controls.Add(this.listCompetidores);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 220);
            this.panel2.TabIndex = 2;
            // 
            // listCompetidores
            // 
            this.listCompetidores.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listCompetidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompetidores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listCompetidores.Location = new System.Drawing.Point(21, 42);
            this.listCompetidores.Name = "listCompetidores";
            this.listCompetidores.Size = new System.Drawing.Size(376, 163);
            this.listCompetidores.TabIndex = 1;
            this.listCompetidores.UseCompatibleStateImageBehavior = false;
            this.listCompetidores.View = System.Windows.Forms.View.List;
            this.listCompetidores.SelectedIndexChanged += new System.EventHandler(this.ListCompetidores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Competidores";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.labEscuela);
            this.panel3.Controls.Add(this.butCambiar);
            this.panel3.Controls.Add(this.labEdad);
            this.panel3.Controls.Add(this.labNivel);
            this.panel3.Controls.Add(this.labPeso);
            this.panel3.Controls.Add(this.labNombre);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(455, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 363);
            this.panel3.TabIndex = 3;
            // 
            // butCambiar
            // 
            this.butCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butCambiar.FlatAppearance.BorderSize = 0;
            this.butCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCambiar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCambiar.ForeColor = System.Drawing.Color.White;
            this.butCambiar.Location = new System.Drawing.Point(50, 298);
            this.butCambiar.Name = "butCambiar";
            this.butCambiar.Size = new System.Drawing.Size(137, 53);
            this.butCambiar.TabIndex = 8;
            this.butCambiar.Text = "Cambiar categoria";
            this.butCambiar.UseVisualStyleBackColor = false;
            this.butCambiar.Click += new System.EventHandler(this.ButCambiar_Click);
            // 
            // labEdad
            // 
            this.labEdad.AutoSize = true;
            this.labEdad.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labEdad.Location = new System.Drawing.Point(18, 173);
            this.labEdad.Name = "labEdad";
            this.labEdad.Size = new System.Drawing.Size(48, 18);
            this.labEdad.TabIndex = 6;
            this.labEdad.Text = "Edad";
            // 
            // labNivel
            // 
            this.labNivel.AutoSize = true;
            this.labNivel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNivel.Location = new System.Drawing.Point(18, 222);
            this.labNivel.Name = "labNivel";
            this.labNivel.Size = new System.Drawing.Size(49, 18);
            this.labNivel.TabIndex = 5;
            this.labNivel.Text = "Nivel";
            this.labNivel.Click += new System.EventHandler(this.Label6_Click);
            // 
            // labPeso
            // 
            this.labPeso.AutoSize = true;
            this.labPeso.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labPeso.Location = new System.Drawing.Point(18, 122);
            this.labPeso.Name = "labPeso";
            this.labPeso.Size = new System.Drawing.Size(44, 18);
            this.labPeso.TabIndex = 4;
            this.labPeso.Text = "Peso";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNombre.Location = new System.Drawing.Point(18, 76);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(68, 18);
            this.labNombre.TabIndex = 3;
            this.labNombre.Text = "Nombre";
            this.labNombre.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Competidor";
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(455, 383);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 4;
            this.controlButtons1.Load += new System.EventHandler(this.ControlButtons1_Load);
            // 
            // labEscuela
            // 
            this.labEscuela.AutoSize = true;
            this.labEscuela.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labEscuela.Location = new System.Drawing.Point(17, 269);
            this.labEscuela.Name = "labEscuela";
            this.labEscuela.Size = new System.Drawing.Size(66, 18);
            this.labEscuela.TabIndex = 9;
            this.labEscuela.Text = "Escuela";
            // 
            // CategoriasLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.controlButtons1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoriasLists";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.CategoriasLists_Load);
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
        private System.Windows.Forms.ListView listCategorias;
        private System.Windows.Forms.Label labCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listCompetidores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labPeso;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label label3;
        private ControlButtons controlButtons1;
        private System.Windows.Forms.Button butCambiar;
        private System.Windows.Forms.Label labEdad;
        private System.Windows.Forms.Label labNivel;
        private System.Windows.Forms.Label labEscuela;
    }
}
