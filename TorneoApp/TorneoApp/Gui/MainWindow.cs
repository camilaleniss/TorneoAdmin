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
        public const string CATSANDA = "Categoria Sanda";
        public const string CATFORMAS = "Categoria Formas";
        public const string COMPETIDORES = "Competidores";
        public const string LISTCOMPETIDORES = "Listado Competidores";
        public const string VERIFICAR = "Verificar Asistencia";
        public const string ESCUELAS = "Escuelas";
        public const string LISTESCUELAS = "Listado Escuelas";
        public const string RANKING = "Ranking Escuelas";
        public const string COMPETENCIA = "Competencia";
        public const string COMPSANDA = "Sanda";
        public const string COMPFORMAS = "Formas";

        private string categoria { get; set; }

        private string subcategoria { get; set; }

        private Torneo Torneo;

        public MainWindow()
        {          
            InitializeComponent();
            menuLateral.Controlador = this;
            categoria = "";
            subcategoria = "";
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
                    this.mainView.controlButtons.Main = this;
                    this.panelView.Controls.Add(mainView);
                    this.categoria = "";
                    InitializeMainView();
                    break;
                case CATEGORIAS:
                    this.categoriasview = new ControlUsers.CategoriasView();
                    this.categoriasview.Main = this;
                    this.categoriasview.controlButtons1.Main = this;
                    InitializeCategorias();
                    this.categoria = CATEGORIAS;
                    this.subcategoria = "";
                    this.panelView.Controls.Add(categoriasview);
                    break;              
                case COMPETIDORES:
                    this.competidorescontroller = new ControlUsers.CompetidoresController();
                    this.competidorescontroller.Main = this;
                    this.competidorescontroller.controlButtons1.Main = this;
                    this.categoria = COMPETIDORES;
                    this.subcategoria = "";
                    this.panelView.Controls.Add(competidorescontroller);
                    break;
                case LISTCOMPETIDORES:
                    this.competidoresview = new ControlUsers.CompetidoresList();
                    this.competidoresview.Main = this;
                    InitializeCompetidoresList();
                    this.categoria = COMPETIDORES;
                    this.subcategoria = LISTCOMPETIDORES;
                    this.panelView.Controls.Add(competidoresview);
                    break;
                case VERIFICAR:
                    this.importarview = new ControlUsers.ConfirmarView();
                    this.importarview.Main = this;
                    this.importarview.controlButtons1.Main = this;
                    InitializeVerificarView();
                    this.categoria = COMPETIDORES;
                    this.subcategoria = VERIFICAR;
                    this.panelView.Controls.Add(importarview);
                    break;
                case ESCUELAS:
                    this.escuelascontroller = new ControlUsers.EscuelasController();
                    this.escuelascontroller.Main = this;
                    this.escuelascontroller.controlButtons1.Main = this;
                    this.categoria = ESCUELAS;
                    this.subcategoria = "";
                    this.panelView.Controls.Add(escuelascontroller);
                    break;
                case LISTESCUELAS:
                    this.escuelasview = new ControlUsers.EscuelasView();
                    this.escuelasview.Main = this;
                    this.escuelasview.controlButtons1.Main = this;
                    InitializeEscuelasView();
                    this.categoria = ESCUELAS;
                    this.subcategoria = LISTESCUELAS;
                    this.panelView.Controls.Add(escuelasview);
                    break;
                case RANKING:
                    this.rankingview = new ControlUsers.Ranking();
                    rankingview.Main = this;
                    InitializeRankingView();
                    this.categoria = ESCUELAS;
                    this.subcategoria = RANKING;
                    this.panelView.Controls.Add(rankingview);
                    break;
                case COMPETENCIA:
                    this.competenciaview = new ControlUsers.CompetenciaController();
                    this.competenciaview.Main = this;
                    this.competenciaview.controlButtons1.Main = this;
                    this.categoria = COMPETENCIA;
                    this.subcategoria = "";
                    this.panelView.Controls.Add(competenciaview);
                    break;
                case COMPSANDA:
                    this.compsanda = new ControlUsers.CompSanda();
                    this.compsanda.Main = this;
                    InitializeCompetenciaSanda();
                    this.categoria = COMPETENCIA;
                    this.subcategoria = COMPSANDA;
                    this.panelView.Controls.Add(compsanda);
                    break;
                case COMPFORMAS:
                    this.compformas = new ControlUsers.CompFormas();
                    this.compformas.Main = this;
                    InitializeCompetenciaFormas();
                    this.categoria = COMPETENCIA;
                    this.subcategoria = COMPFORMAS;
                    this.panelView.Controls.Add(compformas);
                    break;
            }
            
            if(view.Equals(CATSANDA) || view.Equals(CATFORMAS))
            {
                this.categoriaslist = new ControlUsers.CategoriasLists();
                categoriaslist.IsFormas =view.Equals(CATFORMAS) ? true : false;
                categoriaslist.SetNameCategorias();
                categoriaslist.Window = this;
                categoriaslist.controlButtons1.Main = this;
                InitializeListCategorias();
                this.panelView.Controls.Add(categoriaslist);

                this.categoria = CATEGORIAS;
                this.subcategoria = view.Equals(CATSANDA) ? CATSANDA : CATFORMAS;
            }

            UpdateLocation();
        }



        public void UpdateLocation()
        {
            menuLateral.UpdateLocation(categoria, subcategoria);
            Banner.UpdateLocation(categoria, subcategoria);
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

        //COMPETENCIA SANDA
        public void InitializeCompetenciaSanda()
        {
            List<CatSanda> Categorias = Torneo.CategoriasSanda;
            List<String> catString = new List<string>();
            foreach (CatSanda category in Categorias)
            {
                catString.Add(category.Nombre);
                
            }
            compsanda.InitCategories(catString);
            InitCombates(Categorias);
        }
        
        public void InitCombates(List<CatSanda> categoriasSanda)
        {
            foreach (CatSanda category in categoriasSanda)
            {
                category.RondaDeCombates();
            }
        }

        public void MostrarCombates(int index)
        {
            CatSanda categoria = Torneo.CategoriasSanda[index];
            List<Combate> tempCombates = categoria.CombatesActivos;
            List<String> combates = new List<string>();
            foreach (Combate c in tempCombates)
            {
                if (c.Participantes[0] != c.Participantes[1])
                {
                    combates.Add(c.ToString());
                }
                else
                {
                    combates.Add(c.Participantes[0].Name + "(Pase ronda)");
                }

            }
            compsanda.MostrarCombates(combates);
            compsanda.MostrarPodio(categoria);
            compsanda.VaciarRondas();

        }

        public void MostrarRondas(int indexCategoria, int indexCombate)
        {
            //compsanda.VaciarRondas();
            CatSanda categoria = Torneo.CategoriasSanda.ToArray()[indexCategoria];
            Combate combate = categoria.CombatesActivos[indexCombate];
            compsanda.GanadorCombate(combate);
            compsanda.ResumenCombate(combate);

        }

        public void PasarRonda(int indexCategoria)
        {
            CatSanda categoria = Torneo.CategoriasSanda[indexCategoria];
            foreach(Combate c in categoria.CombatesActivos)
            {
                if(c.Ganador == null)
                {
                    MessageBox.Show("Aún no se han definido todos los combates, no puede pasar de ronda aún", "Formato erroneo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if(categoria.CombatesActivos.Count <= 3)
            {
                categoria.CrearPodio();
                compsanda.MostrarPodio(categoria);
                MostrarCombates(indexCategoria);
                
            }
            else
            {
                categoria.ReemparejarGanadores();
                categoria.RondaDeCombates();
                MostrarCombates(indexCategoria);
            }
            
            
        }

        public void MostrarPuntajeRonda(int indexCategoria, int indexCombate, int selectedIndex)
        {
            CatSanda categoria = Torneo.CategoriasSanda.ToArray()[indexCategoria];
            Combate combate = categoria.CombatesActivos[indexCombate];
            if(combate.Rounds.Count > selectedIndex && combate.Rounds[selectedIndex].Puntajes != null)
            {
                compsanda.MostrarRondas(combate.Rounds[selectedIndex]);
            }
            else
            {
                compsanda.VaciarRondas();
            }

        }

        public void MostrarResumenCombates(int indexCategoria, int indexCombate)
        {
            CatSanda categoria = Torneo.CategoriasSanda.ToArray()[indexCategoria];
            Combate combate = categoria.CombatesActivos[indexCombate];
            compsanda.GanadorCombate(combate);

        }

        public string TraducirGanador(int i)
        {
            string ganador = "";
            if (i == 1)
            {
                ganador = "Azul";
            }
            else if (i == 2)
            {
                ganador = "Rojo";
            }
            return ganador;
        }

        public void ModificarPuntajeRonda(int indexCategoria, int indexCombate, int indexRonda, int[,] puntajes)
        {
            CatSanda categoria = Torneo.CategoriasSanda.ToArray()[indexCategoria];
            Combate combate = categoria.CombatesActivos[indexCombate];
            combate.Rounds[indexRonda].Puntajes = puntajes;
            combate.Rounds[indexRonda].CalcularGanador();
            int i = combate.Rounds[indexRonda].Ganador;
            string ganador = TraducirGanador(i);

            compsanda.GanadorRonda(ganador);
            compsanda.GanadorCombate(combate);

            bool cond = combate.CalcularGanador();
            compsanda.AbrirTercerRound(cond);
            compsanda.ResumenCombate(combate);

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

            // (done.Count == 0) categoria.UpdatePuntos(true);

            Torneo.SetPuntosEscuelas();
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

        public void SaveTorneo()
        {
            Torneo.Serializar(Torneo);
            MessageBox.Show("El torneo ha sido guardado exitosamente");
        }

        public void RecuperarTorneo()
        {
            try
            {
                this.Torneo = Torneo.LeerTorneo();
                MessageBox.Show("Torneo recuperado exitosamente");
            }catch(Exception)
            {
                MessageBox.Show("No se pudo recuperar el torneo anterior");
            }
            finally
            {
                InitializeTorneoState();
                ShowView(INIT);
            }
        }

        public void NuevoTorneo()
        {

            Torneo = new Torneo();
            Torneo.InicializarTorneo();
            InitializeTorneoState();
            ShowView(INIT);

        }

        public void InitializeTorneoState()
        {
            this.menuLateral.ReviewState(Torneo.Iniciado);
        }

        public void IniciarTorneo()
        {
            Torneo.Iniciado = true;
            InitializeTorneoState();
        }

        public void InicializarEscuela(String nombreescuela, bool IsFormas)
        {
            Escuela escuela = Torneo.BuscarEscuela(nombreescuela);
            int oro=0, plata=0, bronce=0;
            if (IsFormas)
            {
                oro = escuela.DictionaryFormas[Torneo.ORO].Count*Torneo.ORO;
                plata = escuela.DictionaryFormas[Torneo.PLATA].Count * Torneo.PLATA;
                bronce = escuela.DictionaryFormas[Torneo.BRONCE].Count * Torneo.BRONCE;
            }
            else
            {
                oro = escuela.DictionarySanda[Torneo.ORO].Count * Torneo.ORO;
                plata = escuela.DictionarySanda[Torneo.PLATA].Count * Torneo.PLATA;
                bronce = escuela.DictionarySanda[Torneo.BRONCE].Count * Torneo.BRONCE;
            }

            int puntostotales = IsFormas ? escuela.PFormas : escuela.PSanda;

            rankingview.SetMedallas(oro, plata, bronce, puntostotales);
        }

        public void GetCompetidoresRanking(string nombreesucela, bool IsFormas, int medalla)
        {
            Escuela escuela = Torneo.BuscarEscuela(nombreesucela);
            List<Competidor> competidores = IsFormas ? escuela.DictionaryFormas[medalla] :
                escuela.DictionarySanda[medalla];

            List<String> infocompetidores = new List<String>();

            foreach (Competidor c in competidores)
                infocompetidores.Add(c.ToString());

            rankingview.InitializeCompetidores(infocompetidores);
        }

        public void InitializeRankingView()
        {
            List<Escuela> Formas = Torneo.RankingEscuelas(true);
            List<Escuela> Sanda = Torneo.RankingEscuelas(false);
            rankingview.InitializeRanking(Formas, true);
            rankingview.InitializeRanking(Sanda, false);
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
