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
            CreateMap<SerieCreacionModel, Serie>()
                .ForMember(serie=>serie.SeriesActores, opciones =>opciones.MapFrom(MapSerieActor))
                .ForMember(serie=>serie.SeriesGeneros, opciones=>opciones.MapFrom(MapSerieGenero))
                ;
            CreateMap<Serie, SerieModel>()
                .ForMember(serieModel => serieModel.ActorNombre, opciones => opciones.MapFrom(serie => serie.SeriesActores.FirstOrDefault().Actor.Nombre))
                .ForMember(serieModel => serieModel.GeneroNombre, opciones => opciones.MapFrom(serie => serie.SeriesGeneros.FirstOrDefault().Genero.Nombre))
                ;
        }
        private List<SerieActor> MapSerieActor(SerieCreacionModel serieCreacionModel, Serie serie)
        {
            var resultado = new List<SerieActor>();
            if (serieCreacionModel.ActorId == null)
            {
                return resultado;
            }
            resultado.Add(new SerieActor { ActorId = (int)serieCreacionModel.ActorId });
            return resultado;
        }
        private List<SerieGenero> MapSerieGenero(SerieCreacionModel serieCreacionModel, Serie serie)
        {
            var resultado = new List<SerieGenero>();
            if (serieCreacionModel.GeneroId == null)
            {
                return resultado;
            }
            resultado.Add(new SerieGenero { GeneroId = (int)serieCreacionModel.GeneroId });
            return resultado;
        }

    }
}
