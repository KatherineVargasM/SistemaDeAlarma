using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeAlarma.models;

namespace SistemaDeAlarma.controller
{
    public class lecturasController
    {
        public lecturasModel InsertarLectura(lecturasModel lectura)
        {
            return lecturasModel.Insertar(lectura);
        }

        public string ActualizarLectura(lecturasModel lectura)
        {
            return lecturasModel.Actualizar(lectura);
        }

        public string EliminarLectura(int idLectura)
        {
            return lecturasModel.Eliminar(idLectura);
        }

        public lecturasModel ObtenerLecturaPorId(int idLectura)
        {
            return lecturasModel.ObtenerPorId(idLectura);
        }

        public List<lecturasModel> ObtenerTodasLasLecturas()
        {
            return lecturasModel.ObtenerTodos();
        }
    }
}
