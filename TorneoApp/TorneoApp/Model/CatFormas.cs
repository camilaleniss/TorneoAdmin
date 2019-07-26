using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class CatFormas : Categoria
    {
        public List<Presentacion> Presentaciones { get; set; }

        public Forma Forma { get; set; }

        public CatFormas()
        { 
            Presentaciones = new List<Presentacion>();
            InitializePresentaciones();
        }

        public void InitializePresentaciones()
        {
            foreach (Competidor c in Participantes)
                Presentaciones.Add(new Presentacion(c));
        }

        public override void CalcularMean(){
            var Competidores = Participantes.ToArray();
            double mean=0;
            for (int i = 0; i < Competidores.Length; i++)
                mean += (Competidores[i].GetMatchValue());

            Mean = mean / Competidores.Length;
        }

        public override double CalcularDesviacion(Competidor participante){
            return Math.Abs(participante.GetMatchValue() - Mean);
        }

        public override void GenerarNombre(string NombreForma){
            int MinEdad = GetMinEdad();
            int MaxEdad = GetMaxEdad();
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

            Nombre =  NombreForma+" "+ NivelCat+" de "+MinEdad+"-"+ MaxEdad+" años";
        }

        public Boolean HayEmpate (double Puntos, List<Presentacion> presentaciones)
        {
            return presentaciones.Exists(p => p.Calificacion == Puntos);
        }

        public List<Presentacion> BuscarPresentaciones(double Puntos, List<Presentacion> presentaciones)
        {
            return presentaciones.FindAll(p => p.Calificacion == Puntos);
        }

        public string[] UpdatePodium()
        {
            string[] CompetidoresPodium = new string[Torneo.NUM_JUECES];

            List<Presentacion> Calificadas = PresentacionesCalificadas();

            Calificadas.Sort();

            for (int i = 0; i<CompetidoresPodium.Length; i++)
            {
                Presentacion p = Calificadas.First();
                CompetidoresPodium[i] = p.Competidor.Name;
                Calificadas.Remove(p);
                if (HayEmpate(p.Calificacion, Calificadas))
                {
                    var Iguales = BuscarPresentaciones(p.Calificacion, Calificadas);
                    
                    foreach(var comp in Iguales)
                    {
                        CompetidoresPodium[i] += " /  " + comp.Competidor.Name;
                        Calificadas.Remove(comp);
                    }                  
                }

                SetVarPodium(i + 1, p.Competidor);
                
            }

            return CompetidoresPodium;
        }

        public void SetVarPodium(int index, Competidor p)
        {
            switch (index)
            {
                case 1:
                    Podium.FirstPlace = p;
                    break;
                case 2:
                    Podium.SecondPlace = p;
                    break;
                case 3:
                    Podium.ThirdPlace = p;
                    break;
            }
        }

        public List<Presentacion> PresentacionesCalificadas()
        {
            return Presentaciones.FindAll(p => p.IsDone());
        }

        public List<Presentacion> PresentacionesRestantes()
        {
            return Presentaciones.FindAll(p => p.IsDone()==false);
        }

       





    }
}
