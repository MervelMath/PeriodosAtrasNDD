using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeriodosAtras.ConsoleApp;
using System;

namespace Validar.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ValidarCalculoEntradaPrincipal()
        {
            DateTime data = new DateTime(2020, 5, 25);
            Periodo periodo = new Periodo();
            string test = periodo.CalcularPeriodo(data);

            Assert.AreEqual("um ano e um dia atrás", test);
        }


        [TestMethod]
        public void ValidarMesmoDia()
        {
            DateTime data = new DateTime(2021, 5, 26, 18, 00, 00);
            Periodo periodo = new Periodo();
            string test = periodo.CalcularPeriodo(data);
            Assert.AreEqual("** horas, ** minutos e ** segundos atrás.", test);
        }


        [TestMethod]
        public void ValidarAnoMes()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(400);

            Assert.AreEqual("um ano e um mês atrás", test);
        }


        [TestMethod]
        public void ValidarMesSemana()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(40);
            Assert.AreEqual("um mês e uma semana atrás", test);
        }


        [TestMethod]
        public void ValidarMesDias()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(35);
            Assert.AreEqual("um mês e cinco dias atrás", test);
        }


        [TestMethod]
        public void ValidarSemanaDia()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(8);
            Assert.AreEqual("uma semana e um dia atrás", test);
        }


        [TestMethod]
        public void ValidarDias()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(3);
            Assert.AreEqual("três dias atrás", test);
        }


        [TestMethod]
        public void ValidarAnoDias()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(367);
            Assert.AreEqual("um ano e dois dias atrás", test);
        }


        [TestMethod]
        public void ValidarAnoSemana()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(372);
            Assert.AreEqual("um ano e uma semana atrás", test);
        }


        [TestMethod]
        public void ValidarMesDia()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(31);
            Assert.AreEqual("um mês e um dia atrás", test);
        }


        [TestMethod]
        public void ValidarSemanas()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(21);
            Assert.AreEqual("três semanas atrás", test);
        }


        [TestMethod]
        public void ValidarDia()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(1);
            Assert.AreEqual("um dia atrás", test);
        }


        [TestMethod]
        public void ValidarMes()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(30);
            Assert.AreEqual("um mês atrás", test);
        }


        [TestMethod]
        public void ValidarAno()
        {
            Periodo periodo = new Periodo();
            string test = periodo.Calculate(365);
            Assert.AreEqual("um ano atrás", test);
        }
    }
}
