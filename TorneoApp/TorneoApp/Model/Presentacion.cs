using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class Presentacion : IComparable<double>
    {

        public Competidor Competidor{get; set;}
        public double Calificacion { get; set; }

        public double[] Jueces { get; set; }

        public Presentacion(Competidor Competidor)
        {
            this.Competidor = Competidor;
            this.Calificacion= 0;
            Jueces = new double[Torneo.NUM_JUECES];
        }

        
        public int CompareTo(double other)
        {
            if (Calificacion > other) return 1;
            if (Calificacion < other) return -1;
            return 0;
        }
        

        public bool IsDone()
        {
            return Calificacion == 0 ? false : true;
        }

        
    }
}
