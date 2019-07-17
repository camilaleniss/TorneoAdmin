namespace TorneoApp.Model
{
    partial class MainWindow
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuLateral1 = new TorneoApp.ControlUsers.MenuLateral();
            this.panel1 = new System.Windows.Forms.Panel();
            this.banner1 = new TorneoApp.ControlUsers.Banner();
            this.mainView1 = new TorneoApp.ControlUsers.MainView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLateral1
            // 
            this.menuLateral1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(109)))));
            this.menuLateral1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral1.Location = new System.Drawing.Point(0, 0);
            this.menuLateral1.Name = "menuLateral1";
            this.menuLateral1.Size = new System.Drawing.Size(177, 575);
            this.menuLateral1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainView1);
            this.panel1.Controls.Add(this.banner1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(177, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 575);
            this.panel1.TabIndex = 2;
            // 
            // banner1
            // 
            this.banner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.banner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner1.Location = new System.Drawing.Point(0, 0);
            this.banner1.Name = "banner1";
            this.banner1.Size = new System.Drawing.Size(706, 56);
            this.banner1.TabIndex = 0;
            // 
            // mainView1
            // 
            this.mainView1.BackColor = System.Drawing.Color.White;
            this.mainView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView1.Location = new System.Drawing.Point(0, 56);
            this.mainView1.Name = "mainView1";
            this.mainView1.Size = new System.Drawing.Size(706, 519);
            this.mainView1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuLateral1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ControlUsers.MenuLateral menuLateral1;
        private System.Windows.Forms.Panel panel1;
        private ControlUsers.MainView mainView1;
        private ControlUsers.Banner banner1;
    }
}