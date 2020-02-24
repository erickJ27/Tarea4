using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaUniversitario.Models;
using SistemaUniversitario.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SistemaUniversitario.Controllers
{
    public class EstudianteController
    {
        public bool Guardar(Estudiantes estudiantes)
        {
            bool paso = false;
            if (estudiantes.EstudianteId == 0)
                paso = Insertar(estudiantes);
            else
                paso = Modificar(estudiantes);

            return paso;
        }
        private bool Insertar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.Estudiante.Add(estudiantes);
            paso = db.SaveChanges() > 0;


            return paso;
        }
        private bool Modificar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Entry(estudiantes).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }
        public Estudiantes Buscar(int Id)
        {

            Contexto db = new Contexto();
            Estudiantes est;
            est = db.Estudiante.Find(Id);

            return est;

        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Estudiantes estudiantes = db.Estudiante.Find(Id);
            db.Entry(estudiantes).State = EntityState.Deleted;
            paso = db.SaveChanges() > 0;

            return paso;

        }
        public List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> expression)
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            Contexto db = new Contexto();

            lista = db.Estudiante.Where(expression).ToList();

            return lista;
        }
    }
}
