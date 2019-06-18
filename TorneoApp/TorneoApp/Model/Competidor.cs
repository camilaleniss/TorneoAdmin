using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    class Competidor
    {
        //Categorias de los participantes según tiempo de entrenamiento
        public const int PRINCIPIANTE = 1;
        public const int INTERMEDIO = 2;
        public const int AVANZADO = 3;
        public const int CINTANEGRA = 4;

        //Nombre competidor
        private string Name { get; }

        //Apellido competidor
        private string Lastname { get; }

        //Género true=hombre false=mujer
        private bool IsMan { get; set; }

        //Escuela a la que pertenece
        private Escuela Escuela { get; set; }

        //Edad 
        private int Edad { get; set; }

        //Peso en kg
        private int Peso { get; set; }

        //Tiempo entrenando 1,2, 3 o 4
        private int TiempoEntrenando { get; set; }

        //Si está inscrito a Sanda
        private bool Sanda { get; set; }

        //Si está inscrito a Formas
        private bool Formas { get; set; }

        //A qué categorias de formas está inscrito
        private List<Forma> ListaFormas { get; set; }

        //Si es cinturon negro
        private bool IsBlackBelt { get; set; }

        //Nombre de la eps
        private string Eps { get; set; }

        //Nombre completo del acudiente
        private string ContactName { get; set; }

        //Telefono del acudiente
        private string Telefono { get; set; }

        //Email del competidor
        private string Email { get; set; }

        //Si está presente el competidor
        private bool IsHere { get; set; }

        public Competidor(string Name, string LastName, bool IsMan, int Edad, int Peso,
            bool Formas, bool Sanda, bool IsBlackBelt, string Eps, string ContactName, 
            string Telefono, string Email)
        {
            this.Name = Name;
            this.Lastname = LastName;
            this.IsMan = IsMan;
            this.Edad = Edad;
            this.Peso = Peso;
            this.Formas = Formas;
            this.Sanda = Sanda;
            this.IsBlackBelt = IsBlackBelt;
            this.Eps = Eps;
            this.ContactName = ContactName;
            this.Telefono = Telefono;
            this.Email = Email;

            if (Formas)
            {
                ListaFormas = new List<Forma>();
            }

            //Hay que hacer en la clase Torneo, el clasificador
            TiempoEntrenando = 0;
            Escuela = null;
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
    }
}
