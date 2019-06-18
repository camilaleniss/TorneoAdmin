using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    class Torneo
    {
        //Lista de las categorias abiertas para formas
        private List<CatFormas> CategoriasFormas { get; set; }

        //Lista de las categorias abiertas para sanda
        private List<CatSanda> CategoriasSanda { get; set; }

        //Lista de las escuelas
        private List<Escuela> Escuelas { get; set; }

        //Lista de competidores
        private List<Competidor> Competidores { get; set; }

        //Lista de formas permitidas en el torneo
        private List<Forma> Formas { get; set; }

        public Torneo()
        {
            CategoriasFormas = new List<CatFormas>();

            CategoriasSanda = new List<CatSanda>();

            Escuelas = new List<Escuela>();

            Competidores = new List<Competidor>();

            Formas = new List<Forma>();
        }

    }
}
