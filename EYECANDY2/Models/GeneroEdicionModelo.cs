using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Models
{
    public class GeneroEdicionModelo
    {
        public int Id { get; set; }
        [Required(ErrorMessage= "El campo Género es requerido")]
        public string Nombre { get; set; }
    }
}
