using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class MatchSanda
    {
        public const int NUMSEGEDAD = 11;
        public List<Competidor> Competidores;

        public List<CatSanda> CategoriasSanda;

        public MatchSanda(List<Competidor> Competidores)
        {
            this.Competidores = Competidores;
            /*
            *Estrategia a utilizar
            *Primero se separa por género
            *Luego se separa cada género por TiempoEntreno
            *Luego se separa por Edad, de acuerdo a los RQ
            *Se verifican las categorias habilitadas
            *Se saca la media y el dato más atipico de cada 
            *categoria habilitada
            *Insertan todos los datos más atyp en la lista
            *de competidores restantes
            *Se hace la estrategia para insertar competidores
            *restantes
            *Se retornan las categorias.
             */

        

        }

        public void SepararGeneros(){
            bool IsMan = false;
            for (int i=0; i<2; i++){
                CatSanda Categoria = new CatSanda();
                Categoria.IsMan= IsMan; 
                List<Competidor> TempComp = Competidores.FindAll(competidor => competidor.IsMan == IsMan);
                Categoria.Participantes = TempComp;
                CategoriasSanda.Add(Categoria);
                IsMan= true;
            }            
        }

        public List<CatSanda> SepararNiveles(CatSanda Categoria){
            
            List<CatSanda> CategoriasSegmentadas = new List<CatSanda>();
            
            List<Competidor> Participantes = Categoria.Participantes;

            for (int i=0; i<Competidor.CINTANEGRA; i++){
                if (Participantes.Exists(comp => comp.TiempoEntrenando== i+1)){
                    var Temp = Participantes.FindAll(participante => participante.TiempoEntrenando == i+1);
                    CatSanda TempCat = new CatSanda();
                    TempCat.Participantes = Temp;
                    CategoriasSegmentadas.Add(TempCat);
                }
            }

            return CategoriasSegmentadas;
        }

        
        public List<CatSanda> SepararEdad(CatSanda Categoria){           
            var CompetidoresCategoria = Categoria.Participantes.ToArray();
            Dictionary<int, List<Competidor>> Segmentacion = new Dictionary<int, List<Competidor>>();

            for(int i=0; i<NUMSEGEDAD; i++)
                Segmentacion.Add(i+1, new List<Competidor>());


            for (int i =0; i<CompetidoresCategoria.Length; i++){
                int MatchValue = GetMatchEdad(CompetidoresCategoria[i]);
                //Revisar sí esto no borra un dato anterior
                Segmentacion[MatchValue].Add(CompetidoresCategoria[i]);
            } 
            
             List<CatSanda> CategoriasSegmentadas = ConvertDictionary(Segmentacion);
            
            return CategoriasSegmentadas;
        }

        public int GetMatchEdad(Competidor c){
            int Edad = c.Edad;

            if (Edad>= 6 && Edad<=8) return 0;
            if (Edad>=9 && Edad<=11) return 1;
            if (Edad>=12 && Edad<=14) return 2;
            if(Edad>=15 && Edad<=17) return 3;
            if(Edad>=18 && Edad<=35) return 4;
            if (Edad>=36 && Edad>=40) return 5;
            if (Edad>=41 && Edad>=45) return 6;
            if (Edad>=46 && Edad>=50) return 7;
            if (Edad>=51 && Edad>=55) return 8;
            if (Edad>=56 && Edad>=60) return 9;
            return 10;  
        }

        public List<CatSanda> ConvertDictionary(Dictionary<int, List<Competidor>> Abiertas){
            List<CatSanda> CategoriasAbiertas = new List<CatSanda>();

            for (int i =0; i<NUMSEGEDAD; i++){
                CatSanda TempCat = new CatSanda();
                TempCat.Participantes =Abiertas[i];
                CategoriasAbiertas.Add(TempCat);
            }
            return CategoriasAbiertas;
        }
    }

}
