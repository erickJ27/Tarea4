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
        public int AsignaturaId { get; set; }
        public string DescripcionAsignatura { get; set; }
        public int Creditos { get; set; }
        public decimal SubTotal { get; set; }

        public InscripcionesDetalle()
        {
            DetalleId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            DescripcionAsignatura = string.Empty;
            Creditos = 0;
            SubTotal = 0;
        }
    }
}
