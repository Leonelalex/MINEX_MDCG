using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class GlobGenero
    {
        public GlobGenero()
        {
            MdcgDependientes = new HashSet<MdcgDependiente>();
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int CodigoGenero { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgDependiente> MdcgDependientes { get; set; }
        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
