using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Puntos.Entidades
{
    public class Pagos
    {
        [Key]
        public int PagosID { get; set; }
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public int Monto { get; set; }
        public string Observaciones { get; set; }

        public Pagos()
        {
            this.PagosID = 0;
            this.EstudianteID = 0;
            this.Nombre = String.Empty;
            this.Fecha = String.Empty;
            this.Monto = 0;
            this.Observaciones = String.Empty;
        }

        public Pagos(int nInscripcionID, int nEstudianteID, string nNombre, string nFecha, int nMonto, int nBalance, string nObservaciones)
        {
            PagosID = nInscripcionID;
            EstudianteID = nEstudianteID;
            Nombre = nNombre;
            Fecha = nFecha;
            Monto = nMonto;
            Observaciones = nObservaciones;
        }
    }
}
