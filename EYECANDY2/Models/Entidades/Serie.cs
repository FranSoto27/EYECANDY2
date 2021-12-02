using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models.Entidades
{
    public class Serie
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public int Anio { get; set; }
        [MaxLength(1000)]
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }
        public string AficheUrl { get; set; }
        public List<Genero> Generos  { get; set; }
        public List<Actor> Actores { get; set; }
    }
}
