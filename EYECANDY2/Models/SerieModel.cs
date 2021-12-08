using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models
{
    public class SerieModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }
        public string AficheUrl { get; set; }

        public string ActorNombre { get; set; }
        public string GeneroNombre { get; set; }
    }
}
