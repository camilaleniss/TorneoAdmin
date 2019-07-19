using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Presentacion : IComparable<double>
    {

        public Competidor Competidor{get; set;}
        public double Calificacion { get; set; }

        public Presentacion(Competidor competidor)
        {
            this.Competidor = Competidor;
            Calificacion= 0;
        }

        public int CompareTo(double other)
        {
            if (Calificacion > other) return 1;
            if (Calificacion < other) return -1;
            return 0;
        }
    }
}
