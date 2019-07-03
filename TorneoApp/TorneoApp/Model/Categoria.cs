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

    }
}
