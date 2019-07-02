using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class MatchFormas
    {
        public IDictionary<Forma, List<CatFormas>> CategoriasFormas;

        public List<Competidor> Competidores;

        public MatchFormas(List<Forma> FormasAbiertas, List<Competidor> Competidores)
        {
            CategoriasFormas = new Dictionary<Forma, List<CatFormas>>();

            foreach(Forma formaabierta in FormasAbiertas)
            {
                CategoriasFormas.Add(formaabierta, null);
            }

            this.Competidores = Competidores;

            /*
             * Estrategia a utilizar:
             * Primero se va a separar en cada KEY los competidores inscritos a cada forma
             * Cada KEY es una Forma en particular
             * Luego en cada KEY se van a crear dos listas de competidores, mayores y menores de edad
             * Luego en cada lista de competidores se van a realizar mas separaciones que se agregaran a la lista
             * Luego se van a verificar en tamaño si deben quedar así
             * Las listas deben de estar ordenadas de manera que vaya aumentando su nivel
             * Cuando ya se tengan las listas debe haber un método que devuelva la lista de categorias que
             * resultaron del match. 
             * */
        }
        
        public void SepararFormas()
        {

        }

        public List<Competidor> SepararForma(Forma Forma)
        {
            return null;
        }

        public void SepararEdades()
        {

        }

        public void SegmentarEdades()
        {

        }

        public void SegmentarNivel()
        {

        }

        public void VerificarSizeCategorias()
        {

        }

        public List<Categoria> RetornarCategorias()
        {
            return null;
        }

    }
}
