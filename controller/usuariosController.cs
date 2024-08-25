using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeAlarma;
using SistemaDeAlarma.models;

namespace SistemaDeAlarma.controller
{
    public class usuariosController
    {
        public usuariosModel InsertarUsuario(usuariosModel usuario)
        {
            return usuariosModel.Insertar(usuario);
        }

        public string ActualizarUsuario(usuariosModel usuario)
        {
            return usuariosModel.Actualizar(usuario);
        }

        public string EliminarUsuario(int idUsuario)
        {
            return usuariosModel.Eliminar(idUsuario);
        }

        public usuariosModel ObtenerUsuarioPorId(int idUsuario)
        {
            return usuariosModel.ObtenerPorId(idUsuario);
        }

        public List<usuariosModel> ObtenerTodosLosUsuarios()
        {
            return usuariosModel.ObtenerTodos();
        }
    }
}
