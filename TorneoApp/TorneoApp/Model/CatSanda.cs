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
            int MinEdad = GetMinEdad();
            int MaxEdad = GetMaxEdad();
            int MinPeso = GetMinPeso();
            int MaxPeso = GetMaxPeso();
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

            Nombre =  NivelCat+" de "+MinEdad+"-"+ MaxEdad+" años de "+MinPeso+"-"+MaxPeso+"kg";
            
        } 

        public void CalcularAtipico(){
            double Desv, DesvAtyp;
            var Competidores = Participantes.ToArray();
            int contador = 0;
            Atipico = Competidores[contador]; 
            DesvAtyp= CalcularDesviacion(Atipico);
            do{                 
                Desv = CalcularDesviacion(Competidores[contador]);
                if(Desv >= DesvAtyp){
                    Atipico = Competidores[contador];
                }
                contador++;
            }while(contador < Participantes.Count);
        }
    }
}
