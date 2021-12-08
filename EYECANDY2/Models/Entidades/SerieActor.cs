using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models.Entidades
{
    public class SerieActor
    {
        public int ActorId { get; set; }
        public int SerieId { get; set; }
        public Serie Serie { get; set; }
        public Actor Actor { get; set; }
    }
}
