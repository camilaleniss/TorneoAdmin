using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class Round
    {
        public int[] Puntajes { get; set; }

        public int Ganador { get; set;}

        public Round()
        {
            Puntajes = new int[2];
            Ganador = -1;
        }

        public void CalcularGanador()
        {
            if (Puntajes[0] > Puntajes[1])
                Ganador = 1;
            else if (Puntajes[0] < Puntajes[1])
                Ganador = 2;
            else
                Ganador = 0;
        }

    }
}
