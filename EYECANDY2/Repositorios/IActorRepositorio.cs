using EYECANDY2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Repositorios
{
    public interface IActorRepositorio
    {
        Task Actualizar(ActorEdicionModel model);
        Task<ActorEdicionModel> BuscarPorId(int id);
        Task Eliminar(int id);
        Task Guardar(ActorCreacionModel model);
        Task<List<ActorModel>> ObtenerTodos();
    }
}
