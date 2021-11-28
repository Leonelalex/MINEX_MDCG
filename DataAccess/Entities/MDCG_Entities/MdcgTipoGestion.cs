using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgTipoGestion
    {
        public MdcgTipoGestion()
        {
            MdcgAdjuntoAcreditaciones = new HashSet<MdcgAdjuntoAcreditaciones>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgAdjuntoAcreditaciones> MdcgAdjuntoAcreditaciones { get; set; }
    }
}
