using EYECANDY2.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Controllers
{
    public class DirectoresController : Controller
    {
        private readonly IDirectorRepositorio _repositorio;

        public DirectoresController(IDirectorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Nuevo()
        {
            var lista = await _repositorio.ObtenerTodos();
            return View(lista);
        }
    }
}
