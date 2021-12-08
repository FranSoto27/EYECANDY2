using EYECANDY2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Repositorios
{
    public interface IDirectorRepositorio
    { 

        Task<List<DirectorModel>> ObtenerTodos();
        Task Guardar(DirectorCreacionModel model);
    }
}
