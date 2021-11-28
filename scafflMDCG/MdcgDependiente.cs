using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgDependiente
    {
        public int Codigo { get; set; }
        public int CodigoAcreditacion { get; set; }
        public int? PaisOrigen { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string ApellidoCasada { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public string NumeroCarne { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string NotaDevolucion { get; set; }
        public int? CodigoParentesco { get; set; }
        public DateTime? FechaAcreditacion { get; set; }
        public string NumeroPasaporte { get; set; }
        public int? CodigoTipoPasaporte { get; set; }
        public string NumeroLicencia { get; set; }
        public int? CodigoTipoLicencia { get; set; }
        public bool Estado { get; set; }
        public int? CodigoXAcreditacion { get; set; }
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
        public string NoAcreditacion { get; set; }
        public string HuellaTxt { get; set; }
        public int? CodigoGenero { get; set; }

        public virtual MdcgAcreditacione CodigoAcreditacionNavigation { get; set; }
        public virtual GlobGenero CodigoGeneroNavigation { get; set; }
        public virtual GlobTipoPasaporte CodigoTipoPasaporteNavigation { get; set; }
        public virtual GlobPai PaisOrigenNavigation { get; set; }
    }
}
