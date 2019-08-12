using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class CatSanda : Categoria
    {


        //Aqui deberia ir el arbol de combates
        public bool Genere { get; set; }

        public List<Competidor> ParticipantesVencidos { get; set; }

        public List<Combate> CombatesActivos { get; set; }

        public Podium Podio { get; set; }

        public void RondaDeCombates()
        {

            List<Combate> combates = new List<Combate>();
            Random rand = new Random();
            List<int> possible = Enumerable.Range(0, Participantes.Count).ToList();
            for (int i = 0; i < Participantes.Count() / 2; i++)
            {
                int index = rand.Next(0, possible.Count);
                Competidor p1 = Participantes[possible[index]];
                possible.RemoveAt(index);
                int index2 = rand.Next(0, possible.Count);
                Competidor p2 = Participantes[possible[index2]];
                possible.RemoveAt(index2);
                
                Combate c = new Combate(p1, p2);
                combates.Add(c);
            }
            if (possible.Count > 0)
            {
                //Solucion temporal a competidores impares 
                //Se debe crear una variable dummy para estas situaciones
                Combate c = new Combate(Participantes[possible[0]], Participantes[possible[0]]);
                c.Ganador = Participantes[possible[0]];
                combates.Add(c);
            }

            this.CombatesActivos = combates;
        }

        public void ReemparejarGanadores()
        {
            List<Competidor> participantes = new List<Competidor>();
            foreach(Combate c in CombatesActivos)
            {
                participantes.Add(c.Ganador);
            }
            ClasificarParticipantesVencidos(participantes);


        }

        public void ClasificarParticipantesVencidos(List<Competidor> ganadores)
        {
            foreach(Competidor c in Participantes)
            {
                if (!ganadores.Contains(c))
                {
                    ParticipantesVencidos.Add(c);
                    Participantes.Remove(c);
                }
            }
        }
        public bool IsMan { get; set; }

        public Competidor Atipico { get; set; }

        public CatSanda()
        {
            Opened = true;
        }

        public override void CalcularMean(){
            var Competidores = Participantes.ToArray();
            double mean=0;
            for (int i = 0; i < Competidores.Length; i++)
                mean += (Competidores[i].GetMatchValueSanda());
            Mean = mean / Competidores.Length;
        }

        public override double CalcularDesviacion(Competidor participante){
            return Math.Abs(participante.GetMatchValueSanda() - Mean);
        }

        public override void GenerarNombre(string Nombre){
            int MinEdad = GetMinEdad();
            int MaxEdad = GetMaxEdad();
            int MinPeso = GetMinPeso();
            int MaxPeso = GetMaxPeso();
            int Nivel = GetCategoriaMayoria();

            string NivelCat = "";
            
            switch (Nivel){
                case Competidor.PRINCIPIANTE:
                    NivelCat = "Principiante";
                    break;
                case Competidor.INTERMEDIO:
                    NivelCat = "Intermedio";
                    break;
                case Competidor.AVANZADO:
                    NivelCat = "Avanzado";
                    break;
                case Competidor.CINTANEGRA:
                    NivelCat = "Cinta Negra";
                    break;
            }

            this.Nombre =  NivelCat+" de "+MinEdad+"-"+ MaxEdad+" años de "+MinPeso+"-"+MaxPeso+"kg";
            
        } 

        public void CalcularAtipico(){
            double Desv, DesvAtyp;
            var Competidores = Participantes.ToArray();
            int contador = 0;
            Atipico = Competidores[contador]; 
            DesvAtyp= CalcularDesviacion(Atipico);
            do{                 
                Desv = CalcularDesviacion(Competidores[contador]);
                if(Desv >= DesvAtyp){
                    Atipico = Competidores[contador];
                }
                contador++;
            }while(contador < Participantes.Count);
        }

        public List<CatSanda> GetSubCatPeso()
        {
            List<CatSanda> subcategorias = SepararPeso();
            if (subcategorias.All(cat => cat.Participantes.Count >= 2))
                return subcategorias;

            return null;
        }

        public List<CatSanda> SepararPeso()
        {
            var CompetidoresCategoria = Participantes.ToArray();
            Dictionary<int, List<Competidor>> Segmentacion = new Dictionary<int, List<Competidor>>();

            for (int i = 0; i < MatchSanda.NUMSEGEDAD; i++)
                Segmentacion.Add(i, new List<Competidor>());


            for (int i = 0; i < CompetidoresCategoria.Length; i++)
            {
                int MatchValue = GetMatchPeso(CompetidoresCategoria[i], IsManCategory());
                Segmentacion[MatchValue].Add(CompetidoresCategoria[i]);
            }

            List<CatSanda> CategoriasSegmentadas = ConvertDictionary(Segmentacion);

            return CategoriasSegmentadas;
        }

        public List<CatSanda> ConvertDictionary(Dictionary<int, List<Competidor>> Abiertas)
        {
            List<CatSanda> CategoriasAbiertas = new List<CatSanda>();

            for (int i = 0; i < MatchSanda.NUMSEGEDAD; i++)
            {
                CatSanda TempCat = new CatSanda();
                TempCat.Participantes = Abiertas[i];
                if (TempCat.Participantes.Count != 0)
                    CategoriasAbiertas.Add(TempCat);
            }
            return CategoriasAbiertas;
        }

        public int GetMatchPeso(Competidor c, bool isMan)
        {
            int Peso = c.Peso;
            return isMan ? GetMatchPesoMan(Peso) : GetMatchPesoFem(Peso);
        }

        public int GetMatchPesoMan(int Peso)
        {
            if (Peso >= 30 && Peso <= 35) return 0;
            if (Peso >= 36 && Peso <= 40) return 1;
            if (Peso >= 41 && Peso <= 45) return 2;
            if (Peso >= 46 && Peso <= 50) return 3;
            if (Peso >= 51 && Peso <= 55) return 4;
            if (Peso >= 56 && Peso <= 60) return 5;
            if (Peso >= 61 && Peso <= 65) return 6;
            if (Peso >= 66 && Peso <= 70) return 7;
            if (Peso >= 71 && Peso <= 75) return 8;
            if (Peso >= 76 && Peso <= 78) return 9;
            return 10;
        }

        public int GetMatchPesoFem(int Peso)
        {
            if (Peso >= 30 && Peso <= 35) return 0;
            if (Peso >= 36 && Peso <= 40) return 1;
            if (Peso >= 41 && Peso <= 45) return 2;
            if (Peso >= 46 && Peso <= 50) return 3;
            if (Peso >= 51 && Peso <= 55) return 4;
            if (Peso >= 56 && Peso <= 60) return 5;
            if (Peso >= 61 && Peso <= 65) return 6;
            if (Peso >= 66 && Peso <= 70) return 7;
            return 8;
        }

        public bool IsManCategory()
        {
            IsMan = Participantes.FindAll(p => p.IsMan).Count > 0 ? true : false;
            return IsMan;
        }
    }
}
