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

        public override void CalcularMean(){
            var Competidores = Participantes.ToArray();
            double mean=0;
            for (int i = 0; i < Competidores.Length; i++)
                mean += (Competidores[i].GetMatchValue());

            Mean = mean / Competidores.Length;
        }

        public override double CalcularDesviacion(Competidor participante){
            return Math.Abs(participante.GetMatchValue() - Mean);
        }
        public override void GenerarNombre(string NombreForma){
            int MinEdad = GetMinEdad();
            int MaxEdad = GetMaxEdad();
            int Nivel = GetCategoriaMayoria();

            string NivelCat = "";
            
            switch (Nivel){
                case Competidor.PRINCIPIANTE:
                    NivelCat = "Principiante";
                    break;
                case Competidor.INTERMEDIO:
                    NivelCat = "Intermedio";
                    break;
                case Competidor.AVANZADO:
                    NivelCat = "Avanzado";
                    break;
                case Competidor.CINTANEGRA:
                    NivelCat = "Cinta Negra";
                    break;
            }

            Nombre =  NombreForma+" "+ NivelCat+" de "+MinEdad+"-"+ MaxEdad+" años";
        }

    }
}
