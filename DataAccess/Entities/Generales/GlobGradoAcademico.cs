using DataAccess.Entities.MDCG_Entities;
using System.Collections.Generic;

namespace DataAccess.Entities.Generales
{
    public partial class GlobGradoAcademico
    {
        public GlobGradoAcademico()
        {
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public int? Descripcion { get; set; }

        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
