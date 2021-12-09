using EYECANDY2.Helpers;
using EYECANDY2.Models;
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
        private readonly IAlmacenadorArchivos _almacenadorArchivos;
        private readonly string Carpeta = "img_adirectores";

        public DirectoresController(IDirectorRepositorio repositorio, IAlmacenadorArchivos almacenadorArchivos)
        {
            _repositorio = repositorio;
            _almacenadorArchivos = almacenadorArchivos;
        }
        public async Task<IActionResult> Index()
        {
            var lista = await _repositorio.ObtenerTodos();
            return View(lista);

        }
        public async Task<IActionResult> Nuevo(DirectorCreacionModel model)
        {
            if (ModelState.IsValid)
            {
                var url = await _almacenadorArchivos.GuardarArchivo(model.Imagen, Carpeta);
                model.ImagenUrl = url;

                await _repositorio.Guardar(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
