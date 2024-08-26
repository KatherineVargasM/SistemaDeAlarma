using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeAlarma.models;


namespace SistemaDeAlarma.controller
{
    public class eventosController
    {
        public eventosModel InsertarEvento(eventosModel evento)
        {
            return eventosModel.Insertar(evento);
        }

        public string ActualizarEvento(eventosModel evento)
        {
            return eventosModel.Actualizar(evento);
        }

        public string EliminarEvento(int idEvento)
        {
            return eventosModel.Eliminar(idEvento);
        }

        public eventosModel ObtenerEventoPorId(int idEvento)
        {
            return eventosModel.ObtenerPorId(idEvento);
        }

        public List<eventosModel> ObtenerTodosLosEventos()
        {
            return eventosModel.ObtenerTodos();
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
