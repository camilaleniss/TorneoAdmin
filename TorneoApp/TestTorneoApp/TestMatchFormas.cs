using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorneoApp.Model;
using System;
using System.Collections.Generic;

namespace TestTorneoApp
{
    [TestClass]
    public class TestMatchFormas
    {
        private MatchFormas Matchmaking;

        private Torneo Torneo;

        public TestMatchFormas()
        {
            Torneo = new Torneo();
        }

        public void SetUpStage1()
        {
            Torneo = new Torneo();
            string URL = "..\\..\\..\\RegistroTest3.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            Torneo.LeerCompetidores(lectura);
        }

        public void SetUpStage2()
        {
            Torneo = new Torneo();
            string URL = "..\\..\\..\\RegistroTest4.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            Torneo.LeerCompetidores(lectura);
        }

        [TestMethod]
        public void TestMatchCategorias()
        {
            SetUpStage1();
            List<Forma> FormasAbiertas = Torneo.Formas;
            List<Competidor> Competidores = Torneo.Competidores;

            Matchmaking = new MatchFormas(FormasAbiertas, Competidores);

            List<CatFormas> Categorias = Matchmaking.DoMatch();

            List<CatFormas> MenoresEdad = Categorias.FindAll(cat => cat.IsMayorEdadCategory() == false);
            List<CatFormas> MayoresEdad = Categorias.FindAll(cat => cat.IsMayorEdadCategory());
            //Verificaciones primer caso
            //Todas los competidores estan inscritos a la misma forma
            //Hay 4 en cada categoria de menores de edad y 3 en la de mayores de edad
            //Hay 4 categorias de menores de edad y una en mayores de edad 
            //Solo verifica menores

            Assert.IsTrue(Categorias.Count == 8);
            Assert.IsTrue(MayoresEdad.Count == 4);
            Assert.IsTrue(MenoresEdad.Count == 4);

            //Verificar Menores Edad
            CatFormas tempcat = MenoresEdad[0];
            Assert.IsTrue(tempcat.GetMinEdad() == 6);
            Assert.IsTrue(tempcat.GetMaxEdad() == 8);
            tempcat = MenoresEdad[1];
            Assert.IsTrue(tempcat.GetMinEdad() == 9);
            Assert.IsTrue(tempcat.GetMaxEdad() == 11);
            tempcat = MenoresEdad[2];
            Assert.IsTrue(tempcat.GetMinEdad() == 12);
            Assert.IsTrue(tempcat.GetMaxEdad() == 14);
            tempcat = MenoresEdad[3];
            Assert.IsTrue(tempcat.GetMinEdad() == 15);
            Assert.IsTrue(tempcat.GetMaxEdad() == 17);

            //Verificar Mayores Edad
            tempcat = MayoresEdad[0];
            Assert.IsTrue(tempcat.Participantes.ToArray()[0].TiempoEntrenando == Competidor.PRINCIPIANTE);
            tempcat = MayoresEdad[1];
            Assert.IsTrue(tempcat.Participantes.ToArray()[0].TiempoEntrenando == Competidor.INTERMEDIO);
            tempcat = MayoresEdad[2];
            Assert.IsTrue(tempcat.Participantes.ToArray()[0].TiempoEntrenando == Competidor.AVANZADO);
            tempcat = MayoresEdad[3];
            Assert.IsTrue(tempcat.Participantes.ToArray()[0].TiempoEntrenando == Competidor.CINTANEGRA);
        }

        [TestMethod]
        public void TestMatchVerificar()
        {
            SetUpStage2();
            List<Forma> FormasAbiertas = Torneo.Formas;
            List<Competidor> Competidores = Torneo.Competidores;

            Matchmaking = new MatchFormas(FormasAbiertas, Competidores);

            List<CatFormas> Categorias = Matchmaking.DoMatch();

            List<CatFormas> MenoresEdad = Categorias.FindAll(cat => cat.IsMayorEdadCategory() == false);
            List<CatFormas> MayoresEdad = Categorias.FindAll(cat => cat.IsMayorEdadCategory());

            /*
             *  Se deberian formar las siguientes categorias:
             * Forma sin arma:
             * 4 categorias
             * Dos categorias de menores de edad
             * una de 6-9 años
             * otra de 10-12 años 
             * Dos de mayores de edad
             * Una con 4 PRINCIPIANTES y un INTERMEDIO
             * Una con 4 AVANZADOS y un CINTANEGRA
             * Forma con arma:
             * 3 Categorias
             * Una de menores de edad de 7-12 años
             * Dos de mayores de edad
             * Una con 3 INTERMEDIOS Y un PRINCIPIANTE
             * Una con 4 CINTANEGRA y un AVANZADO
             */

            Assert.IsTrue(Categorias.Count == 7);
            Assert.IsTrue(MenoresEdad.Count == 3);
            Assert.IsTrue(MayoresEdad.Count == 4);


        }
    }
}
