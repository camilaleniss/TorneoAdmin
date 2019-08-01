using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    [Serializable]
    public class Competidor
    {
        //Categorias de los participantes según tiempo de entrenamiento
        public const int PRINCIPIANTE = 1;
        public const int INTERMEDIO = 2;
        public const int AVANZADO = 3;
        public const int CINTANEGRA = 4;

        //Nombre completo competidor
        public string Name { get; }

        //Género true=hombre false=mujer
        public bool IsMan { get; set; }

        //Escuela a la que pertenece
        public Escuela Escuela { get; set; }

        //Edad 
        public int Edad { get; set; }

        //Peso en kg
        public int Peso { get; set; }

        //Tiempo entrenando 1,2, 3 o 4
        public int TiempoEntrenando { get; set; }

        //Si está inscrito a Sanda
        public bool Sanda { get; set; }

        //Si está inscrito a Formas
        public bool Formas { get; set; }

        //A qué categorias de formas está inscrito
        public List<Forma> ListaFormas { get; set; }

        //Si es cinturon negro
        public bool IsBlackBelt { get; set; }

        //Nombre de la eps
        public string Eps { get; set; }

        public string TelefonoPersonal { get; set; }

        //Nombre completo del acudiente
        public string ContactName { get; set; }

        //Telefono del acudiente
        public string TelefonoAcudiente { get; set; }

        //Email del competidor
        public string Email { get; set; }

        //Si está presente el competidor
        public bool IsHere { get; set; }

        public Competidor(string Name, bool IsMan, int Edad, int Peso, bool IsBlackBelt, 
            int TiempoEntrenando, string Eps, string TelefonoPersonal,
            string ContactName, string TelefonoAcudiente, string Email, Escuela Escuela)
        {
            this.Name = Name;
            this.IsMan = IsMan;
            this.Edad = Edad;
            this.Peso = Peso;
            this.IsBlackBelt = IsBlackBelt;
            this.TiempoEntrenando = TiempoEntrenando;
            this.Eps = Eps;
            this.TelefonoPersonal = TelefonoPersonal;
            this.ContactName = ContactName;
            this.TelefonoAcudiente = TelefonoAcudiente;
            this.Email = Email;
            this.Escuela = Escuela;

            Sanda = false;
            Formas = false;
            IsHere = false;

            ListaFormas = new List<Forma>();
        }

        public void AddForma (Forma Forma)
        {
            ListaFormas.Add(Forma);
        }

        public bool ExistForma(Forma Forma)
        {
            if (ListaFormas.Contains(Forma))
                return true;

            return false;
        }

        public int GetMatchValue()
        {
            if (Edad >= 18) return (TiempoEntrenando>2) ? TiempoEntrenando*2 : TiempoEntrenando;

            return TiempoEntrenando + Edad;
        }

        //Para Sanda se hace una ponderación de la edad y el peso
        //entre el nivel 
        public double GetMatchValueSanda(){
            return (Edad+Peso)/TiempoEntrenando;
        }

        public string getNivel()
        {
            switch(TiempoEntrenando){
                case Competidor.PRINCIPIANTE:
                    return  "Principiante";
                case Competidor.INTERMEDIO:
                    return "Intermedio";
                case Competidor.AVANZADO:
                    return "Avanzado";               
            }
            return "Cinta Negra";
        }

        public string GetStringGenere()
        {
            return IsMan ? "Masculino" : "Femenino";
        }
        
        public String ToString()
        {
            return Name + " / " + getNivel() + " / " + Peso + "kg / " + Edad + " años ";
        }

    }
}
