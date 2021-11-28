using System;
using System.ComponentModel.DataAnnotations;

namespace Core.ServiceApp.Requests
{
    public class Funcionario_Req
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string ApellidoCasada { get; set; }
        public int Genero { get; set; }
        public int EstadoCivil { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public int PaisOrigen { get; set; }
        public string CorreoElectronico { get; set; }
        public string OtrosMediosComunicacion { get; set; }
        public int? NacionalidadAdquirida { get; set; }
        public string LugarNacimiento { get; set; }
        public int TipoPasaporte { get; set; }
        public string NumeroPasaporte { get; set; }
        public int GradoAcademico { get; set; }
        public string DireccionParticular { get; set; }
        public string TelefonoParticular { get; set; }
        public string Fotografia { get; set; }
        public string HuellaImg { get; set; }
        public string Firma { get; set; }
        public string HuellaTxt { get; set; }
        public int TipoFuncionario { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoPasaporte { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaVencimientoLicencia { get; set; }

        public int? tipoLicencia { get; set; }

    }
}
