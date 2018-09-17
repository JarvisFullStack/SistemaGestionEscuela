using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscuela.Entidades
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public int CursoId { get; set; }

        public Estudiante()
        {
            EstudianteId = 0;
            Nombre = string.Empty;
            Matricula = string.Empty;
            CursoId = 0;
        }

        public Estudiante(int estudianteId, String nombre, String matricula, int cursoId)
        {
            EstudianteId = estudianteId;
            Nombre = nombre;
            Matricula = matricula;
            CursoId = cursoId;
        }
    }
}
