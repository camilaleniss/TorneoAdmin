using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    class Presentacion
    {

        private Competidor Competidor{get; set;}
        private double Calificacion { get; set; }

        public Presentacion(Competidor competidor)
        {
            this.Competidor = Competidor;
            Calificacion= 0;
        }
    }
}
