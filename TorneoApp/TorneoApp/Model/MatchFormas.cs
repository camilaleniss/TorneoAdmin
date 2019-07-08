using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class MatchFormas
    {
        public Dictionary<Forma, List<CatFormas>> CategoriasFormas;

        public List<Competidor> Competidores;

        public MatchFormas(List<Forma> FormasAbiertas, List<Competidor> Competidores)
        {
            CategoriasFormas = new Dictionary<Forma, List<CatFormas>>();

            foreach(Forma formaabierta in FormasAbiertas)
            {
                CategoriasFormas.Add(formaabierta, new List<CatFormas>());
            }

            this.Competidores = Competidores;

            /*
             * Estrategia a utilizar:
             * Primero se va a separar en cada KEY los competidores inscritos a cada forma
             * Cada KEY es una Forma en particular
             * Luego en cada KEY se van a crear dos listas de competidores, mayores y menores de edad
             * Luego en cada lista de competidores se van a realizar mas separaciones que se agregaran a la lista
             * Luego se van a verificar en tamaño si deben quedar así
             * Las listas deben de estar ordenadas de manera que vaya aumentando su nivel
             * Cuando ya se tengan las listas debe haber un método que devuelva la lista de categorias que
             * resultaron del match. 
             * */
        }

        public List<CatFormas> DoMatch()
        {
            SepararFormas();
            var Keys = CategoriasFormas.Keys.ToArray();
            for (int i = 0; i<Keys.Length; i++)
            {
                var EdadesSeparadas = SepararEdades(CategoriasFormas[Keys[i]].First()).ToArray();
                CategoriasFormas[Keys[i]].Clear();

                for (int c=0; c<EdadesSeparadas.Length; c++)
                {
                    List<CatFormas> Segmentacion;
                    if (EdadesSeparadas[c].IsMayorEdadCategory())
                    {
                        Segmentacion = SegmentarNivel(EdadesSeparadas[c]);
                    }
                    else
                    {
                        Segmentacion = SegmentarEdades(EdadesSeparadas[c]);
                    }
                    CategoriasFormas[Keys[i]].AddRange(Segmentacion);
                }

                var CategoriasDefinitivas = VerificarSizeCategorias(CategoriasFormas[Keys[i]]);
                CategoriasFormas[Keys[i]] = CategoriasDefinitivas;
            }

            return RetornarCategorias();
        }
        
        /**
         *Separa en el diccionario los competidores en cada una de las formas existentes para 
         * proceder a los demas filtros
         */
        public void SepararFormas()
        {
            var Formas = CategoriasFormas.Keys;
            foreach(Forma forma in Formas)
            {
                CatFormas NuevaCategoria = new CatFormas();
                NuevaCategoria.Participantes = SepararForma(forma);
                CategoriasFormas[forma].Add(NuevaCategoria);
            }
        }

        /**
         * Realiza una consulta para saber cuales son los competidores en una lista de competidores que
         * en su lista de formas inscritas tienen la forma pasada como parámetro
         */
        public List<Competidor> SepararForma(Forma Forma)
        {
            List<Competidor> CompetidoresForma = Competidores.FindAll(
                competidores => competidores.ListaFormas.Exists(forma => forma.Equals(Forma)));
            return CompetidoresForma;
        }

        public List<CatFormas> SepararEdades(CatFormas Categoria)
        {
            List<Competidor> Participantes = Categoria.Participantes;

            var MenoresEdad = Participantes.FindAll( comp => comp.Edad < 18);
            CatFormas CatMenores = new CatFormas();
            CatMenores.Participantes = MenoresEdad;

            var MayoresEdad = Participantes.FindAll(comp => comp.Edad >= 18);
            CatFormas CatMayores = new CatFormas();
            CatMayores.Participantes = MayoresEdad;

            List<CatFormas> CategoriasEdades = new List<CatFormas>();
            CategoriasEdades.Add(CatMenores);
            CategoriasEdades.Add(CatMayores);

            return CategoriasEdades;
        }

        public List<CatFormas> SegmentarEdades(CatFormas Categoria)
        {
            List<CatFormas> CategoriasSegmentadas = new List<CatFormas>();

            var Participantes = Categoria.Participantes.ToArray();

            List<Competidor>[] Grupos = new List<Competidor>[4]; 
            for(int i =0; i<Grupos.Length; i++)
                Grupos[i] = new List<Competidor>();
            

            foreach(Competidor comp in Participantes)
            {
                //Verificar a qué  grupo pertenece
                int Edad = comp.Edad;

                if (Edad>=6 && Edad <= 8)
                {
                    Grupos[0].Add(comp);
                }else if(Edad>8 && Edad<=11)
                {
                    Grupos[1].Add(comp);
                }
                else if (Edad>11 && Edad <= 14)
                {
                    Grupos[2].Add(comp);
                }
                else
                {
                    Grupos[3].Add(comp);
                }
            }

            for (int i = 0; i < Grupos.Length; i++)
            {
                if (Grupos[i].Count !=0)
                {
                    CatFormas NuevaCategoria = new CatFormas();
                    NuevaCategoria.Participantes = Grupos[i];
                    CategoriasSegmentadas.Add(NuevaCategoria);
                }             
            }

            return CategoriasSegmentadas;
        }

        public List<CatFormas> SegmentarNivel(CatFormas Categoria)
        {
            List<CatFormas> CategoriasSegmentadas = new List<CatFormas>();

            List<Competidor> Participantes = Categoria.Participantes;

            for (int i=0; i<Competidor.CINTANEGRA; i++)
            {
                if (Participantes.Exists(comp => comp.TiempoEntrenando == i+1))
                {
                    var Temp = Participantes.FindAll(participante => participante.TiempoEntrenando == i+1);
                    CatFormas TempCat = new CatFormas();
                    TempCat.Participantes = Temp;
                    CategoriasSegmentadas.Add(TempCat);
                }
            }

            return CategoriasSegmentadas;
        }

        /**
         *Toma como parametro las categorias que se tengan de una forma en específico
         * Ejemplo, toma todas las categorias de Forma sin arma para verificar si el tamaño es correcto y
         * hacer los debidos arreglos 
         * 
         * Para reubicar los participantes que quedaron en categorias incompletas, hace una lista con ellos
         * y luego verifica en cual categoria puede caber
         */
        public List<CatFormas> VerificarSizeCategorias(List<CatFormas> Categorias)
        {
            var CategoriasExistentes = Categorias.ToArray();

            //Toma todas las categorias que estan incompletos
            var PorArreglar = Categorias.FindAll(categorias => categorias.Participantes.Count < 3).ToArray();

            for (int i = 0; i < CategoriasExistentes.Length; i++)
                CategoriasExistentes[i].CalcularMean();

            List<Competidor> Restantes = new List<Competidor>();

            for (int i =0; i<PorArreglar.Length; i++)
                Restantes.AddRange(PorArreglar[i].Participantes);

            //Toma las categorias que quedaron habilitadas para meter participantes 
            List<CatFormas> CategoriasHabilitadas = Categorias.FindAll(categorias => categorias.Participantes.Count >= 3);

            List<CatFormas> CategoriasDefinitivas = AnadirParticipantes(Restantes, CategoriasHabilitadas);

            return CategoriasDefinitivas;
        }

        /*
        public List<CatFormas> GetCategoriasHabilitadas(CatFormas[] CategoriasPorVer) 
        {
            List<CatFormas> CategoriasHabilitadas = new List<CatFormas>();
            for (int i = 0; i<CategoriasPorVer.Length; i++)
            {
                if (CategoriasPorVer[i].Participantes.Count >= 3)
                    CategoriasHabilitadas.Add(CategoriasPorVer[i]);
            }
            return CategoriasHabilitadas;
        }
        */

        public List<CatFormas> AnadirParticipantes (List<Competidor> Participantes, List<CatFormas> Categorias)
        {
            var CategoriasArray = Categorias.ToArray();       
            foreach(Competidor p in Participantes)
            {
                int index=0;
                double MinDesv=1000000;
                for (int i=0; i<CategoriasArray.Length; i++)
                {
                    double TempDesv=CategoriasArray[i].CalcularDesviacion(p);
                    bool MismoRangoEdad = CategoriasArray[i].IsMayorEdadCategory() == (p.Edad >= 18);
                    if (TempDesv <= MinDesv && MismoRangoEdad)
                    {
                        MinDesv = TempDesv;
                        index = i;
                    }
                }

                CatFormas InsertHere = CategoriasArray[index];
                InsertHere.AddCompetidor(p);
                //Categorias.Insert(index, InsertHere);
            }

            return Categorias;
        }

        public List<CatFormas> RetornarCategorias()
        {
            List<CatFormas> CategoriasTorneo = new List<CatFormas>();
            //Este método debe preparar cada categoria abierta por su nombre forma y caracteristica 
            //añadirlas en una lista y retornarlas 
            var Keys = CategoriasFormas.Keys.ToArray();

            for (int i = 0; i < Keys.Length; i++)
            {
                var Categorias = CategoriasFormas[Keys[i]].ToArray();

                for (int w = 0; w < Categorias.Length; w++)
                {
                    Categorias[w].GenerarNombre(Keys[i].Nombre);
                    Categorias[w].Forma = Keys[i];
                    CategoriasTorneo.Add(Categorias[w]);
                }
            }

            return CategoriasTorneo ;
        }

    }
}
