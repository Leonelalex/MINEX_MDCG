using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class GlobTratamiento
    {
        public GlobTratamiento()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditacione>();
        }

        public int CodigoTratamiento { get; set; }
        public string Descripcion { get; set; }
        public string Abreviatura { get; set; }

        public virtual ICollection<MdcgAcreditacione> MdcgAcreditaciones { get; set; }
    }
}
