using DataAccess.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class Acreditaciones_VM
    {
        public int Codigo { get; set; }
        public int CodigoFuncionario { get; set; }
        public string Mision { get; set; }
        public string EsJefeMision { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaBeneplacito { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaSolicitudBeneplacito { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaPresentacionCredenciales { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaArribo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaTomaPosesion { get; set; }
        public string NoAcreditacion { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaAcreditacion { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaSalida { get; set; }
        public string ViaSalida { get; set; }
        public string LugarAvisoRetiro { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaAvisoRetiro { get; set; }
        public string ServiciosPrestados { get; set; }
        public string NumeroCarne { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaVigencia { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaDevolucion { get; set; }
        public string NotaDevolucion { get; set; }
        public string Observaciones { get; set; }
        public string Asistente { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaImpresion { get; set; }
        public string Estado { get; set; }
        public string SolicitaLicencia { get; set; }
        public string Tratamiento { get; set; }
        public string TipoAcreditacion { get; set; }
        public string Cargo { get; set; }
        public int? Orden { get; set; }
        public string Guia { get; set; }
        public int CorrelativoProtocolo { get; set; }
    }

    public class AcreditacionesEdit_VM
    {
        public int Codigo { get; set; }
        public int CodigoFuncionario { get; set; }
        public CodeName_obj Mision { get; set; }
        public bool EsJefeMision { get; set; }
        public DateTime? FechaBeneplacito { get; set; }
        public DateTime? FechaSolicitudBeneplacito { get; set; }
        public DateTime? FechaPresentacionCredenciales { get; set; }
        public DateTime? FechaArribo { get; set; }
        public DateTime? FechaTomaPosesion { get; set; }
        public string NoAcreditacion { get; set; }
        public DateTime? FechaAcreditacion { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string ViaSalida { get; set; }
        public string LugarAvisoRetiro { get; set; }
        public DateTime? FechaAvisoRetiro { get; set; }
        public string ServiciosPrestados { get; set; }
        public string NumeroCarne { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string NotaDevolucion { get; set; }
        public string Observaciones { get; set; }
        public string Asistente { get; set; }
        public DateTime? FechaImpresion { get; set; }
        public CodeName_obj Estado { get; set; }
        public bool SolicitaLicencia { get; set; }
        public CodeName_obj Tratamiento { get; set; }
        public CodeName_obj TipoAcreditacion { get; set; }
        public CodeName_obj Cargo { get; set; }
        public int? codigoPais { get; set; }
        public int? Orden { get; set; }
        public string Guia { get; set; }
        public int CorrelativoProtocolo { get; set; }
    }
}
