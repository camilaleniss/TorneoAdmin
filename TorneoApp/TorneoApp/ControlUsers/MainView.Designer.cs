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
            this.labNumCat = new System.Windows.Forms.Label();
            this.labCompetidores = new System.Windows.Forms.Label();
            this.controlButtons1 = new TorneoApp.ControlUsers.ControlButtons();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labNumComp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listFormas = new System.Windows.Forms.ListView();
            this.labNumEscuelas = new System.Windows.Forms.Label();
            this.labNumFormas = new System.Windows.Forms.Label();
            this.listEscuelas = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(232)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.labNumCat);
            this.panel1.Controls.Add(this.labCompetidores);
            this.panel1.Location = new System.Drawing.Point(42, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 158);
            this.panel1.TabIndex = 1;
            // 
            // labNumCat
            // 
            this.labNumCat.AutoSize = true;
            this.labNumCat.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumCat.Location = new System.Drawing.Point(207, 101);
            this.labNumCat.Name = "labNumCat";
            this.labNumCat.Size = new System.Drawing.Size(23, 24);
            this.labNumCat.TabIndex = 1;
            this.labNumCat.Text = "0";
            this.labNumCat.Click += new System.EventHandler(this.LabNumCategorias_Click);
            // 
            // labCompetidores
            // 
            this.labCompetidores.AutoSize = true;
            this.labCompetidores.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCompetidores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labCompetidores.Location = new System.Drawing.Point(20, 26);
            this.labCompetidores.Name = "labCompetidores";
            this.labCompetidores.Size = new System.Drawing.Size(121, 24);
            this.labCompetidores.TabIndex = 0;
            this.labCompetidores.Text = "Categorias";
            this.labCompetidores.Click += new System.EventHandler(this.LabCategorias_Click);
            // 
            // controlButtons1
            // 
            this.controlButtons1.BackColor = System.Drawing.Color.White;
            this.controlButtons1.Location = new System.Drawing.Point(472, 0);
            this.controlButtons1.Name = "controlButtons1";
            this.controlButtons1.Size = new System.Drawing.Size(234, 120);
            this.controlButtons1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.panel2.Controls.Add(this.listEscuelas);
            this.panel2.Controls.Add(this.labNumEscuelas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(42, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 198);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Competidores";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.panel3.Controls.Add(this.labNumComp);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(395, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 158);
            this.panel3.TabIndex = 2;
            // 
            // labNumComp
            // 
            this.labNumComp.AutoSize = true;
            this.labNumComp.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumComp.Location = new System.Drawing.Point(207, 101);
            this.labNumComp.Name = "labNumComp";
            this.labNumComp.Size = new System.Drawing.Size(23, 24);
            this.labNumComp.TabIndex = 1;
            this.labNumComp.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Escuelas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(162)))));
            this.panel4.Controls.Add(this.labNumFormas);
            this.panel4.Controls.Add(this.listFormas);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(395, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 198);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(20, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Formas abiertas";
            // 
            // listFormas
            // 
            this.listFormas.Location = new System.Drawing.Point(24, 53);
            this.listFormas.Name = "listFormas";
            this.listFormas.Size = new System.Drawing.Size(219, 130);
            this.listFormas.TabIndex = 1;
            this.listFormas.UseCompatibleStateImageBehavior = false;
            // 
            // labNumEscuelas
            // 
            this.labNumEscuelas.AutoSize = true;
            this.labNumEscuelas.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumEscuelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumEscuelas.Location = new System.Drawing.Point(207, 26);
            this.labNumEscuelas.Name = "labNumEscuelas";
            this.labNumEscuelas.Size = new System.Drawing.Size(23, 24);
            this.labNumEscuelas.TabIndex = 1;
            this.labNumEscuelas.Text = "0";
            // 
            // labNumFormas
            // 
            this.labNumFormas.AutoSize = true;
            this.labNumFormas.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumFormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labNumFormas.Location = new System.Drawing.Point(207, 26);
            this.labNumFormas.Name = "labNumFormas";
            this.labNumFormas.Size = new System.Drawing.Size(23, 24);
            this.labNumFormas.TabIndex = 2;
            this.labNumFormas.Text = "0";
            // 
            // listEscuelas
            // 
            this.listEscuelas.Location = new System.Drawing.Point(24, 53);
            this.listEscuelas.Name = "listEscuelas";
            this.listEscuelas.Size = new System.Drawing.Size(219, 130);
            this.listEscuelas.TabIndex = 3;
            this.listEscuelas.UseCompatibleStateImageBehavior = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.controlButtons1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labBienvenida);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labNumCat;
        private System.Windows.Forms.Label labCompetidores;
        private ControlButtons controlButtons1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listEscuelas;
        private System.Windows.Forms.Label labNumEscuelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labNumComp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labNumFormas;
        private System.Windows.Forms.ListView listFormas;
        private System.Windows.Forms.Label label6;
    }
}
