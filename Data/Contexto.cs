using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaUniversitario.Models;

namespace SistemaUniversitario.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripciones> Inscripcion { get; set; }
        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Asignaturas> Asginatura { get; set; }
        public DbSet<Pagos> Pago { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite(@"Data source=Database/SistemaUniversitario.db"));
        }
    }
}
