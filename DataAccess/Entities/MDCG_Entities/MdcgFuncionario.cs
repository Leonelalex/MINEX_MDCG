using DataAccess.Entities.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgFuncionario
    {
        public MdcgFuncionario()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditaciones>();
            MdcgDependientes = new HashSet<MdcgDependiente>();
        }

        public int Codigo { get; set; }
        public int? IdCorrelativoAnterior { get; set; }
        public string CorrelativoTipo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }
        public int? PaisOrigen { get; set; }
        public string CorreoElectronico { get; set; }
        public string OtrosMediosComunicacion { get; set; }
        public string ApellidoCasada { get; set; }
        public string LugarNacimiento { get; set; }
        public int? CodigoTipoPasaporte { get; set; }
        public string NumeroPasaporte { get; set; }
        public int? CodigoGradoAcademico { get; set; }
        public string DireccionParticular { get; set; }
        public string TelefonoParticular { get; set; }
        public int? CodigoEstadoCivil { get; set; }
        public string NumeroLicencia { get; set; }
        public int? TipoLicencia { get; set; }
        public bool? Estado { get; set; }
        public bool? Eliminado { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string UsuarioElimina { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistra { get; set; }
        public string Fotografia { get; set; }
        public string HuellaImg { get; set; }
        public string Firma { get; set; }
        public int? NacionalidadAdquirida { get; set; }
        public string HuellaTxt { get; set; }
        public int? CodigoTipoFuncionario { get; set; }
        public bool Acreditado { get; set; }
        public DateTime? FechaVencimientoPasaporte { get; set; }
        public DateTime? FechaVencimientoLicencia { get; set; }

        public virtual GlobEstadoCivil CodigoEstadoCivilNavigation { get; set; }
        public virtual GlobGenero CodigoGeneroNavigation { get; set; }
        public virtual GlobGradoAcademico CodigoGradoAcademicoNavigation { get; set; }
        public virtual GlobTipoFuncionario CodigoTipoFuncionarioNavigation { get; set; }
        public virtual GlobTipoPasaporte CodigoTipoPasaporteNavigation { get; set; }
        public virtual GlobPais NacionalidadAdquiridaNavigation { get; set; }
        public virtual GlobPais PaisOrigenNavigation { get; set; }
        public virtual GlobtipoLicencia CodigoTipoLicenciaNavigation { get; set; }
        public virtual ICollection<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
        public virtual ICollection<MdcgDependiente> MdcgDependientes { get; set; }
    }
}
