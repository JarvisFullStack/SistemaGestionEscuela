using SistemaEscuela.DAL;
using SistemaEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela.BLL
{
    public class EstudianteBLL
    {
        
        public static bool Guardar(Estudiante estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

                if (contexto.Estudiante.Add(estudiante) != null)
                {
                    Curso curso = contexto.Curso.Find(estudiante.CursoId);
                    curso.Cantidad += 1;
                    contexto.Entry(curso).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }

        public static bool Modificar(Estudiante estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(estudiante).State = System.Data.Entity.EntityState.Modified;
         
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Estudiante estudiante = contexto.Estudiante.Find(id);
                Curso curso = contexto.Curso.Find(estudiante.CursoId);
                curso.Cantidad -= 1;
                contexto.Entry(curso).State = System.Data.Entity.EntityState.Modified;
                contexto.Estudiante.Remove(estudiante);
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return paso;
        }

        public static Estudiante Buscar(int id)
        {
            Estudiante estudiante = new Estudiante();
            Contexto contexto = new Contexto();
            try
            {
                estudiante = contexto.Estudiante.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return estudiante;

        }

        public static List<Estudiante> GetList(Expression<Func<Estudiante, bool>> expression)
        {
            List<Estudiante> lista = new List<Estudiante>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Estudiante.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return lista;
        }
        
    }
}
