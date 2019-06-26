using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Forma
    {
        //Tipo de forma: con arma, sin arma, arma larga 
        public string CategoriaForma { get; }

        public Forma(string CategoriaForma)
        {
            this.CategoriaForma = CategoriaForma;
        }



    }
}
