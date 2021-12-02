using AutoMapper;
using EYECANDY2.Models;
using EYECANDY2.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Repositorios
{
    public class GenerosRepository : IGenerosRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GenerosRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GeneroModelo>> ObtenerTodos()
        {
            var entities = await _context.Generos.ToListAsync();
            var models = _mapper.Map<List<GeneroModelo>>(entities);
            return models;
        }
        public async Task GuardarGenero(GeneroCreacionModelo model)
        {
            var entidad = _mapper.Map<Genero>(model);
            _context.Generos.Add(entidad);
            await _context.SaveChangesAsync();
        }
        public async Task<GeneroEdicionModelo> BuscarGeneroPorId(int id)
        {
            var entidad = await _context.Generos.FirstOrDefaultAsync(x => x.Id == id);
            var model = _mapper.Map<GeneroEdicionModelo>(entidad);
            return model;
        }

        public async Task ActualizarGenero(GeneroEdicionModelo model)
        {
            var entidad = await _context.Generos.FirstOrDefaultAsync(x => x.Id == model.Id);
            entidad.Nombre = model.Nombre;
            await _context.SaveChangesAsync();
        }
        public async Task EliminarGenero(int id)
        {
            var entidad = await _context.Generos.FirstOrDefaultAsync(x => x.Id == id);
            _context.Generos.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }
}
