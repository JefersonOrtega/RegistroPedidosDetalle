using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroPedidosDetalle.BLL;
using RegistroPedidosDetalle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroPedidosDetalle.BLL.Tests
{
    [TestClass()]
    public class OrdenesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = OrdenesBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            bool paso = false;
            Ordenes orden = new Ordenes();

            orden.OrdenId = 0;
            orden.Fecha = DateTime.Now;
            orden.SuplidorId = 1;
            orden.Monto = 50000;
            orden.OrdenesDetalle = new List<OrdenesDetalle>();

            paso = OrdenesBLL.Guardar(orden);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Ordenes orden = new Ordenes();

            orden.OrdenId = 3;
            orden.Fecha = DateTime.Now;
            orden.SuplidorId = 2;
            orden.Monto = 10000;
            orden.OrdenesDetalle = new List<OrdenesDetalle>();

            paso = OrdenesBLL.Guardar(orden);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = OrdenesBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Ordenes orden;

            orden = OrdenesBLL.Buscar(1);

            if (orden != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetOrdenesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarProductosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListProductosTest()
        {
            Assert.Fail();
        }
    }
}