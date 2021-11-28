using DataAccess.Entities.MDCG_Entities;
using System.Collections.Generic;

namespace DataAccess.Entities.Generales
{
    public partial class GlobTipoPasaporte
    {
        public GlobTipoPasaporte()
        {
            MdcgDependientes = new HashSet<MdcgDependiente>();
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int code { get; set; }
        public string name { get; set; }

        public virtual ICollection<MdcgDependiente> MdcgDependientes { get; set; }
        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
