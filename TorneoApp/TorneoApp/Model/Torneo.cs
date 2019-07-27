using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Torneo
    {
        //Ruta del archivo  registro del torneo
        public const string CSV_ROUTE = "..\\..\\Data\\Registro.csv";

        public const string NOMBRE_TORNEO = "V Torneo de Wushu y Sanda";

        public const int NUM_JUECES = 3;

        public const int ORO = 5;
        public const int PLATA = 3;
        public const int BRONCE = 1;

        //Lista de las categorias abiertas para formas
        public List<CatFormas> CategoriasFormas { get; set; }

        //Lista de las categorias abiertas para sanda
        public List<CatSanda> CategoriasSanda { get; set; }

        //Lista de las escuelas
        public List<Escuela> Escuelas { get; set; }

        //Lista de competidores
        public List<Competidor> Competidores { get; set; }

        //Lista de formas permitidas en el torneo
        public List<Forma> Formas { get; set; }

        public Torneo()
        {
            CategoriasFormas = new List<CatFormas>();

            CategoriasSanda = new List<CatSanda>();

            Escuelas = new List<Escuela>();

            Competidores = new List<Competidor>();

            Formas = new List<Forma>();
        }

        public void InicializarTorneo()
        {
            var Lectura = leerCSV(CSV_ROUTE);
            LeerCompetidores(Lectura);
            DoMatches();
        }

        public void DoMatches()
        {
            var tempComp = Competidores.FindAll(comp => comp.Formas);
            MatchFormas matchformas = new MatchFormas(Formas, tempComp);
            tempComp = Competidores.FindAll(comp => comp.Sanda);
            MatchSanda matchsanda = new MatchSanda(tempComp);
            CategoriasFormas = matchformas.DoMatch();
            CategoriasSanda = matchsanda.DoMatch();
        }

        /*
         * Este método Lee el archivos CSV de los competidores y retorna una lista de el split hecho a la linea leida
         */
        public List<string[]> leerCSV(string path)
        {
            List<string[]> parsedData = new List<string[]>();

            using (StreamReader readFile = new StreamReader(path))
            {
                string line=readFile.ReadLine();
                string[] row;

                while ((line = readFile.ReadLine()) != null)
                {
                    row = line.Split(';');
                    parsedData.Add(row);
                }
            }
            return parsedData;
        }

        public void LeerCompetidores (List<string[]> Competidores)
        {
            var CompetidoresTorneo = Competidores.ToArray();
            for (int i = 0; i<CompetidoresTorneo.Length; i++)
            {
                string Email = CompetidoresTorneo[i][1].Trim();
                string Name = CompetidoresTorneo[i][2].Trim(); ;
                bool IsMan = CompetidoresTorneo[i][3].Equals("Masculino");
                string NombreEscuela = CompetidoresTorneo[i][4].Trim(); ;
                int Edad = Int32.Parse(CompetidoresTorneo[i][5]);
                int Peso = Int32.Parse(CompetidoresTorneo[i][6]);
                string Tiempo = CompetidoresTorneo[i][7];
                string Eps = CompetidoresTorneo[i][8].Trim();
                string[] Inscripcion = CompetidoresTorneo[i][9].Split(',');
                string[] Formas = CompetidoresTorneo[i][10].Split(',');
                bool IsBlackBelt = CompetidoresTorneo[i][11].Equals("Sí");
                string TelefonoPersonal = CompetidoresTorneo[i][12].Trim();
                string NombreAcudiente = CompetidoresTorneo[i][13].Trim();
                string TelefonoAcudiente = CompetidoresTorneo[i][14].Trim();

                //Realiza las verificaciones para crear el Competidor
                Escuela EscuelaCompetidor = AddEscuela(NombreEscuela);
                int TiempoEntrenando = GetTiempoEntrenando(Tiempo, IsBlackBelt);

                Competidor NuevoCompetidor = new Competidor(Name, IsMan, Edad, Peso, IsBlackBelt,
                    TiempoEntrenando, Eps, TelefonoPersonal, NombreAcudiente, TelefonoAcudiente,
                    Email, EscuelaCompetidor);

                Inscripcion = QuitarEspacios(Inscripcion);
                Formas = QuitarEspacios(Formas);

                InscribirCompetidor(NuevoCompetidor, Inscripcion, Formas);
                
            }
        }

        public Escuela AddEscuela(string NombreEscuela)
        {
           
            string ActualEscuela = NombreEscuela.Trim();
            Escuela EscuelaCompetidor = BuscarEscuela(ActualEscuela);

            if(EscuelaCompetidor == null)
            {
                EscuelaCompetidor = new Escuela(NombreEscuela);
                Escuelas.Add(EscuelaCompetidor);
            }

            return EscuelaCompetidor;
                
        }

        public bool ExisteEscuela (string EscuelaAgregar)
        {
            bool Existe = Escuelas.Any(escuelaactual => escuelaactual.Name.Equals(EscuelaAgregar));
            return Existe;
        }

        public Escuela BuscarEscuela (string NombreEscuela)
        {
            if (ExisteEscuela(NombreEscuela))
            {
                Escuela Encontrada = Escuelas.Find(escuela => escuela.Name.Equals(NombreEscuela));
                return Encontrada;
            }
            return null;
        }

        public int GetTiempoEntrenando(string Descripcion, bool IsBlackBelt)
        {
            if (IsBlackBelt) return Competidor.CINTANEGRA;
            if (Descripcion.Equals("0-1 año")) return Competidor.PRINCIPIANTE;
            if (Descripcion.Equals("1-3 años")) return Competidor.INTERMEDIO;
            return Competidor.AVANZADO;
            
        }

        public string[] QuitarEspacios(string [] Arreglo)
        {
            for (int i = 0; i < Arreglo.Length; i++)
                Arreglo[i] = Arreglo[i].Trim();

            return Arreglo;
        }

        public void InscribirCompetidor (Competidor CompetidorActual, string[] Inscripcion, string[] Formas)
        {
            Competidores.Add(CompetidorActual);
            for (int i=0; i<Inscripcion.Length; i++)
            {
                if (Inscripcion[i].Equals("Sanda"))
                {
                    CompetidorActual.Sanda = true;
                }
                else
                {
                    CompetidorActual.Formas = true;
                    InscribirFormas(CompetidorActual, Formas);
                }
            }
        }

        public void InscribirFormas(Competidor Competidor, string [] Formas)
        {
            for(int i = 0; i<Formas.Length; i++)
            {
                Forma FormaAInscribir = AddForma(Formas[i]);
                Competidor.AddForma(FormaAInscribir);
            }
        }

        public Forma AddForma(string NombreForma)
        {

            string FormaActual = NombreForma.Trim();
            Forma FormaCompetidor = BuscarForma(NombreForma);

            if (FormaCompetidor == null)
            {
                FormaCompetidor = new Forma(FormaActual);
                Formas.Add(FormaCompetidor);
            }

            return FormaCompetidor;

        }

        public bool ExisteForma(string FormaAgregar)
        {
            bool Existe = Formas.Any(formaactual => formaactual.Nombre.Equals(FormaAgregar));
            return Existe;
        }

        public Forma BuscarForma(string NombreForma)
        {
            if (ExisteForma(NombreForma))
            {
                Forma Encontrada = Formas.Find(forma => forma.Nombre.Equals(NombreForma));
                return Encontrada;
            }
            return null;
        }

        public Competidor BuscarCompetidor (string NombreCompetidor)
        {
            Competidor Competidor = Competidores.Find(c => c.Name.Equals(NombreCompetidor));
            return Competidor;
        }

        public double GetPromedio (double [] juez)
        {
            double promedio = 0;
            for (int i = 0; i < juez.Length; i++)
                promedio += juez[i];

            promedio /= juez.Length;

            return promedio;
        }

        public Categoria SelectCategoria(int index, bool IsFormas)
        {
            if (IsFormas)
            {
                return CategoriasFormas.ToArray()[index];
            }
            return CategoriasSanda.ToArray()[index];
        }
        
        public Competidor SelectCompetidor(int indexcat, int indexcomp, bool IsFormas)
        {
            Categoria cat = SelectCategoria(indexcat, IsFormas);
            return cat.Participantes.ToArray()[indexcomp];
        }

        public void MoverCompetidor(int categoriaactual, int categorianueva, int indexcomp, bool IsFormas)
        {
            Categoria catantigua = SelectCategoria(categoriaactual, IsFormas);
            Competidor comp = SelectCompetidor(categoriaactual, indexcomp, IsFormas);
            catantigua.EliminarCompetidor(comp);
            Categoria catnuevo = SelectCategoria(categorianueva, IsFormas);
            catnuevo.AddCompetidor(comp);

        }

        public List<String> ToStringCategorias(bool isformas)
        {
            List<String> descrip = new List<String>();
            if (isformas)
            {
                foreach (CatFormas cat in CategoriasFormas)
                    descrip.Add(cat.Nombre);
            }
            else
            {
                foreach (CatSanda cat in CategoriasSanda)
                    descrip.Add(cat.Nombre);
            }
            return descrip;
        }

        public int GetNumOpenedCategoria(bool IsFormas)
        {
            if (IsFormas)
                return CategoriasFormas.FindAll(c => c.Opened).Count;
            return CategoriasSanda.FindAll(c => c.Opened).Count;
        }

        public List<String> GetAllCategoriesNames()
        {
            List<String> Categorias = new List<String>();

            foreach (CatSanda cat in CategoriasSanda)
                Categorias.Add(cat.Nombre);

            foreach (CatFormas cat in CategoriasFormas)
                Categorias.Add(cat.Nombre);

            return Categorias;
        }

        public List<String> ToStringEscuelas()
        {
            List<String> escuelas = new List<String>();
            foreach (Escuela e in Escuelas)
                escuelas.Add(e.Name);

            return escuelas;
        }

        public List<String> ToStringCompetidor()
        {
            List<String> competidores = new List<String>();
            foreach (Competidor e in Competidores)
                competidores.Add(e.Name);

            return competidores;
        }

        public List<Competidor> GetCompetidoresEscuela(int index)
        {
            String nombre = Escuelas.ToArray()[index].Name;
            return Competidores.FindAll(comp => comp.Escuela.Name.Equals(nombre));
        }

        public List<Competidor> CompetidoresAusentes()
        {
            return Competidores.FindAll(competidor => competidor.IsHere == false);
        }

        public void ConfirmarCompetidores(List<int> indexes)
        {
            var restantes = CompetidoresAusentes().ToArray();

            foreach(int i in indexes)
            {
                Competidor comp = restantes[i];
                ConfirmarCompetidor(comp.Name);
            }
        }

        public void ConfirmarCompetidor(String nombre)
        {
            Competidor competidor = BuscarCompetidor(nombre);
            competidor.IsHere = true;
        }


        public void FinishCategory(int indexcat, bool IsFormas)
        {
            Categoria categoria = SelectCategoria(indexcat, IsFormas);
            categoria.DarPuntos();
        }

        public string[] GuardarPresentacion(CatFormas categoria, Competidor competidor, double [] jueces)
        {
            Presentacion presentacion = categoria.BuscarPresentacion(competidor);
            presentacion.Jueces = jueces;
            double puntaje = GetPromedio(jueces);
            presentacion.Calificacion = puntaje;

            return categoria.UpdatePodium();
        }
    }
}
