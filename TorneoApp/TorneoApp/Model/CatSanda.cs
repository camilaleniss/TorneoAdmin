using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class CatSanda : Categoria
    {
        //Aqui deberia ir el arbol de combates
        public bool IsMan { get; set; }

        public Competidor Atipico { get; set; }

        public override void CalcularMean(){
            var Competidores = Participantes.ToArray();
            double mean=0;
            for (int i = 0; i < Competidores.Length; i++)
                mean += (Competidores[i].GetMatchValueSanda());
            Mean = mean / Competidores.Length;
        }

        public override double CalcularDesviacion(Competidor participante){
            return Math.Abs(participante.GetMatchValueSanda() - Mean);
        }

        public override void GenerarNombre(string Nombre){
            
            
        } 

        public void CalcularAtipico(){

        }



    }
}
