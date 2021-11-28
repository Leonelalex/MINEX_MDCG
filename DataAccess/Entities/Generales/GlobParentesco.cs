using DataAccess.Entities.MDCG_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Generales
{
    public partial class GlobParentesco
    {
        public GlobParentesco()
        {
            MdcgDependientes = new HashSet<MdcgDependiente>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public string descripcion { get; set; }

        public virtual ICollection<MdcgDependiente> MdcgDependientes { get; set; }

    }
}
