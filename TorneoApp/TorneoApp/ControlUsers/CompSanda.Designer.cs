namespace TorneoApp.ControlUsers
{
    partial class CompSanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompSanda));
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonPasarRonda = new System.Windows.Forms.Button();
            this.listCombates = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoxBronce = new System.Windows.Forms.TextBox();
            this.BoxPlata = new System.Windows.Forms.TextBox();
            this.BoxOro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxGanador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GanadorButton = new System.Windows.Forms.Button();
            this.juez3Rojo = new System.Windows.Forms.TextBox();
            this.juez2Rojo = new System.Windows.Forms.TextBox();
            this.juez3Azul = new System.Windows.Forms.TextBox();
            this.juez2Azul = new System.Windows.Forms.TextBox();
            this.juez1Rojo = new System.Windows.Forms.TextBox();
            this.juez1Azul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRound = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.resumenCombate = new System.Windows.Forms.TextBox();
            this.resumenRound3 = new System.Windows.Forms.TextBox();
            this.resumenRound2 = new System.Windows.Forms.TextBox();
            this.resumenRound1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nombreDelCombate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.Color.White;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(222)))), ((int)(((byte)(140)))));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(20, 16);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(324, 33);
            this.comboCategory.TabIndex = 0;
            this.comboCategory.Text = "Categoria";
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.ComboCategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(232)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.botonPasarRonda);
            this.panel1.Controls.Add(this.listCombates);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(20, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 218);
            this.panel1.TabIndex = 1;
            // 
            // botonPasarRonda
            // 
            this.botonPasarRonda.FlatAppearance.BorderSize = 0;
            this.botonPasarRonda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPasarRonda.Image = ((System.Drawing.Image)(resources.GetObject("botonPasarRonda.Image")));
            this.botonPasarRonda.Location = new System.Drawing.Point(254, 13);
            this.botonPasarRonda.Name = "botonPasarRonda";
            this.botonPasarRonda.Size = new System.Drawing.Size(46, 38);
            this.botonPasarRonda.TabIndex = 7;
            this.botonPasarRonda.UseVisualStyleBackColor = true;
            this.botonPasarRonda.Click += new System.EventHandler(this.BotonPasarRonda_Click);
            // 
            // listCombates
            // 
            this.listCombates.Location = new System.Drawing.Point(19, 76);
            this.listCombates.Name = "listCombates";
            this.listCombates.Size = new System.Drawing.Size(281, 126);
            this.listCombates.TabIndex = 6;
            this.listCombates.UseCompatibleStateImageBehavior = false;
            this.listCombates.SelectedIndexChanged += new System.EventHandler(this.ListCombates_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ronda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.BoxBronce);
            this.panel2.Controls.Add(this.BoxPlata);
            this.panel2.Controls.Add(this.BoxOro);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(20, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 199);
            this.panel2.TabIndex = 2;
            // 
            // BoxBronce
            // 
            this.BoxBronce.Enabled = false;
            this.BoxBronce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxBronce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BoxBronce.Location = new System.Drawing.Point(123, 149);
            this.BoxBronce.Name = "BoxBronce";
            this.BoxBronce.ReadOnly = true;
            this.BoxBronce.Size = new System.Drawing.Size(177, 29);
            this.BoxBronce.TabIndex = 22;
            // 
            // BoxPlata
            // 
            this.BoxPlata.Enabled = false;
            this.BoxPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPlata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BoxPlata.Location = new System.Drawing.Point(123, 109);
            this.BoxPlata.Name = "BoxPlata";
            this.BoxPlata.ReadOnly = true;
            this.BoxPlata.Size = new System.Drawing.Size(177, 29);
            this.BoxPlata.TabIndex = 22;
            // 
            // BoxOro
            // 
            this.BoxOro.Enabled = false;
            this.BoxOro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BoxOro.Location = new System.Drawing.Point(123, 66);
            this.BoxOro.Name = "BoxOro";
            this.BoxOro.ReadOnly = true;
            this.BoxOro.Size = new System.Drawing.Size(177, 29);
            this.BoxOro.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label16.Location = new System.Drawing.Point(15, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 24);
            this.label16.TabIndex = 24;
            this.label16.Text = "Bronce";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label15.Location = new System.Drawing.Point(15, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "Plata";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(15, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "Oro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(15, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Podium";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(243)))), ((int)(((byte)(195)))));
            this.panel3.Controls.Add(this.textBoxGanador);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.GanadorButton);
            this.panel3.Controls.Add(this.juez3Rojo);
            this.panel3.Controls.Add(this.juez2Rojo);
            this.panel3.Controls.Add(this.juez3Azul);
            this.panel3.Controls.Add(this.juez2Azul);
            this.panel3.Controls.Add(this.juez1Rojo);
            this.panel3.Controls.Add(this.juez1Azul);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBoxRound);
            this.panel3.Location = new System.Drawing.Point(364, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 253);
            this.panel3.TabIndex = 2;
            // 
            // textBoxGanador
            // 
            this.textBoxGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGanador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.textBoxGanador.Location = new System.Drawing.Point(108, 212);
            this.textBoxGanador.Name = "textBoxGanador";
            this.textBoxGanador.ReadOnly = true;
            this.textBoxGanador.Size = new System.Drawing.Size(110, 29);
            this.textBoxGanador.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(11, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ganador";
            // 
            // GanadorButton
            // 
            this.GanadorButton.FlatAppearance.BorderSize = 0;
            this.GanadorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GanadorButton.Image = ((System.Drawing.Image)(resources.GetObject("GanadorButton.Image")));
            this.GanadorButton.Location = new System.Drawing.Point(241, 209);
            this.GanadorButton.Name = "GanadorButton";
            this.GanadorButton.Size = new System.Drawing.Size(46, 38);
            this.GanadorButton.TabIndex = 8;
            this.GanadorButton.UseVisualStyleBackColor = true;
            this.GanadorButton.Click += new System.EventHandler(this.GanadorButton_Click);
            // 
            // juez3Rojo
            // 
            this.juez3Rojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juez3Rojo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.juez3Rojo.Location = new System.Drawing.Point(241, 155);
            this.juez3Rojo.Name = "juez3Rojo";
            this.juez3Rojo.Size = new System.Drawing.Size(50, 29);
            this.juez3Rojo.TabIndex = 15;
            // 
            // juez2Rojo
            // 
            this.juez2Rojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juez2Rojo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.juez2Rojo.Location = new System.Drawing.Point(168, 155);
            this.juez2Rojo.Name = "juez2Rojo";
            this.juez2Rojo.Size = new System.Drawing.Size(50, 29);
            this.juez2Rojo.TabIndex = 14;
            // 
            // juez3Azul
            // 
            this.juez3Azul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juez3Azul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.juez3Azul.Location = new System.Drawing.Point(241, 112);
            this.juez3Azul.Name = "juez3Azul";
            this.juez3Azul.Size = new System.Drawing.Size(50, 29);
            this.juez3Azul.TabIndex = 13;
            // 
            // juez2Azul
            // 
            this.juez2Azul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juez2Azul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.juez2Azul.Location = new System.Drawing.Point(168, 112);
            this.juez2Azul.Name = "juez2Azul";
            this.juez2Azul.Size = new System.Drawing.Size(50, 29);
            this.juez2Azul.TabIndex = 12;
            // 
            // juez1Rojo
            // 
            this.juez1Rojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juez1Rojo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.juez1Rojo.Location = new System.Drawing.Point(95, 155);
            this.juez1Rojo.Name = "juez1Rojo";
            this.juez1Rojo.Size = new System.Drawing.Size(50, 29);
            this.juez1Rojo.TabIndex = 11;
            // 
            // juez1Azul
            // 
            this.juez1Azul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juez1Azul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.juez1Azul.Location = new System.Drawing.Point(95, 112);
            this.juez1Azul.Name = "juez1Azul";
            this.juez1Azul.Size = new System.Drawing.Size(50, 29);
            this.juez1Azul.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(11, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rojo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(11, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Azúl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(237, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Juez 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(164, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Juez 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(91, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Juez 1";
            // 
            // comboBoxRound
            // 
            this.comboBoxRound.BackColor = System.Drawing.Color.White;
            this.comboBoxRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.comboBoxRound.FormattingEnabled = true;
            this.comboBoxRound.Items.AddRange(new object[] {
            "Round 1",
            "Round 2"});
            this.comboBoxRound.Location = new System.Drawing.Point(15, 15);
            this.comboBoxRound.Name = "comboBoxRound";
            this.comboBoxRound.Size = new System.Drawing.Size(289, 33);
            this.comboBoxRound.TabIndex = 5;
            this.comboBoxRound.Text = "Seleccione una ronda";
            this.comboBoxRound.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRound_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(248)))), ((int)(((byte)(217)))));
            this.panel4.Controls.Add(this.botonGuardar);
            this.panel4.Controls.Add(this.resumenCombate);
            this.panel4.Controls.Add(this.resumenRound3);
            this.panel4.Controls.Add(this.resumenRound2);
            this.panel4.Controls.Add(this.resumenRound1);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(364, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 161);
            this.panel4.TabIndex = 3;
            // 
            // botonGuardar
            // 
            this.botonGuardar.FlatAppearance.BorderSize = 0;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botonGuardar.Image")));
            this.botonGuardar.Location = new System.Drawing.Point(258, 111);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(46, 38);
            this.botonGuardar.TabIndex = 18;
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // resumenCombate
            // 
            this.resumenCombate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumenCombate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.resumenCombate.Location = new System.Drawing.Point(241, 11);
            this.resumenCombate.Name = "resumenCombate";
            this.resumenCombate.Size = new System.Drawing.Size(63, 29);
            this.resumenCombate.TabIndex = 21;
            // 
            // resumenRound3
            // 
            this.resumenRound3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumenRound3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.resumenRound3.Location = new System.Drawing.Point(121, 119);
            this.resumenRound3.Name = "resumenRound3";
            this.resumenRound3.ReadOnly = true;
            this.resumenRound3.Size = new System.Drawing.Size(110, 29);
            this.resumenRound3.TabIndex = 20;
            // 
            // resumenRound2
            // 
            this.resumenRound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumenRound2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.resumenRound2.Location = new System.Drawing.Point(121, 83);
            this.resumenRound2.Name = "resumenRound2";
            this.resumenRound2.ReadOnly = true;
            this.resumenRound2.Size = new System.Drawing.Size(110, 29);
            this.resumenRound2.TabIndex = 19;
            // 
            // resumenRound1
            // 
            this.resumenRound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumenRound1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.resumenRound1.Location = new System.Drawing.Point(121, 47);
            this.resumenRound1.Name = "resumenRound1";
            this.resumenRound1.ReadOnly = true;
            this.resumenRound1.Size = new System.Drawing.Size(110, 29);
            this.resumenRound1.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(11, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Round 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(11, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Round 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(11, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Round 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(11, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Resumen combate";
            // 
            // nombreDelCombate
            // 
            this.nombreDelCombate.AutoSize = true;
            this.nombreDelCombate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreDelCombate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.nombreDelCombate.Location = new System.Drawing.Point(360, 24);
            this.nombreDelCombate.Name = "nombreDelCombate";
            this.nombreDelCombate.Size = new System.Drawing.Size(210, 25);
            this.nombreDelCombate.TabIndex = 4;
            this.nombreDelCombate.Text = "Nombre del combate";
            // 
            // CompSanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nombreDelCombate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboCategory);
            this.Name = "CompSanda";
            this.Size = new System.Drawing.Size(706, 519);
            this.Load += new System.EventHandler(this.CompSanda_Load);
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

        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonPasarRonda;
        private System.Windows.Forms.ListView listCombates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox BoxBronce;
        private System.Windows.Forms.TextBox BoxPlata;
        private System.Windows.Forms.TextBox BoxOro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxGanador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GanadorButton;
        private System.Windows.Forms.TextBox juez3Rojo;
        private System.Windows.Forms.TextBox juez2Rojo;
        private System.Windows.Forms.TextBox juez3Azul;
        private System.Windows.Forms.TextBox juez2Azul;
        private System.Windows.Forms.TextBox juez1Rojo;
        private System.Windows.Forms.TextBox juez1Azul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRound;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.TextBox resumenCombate;
        private System.Windows.Forms.TextBox resumenRound3;
        private System.Windows.Forms.TextBox resumenRound2;
        private System.Windows.Forms.TextBox resumenRound1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label nombreDelCombate;
    }
}
