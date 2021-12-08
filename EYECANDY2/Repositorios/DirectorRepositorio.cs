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
    public class DirectorRepositorio : IDirectorRepositorio
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DirectorRepositorio(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<DirectorModel>> ObtenerTodos()
        {
            var entities = await _context.Directores.ToListAsync();
            var models = _mapper.Map<List<DirectorModel>>(entities);
            return (models);
        }
        public async Task Guardar(DirectorCreacionModel model)
        {
            var entidad = _mapper.Map<Director>(model);
            _context.Directores.Add(entidad);
            await _context.SaveChangesAsync();
        }

    }
}
