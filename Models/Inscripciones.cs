using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaUniversitario.Models
{
    public class Inscripciones
    {
        [Key]

        public int InscripcionId { get; set; }
        [Required(ErrorMessage ="El semestre no puede estar vacio")]
        public DateTime Fecha { get; set; }
        public string Semestre { get; set; }
        [Required]
        [Range(minimum:1,maximum:27,ErrorMessage ="Cantidad de creditos no validos maximos 27")]
        public int Limite { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 27, ErrorMessage = "el limite de creditos tomados es 27")]
        public int Tomados { get; set; }
        public int Disponibles { get; set; }
        public int EstudianteId { get; set; }
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles=0;
            EstudianteId = 0;
            Monto = 0;
            Balance = 0;
        }
    }

    
}
