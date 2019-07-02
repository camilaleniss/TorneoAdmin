using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Categoria
    {
        //Nombre de la categoria
        public string Nombre { get; set; }

        //Participantes de la categoria
        public List<Competidor> Participantes { get; set; }

        //Podium de la categoria
        public Podium Podium { get; set; }

        public bool Opened { get; set; }

        public Categoria()
        {
            Participantes = new List<Competidor>();
            Podium = new Podium();
            Opened = false;
        }

    }
}
