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
        public bool Genere { get; set; }

        public List<Combate> RondaDeCombates(List<Competidor> participantes)
        {
            List<Combate> combates = new List<Combate>();
            Random rand = new Random();
            List<int> possible = Enumerable.Range(1, participantes.Count).ToList();
            for (int i = 0; i < participantes.Count()/2; i++)
            {
                int index = rand.Next(0, possible.Count);
                possible.RemoveAt(index);
                int index2 = rand.Next(0, possible.Count);
                possible.RemoveAt(index);
                Combate c = new Combate(participantes[index], participantes[index2]);
                combates.Add(c);
            }
            if(possible.Count > 0)
            {   
                //Solucion temporal a competidores impares 
                //Se debe crear una variable dummy para estas situaciones
                Combate c = new Combate(participantes[possible[0]], participantes[possible[0]]);
                combates.Add(c);
            }
           
            return combates;
        }
    }
}
