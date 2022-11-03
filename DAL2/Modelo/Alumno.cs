using System;
using System.Collections.Generic;

namespace DAL2.Modelo
{
    public partial class Alumno
    {
        public string[] Nombre { get; set; } = null!;
        public string[]? Apellido { get; set; }
    }
}
