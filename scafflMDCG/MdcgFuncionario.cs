using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgFuncionario
    {
        public MdcgFuncionario()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditacione>();
        }

        public int Codigo { get; set; }
        public int? IdCorrelativoAnterior { get; set; }
        public string CorrelativoTipo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int CodigoGenero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int PaisOrigen { get; set; }
        public string CorreoElectronico { get; set; }
        public string OtrosMediosComunicacion { get; set; }
        public string ApellidoCasada { get; set; }
        public string LugarNacimiento { get; set; }
        public int? CodigoTipoPasaporte { get; set; }
        public string NumeroPasaporte { get; set; }
        public int? CodigoGradoAcademico { get; set; }
        public string DireccionParticular { get; set; }
        public string TelefonoParticular { get; set; }
        public bool ResidenteGt { get; set; }
        public DateTime? ResidenteGtFecha { get; set; }
        public int? CodigoEstadoCivil { get; set; }
        public string NombreCompletoConyuge { get; set; }
        public string DatosFamilia { get; set; }
        public string NumeroLicencia { get; set; }
        public int? CodigoTipoLicencia { get; set; }
        public bool Estado { get; set; }
        public bool Eliminado { get; set; }
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

        public virtual GlobEstadoCivil CodigoEstadoCivilNavigation { get; set; }
        public virtual GlobGenero CodigoGeneroNavigation { get; set; }
        public virtual GlobGradoAcademico CodigoGradoAcademicoNavigation { get; set; }
        public virtual GlobTipoFuncionario CodigoTipoFuncionarioNavigation { get; set; }
        public virtual GlobTipoPasaporte CodigoTipoPasaporteNavigation { get; set; }
        public virtual GlobPai NacionalidadAdquiridaNavigation { get; set; }
        public virtual GlobPai PaisOrigenNavigation { get; set; }
        public virtual ICollection<MdcgAcreditacione> MdcgAcreditaciones { get; set; }
    }
}
