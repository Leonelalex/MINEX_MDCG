using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgTipoAcreditacion
    {
        public MdcgTipoAcreditacion()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditaciones>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
    }
}
