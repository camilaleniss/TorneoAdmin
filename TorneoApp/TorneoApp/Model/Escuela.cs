using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class Escuela
    {
        //El nombre de la escuela
        public string Name { get; set; }

        //Puntuación acumulada en formas
        public int PFormas { get; set; }

        //Puntuación acumulada en sanda
        public int PSanda { get; set; }

        public Escuela (string Name)
        {
            this.Name = Name;
            PFormas = 0;
            PSanda = 0;
        }

        public void AumentarFormas(int Incremento)
        {
            PFormas += Incremento;
        }

        public void DisminuirFormas(int Decremento)
        {
            PFormas -= Decremento;
        }

        public void AumentarSanda(int Incremento)
        {
            PFormas += Incremento;
        }

        public void DisminuirSanda(int Decremento)
        {
            PSanda -= Decremento;
        }
    }
}
