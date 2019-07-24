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
        public const string INIT = "Init";
        public const string CATEGORIAS = "Categorias";
        public const string CATSANDA = "CatSanda";
        public const string CATFORMAS = "CatFormas";
        public const string COMPETIDORES = "Competidores";
        public const string LISTCOMPETIDORES = "ListadoCompetidores";
        public const string VERIFICAR = "Verificar";
        public const string ESCUELAS = "Escuelas";
        public const string LISTESCUELAS = "ListadoEscuelas";
        public const string RANKING = "Ranking";
        public const string COMPETENCIA = "Competencia";
        public const string COMPSANDA = "Sanda";
        public const string COMPFORMAS = "Formas";


        private Torneo Torneo;

        

        public MainWindow()
        {          
            InitializeComponent();

            menuLateral.Controlador = this;

            Torneo = new Torneo();
            Torneo.InicializarTorneo();
            ShowView("Init");
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
                case INIT:
                    this.mainView = new ControlUsers.MainView();
                    this.panelView.Controls.Add(mainView);
                    InitializeMainView();
                    break;
                case CATEGORIAS:
                    this.categoriasview = new ControlUsers.CategoriasView();
                    this.categoriasview.Main = this;
                    InitializeCategorias();
                    this.panelView.Controls.Add(categoriasview);
                    break;              
                case COMPETIDORES:
                    this.competidorescontroller = new ControlUsers.CompetidoresController();
                    this.competidorescontroller.Main = this;
                    this.panelView.Controls.Add(competidorescontroller);
                    break;
                case LISTCOMPETIDORES:
                    this.competidoresview = new ControlUsers.CompetidoresList();
                    this.competidoresview.Main = this;
                    this.panelView.Controls.Add(competidoresview);
                    break;
                case VERIFICAR:
                    this.importarview = new ControlUsers.ConfirmarView();
                    this.importarview.Main = this;
                    this.panelView.Controls.Add(importarview);
                    break;
                case ESCUELAS:
                    this.escuelascontroller = new ControlUsers.EscuelasController();
                    this.escuelascontroller.Main = this;
                    this.panelView.Controls.Add(escuelascontroller);
                    break;
                case LISTESCUELAS:
                    this.escuelasview = new ControlUsers.EscuelasView();
                    this.escuelasview.Main = this; 
                    this.panelView.Controls.Add(escuelasview);
                    break;
                case RANKING:
                    this.rankingview = new ControlUsers.Ranking();
                    this.panelView.Controls.Add(rankingview);
                    break;
                case COMPETENCIA:
                    this.competenciaview = new ControlUsers.CompetenciaController();
                    this.competenciaview.Main = this;
                    this.panelView.Controls.Add(competenciaview);
                    break;
                case COMPSANDA:
                    this.compsanda = new ControlUsers.CompSanda();
                    this.panelView.Controls.Add(compsanda);
                    break;
                case COMPFORMAS:
                    this.compformas = new ControlUsers.CompFormas();
                    this.panelView.Controls.Add(compformas);
                    break;
            }
            
            if(view.Equals(CATSANDA) || view.Equals(CATFORMAS))
            {
                this.categoriaslist = new ControlUsers.CategoriasLists();
                categoriaslist.IsFormas =view.Equals(CATFORMAS) ? true : false;
                categoriaslist.SetNameCategorias();
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

        public void MoverA(int categoriaactual, int categorianueva, int indexcomp, bool IsFormas)
        {
            Torneo.MoverCompetidor(categoriaactual, categorianueva, indexcomp, IsFormas);
            string view = IsFormas ? CATFORMAS : CATSANDA;
            ShowView(view);
        }

        public List<String> ToStringCategorias(bool isformas)
        {
            return Torneo.ToStringCategorias(isformas);
        }

        public void InitializeMainView()
        {
            int catsanda = Torneo.CategoriasSanda.Count;
            int catformas = Torneo.CategoriasFormas.Count;
            int categorias = catsanda + catformas;
            int ncompetidores = Torneo.Competidores.Count;          
            List<Escuela> escuelas = Torneo.Escuelas;
            int nescuelas = escuelas.Count;
            List<Forma> formas = Torneo.Formas;
            int nformas = formas.Count;

            mainView.SetNumberLabs(categorias, catsanda, catformas, ncompetidores, nescuelas, nformas);
            mainView.InitializeListEscuelas(escuelas);
            mainView.InitializeListFormas(formas);
        }

        public void InitializeCategorias()
        {
            InitializeLabsCategoriasView();
            InitializeaListAllCategories();
        }

        public void InitializeLabsCategoriasView()
        {
            //Initialize Sanda
            int numcat = Torneo.CategoriasSanda.Count;
            int numopened = Torneo.GetNumOpenedCategoria(false);
            int numfinished = numcat - numopened;

            categoriasview.InitializeLabs(numcat, numopened, numfinished, false);

            numcat = Torneo.CategoriasFormas.Count;
            numopened = Torneo.GetNumOpenedCategoria(true);
            numfinished = numcat - numopened;

            categoriasview.InitializeLabs(numcat, numopened, numfinished, true);
        }

        public void InitializeaListAllCategories()
        {
            List<String> AllCategories = Torneo.GetAllCategoriesNames();
            categoriasview.InitializeListCategorias(AllCategories);
        }

        public void InitializeEscuelasView()
        {
            List<String> Escuelas = Torneo.ToStringEscuelas();
            this.escuelasview.InitializeEscuelas(Escuelas);

        }

        public void GetCompetidoresEscuela(int index)
        {
            List<Competidor> competidores = Torneo.GetCompetidoresEscuela(index);
            escuelasview.InitializeCompetidores(competidores);
        }


    }
}
