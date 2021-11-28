using DataAccess.Entities.MDCG_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Generales
{
    public partial class GlobtipoLicencia
    {
        public GlobtipoLicencia()
        {
            MdcgDependientes = new HashSet<MdcgDependiente>();
            MdcgFuncionarios = new HashSet<MdcgFuncionario>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public virtual ICollection<MdcgDependiente> MdcgDependientes { get; set; }
        public virtual ICollection<MdcgFuncionario> MdcgFuncionarios { get; set; }
    }
}
