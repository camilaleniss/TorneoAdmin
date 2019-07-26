namespace TorneoApp.ControlUsers
{
    partial class CompFormas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompFormas));
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listRestantes = new System.Windows.Forms.ListView();
            this.listHechas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textJuez3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textJuez2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textJuez1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butFinished = new System.Windows.Forms.Button();
            this.textThird = new System.Windows.Forms.TextBox();
            this.textSecond = new System.Windows.Forms.TextBox();
            this.textFirst = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboCategory
            // 
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(179)))));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(14, 14);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(671, 32);
            this.comboCategory.TabIndex = 0;
            this.comboCategory.Text = "Categoria";
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(208)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listRestantes);
            this.panel1.Controls.Add(this.listHechas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 429);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hechas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Restantes";
            // 
            // listRestantes
            // 
            this.listRestantes.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listRestantes.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRestantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.listRestantes.Location = new System.Drawing.Point(17, 92);
            this.listRestantes.Name = "listRestantes";
            this.listRestantes.Size = new System.Drawing.Size(259, 129);
            this.listRestantes.TabIndex = 2;
            this.listRestantes.UseCompatibleStateImageBehavior = false;
            this.listRestantes.View = System.Windows.Forms.View.List;
            // 
            // listHechas
            // 
            this.listHechas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listHechas.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.listHechas.Location = new System.Drawing.Point(17, 275);
            this.listHechas.Name = "listHechas";
            this.listHechas.Size = new System.Drawing.Size(259, 129);
            this.listHechas.TabIndex = 1;
            this.listHechas.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presentaciones";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textResult);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textJuez3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textJuez2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textJuez1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(333, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 203);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(276, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 41);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textResult.Location = new System.Drawing.Point(108, 153);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(52, 26);
            this.textResult.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(33, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total";
            // 
            // textJuez3
            // 
            this.textJuez3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJuez3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textJuez3.Location = new System.Drawing.Point(192, 92);
            this.textJuez3.Name = "textJuez3";
            this.textJuez3.Size = new System.Drawing.Size(52, 26);
            this.textJuez3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(189, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Juez 3";
            // 
            // textJuez2
            // 
            this.textJuez2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJuez2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textJuez2.Location = new System.Drawing.Point(108, 92);
            this.textJuez2.Name = "textJuez2";
            this.textJuez2.Size = new System.Drawing.Size(52, 26);
            this.textJuez2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(105, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Juez 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(24, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Juez 1";
            // 
            // textJuez1
            // 
            this.textJuez1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJuez1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textJuez1.Location = new System.Drawing.Point(27, 92);
            this.textJuez1.Name = "textJuez1";
            this.textJuez1.Size = new System.Drawing.Size(52, 26);
            this.textJuez1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre competidor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.butFinished);
            this.panel3.Controls.Add(this.textThird);
            this.panel3.Controls.Add(this.textSecond);
            this.panel3.Controls.Add(this.textFirst);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(333, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 199);
            this.panel3.TabIndex = 11;
            // 
            // butFinished
            // 
            this.butFinished.FlatAppearance.BorderSize = 0;
            this.butFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFinished.Image = ((System.Drawing.Image)(resources.GetObject("butFinished.Image")));
            this.butFinished.Location = new System.Drawing.Point(286, 13);
            this.butFinished.Name = "butFinished";
            this.butFinished.Size = new System.Drawing.Size(48, 41);
            this.butFinished.TabIndex = 10;
            this.butFinished.UseVisualStyleBackColor = true;
            this.butFinished.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textThird
            // 
            this.textThird.Enabled = false;
            this.textThird.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textThird.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textThird.Location = new System.Drawing.Point(157, 149);
            this.textThird.Name = "textThird";
            this.textThird.Size = new System.Drawing.Size(177, 30);
            this.textThird.TabIndex = 22;
            // 
            // textSecond
            // 
            this.textSecond.Enabled = false;
            this.textSecond.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textSecond.Location = new System.Drawing.Point(157, 109);
            this.textSecond.Name = "textSecond";
            this.textSecond.Size = new System.Drawing.Size(177, 30);
            this.textSecond.TabIndex = 22;
            // 
            // textFirst
            // 
            this.textFirst.Enabled = false;
            this.textFirst.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textFirst.Location = new System.Drawing.Point(157, 66);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(177, 30);
            this.textFirst.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label16.Location = new System.Drawing.Point(15, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 22);
            this.label16.TabIndex = 24;
            this.label16.Text = "Bronce";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label15.Location = new System.Drawing.Point(15, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 22);
            this.label15.TabIndex = 23;
            this.label15.Text = "Plata";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(15, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 22);
            this.label14.TabIndex = 22;
            this.label14.Text = "Oro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(15, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "Podium";
            // 
            // CompFormas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboCategory);
            this.Name = "CompFormas";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.CompFormas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listRestantes;
        private System.Windows.Forms.ListView listHechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textJuez3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textJuez2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textJuez1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textThird;
        private System.Windows.Forms.TextBox textSecond;
        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button butFinished;
    }
}
