using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models
{
    public class SerieCreacionModel
    {
        [MaxLength(100,ErrorMessage = "El campo {0} debe tener como máximo {1} caracteres")]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? Anio { get; set; }
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }
        public IFormFile Afiche { get; set; }
        public string AficheUrl { get; set; }
        public  int? GeneroId { get; set; }
        public int? ActorId { get; set; }
        public int? DirectorId { get; set; }
        public SelectList Actores { get; set; }
        public SelectList Generos { get; set; }
    }
}
