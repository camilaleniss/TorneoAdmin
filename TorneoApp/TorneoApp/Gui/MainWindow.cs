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

        private Torneo Torneo;

        

        public MainWindow()
        {          
            InitializeComponent();

            menuLateral.Controlador = this;

            Torneo = new Torneo();
            Torneo.InicializarTorneo();
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
            this.panelView.Controls.Clear();

            switch (view){
                case "Init":
                    this.mainView = new ControlUsers.MainView();
                    this.panelView.Controls.Add(mainView);
                    break;
                case "Categorias":
                    this.categoriasview = new ControlUsers.CategoriasView();
                    this.panelView.Controls.Add(categoriasview);
                    break;              
                case "Competidores":
                    this.competidoresview = new ControlUsers.CompetidoresView();
                    this.panelView.Controls.Add(competidoresview);
                    break;
                case "Importar":
                    this.importarview = new ControlUsers.ImportarView();
                    this.panelView.Controls.Add(importarview);
                    break;
                case "Escuelas":
                    this.escuelasview = new ControlUsers.EscuelasView();
                    this.panelView.Controls.Add(escuelasview);
                    break;
                case "Ranking":
                    this.rankingview = new ControlUsers.Ranking();
                    this.panelView.Controls.Add(rankingview);
                    break;
                case "CompSanda":
                    this.compsanda = new ControlUsers.CompSanda();
                    this.panelView.Controls.Add(compsanda);
                    break;
                case "CompFormas":
                    this.compformas = new ControlUsers.CompFormas();
                    this.panelView.Controls.Add(compformas);
                    break;
            }
            
            if(view.Equals("CatSanda") || view.Equals("CatFormas"))
            {
                this.categoriaslist = new ControlUsers.CategoriasLists();
                categoriaslist.IsFormas =view.Equals("CatFormas") ? true : false;
                categoriaslist.Window = this;
                InitializeListCategorias();
                this.panelView.Controls.Add(categoriaslist);
            }
        }

        public void InitializeListCategorias()
        {
            bool IsFormas = categoriaslist.IsFormas;
            if (IsFormas)
            {
                InitializeListCatFormas();
            }
            else
            {
                InitializeListCatSanda();
            }
        }

        public void InitializeListCatFormas()
        {
            List<CatFormas> categorias = Torneo.CategoriasFormas;
            foreach(CatFormas c in categorias)
            {
                categoriaslist.getListCategorias().Items.Add(c.Nombre);
            }
        }

        public void InitializeListCatSanda()
        {
            List<CatSanda> categorias = Torneo.CategoriasSanda;
            foreach (CatSanda c in categorias)
            {
                categoriaslist.getListCategorias().Items.Add(c.Nombre);
            }
        }


        private void Banner_Load(object sender, EventArgs e)
        {

        }

        public void SelectCategory(int index, bool IsFormas)
        {
            Categoria categoria = Torneo.SelectCategoria(index, IsFormas);
            categoriaslist.LoadCompetidores(categoria.Participantes);
        }

        public void SelectCompetidor(int index, bool IsFormas, int indexcomp)
        {
            Competidor comp = Torneo.SelectCompetidor(index, indexcomp, IsFormas);
            categoriaslist.LoadData(comp);
        }
    }
}
