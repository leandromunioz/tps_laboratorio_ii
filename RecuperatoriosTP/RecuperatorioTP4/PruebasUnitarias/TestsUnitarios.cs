using Gimnasio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestsUnitarios
    {
        [TestMethod]
        public void Test_AgregarElementoALaLista_CuandoNoHayaElementosEnLaLista_DeberiaRetornarTrue()

        {

            //Arrange:

            Sistema<Clientes> sistema = new Sistema<Clientes>();

            Clientes cliente = new Clientes("pepe", "guerrero", "39487913", new System.DateTime(1996 / 12 / 21), "Mendoza 555", System.DateTime.Today);
            bool resultado;

            //Act:

            resultado = sistema.AgregarElemento(cliente);

            //Assert:

            Assert.AreEqual(true, resultado);

        }

        [TestMethod]
        public void Test_AgregarElementoALaLista_CuandoHayaElementosEnLaLista_DeberiaRetornarTrue()

        {

            //Arrange:

            Sistema<Clientes> sistema = new Sistema<Clientes>();

            Clientes cliente = new Clientes("pepe", "guerrero", "39487913", new System.DateTime(1996 / 12 / 21), "Mendoza 555", System.DateTime.Today);
            Clientes cliente2 = new Clientes("papa", "garcia", "44361856", new System.DateTime(1996 / 11 / 23), "Calzada 25", System.DateTime.Today);

            bool resultado;

            //Act:

            resultado = sistema.AgregarElemento(cliente);
            resultado = sistema.AgregarElemento(cliente2);


            //Assert:

            Assert.AreEqual(true, resultado);


        }


        [TestMethod]

        public void Test_AgregarElementoALaLista_CuandoElElementoDniSeaIgual_DeberiaRetornarFalse()

        {

            //Arrange:

            Sistema<Clientes> sistema = new Sistema<Clientes>();

            Clientes cliente = new Clientes("pepe", "guerrero", "39487913", new System.DateTime(1996 / 12 / 21), "Mendoza 555", System.DateTime.Today);
            Clientes cliente2 = new Clientes("papa", "garcia", "39487913", new System.DateTime(1996 / 12 / 21), "Mendoza 22", System.DateTime.Today);

            bool resultado;

            //Act:

            resultado = sistema.AgregarElemento(cliente);
            resultado = sistema.AgregarElemento(cliente2);


            //Assert:

            Assert.AreEqual(false, resultado);




        }


        [TestMethod]
        public void Test_BuscarElemento_CuandoElElementoNoExista_DeberiaRetornarNull()

        {

            //Arrange:

            Sistema<Clientes> sistema = new Sistema<Clientes>();

            Clientes cliente = new Clientes("pepe", "guerrero", "39487913", new System.DateTime(1996 / 12 / 21), "Mendoza 555", System.DateTime.Today);

            //Act:

            cliente = sistema.BuscarElemento(cliente);

            //Assert:

            Assert.AreEqual(null, cliente);

        }

        [TestMethod]
        public void Test_BuscarElemento_CuandoElElementoExista_DeberiaRetornarElElemento()

        {

            //Arrange:

            Sistema<Clientes> sistema = new Sistema<Clientes>();

            Clientes cliente = new Clientes("pepe", "guerrero", "39487913", new System.DateTime(1996 / 12 / 21), "Mendoza 555", System.DateTime.Today);
            Clientes clienteEsperado;
            sistema.AgregarElemento(cliente);
            //Act:

            clienteEsperado = sistema.BuscarElemento(new Clientes("aa", "aa", "39487913", new System.DateTime(1996 / 12 / 21), "Mendoza 555", System.DateTime.Today));

            //Assert:

            Assert.AreEqual(cliente, clienteEsperado);

        }

    }
}
