using DataAccess.Entities.MDCG_Entities;
using System.Collections.Generic;

namespace DataAccess.Entities.Generales
{
    public partial class GlobTipoFuncionario
    {
        public GlobTipoFuncionario()
        {
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public int CodigoTipoInstitucion { get; set; }
        public int Prioridad { get; set; }

        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
