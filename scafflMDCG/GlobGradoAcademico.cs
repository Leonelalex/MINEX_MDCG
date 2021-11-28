using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class GlobGradoAcademico
    {
        public GlobGradoAcademico()
        {
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int? Descripcion { get; set; }

        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
