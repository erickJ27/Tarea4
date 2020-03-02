using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaUniversitario.Models
{
    public class InscripcionesDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int InscripcionId { get; set; }


    }
}
