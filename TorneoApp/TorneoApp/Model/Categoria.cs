using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    class Categoria
    {
        //Nombre de la categoria
        private string Nombre { get; set; }

        //Participantes de la categoria
        private List<Competidor> Participantes { get; set; }

        //Podium de la categoria
        private Podium Podium { get; set; }

    }
}
