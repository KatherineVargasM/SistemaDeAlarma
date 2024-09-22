using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeAlarma.models;

namespace SistemaDeAlarma.controller
{
    public class alertasController
    {
        public alertasModel InsertarAlerta(alertasModel alerta)
        {
            return alertasModel.Insertar(alerta);
        }

        public bool ActualizarAlerta(alertasModel alerta)
        {
            return alertasModel.Actualizar(alerta);
        }

        public string EliminarAlerta(int idAlerta)
        {
            return alertasModel.Eliminar(idAlerta);
        }

        public alertasModel ObtenerAlertaPorId(int idAlerta)
        {
            return alertasModel.ObtenerPorId(idAlerta);
        }

        public List<alertasModel> ObtenerTodasLasAlertas()
        {
            return alertasModel.ObtenerTodos();
        }

        public List<usuariosModel> ObtenerTodosLosUsuarios()
        {
            return usuariosModel.ObtenerTodos();
        }

        public List<sensoresModel> ObtenerTodosLosSensores()
        {
            return sensoresModel.ObtenerTodos();
        }
    }
}

