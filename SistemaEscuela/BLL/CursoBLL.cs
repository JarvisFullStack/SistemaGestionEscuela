using SistemaEscuela.DAL;
using SistemaEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela.BLL
{
    public class CursoBLL
    {
        public static bool Guardar(Curso curso)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Curso.Add(curso) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }


            return paso;
        }

        public static bool Modificar(Curso curso)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(curso).State = System.Data.Entity.EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Curso curso = contexto.Curso.Find(id);
                contexto.Curso.Remove(curso);
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }

        public static Curso Buscar(int id)
        {
            Curso curso = new Curso();
            Contexto contexto = new Contexto();
            try
            {
                curso = contexto.Curso.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return curso;
        }

        public static List<Curso> GetList(Expression<Func<Curso, bool>> expression)
        {
            List<Curso> lista = new List<Curso>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Curso.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return lista;
        }
    }
}
