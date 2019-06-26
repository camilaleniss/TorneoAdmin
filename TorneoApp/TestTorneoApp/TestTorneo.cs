using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorneoApp.Model;
using System;
using System.Collections.Generic;

namespace TestTorneoApp
{
    [TestClass]
    public class TestTorneo
    {
        private Torneo Torneo;

        public TestTorneo()
        {
            Torneo = new Torneo();
        }

        public void SetUpStage1()
        {
            Torneo = new Torneo();
            string URL = "..\\..\\..\\RegistroTest1.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            Torneo.LeerCompetidores(lectura);
        }

        public void SetUpStage2()
        {
            Torneo = new Torneo();
            string URL = "..\\..\\..\\RegistroTest2.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            Torneo.LeerCompetidores(lectura);
        }

        [TestMethod]
        public void TestLeerCSV()
        {
            string URL = "..\\..\\..\\RegistroTest1.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            string[][] datos = lectura.ToArray();
            Assert.IsTrue(datos[0][2].Equals("María Lenis"));
        }

        [TestMethod]
        public void TestLeerCompetidores()
        {
            Competidor[] competidores;
           
            //Test 1
            SetUpStage1();
            competidores = Torneo.Competidores.ToArray();
            Assert.IsTrue(competidores[0].Name.Equals("María Lenis"));
            Assert.IsFalse(competidores[0].IsMan);
            Assert.IsTrue(competidores[0].Escuela.Name.Equals("Zhang Fei"));
            Assert.IsTrue(competidores[0].Edad == 18);
            Assert.IsTrue(competidores[0].Peso == 50);
            Assert.IsTrue(competidores[0].TiempoEntrenando == Competidor.INTERMEDIO);
            Assert.IsTrue(competidores[0].Eps.Equals("Comfenalco"));
            Assert.IsTrue(competidores[0].Sanda);
            Assert.IsTrue(competidores[0].Formas);
            Assert.IsFalse(competidores[0].IsBlackBelt);
            Assert.IsTrue(competidores[0].ContactName.Equals("Constanza Restrepo"));
            Assert.IsTrue(competidores[0].Telefono.Equals("3173694663"));

            //Test 2
            SetUpStage2();
            competidores = Torneo.Competidores.ToArray();
            Assert.AreEqual(competidores.Length, 4);
            Assert.AreEqual(Torneo.Escuelas.Count, 3);
            Assert.AreEqual(Torneo.Formas.Count, 4);
            Assert.IsTrue(competidores[0].Sanda);
            Assert.IsTrue(competidores[0].Formas);
            Assert.AreEqual(competidores[0].ListaFormas.Count, 2);
            Assert.IsTrue(competidores[1].Sanda);
            Assert.AreEqual(competidores[1].ListaFormas.Count, 0);
            Assert.IsTrue(competidores[2].Formas);
            Assert.AreEqual(competidores[2].ListaFormas.Count, 4);
            Assert.IsTrue(competidores[3].Formas);
            Assert.AreEqual(competidores[3].ListaFormas.Count, 1);
        }
    }
}
