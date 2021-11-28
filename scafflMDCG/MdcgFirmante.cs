using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgFirmante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Firma { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string UsuarioRegistra { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioElimina { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
