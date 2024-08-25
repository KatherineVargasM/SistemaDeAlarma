using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlarma.config
{
    public static class ControlErrores
    {
        public static void ManejarErrorSql(Exception ex, string mensajePersonalizado = "Ocurrio un error en la base de datos.")
        {
            MessageBox.Show($"{mensajePersonalizado}\n\nDetalles del error:\n{ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ManejarErrorGeneral(Exception ex = null, string mensajePersonalizado = "Ocurrio un error inesperado.")
        {
            if (ex != null)
            {
                MessageBox.Show($"{mensajePersonalizado}\n\nDetalles del error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(mensajePersonalizado);
            }
        }

        public static void ManejarInsertar()
        {
            MessageBox.Show("Se ha agregado con éxito.", "Información", MessageBoxButtons.OK);
        }

        public static void ManejarActualizar()
        {
            MessageBox.Show("Se ha actualizado con éxito.", "Información", MessageBoxButtons.OK); ;
        }

        public static void ManejarEliminar()
        {
            MessageBox.Show("Se ha eliminado con éxito.", "Información", MessageBoxButtons.OK);
        }
    }
}
