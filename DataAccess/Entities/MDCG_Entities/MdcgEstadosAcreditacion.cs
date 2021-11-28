using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgEstadosAcreditacion
    {
        public MdcgEstadosAcreditacion()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditaciones>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
    }
}
