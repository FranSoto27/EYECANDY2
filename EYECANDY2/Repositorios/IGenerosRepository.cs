using EYECANDY2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Repositorios
{
    public interface IGenerosRepository
    {
        Task ActualizarGenero(GeneroEdicionModelo model);
        Task<GeneroEdicionModelo> BuscarGeneroPorId(int id);
        Task EliminarGenero(int id);
        Task GuardarGenero(GeneroCreacionModelo model);
        Task<List<GeneroModelo>> ObtenerTodos();
    }
}
