using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    class Podium
    {

        //Primer lugar
        private Competidor FirstPlace { get; set;}


        //Segundo lugar
        private Competidor SecondPlace { get; set; }

        //Tercer lugar
        private Competidor ThirdPlace { get; set; }

        public Podium()
        {
            FirstPlace = null;
            SecondPlace = null;
            ThirdPlace = null;
        }
    }
}
