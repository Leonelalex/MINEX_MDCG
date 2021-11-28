using System;
using System.ComponentModel.DataAnnotations;

namespace Core.ServiceApp.Requests
{
    public class Dependientes_Req
    {
        public int? PaisOrigen { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string ApellidoCasada { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public int? CodigoParentesco { get; set; }
        public string NumeroPasaporte { get; set; }
        public int? CodigoTipoPasaporte { get; set; }
        public string NumeroLicencia { get; set; }
        public int? CodigoTipoLicencia { get; set; }
        public int? CodigoGenero { get; set; }
        public bool Acreditar { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoPasaporte { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaVencimientoLicencia { get; set; }
    }
}
