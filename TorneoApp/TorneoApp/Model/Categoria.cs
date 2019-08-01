using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{       
    [Serializable]
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
            Opened = true;
            Mean = 0;
        }

        public virtual void CalcularMean()
        {
            //Este método tiene su propia implementación en CatFormas y CatSanda
        }

        public virtual double CalcularDesviacion(Competidor participante)
        {
            return -1;
            //Este método tiene su propia implementación en CatFormas y CatSanda
        }

        public void AddCompetidor (Competidor competidor)
        {
            Participantes.Add(competidor);
            CalcularMean();
        }

        public virtual void GenerarNombre(string Nombre)
        {
            this.Nombre = Nombre;
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

        public int GetMinPeso()
        {
            return Participantes.Select(par => par.Peso).Min();
        }

        public int GetMaxPeso()
        {
            return Participantes.Select(par => par.Peso).Max();
        }

        public int GetCategoriaMayoria()
        {
            int Nivel=0, cant=0;
            int[] Niveles = new int[4];

            for (int i = 0; i < Niveles.Length; i++)
                Niveles[0] = Participantes.FindAll(p => p.TiempoEntrenando == (i + 1)).Count;

            for (int i =0; i<Niveles.Length; i++)
            {
                if (Niveles[i] >= cant)
                {
                    Nivel = Participantes.First().TiempoEntrenando;
                    cant = Niveles[i];
                }
            }

            return Nivel;
        }

        public void EliminarCompetidor(Competidor comp)
        {
            Participantes.Remove(comp);
        }

        public void FinishedCategory()
        {
            Opened = false;
        }

        public void DarPuntos()
        {
            Podium.FirstPlace.Escuela.AumentarFormas(Torneo.ORO);
            Podium.SecondPlace.Escuela.AumentarFormas(Torneo.PLATA);
            Podium.ThirdPlace.Escuela.AumentarFormas(Torneo.BRONCE);
            FinishedCategory();
        }
    }
}
