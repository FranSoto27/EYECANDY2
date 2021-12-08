using EYECANDY2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Repositorios
{
    public interface ISerieRepositorio
    {
        Task Guardar(SerieCreacionModel model);
        Task<SerieCreacionModel> NuevaSerieCreacionModel();
        Task<List<SerieModel>> ObtenerTodas();
    }
}
