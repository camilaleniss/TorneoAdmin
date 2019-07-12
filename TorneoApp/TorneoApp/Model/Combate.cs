using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Combate
    {
        //Participantes del combate (2 participantes)
        private Competidor[] Participantes { get; set; }

        //Ganador del combate
        private Competidor Ganador { get; set; }

        //Rounds del combate
        private List<Round> Rounds { get; set; }

        public Combate(Competidor c1, Competidor c2) {
            Participantes[0] = c1;
            Participantes[1] = c2;
            Rounds = new List<Round>();

        }
    
    }
}
