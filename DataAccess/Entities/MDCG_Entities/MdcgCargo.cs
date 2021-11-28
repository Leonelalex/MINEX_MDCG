using System.Collections.Generic;

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgCargo
    {
        public MdcgCargo()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditaciones>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
    }
}
