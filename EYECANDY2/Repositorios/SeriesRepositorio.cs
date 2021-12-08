using AutoMapper;
using EYECANDY2.Models;
using EYECANDY2.Models.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Repositorios
{
    public class SeriesRepositorio : ISerieRepositorio
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IActorRepositorio _actorRepositorio;
        private readonly IGenerosRepository _generosRepository;

        public SeriesRepositorio(ApplicationDbContext context, IMapper mapper, IActorRepositorio actorRepositorio, IGenerosRepository generosRepository)
        {
            _context = context;
            _mapper = mapper;
            _actorRepositorio = actorRepositorio;
            _generosRepository = generosRepository;
        }
        public async Task<SerieCreacionModel> NuevaSerieCreacionModel()
        {
            var resultado = new SerieCreacionModel();
            var listaActores = await _actorRepositorio.ObtenerTodos();
            var listaGeneros = await _generosRepository.ObtenerTodos();

            var selectListActores = new SelectList(listaActores, "Id", "Nombre");
            var selectListGeneros = new SelectList(listaGeneros, "Id", "Nombre");
            resultado.Actores = selectListActores;
            resultado.Generos = selectListGeneros;

            return resultado;
        }
        public async Task Guardar(SerieCreacionModel model)
        {
            var entidad = _mapper.Map<Serie>(model);
            _context.Series.Add(entidad);
            await _context.SaveChangesAsync();
        }
    }
}
