using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class CatFormas : Categoria
    {
        public List<Presentacion> Presentaciones { get; set; }

        public Forma Forma { get; set; }

        public CatFormas()
        { 
            Presentaciones = new List<Presentacion>(); 
        }

        

    }
}
