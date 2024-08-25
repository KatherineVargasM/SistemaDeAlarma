using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeAlarma.models;
using SistemaDeAlarma.config;

namespace SistemaDeAlarma.controller
{
    public class sensoresController
    {
        public sensoresModel InsertarSensor(sensoresModel sensor)
        {
            return sensoresModel.Insertar(sensor);
        }

        public string ActualizarSensor(sensoresModel sensor)
        {
            return sensoresModel.Actualizar(sensor);
        }

        public string EliminarSensor(int idSensor)
        {
            return sensoresModel.Eliminar(idSensor);
        }

        public sensoresModel ObtenerSensorPorId(int idSensor)
        {
            return sensoresModel.ObtenerPorId(idSensor);
        }

        public List<sensoresModel> ObtenerTodosLosSensores()
        {
            return sensoresModel.ObtenerTodos();
        }
    }
}
