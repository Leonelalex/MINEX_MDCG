using DataAccess.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class Dependientes_VM
    {
        public int Codigo { get; set; }
        public int CodigoFuncionario { get; set; }
        public string PaisOrigen { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string ApellidoCasada { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaVigencia { get; set; }
        public string NumeroCarne { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaDevolucion { get; set; }
        public string NotaDevolucion { get; set; }
        public string Parentesco { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaAcreditacion { get; set; }
        public string NumeroPasaporte { get; set; }
        public string TipoPasaporte { get; set; }
        public string NumeroLicencia { get; set; }
        public string TipoLicencia { get; set; }
        public string Genero { get; set; }
        public bool Acreditado { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoPasaporte { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaVencimientoLicencia { get; set; }
    }

    public class DependientesEdit_VM
    {
        public int CodigoFuncionario { get; set; }
        public CodeName_obj PaisOrigen { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string ApellidoCasada { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public string NumeroCarne { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string NotaDevolucion { get; set; }
        public CodeName_obj Parentesco { get; set; }
        public DateTime? FechaAcreditacion { get; set; }
        public string NumeroPasaporte { get; set; }
        public CodeName_obj TipoPasaporte { get; set; }
        public string NumeroLicencia { get; set; }
        public CodeName_obj TipoLicencia { get; set; }
        public string NoAcreditacion { get; set; }
        public CodeName_obj Genero { get; set; }
        public bool Acreditado { get; set; }
        public string Fotografia { get; set; }

        public DateTime? FechaVencimientoPasaporte { get; set; }
        public DateTime? FechaVencimientoLicencia { get; set; }
    }
}
