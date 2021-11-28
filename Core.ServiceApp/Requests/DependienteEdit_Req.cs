using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ServiceApp.Requests
{
    public class DependienteEdit_Req
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
        public string Fotografia { get; set; }
        public string HuellaImg { get; set; }
        public string Firma { get; set; }
        public string NoAcreditacion { get; set; }
        public string HuellaTxt { get; set; }
        public int? CodigoGenero { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoPasaporte { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoLicencia { get; set; }
    }
}
