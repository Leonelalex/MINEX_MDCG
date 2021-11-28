using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class GlobTipoFuncionario
    {
        public GlobTipoFuncionario()
        {
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int CodigoTipoFuncionario { get; set; }
        public string Descripcion { get; set; }
        public int CodigoTipoInstitucion { get; set; }
        public int Prioridad { get; set; }

        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
