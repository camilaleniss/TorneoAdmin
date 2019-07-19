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
            this.menuLateral = new TorneoApp.ControlUsers.MenuLateral();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.mainView = new TorneoApp.ControlUsers.MainView();
            this.Banner = new TorneoApp.ControlUsers.Banner();
            this.panelContent.SuspendLayout();
            this.panelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLateral
            // 
            this.menuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(78)))), ((int)(((byte)(109)))));
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 0);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(177, 575);
            this.menuLateral.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelView);
            this.panelContent.Controls.Add(this.Banner);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(177, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(706, 575);
            this.panelContent.TabIndex = 1;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.mainView);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 56);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(706, 519);
            this.panelView.TabIndex = 1;
            // 
            // mainView
            // 
            this.mainView.BackColor = System.Drawing.Color.White;
            this.mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView.Location = new System.Drawing.Point(0, 0);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(706, 519);
            this.mainView.TabIndex = 0;
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(706, 56);
            this.Banner.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 575);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelContent.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private ControlUsers.MenuLateral menuLateral;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelView;
        private ControlUsers.Banner Banner;
        private ControlUsers.MainView mainView;

        /*
        private ControlUsers.CategoriasLists categoriaslist;
        private ControlUsers.CategoriasView categoriasview;
        private ControlUsers.CompFormas compformas;
        private ControlUsers.CompSanda compsanda;
        private ControlUsers.EscuelasView escuelasview;
        private ControlUsers.ImportarView importarview;
        private ControlUsers.Ranking rankingview;
        private ControlUsers.CompetidoresView competidoresview;
        */
    }
}