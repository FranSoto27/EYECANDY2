using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models
{
    public class GeneroCreacionModelo
    {
        [Required(ErrorMessage ="El campo nombre es requerido") ]
        public string Nombre { get; set; }
    }
}
