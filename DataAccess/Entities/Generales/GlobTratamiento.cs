using DataAccess.Entities.MDCG_Entities;
using System.Collections.Generic;

namespace DataAccess.Entities.Generales
{
    public partial class GlobTratamiento
    {
        public GlobTratamiento()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditaciones>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public string Abreviatura { get; set; }

        public virtual ICollection<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
    }
}
