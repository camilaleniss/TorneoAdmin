using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class Podium
    {

        //Primer lugar
        public Competidor FirstPlace { get; set;}

        //Segundo lugar
        public Competidor SecondPlace { get; set; }

        //Tercer lugar
        public Competidor ThirdPlace { get; set; }

        public Podium()
        {
            FirstPlace = null;
            SecondPlace = null;
            ThirdPlace = null;
        }

    }
}
