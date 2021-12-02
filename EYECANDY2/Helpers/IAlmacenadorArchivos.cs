﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Helpers
{
    public interface IAlmacenadorArchivos
    {
        Task EliminarArchivo(string url, string nombreCarpeta);
        Task<string> GuardarArchivo(IFormFile archivo, string carpeta);
    }
}
