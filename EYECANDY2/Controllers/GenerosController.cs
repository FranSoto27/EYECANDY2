using EYECANDY2.Models;
using EYECANDY2.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Controllers
{
    public class GenerosController : Controller
    {
        private readonly IGenerosRepository _repository;

        public GenerosController(IGenerosRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var generos = await _repository.ObtenerTodos();
            return View(generos);
        }
        public IActionResult NuevoGenero()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NuevoGenero(GeneroCreacionModelo model)
        {
            if (ModelState.IsValid)
            {
                await _repository.GuardarGenero(model);
                var list = await _repository.ObtenerTodos();
                return View("Index", list);
            }
            return View("NuevoGenero", model);
        }

        public async Task<IActionResult> EditarGenero([FromRoute] int id)
            {
            var genero = await _repository.BuscarGeneroPorId(id);
            return View(genero);
            }
        [HttpPost]
        public async Task<IActionResult> EditarGenero(GeneroEdicionModelo model)
        {
            if(ModelState.IsValid)
            {
                await _repository.ActualizarGenero(model);
                var list = await _repository.ObtenerTodos();
                return View("Index", list);
            }
            return View("EditarGenero", model);
        }
        public async Task<IActionResult> EliminarGenero([FromRoute] int id)
        {
            var genero = await _repository.BuscarGeneroPorId(id);
            return View(genero);
        }
        [HttpPost]
        public async Task<IActionResult> EliminarGenero(GeneroEdicionModelo model)
        {
            await _repository.EliminarGenero(model.Id);
            var list = await _repository.ObtenerTodos();
            return View("index", list);
        }

    }
}
