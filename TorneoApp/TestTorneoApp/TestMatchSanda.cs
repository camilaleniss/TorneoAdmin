using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorneoApp.Model;
using System;
using System.Collections.Generic;

namespace TestTorneoApp
{
    [TestClass]
    public class TestMatchSanda
    {
        private MatchSanda Matchmaking;

        private Torneo Torneo;

        public TestMatchSanda()
        {
            Torneo = new Torneo();
        }

        public void SetUpStage1()
        {
            Torneo = new Torneo();
            string URL = "..\\..\\..\\RegistroTest5.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            Torneo.LeerCompetidores(lectura);
        }

        public void SetUpStage2()
        {
            Torneo = new Torneo();
            string URL = "..\\..\\..\\RegistroTest6.csv";
            List<string[]> lectura = Torneo.leerCSV(URL);
            Torneo.LeerCompetidores(lectura);
        }

        [TestMethod]
        public void TestMatchCategorias()
        {
            SetUpStage1();
            List<Competidor> Competidores = Torneo.Competidores;
            Matchmaking = new MatchSanda(Competidores);

            List<CatSanda> Categorias = Matchmaking.DoMatch();

            Assert.IsTrue( Categorias.Count==20);

            List<CatSanda> TempCat = Categorias.FindAll(categoria => categoria.IsMan == false);

            Assert.IsTrue(TempCat.Count == 10);
            Assert.IsTrue(TempCat.FindAll(categoria => categoria.IsMayorEdadCategory()).Count == 5);

            TempCat = Categorias.FindAll(categoria => categoria.IsMan);

            Assert.IsTrue(TempCat.Count == 10);
            Assert.IsTrue(TempCat.FindAll(categoria => categoria.IsMayorEdadCategory()).Count == 5);

        }

       
    }
}
