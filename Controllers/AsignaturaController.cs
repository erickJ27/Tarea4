using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaUniversitario.Data;
using SistemaUniversitario.Models;

namespace SistemaUniversitario.Controllers
{
    public class AsignaturaController
    {
        public bool Guardar(Asignaturas asignaturas)
        {
            bool paso = false;
            if (asignaturas.AsignaturaId == 0)
                paso = Insertar(asignaturas);
            else
                paso = Modificar(asignaturas);

            return paso;
        }
        private bool Insertar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.Asginatura.Add(asignaturas);
            paso = db.SaveChanges() > 0;


            return paso;
        }
        private bool Modificar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Entry(asignaturas).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }
        public Asignaturas Buscar(int Id)
        {

            Contexto db = new Contexto();
            Asignaturas asi;
            asi = db.Asginatura.Find(Id);

            return asi;

        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Asignaturas asignaturas = db.Asginatura.Find(Id);
            db.Entry(asignaturas).State = EntityState.Deleted;
            paso = db.SaveChanges() > 0;

            return paso;

        }
        public List<Asignaturas> GetList(Expression<Func<Asignaturas, bool>> expression)
        {
            List<Asignaturas> lista = new List<Asignaturas>();
            Contexto db = new Contexto();

            lista = db.Asginatura.Where(expression).ToList();

            return lista;
        }
    }
}
