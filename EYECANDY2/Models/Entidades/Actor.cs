using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [MaxLength(1055)]
        public string Biografia { get; set; }
        [MaxLength(255)]
        public string ImagenUrl { get; set; }
        public List<SerieActor> SeriesActores { get; set; }
    }
}
