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
    public class PagoController
    {
        public bool Guardar(Pagos pagos)
        {
            bool paso = false;
            if (pagos.PagoId == 0)
                paso = Insertar(pagos);
            else
                paso = Modificar(pagos);

            return paso;
        }
        private bool Insertar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.Pago.Add(pagos);
            paso = db.SaveChanges() > 0;


            return paso;
        }
        private bool Modificar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Entry(pagos).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }
        public Pagos Buscar(int Id)
        {

            Contexto db = new Contexto();
            Pagos pag;
            pag = db.Pago.Find(Id);

            return pag;

        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Pagos pagos = db.Pago.Find(Id);
            db.Entry(pagos).State = EntityState.Deleted;
            paso = db.SaveChanges() > 0;

            return paso;

        }
        public List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> lista = new List<Pagos>();
            Contexto db = new Contexto();

            lista = db.Pago.Where(expression).ToList();

            return lista;
        }
    }
}
