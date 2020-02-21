using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaUniversitario.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Matricula { get; set; }
        public string Nombres { get; set; }
        public decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Matricula = string.Empty;
            Nombres = string.Empty;
            Balance = 0;
        }
    }
}
