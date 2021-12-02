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
    public class ActorRepositorio : IActorRepositorio
    {

        
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public ActorRepositorio(ApplicationDbContext context, IMapper mapper)
        {
           
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ActorModel>> ObtenerTodos()
            {
                var entities = await _context.Actores.ToListAsync();
                var models = _mapper.Map<List<ActorModel>>(entities);
                return models;
            }
        public async Task Guardar(ActorCreacionModel model)
        {
            var entidad = _mapper.Map<Actor>(model);
            _context.Actores.Add(entidad);
            await _context.SaveChangesAsync();
        }
        public async Task<ActorEdicionModel> BuscarPorId(int id)
        {
            var entidad = await _context.Actores.FirstOrDefaultAsync(x => x.Id == id);
            var model = _mapper.Map<ActorEdicionModel>(entidad);
            return model;
        }
        public async Task Actualizar(ActorEdicionModel model)
        {
            var entidad = await _context.Actores.FirstOrDefaultAsync(x => x.Id == model.Id);
            entidad.Nombre = model.Nombre;
            entidad.FechaNacimiento = Convert.ToDateTime(model.FechaNacimiento);
            entidad.Biografia = model.Biografia;
            entidad.ImagenUrl = model.ImagenUrl;
            await _context.SaveChangesAsync();
        }
        public async Task Eliminar(int id)
        {
            var entidad = await _context.Actores.FirstOrDefaultAsync(x => x.Id == id);
            _context.Actores.Remove(entidad);
            await _context.SaveChangesAsync();
        }

    }
   
}
