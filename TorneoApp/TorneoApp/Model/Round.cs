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
        public int[,] Puntajes { get; set; }

        public int Ganador { get; set;}

        public Round()
        {
            Puntajes = new int[2,3];
            Ganador = -1;
        }

        public void CalcularGanador()
        {
            if (SumarFila(0) > SumarFila(1))
                Ganador = 1;
            else if (SumarFila(0) < SumarFila(1))
                Ganador = 2;
            else
                Ganador = 0;
        }

        public int SumarFila(int index)
        {
            int suma = 0;
            for(int i = 0; i < 3; i++)
            {
                suma += Puntajes[index,i];
            }
            return suma;
        }
    }
}
