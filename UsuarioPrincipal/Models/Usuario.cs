using System;
using System.Collections.Generic;

#nullable disable

namespace UsuarioPrincipal.Models
{
    public partial class Usuario
    {
        public decimal? IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string FechaAlta { get; set; }
    }
}
