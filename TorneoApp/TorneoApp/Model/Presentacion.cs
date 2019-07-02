using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Presentacion
    {

        public Competidor Competidor{get; set;}
        public double Calificacion { get; set; }

        public Presentacion(Competidor competidor)
        {
            this.Competidor = Competidor;
            Calificacion= 0;
        }
    }
}
