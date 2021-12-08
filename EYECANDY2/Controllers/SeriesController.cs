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
    public class SeriesController : Controller
    {
        private readonly ISerieRepositorio _repositorio;
        private readonly IAlmacenadorArchivos _almacenadorArchivos;
        private readonly string Carpeta = "imagenes_afiches";

       public SeriesController(ISerieRepositorio repositorio, IAlmacenadorArchivos almacenadorArchivos)
        {
            _repositorio = repositorio;
            _almacenadorArchivos = almacenadorArchivos;
        }
            public IActionResult Index()
            {
            return View();
        }
        public async Task<IActionResult> Nuevo()
        {
            var model = await _repositorio.NuevaSerieCreacionModel();
            return View(model);
            
        }
        [HttpPost]
        public async Task<IActionResult> Nuevo(SerieCreacionModel model)
        {
            if(ModelState.IsValid)
            {
                if(model.Afiche != null)
                {
                    var urlAfiche = await _almacenadorArchivos.GuardarArchivo(model.Afiche, Carpeta);
                    model.AficheUrl = urlAfiche;
                }

                return RedirectToAction("Index");
            }

            return View(model);
               
        }
    }
}
