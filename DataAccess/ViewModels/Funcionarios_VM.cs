using DataAccess.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class Funcionarios_VM
    {
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string PaisOrigen { get; set; }
        public string CorreoElectronico { get; set; }
        public string OtrosMediosComunicacion { get; set; }
        public string ApellidoCasada { get; set; }
        public string LugarNacimiento { get; set; }
        public string TipoPasaporte { get; set; }
        public string NumeroPasaporte { get; set; }
        public string GradoAcademico { get; set; }
        public string DireccionParticular { get; set; }
        public string TelefonoParticular { get; set; }
        public bool? ResidenteGt { get; set; }
        public DateTime? ResidenteGtFecha { get; set; }
        public string EstadoCivil { get; set; }
        public string NombreCompletoConyuge { get; set; }
        public string DatosFamilia { get; set; }
        public string NumeroLicencia { get; set; }
        public string TipoLicencia { get; set; }
        public string NacionalidadAdquirida { get; set; }
        public bool Acreditado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaVencimientoPasaporte { get; set; }
        public DateTime? FechaVencimientoLicencia { get; set; }
    }

    public class FuncionarioEdit_VM
    {
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public CodeName_obj Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public CodeName_obj PaisOrigen { get; set; }
        public string CorreoElectronico { get; set; }
        public string OtrosMediosComunicacion { get; set; }
        public string ApellidoCasada { get; set; }
        public string LugarNacimiento { get; set; }
        public CodeName_obj TipoPasaporte { get; set; }
        public string NumeroPasaporte { get; set; }
        public CodeName_obj GradoAcademico { get; set; }
        public string DireccionParticular { get; set; }
        public string TelefonoParticular { get; set; }
        public bool? ResidenteGt { get; set; }
        public DateTime? ResidenteGtFecha { get; set; }
        public CodeName_obj EstadoCivil { get; set; }
        public string NombreCompletoConyuge { get; set; }
        public string DatosFamilia { get; set; }
        public string NumeroLicencia { get; set; }
        public CodeName_obj TipoLicencia { get; set; }
        public CodeName_obj NacionalidadAdquirida { get; set; }
        public string Fotografia { get; set; }
        public string HuellaImg { get; set; }
        public string Firma { get; set; }
        public string HuellaTxt { get; set; }
        public CodeName_obj TipoFuncionario { get; set; }
        public bool Acreditado { get; set; }
        public DateTime? FechaVencimientoPasaporte { get; set; }
        public DateTime? FechaVencimientoLicencia { get; set; }
    }
}
