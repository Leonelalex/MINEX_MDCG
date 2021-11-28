using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgTipoGestion
    {
        public MdcgTipoGestion()
        {
            MdcgAdjuntoAcreditaciones = new HashSet<MdcgAdjuntoAcreditacione>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgAdjuntoAcreditacione> MdcgAdjuntoAcreditaciones { get; set; }
    }
}
