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
    public class ActoresController : Controller
    {
        private readonly IActorRepositorio _repositorio;
        private readonly IAlmacenadorArchivos _almacenadorArchivos;
        private readonly string Carpeta = "img_actores";

        public ActoresController(IActorRepositorio repositorio, IAlmacenadorArchivos almacenadorArchivos)
        {
            _repositorio = repositorio;
            _almacenadorArchivos = almacenadorArchivos;
        }
        public async Task<IActionResult> Index()
        {
            var lista = await _repositorio.ObtenerTodos();
            return View(lista);
        }
        public IActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Nuevo(ActorCreacionModel model)
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
        public async Task<IActionResult> Editar([FromRoute]int id)
        {
            var modelo = await _repositorio.BuscarPorId(id);
            return View(modelo);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(ActorEdicionModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Imagen != null)
                {
                    await _almacenadorArchivos.EliminarArchivo(model.ImagenUrl, Carpeta);
                    var nuevaUrl = await _almacenadorArchivos.GuardarArchivo(model.Imagen, Carpeta);
                    model.ImagenUrl = nuevaUrl;
                }
                await _repositorio.Actualizar(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }
        public async Task<IActionResult> Eliminar([FromRoute] int id)
        {
            var model = await _repositorio.BuscarPorId(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Eliminar(ActorEdicionModel model)
        {
            var entidad = await _repositorio.BuscarPorId(model.Id);
            await _almacenadorArchivos.EliminarArchivo(entidad.ImagenUrl, Carpeta);
            await _repositorio.Eliminar(model.Id);
            return RedirectToAction("Index");
        }
    }
    }



