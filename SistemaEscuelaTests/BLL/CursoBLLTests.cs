using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaEscuela.BLL;
using SistemaEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela.BLL.Tests
{
    [TestClass()]
    public class CursoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Curso curso = new Curso()
            {
                Descripcion = "Curso1",
                Cantidad = 0
            };
            Curso curso1 = new Curso()
            {
                Descripcion = "Curso1",
                Cantidad = 0
            };
            bool paso = CursoBLL.Guardar(curso);
            CursoBLL.Guardar(curso1);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Curso curso = new Curso()
            {
                CursoId = 2,
                Descripcion = "Nueva Descripcion",
                Cantidad = 2

            };
            bool paso = CursoBLL.Modificar(curso);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = CursoBLL.Eliminar(2);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Curso curso = CursoBLL.Buscar(2);
            bool paso = false;
            if (curso != null)
                paso = true;

            
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Curso> lista = new List<Curso>();
            lista = CursoBLL.GetList(x => true);
            bool paso = lista.Count() > 0;
            Assert.AreEqual(true, paso);
        }
    }
}