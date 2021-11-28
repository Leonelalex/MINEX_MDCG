using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class GlobTipoPasaporte
    {
        public GlobTipoPasaporte()
        {
            MdcgDependientes = new HashSet<MdcgDependiente>();
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int CodigoTipoPasaporte { get; set; }
        public string NombreTipoPasaporte { get; set; }

        public virtual ICollection<MdcgDependiente> MdcgDependientes { get; set; }
        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
