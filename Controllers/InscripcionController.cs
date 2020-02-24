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
    public class InscripcionController
    {

        public bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            if (inscripciones.InscripcionId == 0)
                paso =Insertar(inscripciones);
            else
                paso =Modificar(inscripciones);

            return paso;
        }
        private bool Insertar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();

             db.Inscripcion.Add(inscripciones);
            paso = db.SaveChanges() > 0;


            return paso;
        }
        private bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Entry(inscripciones).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Inscripciones Buscar(int Id)
        {

            Contexto db = new Contexto();
            Inscripciones ins;
            ins = db.Inscripcion.Find(Id);

            return ins;

        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Inscripciones inscripciones=db.Inscripcion.Find(Id);
            db.Entry(inscripciones).State = EntityState.Deleted;
            paso = db.SaveChanges() > 0;

            return paso;

        }
        public List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> expression)
        {
            List<Inscripciones> lista = new List<Inscripciones>();
            Contexto db = new Contexto();

            lista = db.Inscripcion.Where(expression).ToList();

            return lista;
        }


    }
}
