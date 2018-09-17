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
    public class EstudianteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            int id = CursoBLL.Buscar(3).CursoId;
            if (id != 3) Assert.Fail();
            Estudiante estudiante = new Estudiante() {
                Nombre = "Felipe",
                Matricula = "2016-0580",
                CursoId = id
            };
            Estudiante estudiante2 = new Estudiante()
            {
                Nombre = "Felipe",
                Matricula = "2016-0580",
                CursoId = id
            };
            bool paso = EstudianteBLL.Guardar(estudiante);
            EstudianteBLL.Guardar(estudiante2);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Estudiante estudiante = new Estudiante()
            {
                EstudianteId = 2,
                Nombre = "Nuevo nombre",
                Matricula = "asd",
                CursoId = 2
                
            };
            bool paso = EstudianteBLL.Modificar(estudiante);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = EstudianteBLL.Eliminar(3);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Estudiante> lista = new List<Estudiante>();
            lista = EstudianteBLL.GetList(x => true);
            bool paso = lista.Count() > 0;
            Assert.AreEqual(true, paso);
        }
    }
}