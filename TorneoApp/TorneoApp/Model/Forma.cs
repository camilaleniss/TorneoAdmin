using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    class Forma
    {
        //Tipo de forma: con arma, sin arma, arma larga 
        private string CategoriaForma { get; }

        //Con arma = true, sin arma = false
        private bool ConArma { get; }

        public Forma(bool ConArma)
        {
            this.ConArma = ConArma;
            if (ConArma)
            {
                CategoriaForma = "Forma con arma";
            }
            else
            {
                CategoriaForma = "Forma sin arma";
            }
        }

        public Forma(string Nombre, bool ConArma)
        {
            this.ConArma = ConArma;
            if (ConArma)
            {
                CategoriaForma = "Forma "+Nombre+" con arma";
            }
            else
            {
                CategoriaForma = "Forma " + Nombre + " con arma";
            }
        }



    }
}
