using Puntos.DAL;
using Puntos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Puntos.BLL
{
    class PagosBLL
    {
        public static bool Guardar(Pagos Pago)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Pago.Add(Pago);
                contex.SaveChanges();

                paso = true;
            }

            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(Pagos TipoTelefono)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(TipoTelefono).State = EntityState.Modified;
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;

        }

        public static bool Eliminar(int TipoID)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                var t = contex.Pago.Find(TipoID);

                contex.Pago.Remove(t);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> criterioBusqueda)
        {
            List<Pagos> t = new List<Pagos>();
            try
            {
                Contexto contex = new Contexto();
                t = contex.Pago.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return t;
        }
    }
}
