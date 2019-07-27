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
                    InitializeCompetidoresList();
                    this.panelView.Controls.Add(competidoresview);
                    break;
                case VERIFICAR:
                    this.importarview = new ControlUsers.ConfirmarView();
                    this.importarview.Main = this;
                    InitializeVerificarView();
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
                    InitializeEscuelasView();
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
                    this.compformas.Main = this;
                    InitializeCompetenciaFormas();
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
            string nombreescuela = Torneo.ToStringEscuelas()[index];
            int puntossanda = Torneo.Escuelas.ToArray()[index].PSanda;
            int puntosformas = Torneo.Escuelas.ToArray()[index].PFormas;

            escuelasview.InitializeCompetidores(competidores, nombreescuela, puntossanda, puntosformas);
        }

        public void InitializeCompetidoresList()
        {
            var Competidores = Torneo.ToStringCompetidor();
            competidoresview.InitializeListCompetidores(Competidores);
            GetInfoCompetidor(0);
        }

        public void InitializeVerificarView()
        {
            var Competidores = Torneo.CompetidoresAusentes();
            importarview.InitializeCompetidores(Competidores);
        }

        public void GetInfoCompetidor(int index)
        {
            Competidor c = Torneo.Competidores.ToArray()[index];
            string nombre = c.Name;
            string genero = c.GetStringGenere();
            string edad = c.Edad + "";
            string peso = c.Peso + "";
            string nivel = c.getNivel();
            string sanda = c.Sanda ? "Sí" : "No";
            string formas = c.Formas ? "Sí" : "No";
            string cinta = c.IsBlackBelt ? "Sí" : "No";
            string telefono = c.TelefonoPersonal;
            string eps = c.Eps;
            string escuela = c.Escuela.Name;
            string acudiente = c.ContactName;
            string telacudiente = c.TelefonoAcudiente;
            List<Forma> listformas = c.ListaFormas;

            competidoresview.InitializeInfoCompetidor(nombre, genero, edad, peso, nivel, sanda, formas,
                cinta, telefono, escuela, eps, acudiente, telacudiente, listformas);
        }

        public void ConfirmarCompetidores(List<int> indices)
        {
            Torneo.ConfirmarCompetidores(indices);
            InitializeVerificarView();
        }

        //COMPETENCIA FORMAS

        public void InitializeCompetenciaFormas()
        {
            var Categorias = Torneo.CategoriasFormas;
            List<String> catstring = new List<String>();
            foreach (var cat in Categorias)
                catstring.Add(cat.Nombre);

            compformas.InitCategories(catstring);

        }

        public void InitializePresentaciones(int index)
        {
            CatFormas categoria = Torneo.CategoriasFormas.ToArray()[index];
            List<Presentacion> temppresentacion = categoria.PresentacionesCalificadas();
            List<String> done = new List<String>();

            foreach (Presentacion p in temppresentacion)
                done.Add(p.Competidor.Name);

            compformas.InitializeCalificadas(done);

            temppresentacion = categoria.PresentacionesRestantes();

            done.Clear();

            foreach (Presentacion p in temppresentacion)
                done.Add(p.Competidor.Name);

            compformas.InitializeRestantes(done);

            if (done.Count == 0) categoria.DarPuntos();
        }

        public void ShowPresentacion(String nombreCompetidor)
        {
            Competidor competidor = Torneo.BuscarCompetidor(nombreCompetidor);
            CatFormas categoria = Torneo.CategoriasFormas.ToArray()[compformas.IndexCategoria];
            Presentacion presentacion = categoria.BuscarPresentacion(competidor);

            compformas.InitializePresentacion(presentacion.Jueces, presentacion.Calificacion);
            if (presentacion.IsDone())
                compformas.SetTextResult(presentacion.Calificacion);

        }

        public double SendCalificacionFormas(double[] jueces)
        {
            double Calificacion = Torneo.GetPromedio(jueces);

            Competidor competidor = Torneo.BuscarCompetidor(compformas.NameCompetidor);
            CatFormas categoria = Torneo.CategoriasFormas.ToArray()[compformas.IndexCategoria];

            string [] podium = Torneo.GuardarPresentacion(categoria, competidor, jueces);

            compformas.InitializePodium(podium);
            return Calificacion;
        }



    }
}
