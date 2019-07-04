using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Categoria
    {

        //Nombre de la categoria
        public string Nombre { get; set; }

        //Participantes de la categoria
        public List<Competidor> Participantes { get; set; }

        //Podium de la categoria
        public Podium Podium { get; set; }

        public bool Opened { get; set; }

        public double Mean { get; set; }

        public Categoria()
        {
            Participantes = new List<Competidor>();
            Podium = new Podium();
            Opened = false;
            Mean = 0;
        }

        public void CalcularMean()
        {
            var Competidores = Participantes.ToArray();
            double mean=0;
            for (int i = 0; i < Competidores.Length; i++)
                mean += (Competidores[i].Edad + Competidores[i].TiempoEntrenando);

            Mean = mean / Competidores.Length;
        }

        public double CalcularDesviacion(Competidor participante)
        {
            return Math.Abs(participante.GetMatchValue() - Mean);
        }

        public void AddCompetidor (Competidor competidor)
        {
            Participantes.Add(competidor);
            CalcularMean();
        }

        public void GenerarNombre(string NombreForma)
        {
            int MinEdad = GetMinEdad();
            int MaxEdad = GetMaxEdad();
            int Nivel = Participantes.Select(par => par.TiempoEntrenando).Max();

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

            Nombre =  NombreForma+" "+ NivelCat+" de "+MinEdad+"-"+ MaxEdad+"años";
        }

        public bool IsMayorEdadCategory()
        {
            return Participantes.Exists(p => p.Edad >= 18);
        }

        public int GetMinEdad()
        {
            return Participantes.Select(par => par.Edad).Min();
        }

        public int GetMaxEdad()
        {
            return Participantes.Select(par => par.Edad).Max();
        }

    }
}
