using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela.Entidades
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public Curso()
        {
            CursoId = 0;
            Descripcion = String.Empty;
            Cantidad = 0;
        }

        public Curso(int id, string descripcion, int cantidad)
        {
            CursoId = id;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }
    }
}
