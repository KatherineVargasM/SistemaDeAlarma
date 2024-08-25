using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeAlarma.models;

namespace SistemaDeAlarma.controller
{
    public class ubicacionesController
    {
        public ubicacionesModel InsertarUbicacion(ubicacionesModel ubicacion)
        {
            return ubicacionesModel.Insertar(ubicacion);
        }

        public string ActualizarUbicacion(ubicacionesModel ubicacion)
        {
            return ubicacionesModel.Actualizar(ubicacion);
        }

        public string EliminarUbicacion(int idUbicacion)
        {
            return ubicacionesModel.Eliminar(idUbicacion);
        }

        public ubicacionesModel ObtenerUbicacionPorId(int idUbicacion)
        {
            return ubicacionesModel.ObtenerPorId(idUbicacion);
        }

        public List<ubicacionesModel> ObtenerTodasLasUbicaciones()
        {
            return ubicacionesModel.ObtenerTodos();
        }
    }
}
