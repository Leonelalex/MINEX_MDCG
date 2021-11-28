using System;

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgBitacora
    {
        public int Codigo { get; set; }
        public int CodigoAcreditacion { get; set; }
        public int Estado { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }

        public virtual MdcgAcreditaciones CodigoAcreditacionNavigation { get; set; }
    }
}
