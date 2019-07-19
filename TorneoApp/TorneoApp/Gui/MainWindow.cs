using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoApp.Model
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {          
            InitializeComponent();

            menuLateral.Controlador = this;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void Banner1_Load(object sender, EventArgs e)
        {

        }

        private void MainView1_Load(object sender, EventArgs e)
        {

        }

        public void ShowView(string view)
        {
            switch (view){
                case "Init":
                    this.mainView = new ControlUsers.MainView();
                    break;
                case "Categorias":
                    this.mainView = new ControlUsers.CategoriasView();
                    break;
                case "CatSanda":
                    this.mainView = new ControlUsers.CategoriasLists();
                    break;
                case "CatFormas":
                    this.mainView = new ControlUsers.CategoriasLists();
                    break;
                case "Competidores":
                    this.mainView = new ControlUsers.CompetidoresView();
                    break;
                case "Importar":
                    this.mainView = new ControlUsers.ImportarView();
                    break;
                case "Escuelas":
                    this.mainView = new ControlUsers.EscuelasView();
                    break;
                case "Ranking":
                    this.mainView = new ControlUsers.Ranking();
                    break;
                case "CompSanda":
                    this.mainView = new ControlUsers.CompSanda();
                    break;
                case "CompFormas":
                    this.mainView = new ControlUsers.CompFormas();
                    break;
            }
            this.panelView.Controls.Clear();           
            this.panelView.Controls.Add(mainView);
        }
    }
}
