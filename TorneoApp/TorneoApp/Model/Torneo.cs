﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoApp.Model
{
    public class Torneo
    {
        //Ruta del archivo  registro del torneo
        public const string XLS_ROUTE = "..\\..\\Registro.csv";

        //Lista de las categorias abiertas para formas
        public List<CatFormas> CategoriasFormas { get; set; }

        //Lista de las categorias abiertas para sanda
        public List<CatSanda> CategoriasSanda { get; set; }

        //Lista de las escuelas
        public List<Escuela> Escuelas { get; set; }

        //Lista de competidores
        public List<Competidor> Competidores { get; set; }

        //Lista de formas permitidas en el torneo
        public List<Forma> Formas { get; set; }

        public Torneo()
        {
            CategoriasFormas = new List<CatFormas>();

            CategoriasSanda = new List<CatSanda>();

            Escuelas = new List<Escuela>();

            Competidores = new List<Competidor>();

            Formas = new List<Forma>();
        }

        /*
         * Este método Lee el archivos CSV de los competidores y retorna una lista de el split hecho a la linea leida
         */
        public List<string[]> leerCSV(string path)
        {
            List<string[]> parsedData = new List<string[]>();

            using (StreamReader readFile = new StreamReader(path))
            {
                string line=readFile.ReadLine();
                string[] row;

                while ((line = readFile.ReadLine()) != null)
                {
                    row = line.Split(';');
                    parsedData.Add(row);
                }
            }
            return parsedData;
        }

        public void LeerCompetidores (List<string[]> Competidores)
        {
            var CompetidoresTorneo = Competidores.ToArray();
            for (int i = 0; i<CompetidoresTorneo.Length; i++)
            {
                string Email = CompetidoresTorneo[i][1].Trim();
                string Name = CompetidoresTorneo[i][2].Trim(); ;
                bool IsMan = CompetidoresTorneo[i][3].Equals("Masculino");
                string NombreEscuela = CompetidoresTorneo[i][4].Trim(); ;
                int Edad = Int32.Parse(CompetidoresTorneo[i][5]);
                int Peso = Int32.Parse(CompetidoresTorneo[i][6]);
                string Tiempo = CompetidoresTorneo[i][7];
                string Eps = CompetidoresTorneo[i][8].Trim();
                string[] Inscripcion = CompetidoresTorneo[i][9].Split(',');
                string[] Formas = CompetidoresTorneo[i][10].Split(',');
                bool IsBlackBelt = CompetidoresTorneo[i][11].Equals("Sí");
                string NombreAcudiente = CompetidoresTorneo[i][12].Trim();
                string Telefono = CompetidoresTorneo[i][13].Trim();

                //Realiza las verificaciones para crear el Competidor
                Escuela EscuelaCompetidor = AddEscuela(NombreEscuela);
                int TiempoEntrenando = GetTiempoEntrenando(Tiempo, IsBlackBelt);

                Competidor NuevoCompetidor = new Competidor(Name, IsMan, Edad, Peso, IsBlackBelt,
                    TiempoEntrenando, Eps, NombreAcudiente, Telefono, Email, EscuelaCompetidor);

                Inscripcion = QuitarEspacios(Inscripcion);
                Formas = QuitarEspacios(Formas);

                InscribirCompetidor(NuevoCompetidor, Inscripcion, Formas);
                
            }
        }

        public Escuela AddEscuela(string NombreEscuela)
        {
           
            string ActualEscuela = NombreEscuela.Trim();
            Escuela EscuelaCompetidor = BuscarEscuela(ActualEscuela);

            if(EscuelaCompetidor == null)
            {
                EscuelaCompetidor = new Escuela(NombreEscuela);
                Escuelas.Add(EscuelaCompetidor);
            }

            return EscuelaCompetidor;
                
        }

        public bool ExisteEscuela (string EscuelaAgregar)
        {
            bool Existe = Escuelas.Any(escuelaactual => escuelaactual.Name.Equals(EscuelaAgregar));
            return Existe;
        }

        public Escuela BuscarEscuela (string NombreEscuela)
        {
            if (ExisteEscuela(NombreEscuela))
            {
                Escuela Encontrada = Escuelas.Find(escuela => escuela.Name.Equals(NombreEscuela));
                return Encontrada;
            }
            return null;
        }

        public int GetTiempoEntrenando(string Descripcion, bool IsBlackBelt)
        {
            if (IsBlackBelt) return Competidor.CINTANEGRA;
            if (Descripcion.Equals("0-1 año")) return Competidor.PRINCIPIANTE;
            if (Descripcion.Equals("1-3 años")) return Competidor.INTERMEDIO;
            return Competidor.AVANZADO;
            
        }

        public string[] QuitarEspacios(string [] Arreglo)
        {
            for (int i = 0; i < Arreglo.Length; i++)
                Arreglo[i] = Arreglo[i].Trim();

            return Arreglo;
        }

        public void InscribirCompetidor (Competidor CompetidorActual, string[] Inscripcion, string[] Formas)
        {
            Competidores.Add(CompetidorActual);
            for (int i=0; i<Inscripcion.Length; i++)
            {
                if (Inscripcion[i].Equals("Sanda"))
                {
                    CompetidorActual.Sanda = true;
                }
                else
                {
                    CompetidorActual.Formas = true;
                    InscribirFormas(CompetidorActual, Formas);
                }
            }
        }

        public void InscribirFormas(Competidor Competidor, string [] Formas)
        {
            for(int i = 0; i<Formas.Length; i++)
            {
                Forma FormaAInscribir = AddForma(Formas[i]);
                Competidor.AddForma(FormaAInscribir);
            }
        }

        public Forma AddForma(string NombreForma)
        {

            string FormaActual = NombreForma.Trim();
            Forma FormaCompetidor = BuscarForma(NombreForma);

            if (FormaCompetidor == null)
            {
                FormaCompetidor = new Forma(FormaActual);
                Formas.Add(FormaCompetidor);
            }

            return FormaCompetidor;

        }

        public bool ExisteForma(string FormaAgregar)
        {
            bool Existe = Formas.Any(formaactual => formaactual.CategoriaForma.Equals(FormaAgregar));
            return Existe;
        }

        public Forma BuscarForma(string NombreForma)
        {
            if (ExisteForma(NombreForma))
            {
                Forma Encontrada = Formas.Find(forma => forma.CategoriaForma.Equals(NombreForma));
                return Encontrada;
            }
            return null;
        }


    }
}