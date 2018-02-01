using Puntos.BLL;
using Puntos.DAL;
using Puntos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puntos
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (pagoIDtextBox.Text == String.Empty || nombretextBox.Text == String.Empty || estudianteIDtextBox.Text == String.Empty || observacionestextBox.Text == String.Empty)
            {
                vacioerrorProvider.SetError(pagoIDtextBox, "Trate de no dejar nada vacio");
            }
            else
            {
                Pagos p = LlenaClase();
                if (PagosBLL.Guardar(p))
                    MessageBox.Show("Acaba de Registrar su pago");
                else
                    MessageBox.Show("No se pudo registrar su pago");
            }
        }

        private Pagos LlenaClase()
        {
            Pagos p = new Pagos();

            p.PagosID = 0;
            p.Nombre = nombretextBox.Text;
            p.Monto = int.Parse(montonumericUpDown.ToString());
            p.Fecha = fechadateTimePicker.Text;
            p.EstudianteID = int.Parse(estudianteIDtextBox.ToString());
            p.Observaciones = observacionestextBox.Text;

            return p;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            pagoIDtextBox.Text = String.Empty;
            nombretextBox.Text = String.Empty;
            fechadateTimePicker.Text = String.Empty;
            estudianteIDtextBox.Text = String.Empty;
            observacionestextBox.Text = String.Empty;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int Id = 0;
            Contexto d = new Contexto();

            int.TryParse(pagoIDtextBox.Text, out Id);

            var t = d.Pago.Find(Id);

            d.Pago.Remove(t);
            d.SaveChanges();
        }


    }
}
