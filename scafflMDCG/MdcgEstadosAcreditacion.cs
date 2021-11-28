using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgEstadosAcreditacion
    {
        public MdcgEstadosAcreditacion()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditacione>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgAcreditacione> MdcgAcreditaciones { get; set; }
    }
}
