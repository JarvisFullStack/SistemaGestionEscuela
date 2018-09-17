using SistemaEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
