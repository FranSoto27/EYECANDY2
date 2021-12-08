using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models.Entidades
{
    public class SerieGenero
    {
        public int GeneroId { get; set; }
        public int SerieId { get; set; }
        public Serie Serie { get; set; }
        public Genero Genero { get; set; }
    }
}
