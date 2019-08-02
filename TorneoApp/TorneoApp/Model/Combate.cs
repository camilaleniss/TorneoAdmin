using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class Combate
    {
        //Participantes del combate (2 participantes)
        public Competidor[] Participantes { get; set; }

        //Ganador del combate
        public Competidor Ganador { get; set; }

        //Rounds del combate
        public List<Round> Rounds { get; set; }

        public Combate(Competidor c1, Competidor c2) {
            Participantes = new Competidor[2];
            Participantes[0] = c1;
            Participantes[1] = c2;
            Rounds = new List<Round>();

        }

        public override String ToString()
        {
            return Participantes[0].Name + " vs " + Participantes[1].Name;
        }
    
    }
}
