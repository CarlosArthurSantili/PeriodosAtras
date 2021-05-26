using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeriodosAtras;
using System;

namespace PeriodosAtrasTestes
{
    [TestClass]
    public class PeriodosAtrasTestesClasse
    {
        [TestMethod]
        public void TesteMenosQueUmDiaAtras()
        {
            DateTime dataTeste = new DateTime(2021, 05, 26, 12, 00, 00);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Uma hora e trinta minutos atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteUmDiaAtras()
        {
            DateTime dataTeste = new DateTime(2021, 05, 25);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Um dia atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteQuatroDiasAtras()
        {
            DateTime dataTeste = new DateTime(2021, 05, 22);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Quatro dias atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteUmaSemanaDoisDiasAtras()
        {
            DateTime dataTeste = new DateTime(2021, 05, 17);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Uma semana e dois dias atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteDuasSemanasAtras()
        {
            DateTime dataTeste = new DateTime(2021, 05, 12);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Duas semanas atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteTresSemanasUmDiaAtras()
        {
            DateTime dataTeste = new DateTime(2021, 05, 04);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Três semanas e um dia atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteUmMesUmaSemanaUmDiaAtras()
        {
            DateTime dataTeste = new DateTime(2021, 04, 18);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Um mês e uma semana e um dia atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteDoisMesesAtras()
        {
            DateTime dataTeste = new DateTime(2021, 03, 26);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Dois meses atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteDoisMesesUmaSemanaUmDiaAtrasAtras()
        {
            DateTime dataTeste = new DateTime(2021, 03, 18);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Dois meses e uma semana e um dia atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteDoisAnosAtras()
        {
            DateTime dataTeste = new DateTime(2019, 05, 26);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Dois anos atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteUmAnoDoisMesesAtras()
        {
            DateTime dataTeste = new DateTime(2020, 03, 26);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Um ano e dois meses atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteTresAnosNoveMesesUmaSemanaUmDiaAtras()
        {
            DateTime dataTeste = new DateTime(2017, 08, 18);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Três anos e nove meses e uma semana e um dia atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteCinquentaDoisAnosAtras()
        {
            DateTime dataTeste = new DateTime(1969, 05, 26);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Cinquenta e dois anos atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteOitentaUmAnosUmMesDuasSemanasAtras()
        {
            DateTime dataTeste = new DateTime(1940, 04, 12);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Oitenta e um anos e um mês e duas semanas atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteDezAnosSeisMesesAtras()
        {
            DateTime dataTeste = new DateTime(2010, 11, 26);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Dez anos e seis meses atrás", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteDataNoFuturo()
        {
            DateTime dataTeste = new DateTime(2027, 08, 18);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Data Inválida", controleTeste.CalcularPeriodosAtras());
        }

        [TestMethod]
        public void TesteDataNoPassadoDistante()
        {
            DateTime dataTeste = new DateTime(1027, 08, 18);

            ControleData controleTeste = new ControleData(dataTeste);

            Assert.AreEqual("Data Inválida", controleTeste.CalcularPeriodosAtras());
        }
    }
}
