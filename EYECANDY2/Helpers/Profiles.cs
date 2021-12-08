using AutoMapper;
using EYECANDY2.Models;
using EYECANDY2.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Helpers
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Genero, GeneroModelo>();
            CreateMap<GeneroCreacionModelo, Genero>();
            CreateMap<Genero, GeneroEdicionModelo>();
            CreateMap<Actor, ActorModel>();
            CreateMap<ActorCreacionModel, Actor>();
            CreateMap<Actor, ActorEdicionModel>();
            CreateMap<Director, DirectorModel>();
        }

    }
}
