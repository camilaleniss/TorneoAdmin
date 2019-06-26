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

        [TestMethod]
        public void TestLeerCSV()
        {
            string URL = "..\\..\\..\\Registro.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            string[][] datos = lectura.ToArray();
            Assert.IsTrue(datos[0][2].Equals("María Lenis"));

            /*
            Torneo.LeerXLS(URL);
            Competidor[] competidores = Torneo.Competidores.ToArray();
            Assert.IsTrue(competidores[1].Name.Equals("María Lenis"));
            Assert.IsFalse(competidores[1].IsMan);
            Assert.IsTrue(competidores[1].Escuela.Name.Equals("Zhang Fei"));
            Assert.IsTrue(competidores[1].Edad == 18);
            Assert.IsTrue(competidores[1].Peso == 50);
            Assert.IsTrue(competidores[1].TiempoEntrenando == Competidor.INTERMEDIO);
            Assert.Equals(competidores[1].Eps, "Comfenalco");
            Assert.IsTrue(competidores[1].Sanda);
            Assert.IsTrue(competidores[1].Formas);
            Assert.IsFalse(competidores[1].IsBlackBelt);
            Assert.Equals(competidores[1].ContactName, "Constanza Restrepo");
            Assert.Equals(competidores[1].Telefono ,"3173694663");
            */
        }

        [TestMethod]
        public void TestLeerCompetidores()
        {
            string URL = "..\\..\\..\\Registro.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            Torneo.LeerCompetidores(lectura);

            Competidor[] competidores = Torneo.Competidores.ToArray();
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
        }
    }
}
