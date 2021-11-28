using DataAccess.Entities.MDCG_Entities;
using System.Collections.Generic;

namespace DataAccess.Entities.Generales
{
    public partial class GlobEstadoCivil
    {
        public GlobEstadoCivil()
        {
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
