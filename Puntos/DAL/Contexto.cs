using Puntos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Puntos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Pagos> Pago { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
